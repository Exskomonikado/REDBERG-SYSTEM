Imports MySql.Data.MySqlClient

Public Class DashboardOutTransact
    Private employeeId As String
    Private employeeName As String

    Public Property IsEditMode As Boolean = False
    Public Property SelectedTeamLeaderID As String = ""
    ' Constructor to accept employee ID and name
    Public Sub New(empId As Integer, empName As String, Optional editMode As Boolean = False, Optional teamID As String = "")
        InitializeComponent() ' This call is required by the designer.
        employeeId = empId
        employeeName = empName
        isEditMode = editMode
        SelectedTeamLeaderID = teamID
    End Sub
    Private Sub PopulateTeamLeaderComboBox()
        Dim query As String = "SELECT team_leaderId FROM team" ' Adjust the query as needed

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        cmbTeamID.Items.Add(reader("team_leaderId").ToString())
                    End While
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub PopulateProductComboBox()
        Dim query As String = "SELECT product_id FROM products" ' Adjust the query as needed

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        cmbProductID.Items.Add(reader("product_id").ToString())
                    End While
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub btnSCancel_Click(sender As Object, e As EventArgs) Handles btnSCancel.Click
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSSave_Click(sender As Object, e As EventArgs) Handles btnSSave.Click
        Dim teamLeaderId As String = txtTeamLeaderID.Text.Trim()

        If String.IsNullOrWhiteSpace(teamLeaderId) Then
            MessageBox.Show("Please enter a valid Team Leader ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim teamLeaderName As String = txtTeamLeaderName.Text.Trim()
        Dim teamNumber As String = txtTeamNumber.Text.Trim()
        Dim contact As String = txtContact.Text.Trim()
        Dim subcon As String = txtTypeOfSubcon.Text.Trim()
        Dim type As String = cmbType.Text.Trim()
        Dim dateValue As Date = dtpSDate.Value

        If String.IsNullOrWhiteSpace(teamLeaderName) OrElse String.IsNullOrWhiteSpace(teamNumber) OrElse String.IsNullOrWhiteSpace(contact) OrElse String.IsNullOrWhiteSpace(type) OrElse String.IsNullOrWhiteSpace(subcon) Then
            MessageBox.Show("Please fill in all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If IsEditMode Then
            ' Perform UPDATE
            If UpdateTeam(dateValue, teamLeaderId, teamLeaderName, teamNumber, contact, subcon, type) Then
                MessageBox.Show("Team updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                InsertActivityLog(employeeId, employeeName, "UPDATED TEAM: ID: " & teamLeaderId)
                Me.Close()
            Else
                MessageBox.Show("Failed to update team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' Perform INSERT
            If InsertTeam(dateValue, teamLeaderId, teamLeaderName, teamNumber, contact, subcon, type) Then
                MessageBox.Show("Team inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                InsertActivityLog(employeeId, employeeName, "ADDED TEAM: ID: " & teamLeaderId)
                ClearInputFields()
            Else
                MessageBox.Show("Failed to insert team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Function UpdateTeam(dateValue As Date, teamLeaderId As String, teamLeaderName As String, teamNumber As String, contact As String, subcon As String, type As String) As Boolean
        Dim query As String = "UPDATE team SET date=@date, team_leaderName=@teamLeaderName, team_number=@teamNumber, contact=@contact, subcon=@subcon, type=@type WHERE team_leaderId=@teamLeaderId"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@date", dateValue)
                cmd.Parameters.AddWithValue("@teamLeaderName", teamLeaderName)
                cmd.Parameters.AddWithValue("@teamNumber", teamNumber)
                cmd.Parameters.AddWithValue("@contact", contact)
                cmd.Parameters.AddWithValue("@subcon", subcon)
                cmd.Parameters.AddWithValue("@type", type)
                cmd.Parameters.AddWithValue("@teamLeaderId", teamLeaderId)

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                Catch ex As Exception
                    MessageBox.Show("Error updating team: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function


    Private Function InsertTeam(dateValue As Date, teamLeaderId As String, teamLeaderName As String, teamNumber As String, contact As String, subcon As String, type As String) As Boolean
        Dim queryCheck As String = "SELECT COUNT(*) FROM team WHERE team_leaderId = @teamLeaderId"
        Dim queryInsert As String = "INSERT INTO team (date, team_leaderId, team_leaderName, team_number, contact, subcon, type) VALUES (@date, @teamLeaderId, @teamLeaderName, @teamNumber, @contact, @subcon, @type)"

        Using conn As New MySqlConnection(connectionString)
            Using cmdCheck As New MySqlCommand(queryCheck, conn)
                cmdCheck.Parameters.AddWithValue("@teamLeaderId", teamLeaderId)

                Try
                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Team Leader ID already exists. Please use a different ID.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If

                    ' If no duplicate, proceed to insert
                    Using cmdInsert As New MySqlCommand(queryInsert, conn)
                        cmdInsert.Parameters.AddWithValue("@date", dateValue)
                        cmdInsert.Parameters.AddWithValue("@teamLeaderId", teamLeaderId)
                        cmdInsert.Parameters.AddWithValue("@teamLeaderName", teamLeaderName)
                        cmdInsert.Parameters.AddWithValue("@teamNumber", teamNumber)
                        cmdInsert.Parameters.AddWithValue("@contact", contact)
                        cmdInsert.Parameters.AddWithValue("@subcon", subcon) ' Add subcon parameter
                        cmdInsert.Parameters.AddWithValue("@type", type)

                        cmdInsert.ExecuteNonQuery()
                    End Using

                    Return True
                Catch ex As Exception
                    MessageBox.Show("Error inserting team: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function
    Private Sub ClearInputFields()
        txtTeamLeaderID.Clear()
        txtTeamLeaderName.Clear()
        txtTeamNumber.Clear()
        txtTypeOfSubcon.Clear()
        txtContact.Clear() ' Clear the subcon field
        cmbType.SelectedIndex = 0
        dtpSDate.Value = DateTime.Now
    End Sub

    Private Sub DashboardOutTransact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTeamLeaderComboBox()
        PopulateProductComboBox()

        ' Tooltips for Team Information Fields
        ToolTip1.SetToolTip(cmbTeamID, "Select the unique Team ID from the dropdown.")
        ToolTip1.SetToolTip(txtLeaderName, "Enter the name of the team leader.")
        ToolTip1.SetToolTip(cmbTeamNumber, "Select the team number from the dropdown.")
        ToolTip1.SetToolTip(cmbProductID, "Select the Product ID for the team.")
        ToolTip1.SetToolTip(txtProductName, "Enter the product name associated with the team.")
        ToolTip1.SetToolTip(txtPrice1, "Enter the price of the product.")
        ToolTip1.SetToolTip(txtType1, "Enter the product type.")
        ToolTip1.SetToolTip(txtQuantity1, "Enter the quantity of products in the team.")

        ' Tooltips for Team Leader Information Fields
        ToolTip1.SetToolTip(txtTeamLeaderID, "Enter the Team Leader's unique ID.")
        ToolTip1.SetToolTip(txtTeamLeaderName, "Enter the Team Leader's full name.")
        ToolTip1.SetToolTip(txtTeamNumber, "Enter the team number for the team.")
        ToolTip1.SetToolTip(txtContact, "Enter the contact number of the team leader.")
        ToolTip1.SetToolTip(txtTypeOfSubcon, "Enter the type of subcontractor.")
        ToolTip1.SetToolTip(cmbType, "Select the type of team.")

    End Sub

    Private Sub cmbTeamID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeamID.SelectedIndexChanged
        Dim selectedLeaderId As String = cmbTeamID.SelectedItem.ToString()
        PopulateTeamNumberComboBox(selectedLeaderId)
        LoadTeamLeaderName(selectedLeaderId)
    End Sub
    Private Sub PopulateTeamNumberComboBox(teamLeaderId As String)
        cmbTeamNumber.Items.Clear() ' Clear previous items
        Dim query As String = "SELECT team_number FROM team WHERE team_leaderId = @team_leaderId"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@team_leaderId", teamLeaderId)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        cmbTeamNumber.Items.Add(reader("team_number").ToString())
                    End While
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadTeamLeaderName(teamLeaderId As String)
        Dim query As String = "SELECT team_leaderName FROM team WHERE team_leaderId = @team_leaderId"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@team_leaderId", teamLeaderId)
                Try
                    connection.Open()
                    Dim teamLeaderName As String = command.ExecuteScalar()?.ToString()
                    txtLeaderName.Text = teamLeaderName
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub cmbProductID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductID.SelectedIndexChanged
        Dim selectedProductId As String = cmbProductID.SelectedItem.ToString()
        LoadProductDetails(selectedProductId)
    End Sub
    Private Sub LoadProductDetails(productId As String)
        Dim query As String = "SELECT product_name, type, price, quantity FROM products WHERE product_id = @product_id"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@product_id", productId)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            txtProductName.Text = reader("product_name").ToString()
                            txtType1.Text = reader("type").ToString()
                            txtPrice1.Text = reader("price").ToString()
                            txtQuantity1.Text = reader("quantity").ToString()

                            ' Check if the quantity is greater than 0
                            Dim availableQuantity As Integer = Integer.Parse(reader("quantity").ToString())
                            If availableQuantity <= 0 Then
                                MessageBox.Show("Selected product is out of stock.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                btnSave.Enabled = False ' Disable the insert button
                            Else
                                btnSave.Enabled = True ' Enable the insert button
                            End If
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Public Function GenerateTransactionID() As String
        Return "TXN-" & New Random().Next(1000, 9999).ToString()
    End Function

    Public Sub InsertData()
        ' Validate Inputs
        If String.IsNullOrWhiteSpace(txtLeaderName.Text) OrElse
           String.IsNullOrWhiteSpace(cmbTeamID.Text) OrElse
           String.IsNullOrWhiteSpace(cmbTeamNumber.Text) OrElse
           String.IsNullOrWhiteSpace(cmbProductID.Text) OrElse
           String.IsNullOrWhiteSpace(txtProductName.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrice1.Text) OrElse
           String.IsNullOrWhiteSpace(txtQuantity1.Text) OrElse
           String.IsNullOrWhiteSpace(txtType1.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim price As Integer
        Dim quantity As Integer
        If Not Integer.TryParse(txtPrice1.Text, price) OrElse Not Integer.TryParse(txtQuantity1.Text, quantity) Then
            MessageBox.Show("Price and Quantity must be valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check available stock
        Dim availableQuantity As Integer = GetAvailableQuantity(cmbProductID.SelectedItem.ToString())
        If quantity > availableQuantity Then
            MessageBox.Show("Quantity cannot exceed available stock.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Calculate Total Price
        Dim totalPrice As Integer = price * quantity
        Dim transactionId As String = GenerateTransactionID()
        Dim dateValue As Date = Date.Now
        Dim teamLeaderId As String = cmbTeamID.SelectedItem.ToString()
        Dim teamLeader As String = txtLeaderName.Text
        Dim teamNumber As String = cmbTeamNumber.SelectedItem.ToString()
        Dim productId As String = cmbProductID.SelectedItem.ToString()
        Dim productName As String = txtProductName.Text
        Dim type As String = txtType1.Text

        Dim query As String = "INSERT INTO outtransact (transaction_id, date, employee_id, employee_name, team_leaderId, team_leaderName, team_number, product_id, product_name, type, price, quantity) " &
                              "VALUES (@transaction_id, @date, @employee_id, @employee_name, @team_leaderId, @team_leader, @team_number, @product_id, @product_name, @type, @price, @quantity)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@transaction_id", transactionId)
                command.Parameters.AddWithValue("@date", dateValue)
                command.Parameters.AddWithValue("@employee_id", employeeId.ToString())
                command.Parameters.AddWithValue("@employee_name", employeeName)
                command.Parameters.AddWithValue("@team_leaderId", teamLeaderId)
                command.Parameters.AddWithValue("@team_leader", teamLeader)
                command.Parameters.AddWithValue("@team_number", teamNumber)
                command.Parameters.AddWithValue("@product_id", productId)
                command.Parameters.AddWithValue("@product_name", productName)
                command.Parameters.AddWithValue("@type", type)
                command.Parameters.AddWithValue("@price", totalPrice)
                command.Parameters.AddWithValue("@quantity", quantity)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        InsertActivityLog(employeeId, employeeName, "ADDED OUTBOUND TRANSACTION: " & transactionId)
                        MessageBox.Show("Data inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        UpdateProductQuantity(productId, quantity) ' Reduce stock
                    Else
                        MessageBox.Show("Data insertion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub UpdateProductQuantity(productId As String, quantitySold As Integer)
        Dim query As String = "UPDATE products SET quantity = quantity - @quantitySold WHERE product_id = @product_id AND quantity >= @quantitySold"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@quantitySold", quantitySold)
                command.Parameters.AddWithValue("@product_id", productId)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Product quantity updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Insufficient stock or invalid product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error updating product quantity: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Fetch Available Quantity
    Private Function GetAvailableQuantity(productId As String) As Integer
        Dim query As String = "SELECT quantity FROM products WHERE product_id = @product_id"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@product_id", productId)

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()
                    Return If(result IsNot Nothing, Convert.ToInt32(result), -1)
                Catch ex As Exception
                    MessageBox.Show("Error fetching product quantity: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return -1
                End Try
            End Using
        End Using
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InsertData()
        txtLeaderName.Clear()
        cmbTeamID.SelectedIndex = 0
        cmbTeamNumber.SelectedIndex = 0
        cmbProductID.SelectedIndex = 0
        txtProductName.Clear()
        txtType1.Clear()
        txtPrice1.Clear()
        txtQuantity1.Clear()
    End Sub

    Private Sub txtQuantity1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity1.KeyPress
        ' Only allow numeric digits and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQuantity1_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity1.TextChanged
        ' Remove any non-numeric characters that might have been pasted
        If System.Text.RegularExpressions.Regex.IsMatch(txtQuantity1.Text, "[^0-9]") Then
            Dim cursorPosition As Integer = txtQuantity1.SelectionStart
            txtQuantity1.Text = System.Text.RegularExpressions.Regex.Replace(txtQuantity1.Text, "[^0-9]", "")
            ' Maintain cursor position after text change
            txtQuantity1.SelectionStart = Math.Min(cursorPosition, txtQuantity1.Text.Length)
        End If

        ' Optional: Prevent leading zeros
        If txtQuantity1.Text.Length > 1 AndAlso txtQuantity1.Text.StartsWith("0") Then
            txtQuantity1.Text = txtQuantity1.Text.TrimStart("0"c)
            txtQuantity1.SelectionStart = txtQuantity1.Text.Length
        End If

        ' Optional: Prevent empty field by setting to "0" if empty
        If String.IsNullOrEmpty(txtQuantity1.Text) Then
            txtQuantity1.Text = "0"
            txtQuantity1.SelectionStart = 1
        End If
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        ' Get the current cursor position
        Dim cursorPos As Integer = txtContact.SelectionStart

        ' Remove any non-numeric characters
        Dim numericText As String = New String(txtContact.Text.Where(Function(c) Char.IsDigit(c)).ToArray())

        ' Update the text if it was changed
        If txtContact.Text <> numericText Then
            txtContact.Text = numericText
            ' Restore the cursor position (adjusted for any removed characters)
            txtContact.SelectionStart = Math.Min(cursorPos, numericText.Length)
        End If
    End Sub
    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        ' Only allow numbers and control keys (like backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class