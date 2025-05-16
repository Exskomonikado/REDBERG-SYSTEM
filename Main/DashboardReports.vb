Imports MySql.Data.MySqlClient

Public Class DashboardReports
    Public Property EmployeeType As String
    Private parent As Dashboard
    Private empId As Integer
    Private empName As String

    ' Constructor to receive values
    Public Sub New(parentForm As Dashboard, empId As Integer, empName As String)
        InitializeComponent()
        Me.parent = parentForm
        Me.empId = empId
        Me.empName = empName
    End Sub

    Private Sub DashboardReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetButtonVisibility()
        LoadReportsData()
        UpdateReportTotals()

        cmbStatusFilter.Items.Clear()
        cmbStatusFilter.Items.Add("ALL")
        cmbStatusFilter.Items.Add("UNREAD")
        cmbStatusFilter.Items.Add("READ")

        ' Set default selection
        cmbStatusFilter.SelectedIndex = 0 ' Default to ALL

        ToolTip1.SetToolTip(txtSearch, "Click to search")

    End Sub

    Private Sub SetButtonVisibility()
        If EmployeeType = "ADMIN" Then
            ' If the user is an Admin, show Update and Remove buttons
            btnUpdate.Visible = True
            btnRemove.Visible = True
            Guna2Panel4.BorderColor = Color.Black
            btnUpdate.BorderColor = Color.Black
            btnAdd.Visible = False
        Else
            ' If the user is not an Admin, only show Add button
            btnUpdate.Visible = False
            btnRemove.Visible = False
            Guna2Panel4.BorderColor = Color.Transparent
            btnAdd.Visible = True
        End If
    End Sub

    Private Sub LoadReportsData(Optional statusFilter As String = "")
        Dim query As String = "SELECT reports_id, date, subject, status, employee_id, employee_name, description FROM reports"

        ' Apply filtering based on EmployeeType (Admin sees all, Staff sees their own)
        If EmployeeType = "STAFF" Then
            query &= " WHERE employee_id = @empId"

            ' If statusFilter is provided, add it to the WHERE clause
            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " AND status = @statusFilter"
            End If
        Else
            ' If ADMIN, filter only by status if selected
            If Not String.IsNullOrEmpty(statusFilter) Then
                query &= " WHERE status = @statusFilter"
            End If
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(query, conn)

                ' Add parameters based on filters
                If EmployeeType = "STAFF" Then
                    cmd.Parameters.AddWithValue("@empId", empId)
                End If
                If Not String.IsNullOrEmpty(statusFilter) Then
                    cmd.Parameters.AddWithValue("@statusFilter", statusFilter)
                End If

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Bind data to DataGridView
                dgvReports.AutoGenerateColumns = True
                dgvReports.DataSource = table

                ' Format DataGridView
                FormatReportsDataGridView()

            Catch ex As MySqlException
                MessageBox.Show("Error loading reports: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub FormatReportsDataGridView()
        ' Ensure that the DataGridView has columns before formatting
        If dgvReports.Columns.Count = 0 Then
            Return ' Exit if there are no columns
        End If

        ' Adjust column headers safely
        dgvReports.Columns(0).HeaderText = "Report ID"
        dgvReports.Columns(1).HeaderText = "Date"
        dgvReports.Columns(2).HeaderText = "Subject"
        dgvReports.Columns(3).HeaderText = "Status"

        ' Hide employee_id, employee_name, and description columns
        If dgvReports.Columns.Count > 4 Then dgvReports.Columns(4).Visible = False ' Employee ID
        If dgvReports.Columns.Count > 5 Then dgvReports.Columns(5).Visible = False ' Employee Name
        If dgvReports.Columns.Count > 6 Then dgvReports.Columns(6).Visible = False ' Description
    End Sub

    Private Sub dgvReports_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReports.CellClick
        ' Check if a valid row is clicked
        If e.RowIndex >= 0 Then
            ' Get the values from the selected row
            Dim reportId As Integer = Convert.ToInt32(dgvReports.Rows(e.RowIndex).Cells(0).Value)
            Dim reportDate As DateTime = Convert.ToDateTime(dgvReports.Rows(e.RowIndex).Cells(1).Value)
            Dim subject As String = dgvReports.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim status As String = dgvReports.Rows(e.RowIndex).Cells(3).Value.ToString()
            Dim employeeId As Integer = Convert.ToInt32(dgvReports.Rows(e.RowIndex).Cells(4).Value)
            Dim employeeName As String = dgvReports.Rows(e.RowIndex).Cells(5).Value.ToString()  ' Directly fetch employee_name
            Dim description As String = dgvReports.Rows(e.RowIndex).Cells(6).Value.ToString()

            ' Display the selected data in the labels
            DisplayReportDetails(employeeId, employeeName, reportId, reportDate, subject, description, status)
        End If
    End Sub

    Private Sub DisplayReportDetails(employeeId As Integer, employeeName As String, reportId As Integer, reportDate As DateTime, subject As String, description As String, status As String)
        ' Display data in labels, now including the employee name
        lblEmployeeID.Text = employeeId.ToString()
        lblEmployeeName.Text = employeeName
        lblReportID.Text = reportId.ToString()
        lblReportDate.Text = reportDate.ToString("yyyy-MM-dd")
        lblSubject.Text = subject
        lblDescription.Text = description
        lblStatus.Text = status
    End Sub

    Private Sub UpdateReportTotals()
        Dim queryTotalReports As String
        Dim queryTotalUnreadReports As String

        If EmployeeType = "STAFF" Then
            queryTotalReports = "SELECT COUNT(*) FROM reports WHERE employee_id = @empId"
            queryTotalUnreadReports = "SELECT COUNT(*) FROM reports WHERE status = 'Unread' AND employee_id = @empId"
        Else
            queryTotalReports = "SELECT COUNT(*) FROM reports"
            queryTotalUnreadReports = "SELECT COUNT(*) FROM reports WHERE status = 'Unread'"
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Get the total number of reports
                Dim cmdTotalReports As New MySqlCommand(queryTotalReports, conn)
                If EmployeeType = "STAFF" Then
                    cmdTotalReports.Parameters.AddWithValue("@empId", empId)
                End If
                Dim totalReports As Integer = Convert.ToInt32(cmdTotalReports.ExecuteScalar())
                btnTotalReports.Text = "Total Reports: " & totalReports.ToString()

                ' Get the total number of unread reports
                Dim cmdTotalUnreadReports As New MySqlCommand(queryTotalUnreadReports, conn)
                If EmployeeType = "STAFF" Then
                    cmdTotalUnreadReports.Parameters.AddWithValue("@empId", empId)
                End If
                Dim totalUnreadReports As Integer = Convert.ToInt32(cmdTotalUnreadReports.ExecuteScalar())
                btnTotalUnread.Text = "Total Unread Reports: " & totalUnreadReports.ToString()

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Check if ManageAddReport is already open
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is ManageAddReport Then
                frm.BringToFront()
                Exit Sub
            End If
        Next

        ' If not open, create a new instance
        Dim addReport As New ManageAddReport(empId, empName) ' Pass actual values here
        addReport.pnlAdd.Visible = True
        addReport.Show()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Ensure a row is selected
        If dgvReports.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a report to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Get the selected report ID from the DataGridView
        Dim reportId As String = dgvReports.SelectedRows(0).Cells("reports_id").Value.ToString()

        ' Call the function to update the status
        If UpdateReportStatus(reportId) Then
            MessageBox.Show("Report status updated to 'READ'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            InsertActivityLog(empId, empName, $"READ A REPORT: ID: {reportId}")

            ' Refresh DataGrid to reflect changes
            LoadReportsData()
        Else
            MessageBox.Show("Failed to update report status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function UpdateReportStatus(reportId As String) As Boolean
        Dim query As String = "UPDATE reports SET status = 'READ' WHERE reports_id = @reportId"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@reportId", reportId)

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0 ' Return True if at least one row was updated
                Catch ex As Exception
                    MessageBox.Show("Error updating report status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub cmbStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatusFilter.SelectedIndexChanged
        ' Get selected status
        Dim selectedStatus As String = cmbStatusFilter.SelectedItem.ToString()

        ' Pass status filter to LoadReportsData function
        If selectedStatus = "ALL" Then
            LoadReportsData() ' Load all data if "ALL" is selected
        Else
            LoadReportsData(selectedStatus)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' Ensure a row is selected
        If dgvReports.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a report to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Get the selected report details
        Dim reportId As Integer = Convert.ToInt32(dgvReports.SelectedRows(0).Cells("reports_id").Value)
        Dim reportStatus As String = dgvReports.SelectedRows(0).Cells("status").Value.ToString()

        ' Check if the status is "READ"
        If reportStatus <> "READ" Then
            MessageBox.Show("You can only delete reports that are marked as 'READ'. Please update the status first.", "Deletion Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Confirm deletion
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to remove this report?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            ' Proceed with deletion
            InsertActivityLog(empId, empName, $"REMOVE A REPORT: ID: {reportId}")
            DeleteReport(reportId)
        End If
    End Sub

    Private Sub DeleteReport(reportId As Integer)
        Dim query As String = "DELETE FROM reports WHERE reports_id = @reportId"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@reportId", reportId)

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Report deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadReportsData() ' Refresh DataGridView
                        UpdateReportTotals() ' Update the total counts
                    Else
                        MessageBox.Show("Failed to delete the report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error deleting report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim()

        ' Ensure a search term is entered
        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("Please enter a search term.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Build the WHERE condition based on selected checkboxes
        Dim whereClause As String = ""
        Dim firstCondition As Boolean = True

        If chkReportID.Checked Then
            If firstCondition Then
                whereClause &= "reports_id LIKE @searchValue"
                firstCondition = False
            Else
                whereClause &= " OR reports_id LIKE @searchValue"
            End If
        End If

        If chkSubject.Checked Then
            If firstCondition Then
                whereClause &= "subject LIKE @searchValue"
                firstCondition = False
            Else
                whereClause &= " OR subject LIKE @searchValue"
            End If
        End If

        ' Ensure at least one filter is selected
        If String.IsNullOrEmpty(whereClause) Then
            MessageBox.Show("Please select at least one filter option.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Perform search using the generated WHERE clause
        SearchReports(whereClause, searchText)
    End Sub
    Private Sub SearchReports(whereClause As String, searchValue As String)
        Dim query As String = $"SELECT reports_id, date, subject, status, employee_id, employee_name, description FROM reports WHERE {whereClause}"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@searchValue", "%" & searchValue & "%")

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        dgvReports.DataSource = table
                        FormatReportsDataGridView()
                    Else
                        MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtSearch.Text = ""
                        LoadReportsData() ' Reloads all reports if no results found
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error searching: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSearch.Text = ""
                End Try
            End Using
        End Using
    End Sub
    Private Sub Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles chkReportID.CheckedChanged, chkSubject.CheckedChanged
        If CType(sender, Guna.UI2.WinForms.Guna2CustomCheckBox).Checked Then
            If sender Is chkReportID Then
                chkSubject.Checked = False
            ElseIf sender Is chkSubject Then
                chkReportID.Checked = False
            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        SetButtonVisibility()
        LoadReportsData()
        UpdateReportTotals()

        cmbStatusFilter.Items.Clear()
        cmbStatusFilter.Items.Add("ALL")
        cmbStatusFilter.Items.Add("UNREAD")
        cmbStatusFilter.Items.Add("READ")

        ' Set default selection
        cmbStatusFilter.SelectedIndex = 0 ' Default to ALL
    End Sub

End Class
