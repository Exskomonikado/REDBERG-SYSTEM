Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class ManageAccounts
    Public Property EmployeeID As String
    Public Property FullName As String
    Public Property LoggedInUserId As String
    Public Property LoggedInFullName As String

    Public Property Form23Instance As DashboardAccounts

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            InsertAccount()

            InsertActivityLog(EmployeeID, FullName, $"CREATED ACCOUNT FOR EMPLOYEE ID: {txtEmployeeID.Text}")

            If Form23Instance IsNot Nothing Then
                Form23Instance.LoadData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub InsertAccount()
        ' Retrieve inputs from form controls
        Dim employeeId As String = txtEmployeeID.Text.Trim()
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim surname As String = txtSurname.Text.Trim()
        Dim middleName As String = txtMiddleName.Text.Trim()
        Dim birthdate As Date = dtpBirthdate.Value
        Dim contact As String = txtContact.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()
        Dim gmail As String = txtGmail.Text.Trim()
        Dim accountType As String = If(cmbRole.SelectedItem Is Nothing, "", cmbRole.SelectedItem.ToString())
        Dim startDate As Date = dtpStartDate.Value
        Dim department As String = txtDepartment.Text.Trim()
        Dim role As String = txtSpecificRole.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If String.IsNullOrWhiteSpace(employeeId) OrElse String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(surname) OrElse
           String.IsNullOrWhiteSpace(middleName) OrElse String.IsNullOrWhiteSpace(contact) OrElse String.IsNullOrWhiteSpace(address) OrElse
           String.IsNullOrWhiteSpace(gmail) OrElse String.IsNullOrWhiteSpace(accountType) OrElse String.IsNullOrWhiteSpace(department) OrElse
           String.IsNullOrWhiteSpace(role) OrElse String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then

            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(accountType) Then
            MessageBox.Show("Account Type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbRole.SelectedIndex = 0
            Exit Sub
        End If

        If Not Regex.IsMatch(gmail, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            MessageBox.Show("Invalid Gmail address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtGmail.Text = ""
            Exit Sub
        End If

        If contact.Length > 11 OrElse Not IsNumeric(contact) Then
            MessageBox.Show("Invalid contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContact.Text = ""
            Exit Sub
        End If

        ' Generate a 6-digit random code
        Dim randomCode As String = New Random().Next(100000, 999999).ToString()

        ' MySQL Database Insertion
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Check if employee_id already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM accounts WHERE employee_id = @employeeId"
                Using checkCmd As New MySqlCommand(checkQuery, connection)
                    checkCmd.Parameters.AddWithValue("@employeeId", employeeId)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Employee ID already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using

                ' Check if gmail already exists
                Dim checkGmailQuery As String = "SELECT COUNT(*) FROM accounts WHERE gmail = @gmail"
                Using gmailCmd As New MySqlCommand(checkGmailQuery, connection)
                    gmailCmd.Parameters.AddWithValue("@gmail", gmail)
                    Dim gmailCount As Integer = Convert.ToInt32(gmailCmd.ExecuteScalar())
                    If gmailCount > 0 Then
                        MessageBox.Show("Gmail already exists. Please use another Gmail address.", "Duplicate Gmail", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using

                ' Check if username already exists
                Dim checkUsernameQuery As String = "SELECT COUNT(*) FROM accounts WHERE username = @username"
                Using usernameCmd As New MySqlCommand(checkUsernameQuery, connection)
                    usernameCmd.Parameters.AddWithValue("@username", username)
                    Dim usernameCount As Integer = Convert.ToInt32(usernameCmd.ExecuteScalar())
                    If usernameCount > 0 Then
                        MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using

                ' Check for strong password
                Dim passwordPattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$"
                If Not Regex.IsMatch(password, passwordPattern) Then
                    MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, number, and special character.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If


                ' Insert query
                Dim query As String = "INSERT INTO accounts (employee_id, first_name, surname, middle_name, birthdate, contact, address, gmail, type, start_date, department, role, username, password, code) " &
                                      "VALUES (@employeeId, @firstName, @surname, @middleName, @birthdate, @contact, @address, @gmail, @type, @startDate, @department, @role, @username, @password, @code)"

                Using command As New MySqlCommand(query, connection)
                    ' Add parameters
                    command.Parameters.AddWithValue("@employeeId", employeeId)
                    command.Parameters.AddWithValue("@firstName", firstName)
                    command.Parameters.AddWithValue("@surname", surname)
                    command.Parameters.AddWithValue("@middleName", middleName)
                    command.Parameters.AddWithValue("@birthdate", birthdate)
                    command.Parameters.AddWithValue("@contact", contact)
                    command.Parameters.AddWithValue("@address", address)
                    command.Parameters.AddWithValue("@gmail", gmail)
                    command.Parameters.AddWithValue("@type", accountType)
                    command.Parameters.AddWithValue("@startDate", startDate)
                    command.Parameters.AddWithValue("@department", department)
                    command.Parameters.AddWithValue("@role", role)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)
                    command.Parameters.AddWithValue("@code", randomCode)

                    ' Execute the query
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Account added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear() ' Call the Clear method to reset the textboxes after successful insertion

        Catch ex As MySqlException
            MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Clear()
        txtEmployeeID.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtSurname.Clear()
        txtContact.Clear()
        txtAddress.Clear()
        txtGmail.Clear()
        txtDepartment.Clear()
        txtSpecificRole.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbRole.SelectedIndex = 0 ' Clear selected item
        dtpBirthdate.Value = DateTime.Now ' Reset to current date
        dtpStartDate.Value = DateTime.Now ' Reset to current date
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this data?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            UpdateAccount() ' Ensure this method is defined and handles the update logic

            If Form23Instance IsNot Nothing Then
                Form23Instance.LoadData() ' Refresh the data in Form23 after the update
            End If
        End If
    End Sub
    Public Sub LoadEmployeeDetails(empId As String)
        Dim query As String = "SELECT * FROM accounts WHERE employee_id = @employeeId"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@employeeId", empId)

            Try
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Populate textboxes with the data
                        txtEditEmployeeID.Text = reader("employee_id").ToString()
                        txtEditFirstName.Text = reader("first_name").ToString()
                        txtEditSurname.Text = reader("surname").ToString()
                        txtEditMiddleName.Text = reader("middle_name").ToString()
                        dtpEditBirthdate.Value = Convert.ToDateTime(reader("birthdate"))
                        txtEditContact.Text = reader("contact").ToString()
                        txtEditAddress.Text = reader("address").ToString()
                        txtEditGmail.Text = reader("gmail").ToString()
                        cmbEditRole.SelectedItem = reader("type").ToString()
                        dtpEditStartDate.Value = Convert.ToDateTime(reader("start_date"))
                        txtEditDepartment.Text = reader("department").ToString()
                        txtEditSpecificRole.Text = reader("role").ToString()
                        txtEditUsername.Text = reader("username").ToString()
                        txtEditPassword.Text = reader("password").ToString()
                    Else
                        MessageBox.Show("No employee found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Public Sub UpdateAccount()
        Dim query As String = "UPDATE accounts SET first_name = @firstName, surname = @surname, middle_name = @middleName, birthdate = @birthdate, contact = @contact, address = @address, gmail = @gmail, type = @type, start_date = @startDate, department = @department, role = @role, username = @username, password = @password WHERE employee_id = @employeeId"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@firstName", txtEditFirstName.Text)
            command.Parameters.AddWithValue("@surname", txtEditSurname.Text)
            command.Parameters.AddWithValue("@middleName", txtEditMiddleName.Text)
            command.Parameters.AddWithValue("@birthdate", dtpEditBirthdate.Value)
            command.Parameters.AddWithValue("@contact", txtEditContact.Text)
            command.Parameters.AddWithValue("@address", txtEditAddress.Text)
            command.Parameters.AddWithValue("@gmail", txtEditGmail.Text)
            command.Parameters.AddWithValue("@type", cmbEditRole.SelectedItem.ToString())
            command.Parameters.AddWithValue("@startDate", dtpEditStartDate.Value)
            command.Parameters.AddWithValue("@department", txtEditDepartment.Text)
            command.Parameters.AddWithValue("@role", txtEditSpecificRole.Text)
            command.Parameters.AddWithValue("@username", txtEditUsername.Text)
            command.Parameters.AddWithValue("@password", txtEditPassword.Text)
            command.Parameters.AddWithValue("@employeeId", EmployeeID)

            Try
                connection.Open()
                Dim result As Integer = command.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    InsertActivityLog(LoggedInUserId, LoggedInFullName, $"UPDATED ACCOUNT FOR EMPLOYEE ID: {txtEditEmployeeID.Text}")

                    Clear()
                    Me.Hide()
                Else
                    MessageBox.Show("No data was updated.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ManageAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DashboardAccounts.IsEditMode Then
            ' Only try to load details if in Edit Mode
            LoadEmployeeDetails(EmployeeID)
        End If

        ToolTip1.SetToolTip(txtEmployeeID, "Enter the employee ID (unique identifier).")
        ToolTip1.SetToolTip(txtFirstName, "Enter the employee's first name.")
        ToolTip1.SetToolTip(txtMiddleName, "Enter the employee's middle name.")
        ToolTip1.SetToolTip(txtSurname, "Enter the employee's surname (last name).")
        ToolTip1.SetToolTip(txtContact, "Enter the employee's contact number.")
        ToolTip1.SetToolTip(txtAddress, "Enter the employee's residential address.")
        ToolTip1.SetToolTip(txtGmail, "Enter the employee's Gmail address.")
        ToolTip1.SetToolTip(txtDepartment, "Enter the department the employee belongs to.")
        ToolTip1.SetToolTip(txtSpecificRole, "Enter the employee's specific role within the department.")
        ToolTip1.SetToolTip(txtUsername, "Enter a unique username for the employee.")
        ToolTip1.SetToolTip(txtPassword, "Enter a password for the employee's account.")
        ToolTip1.SetToolTip(dtpBirthdate, "Select the employee's birthdate.")
        ToolTip1.SetToolTip(dtpStartDate, "Select the employee's start date at the company.")
        ToolTip1.SetToolTip(cmbEditRole, "Choose the employee's role from the dropdown.")

        ' Tooltips for Editing Employee Information Fields
        ToolTip1.SetToolTip(txtEditEmployeeID, "Enter the employee ID to edit.")
        ToolTip1.SetToolTip(txtEditFirstName, "Edit the employee's first name.")
        ToolTip1.SetToolTip(txtEditMiddleName, "Edit the employee's middle name.")
        ToolTip1.SetToolTip(txtEditSurname, "Edit the employee's surname (last name).")
        ToolTip1.SetToolTip(txtEditContact, "Edit the employee's contact number.")
        ToolTip1.SetToolTip(txtEditAddress, "Edit the employee's residential address.")
        ToolTip1.SetToolTip(txtEditGmail, "Edit the employee's Gmail address.")
        ToolTip1.SetToolTip(txtEditDepartment, "Edit the department the employee belongs to.")
        ToolTip1.SetToolTip(txtEditSpecificRole, "Edit the employee's specific role within the department.")
        ToolTip1.SetToolTip(txtEditUsername, "Edit the employee's username.")
        ToolTip1.SetToolTip(txtEditPassword, "Edit the employee's password.")
        ToolTip1.SetToolTip(dtpEditBirthdate, "Edit the employee's birthdate.")
        ToolTip1.SetToolTip(dtpEditStartDate, "Edit the employee's start date at the company.")
        ToolTip1.SetToolTip(cmbEditRole, "Choose the employee's new role from the dropdown.")
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

    Private Sub txtEditContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEditContact.KeyPress
        ' Allow digits (0-9), Backspace (8), and Delete (127)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Block the input
        End If
    End Sub
    Private Sub txtEditContact_TextChanged(sender As Object, e As EventArgs) Handles txtEditContact.TextChanged
        ' Remove any non-digit characters
        Dim numbersOnly As String = New String(txtEditContact.Text.Where(Function(c) Char.IsDigit(c)).ToArray())

        If txtEditContact.Text <> numbersOnly Then
            txtEditContact.Text = numbersOnly
        End If
    End Sub
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar ' Show password
        Else
            txtPassword.PasswordChar = "●"c ' Hide password using bullet
        End If
    End Sub


End Class