Imports MySql.Data.MySqlClient

Public Class ManageTransact
    Private employeeId As Integer
    Private employeeName As String
    Public isEditMode As Boolean = False
    Public originalSupplierID As String = ""


    ' Constructor to accept employee ID and name
    Public Sub New(empId As Integer, empName As String)
        InitializeComponent() ' This call is required by the designer.
        employeeId = empId
        employeeName = empName
    End Sub

    Public Function GenerateTransactionID() As String
        Return "TXN-" & New Random().Next(1000, 9999).ToString()
    End Function

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductIDs()
        LoadSupplierIDs()

        ' Set ToolTips for the ComboBoxes, TextBoxes, and DateTimePickers
        ToolTip1.SetToolTip(cmbProduct, "Select the product ID from the dropdown.")
        ToolTip1.SetToolTip(cmbSupplier, "Select the supplier ID from the dropdown.")
        ToolTip1.SetToolTip(txtProductName, "Enter the product's name.")
        ToolTip1.SetToolTip(txtQuantity, "Enter the quantity of the product.")
        ToolTip1.SetToolTip(txtSupplierName, "Enter the supplier's name.")
        ToolTip1.SetToolTip(txtSContact, "Enter the supplier's contact number.")
        ToolTip1.SetToolTip(txtSAddress, "Enter the supplier's address.")
        ToolTip1.SetToolTip(dtpDate, "Select the date for the transaction.")
        ToolTip1.SetToolTip(dtpSDate, "Select the date for the supplier registration.")
        ToolTip1.SetToolTip(txtSSupplierID, "Enter the supplier's ID.")
        ToolTip1.SetToolTip(txtSSupplierName, "Enter the supplier's name.")

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub LoadProductIDs()
        Dim query As String = "SELECT product_id FROM products"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    cmbProduct.Items.Clear() ' Clear existing items
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cmbProduct.Items.Add(reader("product_id").ToString())
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading product IDs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadSupplierIDs()
        Dim query As String = "SELECT supplier_id FROM supplier"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    cmbSupplier.Items.Clear() ' Clear existing items
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cmbSupplier.Items.Add(reader("supplier_id").ToString())
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading supplier IDs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub cmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        If cmbSupplier.SelectedItem IsNot Nothing Then
            Dim selectedSupplierID As String = cmbSupplier.SelectedItem.ToString()
            LoadSupplierDetails(selectedSupplierID)
        End If
    End Sub

    Private Sub cmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduct.SelectedIndexChanged
        If cmbProduct.SelectedItem IsNot Nothing Then
            Dim selectedProductID As String = cmbProduct.SelectedItem.ToString()
            LoadDetails("products", selectedProductID, txtQuantity)
        End If
    End Sub

    Private Sub LoadDetails(tableName As String, id As String, textBox As Guna.UI2.WinForms.Guna2TextBox)
        Dim query As String = $"SELECT product_name FROM {tableName} WHERE product_id=@id"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtProductName.Text = reader("product_name").ToString()
                        Else
                            MessageBox.Show($"{tableName} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadSupplierDetails(supplierID As String)
        Dim query As String = "SELECT supplier_name FROM supplier WHERE supplier_id=@supplierID"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@supplierID", supplierID)
                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtSupplierName.Text = reader("supplier_name").ToString()
                        Else
                            MessageBox.Show("Supplier not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading supplier details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(txtSupplierName.Text) OrElse
           String.IsNullOrWhiteSpace(txtProductName.Text) OrElse
           String.IsNullOrWhiteSpace(txtQuantity.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim quantity As Integer
        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If

        ' Generate the transaction ID
        Dim transactionID As String = GenerateTransactionID()

        ' Prepare the SQL insert command for the transaction
        Dim insertQuery As String = "INSERT INTO intransac (transaction_id, date, supplier_id, supplier_name, product_id, product_name, quantity, employee_id, employee_name) VALUES (@transactionId, @date, @supplierId, @supplierName, @productId, @productName, @quantity, @employeeId, @employeeName)"

        ' Prepare the SQL update command for the product quantity
        Dim updateQuery As String = "UPDATE products SET quantity = quantity + @quantity WHERE product_id = @productId"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Using transaction As MySqlTransaction = connection.BeginTransaction()
                Try
                    ' Insert transaction
                    Using insertCommand As New MySqlCommand(insertQuery, connection, transaction)
                        ' Add parameters for the insert command
                        insertCommand.Parameters.AddWithValue("@transactionId", transactionID)
                        insertCommand.Parameters.AddWithValue("@date", dtpDate.Value)
                        insertCommand.Parameters.AddWithValue("@supplierId", cmbSupplier.SelectedItem.ToString())
                        insertCommand.Parameters.AddWithValue("@supplierName", txtSupplierName.Text)
                        insertCommand.Parameters.AddWithValue("@productId", cmbProduct.SelectedItem.ToString())
                        insertCommand.Parameters.AddWithValue("@productName", txtProductName.Text)
                        insertCommand.Parameters.AddWithValue("@quantity", quantity)
                        insertCommand.Parameters.AddWithValue("@employeeId", employeeId) ' Use the employeeId from the constructor
                        insertCommand.Parameters.AddWithValue("@employeeName", employeeName) ' Use the employeeName from the constructor

                        ' Execute the insert command
                        insertCommand.ExecuteNonQuery()
                    End Using ' Update product quantity
                    Using updateCommand As New MySqlCommand(updateQuery, connection, transaction)
                        updateCommand.Parameters.AddWithValue("@quantity", quantity)
                        updateCommand.Parameters.AddWithValue("@productId", cmbProduct.SelectedItem.ToString())

                        ' Execute the update command
                        updateCommand.ExecuteNonQuery()
                    End Using

                    ' Commit the transaction
                    transaction.Commit()
                    MessageBox.Show("Transaction added successfully with ID: " & transactionID)

                    InsertActivityLog(employeeId, employeeName, $"ADDED INBOUND TRANSACTION: {transactionID}")


                    ' Clear the input fields after successful insertion
                    Clear()

                Catch ex As MySqlException
                    ' Rollback the transaction in case of error
                    transaction.Rollback()
                    MessageBox.Show("Error: " & ex.Message)
                    Clear()
                End Try
            End Using
        End Using
    End Sub

    Private Function GetEmployeeId(employeeName As String) As Integer
        Dim employeeId As Integer = 0
        Dim query As String = "SELECT employee_id FROM accounts WHERE CONCAT(TRIM(first_name), ' ', TRIM(surname)) = @employeeName"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@employeeName", employeeName.Trim()) ' Trim to remove any leading/trailing spaces
                Try
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        employeeId = Convert.ToInt32(result)
                    Else
                        MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving employee ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        Return employeeId
    End Function

    Private Sub Clear()
        ' Clear the input fields after successful insertion
        txtProductName.Text = ""
        txtQuantity.Text = ""
        txtSupplierName.Text = ""
        cmbProduct.SelectedIndex = -1
        cmbSupplier.SelectedIndex = -1
    End Sub

    Private Sub btnSCancel_Click(sender As Object, e As EventArgs) Handles btnSCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSSave_Click(sender As Object, e As EventArgs) Handles btnSSave.Click
        ' Validate input fields
        If String.IsNullOrWhiteSpace(txtSSupplierName.Text) OrElse
       String.IsNullOrWhiteSpace(txtSContact.Text) OrElse
       String.IsNullOrWhiteSpace(txtSSupplierID.Text) OrElse
       String.IsNullOrWhiteSpace(txtSAddress.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand()
            command.Connection = connection

            If isEditMode Then
                ' UPDATE supplier
                command.CommandText = "UPDATE supplier SET supplier_name=@name, contact=@contact, address=@address, date=@date WHERE supplier_id=@supplierId"
            Else
                ' Check for duplicate
                If IsSupplierIdDuplicate(txtSSupplierID.Text) Then
                    MessageBox.Show("Supplier ID already exists. Please use a different Supplier ID.", "Duplicate Supplier ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' INSERT supplier
                command.CommandText = "INSERT INTO supplier (date, supplier_id, supplier_name, contact, address) VALUES (@date, @supplierId, @name, @contact, @address)"
            End If

            ' Common parameters
            command.Parameters.AddWithValue("@date", dtpSDate.Value.Date)
            command.Parameters.AddWithValue("@supplierId", txtSSupplierID.Text)
            command.Parameters.AddWithValue("@name", txtSSupplierName.Text)
            command.Parameters.AddWithValue("@contact", txtSContact.Text)
            command.Parameters.AddWithValue("@address", txtSAddress.Text)

            Try
                connection.Open()
                Dim rowsAffected = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    If isEditMode Then
                        MessageBox.Show("Supplier updated successfully.")
                        InsertActivityLog(employeeId, employeeName, $"UPDATED SUPPLIER: {txtSSupplierID.Text}")
                    Else
                        MessageBox.Show("Supplier added successfully.")
                        InsertActivityLog(employeeId, employeeName, $"ADDED SUPPLIER: {txtSSupplierID.Text}")
                    End If

                    ClearInputFields()
                    isEditMode = False
                    txtSSupplierID.Enabled = True
                    btnSSave.Text = "Save"
                Else
                    MessageBox.Show("No changes were made.")
                End If
            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function IsSupplierIdDuplicate(supplierId As String) As Boolean
        If isEditMode AndAlso supplierId = originalSupplierID Then
            ' Don't consider it duplicate if user didn't change the ID
            Return False
        End If

        Dim query As String = "SELECT COUNT(*) FROM supplier WHERE supplier_id = @supplierId"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@supplierId", supplierId)

                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                Catch ex As MySqlException
                    MessageBox.Show("Error checking for duplicate Supplier ID: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function


    Private Sub ClearInputFields()
        ' Clear the input fields after successful insertion
        txtSSupplierName.Clear()
        txtSContact.Clear()
        txtSSupplierID.Clear()
        txtSAddress.Clear()
        dtpSDate.Value = DateTime.Now ' Reset date to current date
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        ' Only allow numeric digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        ' Remove any non-numeric characters that might have been pasted
        If System.Text.RegularExpressions.Regex.IsMatch(txtQuantity.Text, "[^0-9]") Then
            txtQuantity.Text = System.Text.RegularExpressions.Regex.Replace(txtQuantity.Text, "[^0-9]", "")
            txtQuantity.Select(txtQuantity.Text.Length, 0) ' Move cursor to end
        End If
    End Sub
    Private Sub txtSContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSContact.KeyPress
        ' Allow only numbers, backspace, and '+' (for international numbers)
        If Not Char.IsDigit(e.KeyChar) AndAlso
       e.KeyChar <> ControlChars.Back AndAlso
       e.KeyChar <> "+"c AndAlso
       e.KeyChar <> " "c Then
            e.Handled = True
        End If

        ' Prevent more than one '+' character
        If e.KeyChar = "+"c AndAlso txtSContact.Text.Contains("+") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSContact_TextChanged(sender As Object, e As EventArgs) Handles txtSContact.TextChanged
        ' Remove any invalid characters that might have been pasted
        Dim cleanedText As String = System.Text.RegularExpressions.Regex.Replace(txtSContact.Text, "[^0-9 +]", "")

        ' Limit to 15 characters (typical max for phone numbers)
        If cleanedText.Length > 15 Then
            cleanedText = cleanedText.Substring(0, 15)
        End If

        ' Only update if the text actually changed to prevent infinite loop
        If cleanedText <> txtSContact.Text Then
            txtSContact.Text = cleanedText
            txtSContact.SelectionStart = txtSContact.Text.Length ' Move cursor to end
        End If

    End Sub
    Public Sub ClearSupplierFields()
        ' Clear all fields used for editing or adding suppliers
        txtSSupplierID.Text = ""
        txtSSupplierName.Text = ""
        txtSContact.Text = ""
        txtSAddress.Text = ""
        dtpSDate.Value = Date.Today

        ' Reset any mode flags if applicable (e.g., isEditingSupplier = False)
    End Sub
End Class
