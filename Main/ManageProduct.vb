Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Public Class ManageProduct
    Private supplierDetails As New Dictionary(Of String, (String, String, String))
    Private productId1 As String
    Private parent As Dashboard
    Private empId As Integer
    Private empName As String
    Private selectedSupplierId As String
    Private originalImageBytes As Byte()


    Public Sub New(id As String, name As String, type As String, quantity As Integer, additionalDetails As (Decimal, String, String, Date, String, String, String, String, Byte()), empId As String, empName As String)
        InitializeComponent()

        Me.empId = CInt(empId)
        Me.empName = empName
        productId1 = id
        selectedSupplierId = additionalDetails.Item5
        originalImageBytes = additionalDetails.Item9

        ' Set basic product info
        txtEditProductID.Text = productId1
        txtEditProductName.Text = name
        cmbEditType.Text = type
        txtEditQuantity.Text = quantity.ToString()
        txtEditPrice.Text = additionalDetails.Item1.ToString("F2")
        txtEditBarcode.Text = additionalDetails.Item2
        txtEditDescription.Text = additionalDetails.Item3
        dtpEditDate.Value = additionalDetails.Item4
        txtEditSupplierName.Text = additionalDetails.Item6
        txtEditContact.Text = additionalDetails.Item7
        txtEditAddress.Text = additionalDetails.Item8

        ' Load suppliers and set selection
        LoadSupplierIDs()
        Application.DoEvents()
        SetSupplierSelection(selectedSupplierId)

        ' Load product image
        LoadProductImage()
    End Sub

    Private Sub LoadSupplierIDs()
        Dim query As String = "SELECT supplier_id, supplier_name, contact, address FROM supplier"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        cmbEditSupplierID.BeginUpdate()
                        cmbEditSupplierID.Items.Clear()
                        supplierDetails.Clear()

                        While reader.Read()
                            Dim supplierId As String = reader("supplier_id").ToString()
                            Dim name As String = reader("supplier_name").ToString()
                            Dim contact As String = reader("contact").ToString()
                            Dim address As String = reader("address").ToString()

                            cmbEditSupplierID.Items.Add(supplierId)
                            supplierDetails(supplierId) = (name, contact, address)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error loading suppliers: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmbEditSupplierID.EndUpdate()
        End Try
    End Sub

    Private Sub SetSupplierSelection(supplierId As String)
        If String.IsNullOrEmpty(supplierId) Then Return

        ' Try multiple selection methods
        cmbEditSupplierID.SelectedItem = supplierId

        If cmbEditSupplierID.SelectedIndex = -1 Then
            Dim index As Integer = cmbEditSupplierID.FindStringExact(supplierId)
            If index >= 0 Then
                cmbEditSupplierID.SelectedIndex = index
            End If
        End If

        ' Update supplier details if selection is valid
        If cmbEditSupplierID.SelectedIndex <> -1 Then
            cmbEditSupplierID_SelectedIndexChanged(cmbEditSupplierID, EventArgs.Empty)
        End If
    End Sub

    Private Sub LoadProductImage()
        If originalImageBytes IsNot Nothing AndAlso originalImageBytes.Length > 0 Then
            Try
                Using ms As New MemoryStream(originalImageBytes)
                    Guna2PictureBox2.Image = Image.FromStream(ms)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
                Guna2PictureBox2.Image = Nothing
            End Try
        Else
            Guna2PictureBox2.Image = Nothing
        End If
    End Sub

    Private Sub cmbEditSupplierID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEditSupplierID.SelectedIndexChanged
        If cmbEditSupplierID.SelectedIndex = -1 Then
            txtEditSupplierName.Clear()
            txtEditContact.Clear()
            txtEditAddress.Clear()
            Return
        End If

        Dim selectedSupplierID As String = cmbEditSupplierID.Text
        If supplierDetails.ContainsKey(selectedSupplierID) Then
            Dim details = supplierDetails(selectedSupplierID)
            txtEditSupplierName.Text = details.Item1
            txtEditContact.Text = details.Item2
            txtEditAddress.Text = details.Item3
        End If
    End Sub

    Private Const MAX_PRICE As Decimal = 1000000.0 ' 1 million limit

    Private Sub txtEditPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEditPrice.KeyPress
        ' Allow only numbers, decimal point, and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

        ' Only allow one decimal point
        If e.KeyChar = "." AndAlso DirectCast(sender, TextBox).Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEditPrice_TextChanged(sender As Object, e As EventArgs) Handles txtEditPrice.TextChanged
        ' Remove any non-numeric characters except decimal point
        Dim cursorPos As Integer = txtEditPrice.SelectionStart
        txtEditPrice.Text = System.Text.RegularExpressions.Regex.Replace(txtEditPrice.Text, "[^0-9.]", "")
        txtEditPrice.SelectionStart = cursorPos

        ' Check if price exceeds maximum limit
        Dim price As Decimal
        If Decimal.TryParse(txtEditPrice.Text, price) AndAlso price > MAX_PRICE Then
            MessageBox.Show($"Price cannot exceed {MAX_PRICE:N2}", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEditPrice.Text = MAX_PRICE.ToString("N2")
            txtEditPrice.SelectAll()
        End If
    End Sub

    Private Sub txtEditQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEditQuantity.KeyPress
        ' Only allow numbers and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEditQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtEditQuantity.TextChanged
        ' Remove any non-numeric characters
        Dim cursorPos As Integer = txtEditQuantity.SelectionStart
        txtEditQuantity.Text = System.Text.RegularExpressions.Regex.Replace(txtEditQuantity.Text, "[^0-9]", "")
        txtEditQuantity.SelectionStart = cursorPos

        ' Prevent leading zeros
        If txtEditQuantity.Text.Length > 1 AndAlso txtEditQuantity.Text.StartsWith("0") Then
            txtEditQuantity.Text = txtEditQuantity.Text.TrimStart("0"c)
            txtEditQuantity.SelectionStart = txtEditQuantity.Text.Length
        End If

        ' Set to "1" if empty
        If String.IsNullOrEmpty(txtEditQuantity.Text) Then
            txtEditQuantity.Text = "1"
            txtEditQuantity.SelectionStart = 1
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub btnEditSubmit_Click(sender As Object, e As EventArgs) Handles btnEditSubmit.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Guna2PictureBox2.Image = Image.FromFile(openFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnEditSave_Click(sender As Object, e As EventArgs) Handles btnEditSave.Click
        ' Validate all required fields
        If String.IsNullOrWhiteSpace(txtEditProductName.Text) OrElse
       String.IsNullOrWhiteSpace(txtEditQuantity.Text) OrElse
       String.IsNullOrWhiteSpace(cmbEditType.Text) OrElse
       String.IsNullOrWhiteSpace(txtEditPrice.Text) OrElse
       String.IsNullOrWhiteSpace(txtEditBarcode.Text) OrElse
       String.IsNullOrWhiteSpace(txtEditDescription.Text) OrElse
       cmbEditSupplierID.SelectedIndex = -1 Then

            MessageBox.Show("Please fill in all required fields.", "Validation Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate numeric fields
        Dim quantity As Integer
        Dim price As Decimal

        If Not Integer.TryParse(txtEditQuantity.Text, quantity) OrElse quantity < 0 Then
            MessageBox.Show("Please enter a valid positive quantity.", "Validation Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Decimal.TryParse(txtEditPrice.Text, price) OrElse price <= 0 Then
            MessageBox.Show("Please enter a valid positive price.", "Validation Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Prepare the SQL update query
        Dim query As String = "UPDATE products SET " &
                          "product_name = @product_name, " &
                          "type = @type, " &
                          "quantity = @quantity, " &
                          "price = @price, " &
                          "description = @description, " &
                          "barcode = @barcode, " &
                          "exdate = @exdate, " &
                          "supplier_id = @supplier_id, " &
                          "supplier_name = @supplier_name, " &
                          "contact = @contact, " &
                          "address = @address, " &
                          "photo = @photo " &
                          "WHERE product_id = @product_id"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    ' Add parameters with proper null handling
                    command.Parameters.AddWithValue("@product_id", productId1)
                    command.Parameters.AddWithValue("@product_name", If(String.IsNullOrEmpty(txtEditProductName.Text), DBNull.Value, txtEditProductName.Text))
                    command.Parameters.AddWithValue("@type", If(String.IsNullOrEmpty(cmbEditType.Text), DBNull.Value, cmbEditType.Text))
                    command.Parameters.AddWithValue("@quantity", quantity)
                    command.Parameters.AddWithValue("@price", price)
                    command.Parameters.AddWithValue("@description", If(String.IsNullOrEmpty(txtEditDescription.Text), DBNull.Value, txtEditDescription.Text))
                    command.Parameters.AddWithValue("@barcode", If(String.IsNullOrEmpty(txtEditBarcode.Text), DBNull.Value, txtEditBarcode.Text))
                    command.Parameters.AddWithValue("@exdate", dtpEditDate.Value)
                    command.Parameters.AddWithValue("@supplier_id", If(cmbEditSupplierID.SelectedIndex = -1, DBNull.Value, cmbEditSupplierID.Text))
                    command.Parameters.AddWithValue("@supplier_name", If(String.IsNullOrEmpty(txtEditSupplierName.Text), DBNull.Value, txtEditSupplierName.Text))
                    command.Parameters.AddWithValue("@contact", If(String.IsNullOrEmpty(txtEditContact.Text), DBNull.Value, txtEditContact.Text))
                    command.Parameters.AddWithValue("@address", If(String.IsNullOrEmpty(txtEditAddress.Text), DBNull.Value, txtEditAddress.Text))

                    ' Handle image saving with proper error handling
                    Try
                        If Guna2PictureBox2.Image IsNot Nothing Then
                            Using ms As New MemoryStream()
                                ' Save image in PNG format for consistency
                                Guna2PictureBox2.Image.Save(ms, Imaging.ImageFormat.Png)
                                command.Parameters.AddWithValue("@photo", ms.ToArray())
                            End Using
                        Else
                            ' Keep original image if no new image was selected
                            command.Parameters.AddWithValue("@photo", If(originalImageBytes IsNot Nothing, originalImageBytes, DBNull.Value))
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Warning: Could not process the image. Original image will be kept. Error: " & ex.Message,
                                  "Image Processing Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        command.Parameters.AddWithValue("@photo", If(originalImageBytes IsNot Nothing, originalImageBytes, DBNull.Value))
                    End Try

                    ' Execute the command with transaction for safety
                    Using transaction As MySqlTransaction = connection.BeginTransaction()
                        Try
                            command.Transaction = transaction
                            Dim rowsAffected As Integer = command.ExecuteNonQuery()

                            If rowsAffected > 0 Then
                                transaction.Commit()
                                MessageBox.Show("Product updated successfully!", "Success",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information)

                                ' Log the activity
                                InsertActivityLog(empId, empName, $"EDITED PRODUCT: {productId1} - {txtEditProductName.Text}")

                                Me.DialogResult = DialogResult.OK
                                Me.Close()
                            Else
                                transaction.Rollback()
                                MessageBox.Show("No changes were made to the product. The product ID might not exist.",
                                          "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Catch ex As Exception
                            transaction.Rollback()
                            Throw ' Re-throw to be caught by outer catch
                        End Try
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message & vbCrLf & "Error Number: " & ex.Number,
                       "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error saving product: " & ex.Message,
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertActivityLog(employeeId As Integer, employeeName As String, action As String)
        Dim query As String = "INSERT INTO activity_logs (employee_id, employee_name, action, action_date) " &
                              "VALUES (@employeeId, @employeeName, @action, NOW())"

        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@employeeId", employeeId)
                    command.Parameters.AddWithValue("@employeeName", employeeName)
                    command.Parameters.AddWithValue("@action", action)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine($"Failed to log activity: {ex.Message}")
        End Try
    End Sub

    Private Sub ManageProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set tooltips
        ToolTip1.SetToolTip(txtEditProductName, "Enter the name of the product.")
        ToolTip1.SetToolTip(cmbEditType, "Select the product category or type.")
        ToolTip1.SetToolTip(txtEditQuantity, "Enter the available quantity in stock.")
        ToolTip1.SetToolTip(txtEditPrice, "Enter the product's unit price.")
        ToolTip1.SetToolTip(txtEditDescription, "Enter a brief description of the product.")
        ToolTip1.SetToolTip(txtEditBarcode, "Enter or scan the product's barcode.")
        ToolTip1.SetToolTip(dtpEditDate, "Select the product's expiration or restock date.")
        ToolTip1.SetToolTip(cmbEditSupplierID, "Choose the ID of the supplier.")
        ToolTip1.SetToolTip(txtEditSupplierName, "Enter the full name of the supplier.")
        ToolTip1.SetToolTip(txtEditContact, "Enter the supplier's contact number.")
        ToolTip1.SetToolTip(txtEditAddress, "Enter the supplier's address.")
    End Sub
End Class