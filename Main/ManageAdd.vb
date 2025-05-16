Imports MySql.Data.MySqlClient
Public Class ManageAdd
    Private supplierDetails As New Dictionary(Of String, (String, String, String))
    Private productId1 As String
    Private empId As String
    Private empName As String
    Private Const MAX_PRICE As Decimal = 1000000.0 ' 1 million limit

    Public Sub New(empId As Integer, empName As String)
        InitializeComponent()
        Me.empId = empId
        Me.empName = empName
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim productId As String = txtProductID.Text.Trim()
        Dim productName As String = txtProductName.Text.Trim()
        Dim type As String = cmbType.Text.Trim()
        Dim description As String = txtDescription.Text.Trim()
        Dim barcode As String = txtBarcode.Text.Trim()
        Dim supplierId As String = cmbSupplierID.Text.Trim()
        Dim supplierName As String = txtSupplierName.Text.Trim()
        Dim contact As String = txtContact.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()
        Dim expiryDate As Date = dtpDate.Value
        Dim photo As Byte() = Nothing

        ' Validate quantity (must be positive integer)
        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text.Trim(), quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid positive number for quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantity.Focus()
            txtQuantity.SelectAll()
            Return
        End If

        ' Validate price (must be positive decimal and <= 1 million)
        Dim price As Decimal
        If Not Decimal.TryParse(txtPrice.Text.Trim(), price) OrElse price <= 0 Then
            MessageBox.Show("Please enter a valid positive number for price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            txtPrice.SelectAll()
            Return
        ElseIf price > MAX_PRICE Then
            MessageBox.Show($"Price cannot exceed {MAX_PRICE:N2}. Please enter a lower amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            txtPrice.SelectAll()
            Return
        End If

        ' Check if required fields are empty
        If String.IsNullOrWhiteSpace(productId) OrElse
           String.IsNullOrWhiteSpace(productName) OrElse
           String.IsNullOrWhiteSpace(type) OrElse
           String.IsNullOrWhiteSpace(description) OrElse
           String.IsNullOrWhiteSpace(barcode) OrElse
           String.IsNullOrWhiteSpace(supplierId) OrElse
           String.IsNullOrWhiteSpace(supplierName) OrElse
           String.IsNullOrWhiteSpace(contact) OrElse
           String.IsNullOrWhiteSpace(address) Then

            MessageBox.Show("Please fill in all fields with valid data.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check expiry date
        If expiryDate = DateTime.Now Then
            MessageBox.Show("Date must be a present date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Convert image to byte array
        If Guna2PictureBox1.Image IsNot Nothing Then
            Using ms As New System.IO.MemoryStream()
                Guna2PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                photo = ms.ToArray()
            End Using
        End If

        ' Check if product_id already exists
        Dim checkQuery As String = "SELECT COUNT(*) FROM products WHERE product_id = @product_id"
        Using connection As New MySqlConnection(connectionString)
            Using checkCommand As New MySqlCommand(checkQuery, connection)
                checkCommand.Parameters.AddWithValue("@product_id", productId)

                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Product ID already exists. Please use a different Product ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtProductID.Focus()
                        Return
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            End Using
        End Using

        ' Insert data into database
        Dim query As String = "INSERT INTO products (product_id, product_name, type, quantity, price, description, barcode, exdate, supplier_id, supplier_name, contact, address, photo) " &
                              "VALUES (@product_id, @product_name, @type, @quantity, @price, @description, @barcode, @exdate, @supplier_id, @supplier_name, @contact, @address, @photo)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@product_id", productId)
                command.Parameters.AddWithValue("@product_name", productName)
                command.Parameters.AddWithValue("@type", type)
                command.Parameters.AddWithValue("@quantity", quantity)
                command.Parameters.AddWithValue("@price", price)
                command.Parameters.AddWithValue("@description", description)
                command.Parameters.AddWithValue("@barcode", barcode)
                command.Parameters.AddWithValue("@exdate", expiryDate)
                command.Parameters.AddWithValue("@supplier_id", supplierId)
                command.Parameters.AddWithValue("@supplier_name", supplierName)
                command.Parameters.AddWithValue("@contact", contact)
                command.Parameters.AddWithValue("@address", address)
                command.Parameters.AddWithValue("@photo", If(photo, DBNull.Value)) ' Handle null photo

                Try
                    connection.Open()
                    Dim result As Integer = command.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Product inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Log activity
                        InsertActivityLog(empId, empName, $"ADDED A PRODUCT: '{productName}' (ID: {productId})")

                        ' Clear input fields after successful insert
                        Clear()

                    Else
                        MessageBox.Show("Error inserting product.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Clear()
        txtProductID.Clear()
        txtProductName.Clear()
        txtQuantity.Clear()
        cmbType.SelectedIndex = -1
        txtPrice.Clear()
        txtBarcode.Clear()
        txtDescription.Clear()
        cmbSupplierID.SelectedIndex = -1
        txtSupplierName.Clear()
        txtContact.Clear()
        txtAddress.Clear()
        Guna2PictureBox1.Image = Nothing
        dtpDate.Value = DateTime.Now
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ManageAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSupplierIDs()

        ToolTip1.SetToolTip(txtProductID, "Enter the unique product ID.")
        ToolTip1.SetToolTip(txtProductName, "Enter the name of the product.")
        ToolTip1.SetToolTip(cmbType, "Select the product type.")
        ToolTip1.SetToolTip(txtDescription, "Enter a brief description of the product.")
        ToolTip1.SetToolTip(txtBarcode, "Scan or enter the product's barcode.")
        ToolTip1.SetToolTip(cmbSupplierID, "Select the supplier ID from the list.")
        ToolTip1.SetToolTip(txtSupplierName, "This shows the name of the selected supplier.")
        ToolTip1.SetToolTip(txtContact, "Enter or view the supplier's contact number.")
        ToolTip1.SetToolTip(txtAddress, "Enter or view the supplier's address.")
        ToolTip1.SetToolTip(dtpDate, "Select the product's date.")
    End Sub

    Private Sub LoadSupplierIDs()
        Dim query As String = "SELECT supplier_id, supplier_name, contact, address FROM supplier"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        cmbSupplierID.Items.Clear()
                        supplierDetails.Clear() ' Clear previous data

                        While reader.Read()
                            Dim supplierId As String = reader("supplier_id").ToString()
                            Dim name As String = reader("supplier_name").ToString()
                            Dim contact As String = reader("contact").ToString()
                            Dim address As String = reader("address").ToString()

                            ' Add to ComboBox
                            cmbSupplierID.Items.Add(supplierId)
                            ' Store details in the dictionary
                            supplierDetails(supplierId) = (name, contact, address)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error loading suppliers: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbSupplierID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplierID.SelectedIndexChanged
        Dim selectedSupplierID As String = cmbSupplierID.Text

        ' Check if the supplier ID exists in the dictionary
        If supplierDetails.ContainsKey(selectedSupplierID) Then
            Dim details = supplierDetails(selectedSupplierID)
            txtSupplierName.Text = details.Item1 ' supplier_name
            txtContact.Text = details.Item2 ' contact
            txtAddress.Text = details.Item3 ' address
        Else
            ' Clear the textboxes if supplier is not found
            txtSupplierName.Clear()
            txtContact.Clear()
            txtAddress.Clear()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Guna2PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub

    ' Prevent non-numeric input for quantity
    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        ' Only allow numbers and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    ' Prevent invalid input for price
    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        ' Only allow numbers, decimal point, and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

        ' Only allow one decimal point
        If e.KeyChar = "." AndAlso DirectCast(sender, TextBox).Text.IndexOf(".") > -1 Then
            e.Handled = True
        End If
    End Sub

    ' Validate price when leaving the field
    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        Dim price As Decimal
        If Decimal.TryParse(txtPrice.Text.Trim(), price) AndAlso price > MAX_PRICE Then
            MessageBox.Show($"Price cannot exceed {MAX_PRICE:N2}. Please enter a lower amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            txtPrice.SelectAll()
        End If
    End Sub
End Class