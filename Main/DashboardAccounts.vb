Imports MySql.Data.MySqlClient

Public Class DashboardAccounts
    Public Shared IsEditMode As Boolean = False
    Public Property EmployeeID As String
    Public Property EmployeeType As String
    Public Property FullName As String


    Private Sub DashboardAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView
        LoadData()

        ' Load totals for accounts, admins, and staff
        LoadTotals()

        ToolTip1.SetToolTip(txtSearch, "Click to search")

    End Sub

    Public Sub LoadData()
        Dim query As String = "SELECT employee_id, first_name, surname, type FROM accounts"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                ' Fill the DataTable
                adapter.Fill(table)

                ' Bind the DataTable to the DataGridView
                dgvAccount.DataSource = table

                ' Format DataGridView columns
                FormatDataGridView()

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub FormatDataGridView()
        ' Format headers to uppercase with no underlines
        dgvAccount.Columns(0).HeaderText = "Employee ID"
        dgvAccount.Columns(1).HeaderText = "First Name"
        dgvAccount.Columns(2).HeaderText = "Surname"
        dgvAccount.Columns(3).HeaderText = "Type"
    End Sub

    Private Sub dgvAccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccount.CellClick
        ' Check if a valid row is clicked
        If e.RowIndex >= 0 Then
            ' Get the employee_id from the selected row
            Dim employeeId As Integer = Convert.ToInt32(dgvAccount.Rows(e.RowIndex).Cells(0).Value)

            ' Display the details in labels
            DisplayDetails(employeeId)
        End If
    End Sub

    Private Sub DisplayDetails(employeeId As Integer)
        Dim query As String = "SELECT * FROM accounts WHERE employee_id = @employeeId"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@employeeId", employeeId)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Read the data and display it in the labels
                If reader.Read() Then
                    lblStartDate.Text = If(reader("start_date") Is DBNull.Value, "N/A", Convert.ToDateTime(reader("start_date")).ToString("yyyy-MM-dd"))
                    lblEmployeeID.Text = reader("employee_id").ToString()
                    lblFirstName.Text = reader("first_name").ToString()
                    lblMiddleName.Text = reader("middle_name").ToString()
                    lblSurname.Text = reader("surname").ToString()

                    ' Safely handle birthdate field
                    If Not IsDBNull(reader("birthdate")) Then
                        Dim birthdate As Object = reader("birthdate")
                        If birthdate IsNot DBNull.Value AndAlso IsDate(birthdate) Then
                            Try
                                ' Attempt conversion to DateTime
                                Dim birthDateValue As DateTime = Convert.ToDateTime(birthdate)
                                lblBirthdate.Text = birthDateValue.ToString("yyyy-MM-dd") ' Use the format you prefer
                            Catch ex As FormatException
                                lblBirthdate.Text = "Invalid Date Format"
                            End Try
                        Else
                            lblBirthdate.Text = "N/A"
                        End If
                    Else
                        lblBirthdate.Text = "N/A"
                    End If

                    lblContact.Text = If(reader("contact") Is DBNull.Value, "N/A", reader("contact").ToString())
                    lblAddress.Text = If(reader("address") Is DBNull.Value, "N/A", reader("address").ToString())
                    lblGmail.Text = If(reader("gmail") Is DBNull.Value, "N/A", reader("gmail").ToString())
                End If
            Catch ex As MySqlException
                MessageBox.Show("MySQL Error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadTotals()
        ' SQL query to count total accounts
        Dim queryTotalAccounts As String = "SELECT COUNT(*) FROM accounts"

        ' SQL query to count total Admins and Staff
        Dim queryTotalAdmins As String = "SELECT COUNT(*) FROM accounts WHERE type = 'Admin'"
        Dim queryTotalStaff As String = "SELECT COUNT(*) FROM accounts WHERE type = 'Staff'"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Get the total number of accounts
                Dim cmdTotalAccounts As New MySqlCommand(queryTotalAccounts, conn)
                Dim totalAccounts As Integer = Convert.ToInt32(cmdTotalAccounts.ExecuteScalar())

                ' Update the button text for Total Accounts
                btnTotalAccounts.Text = "Total Accounts: " & totalAccounts.ToString()

                ' Get the total number of Admins
                Dim cmdTotalAdmins As New MySqlCommand(queryTotalAdmins, conn)
                Dim totalAdmins As Integer = Convert.ToInt32(cmdTotalAdmins.ExecuteScalar())

                ' Update the button text for Total Admins
                btnTotalAdmin.Text = "Total Admin: " & totalAdmins.ToString()

                ' Get the total number of Staff
                Dim cmdTotalStaff As New MySqlCommand(queryTotalStaff, conn)
                Dim totalStaff As Integer = Convert.ToInt32(cmdTotalStaff.ExecuteScalar())

                ' Update the button text for Total Staff
                btnTotalStaff.Text = "Total Staff: " & totalStaff.ToString()

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Get the search input from the TextBox
        Dim searchText As String = txtSearch.Text.Trim()

        ' Check if the search text is empty
        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("Please enter a search term.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check which filter is selected
        Dim columnName As String = ""
        If chkEmployeeID.Checked Then
            columnName = "employee_id"
        ElseIf chkFirstName.Checked Then
            columnName = "first_name"
        ElseIf chkSurname.Checked Then
            columnName = "surname"
        Else
            MessageBox.Show("Please select a search category.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Call the function to search the database
        SearchAccounts(columnName, searchText)
    End Sub

    Private Sub SearchAccounts(column As String, searchValue As String)
        ' Create the SQL query
        Dim query As String = $"SELECT employee_id, first_name, surname, type FROM accounts WHERE {column} LIKE @searchValue"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@searchValue", "%" & searchValue & "%")

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(table)

                    ' Check if any rows were returned
                    If table.Rows.Count > 0 Then
                        ' Bind the result to the DataGridView
                        dgvAccount.DataSource = table
                        FormatDataGridView() ' Call your formatting method
                    Else
                        MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Optionally, reset the DataGridView or load all accounts
                        LoadData() ' Call your method to load all accounts
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Error searching: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkEmployeeID.CheckedChanged, chkFirstName.CheckedChanged, chkSurname.CheckedChanged
        ' Ensure only one checkbox can be checked at a time
        If CType(sender, Guna.UI2.WinForms.Guna2CustomCheckBox).Checked Then
            ' Uncheck the other checkboxes
            If sender Is chkEmployeeID Then
                chkFirstName.Checked = False
                chkSurname.Checked = False
            ElseIf sender Is chkFirstName Then
                chkEmployeeID.Checked = False
                chkSurname.Checked = False
            ElseIf sender Is chkSurname Then
                chkEmployeeID.Checked = False
                chkFirstName.Checked = False
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Check if ManageAccounts is already open
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is ManageAccounts Then
                frm.BringToFront()
                Exit Sub
            End If
        Next

        ' If not open, create a new instance
        IsEditMode = False
        Dim manageAccountsForm As New ManageAccounts()
        manageAccountsForm.pnlEdit.Visible = False
        manageAccountsForm.pnlAdd.Visible = True

        manageAccountsForm.EmployeeId = Me.EmployeeID
        manageAccountsForm.FullName = Me.FullName
        manageAccountsForm.Show()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        IsEditMode = True

        If dgvAccount.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Do you want to update the selected account?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dgvAccount.SelectedRows(0)

            ' Check if ManageAccounts is already open
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is ManageAccounts Then
                    Dim existingForm As ManageAccounts = CType(frm, ManageAccounts)
                    existingForm.BringToFront()
                    existingForm.EmployeeId = selectedRow.Cells("employee_id").Value.ToString()
                    existingForm.LoadEmployeeDetails(selectedRow.Cells("employee_id").Value.ToString())
                    existingForm.pnlAdd.Visible = False
                    existingForm.pnlEdit.Visible = True
                    existingForm.pnlEdit.Location = New Point(12, 12)
                    Exit Sub
                End If
            Next

            ' If not open, create a new instance
            Dim form25 As New ManageAccounts
            form25.Form23Instance = Me
            form25.EmployeeId = selectedRow.Cells("employee_id").Value.ToString()
            form25.LoadEmployeeDetails(selectedRow.Cells("employee_id").Value.ToString())
            form25.pnlAdd.Visible = False
            form25.pnlEdit.Visible = True
            form25.pnlEdit.Location = New Point(12, 12)

            form25.LoggedInUserId = Me.EmployeeID
            form25.LoggedInFullName = Me.FullName

            form25.ShowDialog()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' Check if a row is selected
        If dgvAccount.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected row
        Dim selectedRow As DataGridViewRow = dgvAccount.SelectedRows(0)
        Dim employeeId As String = selectedRow.Cells("employee_id").Value.ToString()

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the account with Employee ID: {employeeId}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Proceed with deletion
            DeleteAccount(employeeId)
        End If
    End Sub

    Private Sub DeleteAccount(employeeId As String)
        Dim query As String = "DELETE FROM accounts WHERE employee_id = @employee_id"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@employee_id", employeeId)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Account deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Call InsertActivityLog here
                        InsertActivityLog(Me.EmployeeID, Me.FullName, $"DELETED ACCOUNT WITH EMPLOYEE ID: {employeeId}")

                        LoadData() ' Refresh the DataGridView after deletion
                    Else
                        MessageBox.Show("No account found with the specified Employee ID.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim query As String = "SELECT employee_id, first_name, surname, type FROM accounts"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                ' Fill the DataTable
                adapter.Fill(table)

                ' Bind the DataTable to the DataGridView
                dgvAccount.DataSource = table

                ' Format DataGridView columns
                FormatDataGridView()

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
        LoadData()

        ' Load totals for accounts, admins, and staff
        LoadTotals()
    End Sub

End Class
