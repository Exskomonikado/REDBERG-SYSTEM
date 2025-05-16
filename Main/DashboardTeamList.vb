Imports MySql.Data.MySqlClient

Public Class DashboardTeamList
    Private parent As Dashboard
    Private empId As Integer
    Private empName As String
    Private selectedTeamLeaderId As String
    Private selectedTeamNumber As String ' Store the selected team number


    ' Constructor to receive values
    Public Sub New(parentForm As Dashboard, empId As Integer, empName As String)
        InitializeComponent()
        Me.parent = parentForm
        Me.empId = empId
        Me.empName = empName
    End Sub

    Private Sub btnTransacts_Click(sender As Object, e As EventArgs) Handles btnTransacts.Click
        Dim transactsForm As New DashboardOutTransact(empId, empName) ' Pass actual values here
        transactsForm.pnlAdd.Visible = False
        transactsForm.pnlSuppliers.Visible = True
        transactsForm.pnlSuppliers.Location = New Point(12, 12)
        transactsForm.Show()
    End Sub

    Private Sub DashboardTeamList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData() ' Load all data into the DataGridView
        LoadTotals() ' Load the totals for Leader, Organic, and Partner
        FormatDataGridView() ' Format DataGridView headers
    End Sub
    Private Sub LoadData(Optional filter As String = "")
        Dim query As String = "SELECT team_leaderId, team_leaderName, team_number, subcon FROM team"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(query, conn)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                dgvTeam.DataSource = dataTable
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub dgvTeam_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeam.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTeam.Rows(e.RowIndex)
            selectedTeamLeaderId = row.Cells("team_leaderId").Value.ToString() ' Store selected ID
            Dim selectedTeamNumber As String = row.Cells("team_number").Value.ToString() ' Store team number

            ' Load details for the selected team leader
            GetTeamDetails(selectedTeamLeaderId)

            ' Save team number in a class-level variable
            lblTeamNumber.Text = selectedTeamNumber
        End If
    End Sub


    Private Sub GetTeamDetails(teamLeaderId As String)
        Dim query As String = "SELECT date, team_leaderId, team_leaderName, team_number, contact, subcon, type FROM team WHERE team_leaderId = @teamLeaderId"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@teamLeaderId", teamLeaderId)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    lblDate.Text = reader("date").ToString()
                    lblTeamLeaderId.Text = reader("team_leaderId").ToString()
                    lblTeamLeaderName.Text = reader("team_leaderName").ToString()
                    lblTeamNumber.Text = reader("team_number").ToString()
                    lblContact.Text = reader("contact").ToString()
                    lblSubcon.Text = reader("subcon").ToString()
                    lblType.Text = reader("type").ToString()
                End If
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub LoadTotals()
        ' SQL query to count the distinct team_leaderId for the "Total Leader"
        Dim queryLeader As String = "SELECT COUNT(DISTINCT team_leaderId) AS totalLeader FROM team"

        ' SQL query to count Leader, Organic, and Partner types
        Dim queryType As String = "SELECT type, COUNT(*) AS total FROM team GROUP BY type"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Total Leader: Count the distinct team_leaderId
                Dim cmdLeader As New MySqlCommand(queryLeader, conn)
                Dim totalLeader As Integer = Convert.ToInt32(cmdLeader.ExecuteScalar())

                ' Update "Total Leader" button text
                btnTotalLeader.Text = "Total Leader: " & totalLeader.ToString()

                ' Total Organic, Total Partner: Get counts based on the type column
                Dim cmdType As New MySqlCommand(queryType, conn)
                Dim reader As MySqlDataReader = cmdType.ExecuteReader()

                ' Initialize counters
                Dim totalOrganic As Integer = 0
                Dim totalPartner As Integer = 0

                ' Loop through the reader to check for "Organic" and "Partner" types
                While reader.Read()
                    ' Check the value of the "type" column
                    Select Case reader("type").ToString().ToLower()
                        Case "organic"
                            totalOrganic = Convert.ToInt32(reader("total"))
                        Case "partner"
                            totalPartner = Convert.ToInt32(reader("total"))
                    End Select
                End While

                ' Update "Total Organic" and "Total Partner" button text
                btnTotalOrganic.Text = "Total Organic: " & totalOrganic.ToString()
                btnTotalPartner.Text = "Total Partner: " & totalPartner.ToString()

            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Function to format the DataGridView headers
    Private Sub FormatDataGridView()
        For Each column As DataGridViewColumn In dgvTeam.Columns
            ' Set the header text to uppercase
            column.HeaderText = column.HeaderText.ToUpper()

            With dgvTeam
                .Columns("team_leaderId").HeaderText = "ID"
                .Columns("team_leaderName").HeaderText = "Leader Name"
                .Columns("team_number").HeaderText = "Team No."
                .Columns("subcon").HeaderText = "Subcon"
            End With

            ' Remove underline (if present, this usually comes from a hyperlink-style default)
            column.HeaderCell.Style.Font = New Font("Arial", 10, FontStyle.Regular)
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("Please enter a search term.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Build the WHERE condition based on selected checkboxes
        Dim whereClause As String = ""
        Dim firstCondition As Boolean = True

        If chkTeamLeaderId.Checked Then
            If firstCondition Then
                whereClause &= "team_leaderId LIKE @searchValue"
                firstCondition = False
            Else
                whereClause &= " OR team_leaderId LIKE @searchValue"
            End If
        End If

        If chkTeamLeaderName.Checked Then
            If firstCondition Then
                whereClause &= "team_leaderName LIKE @searchValue"
                firstCondition = False
            Else
                whereClause &= " OR team_leaderName LIKE @searchValue"
            End If
        End If

        If chkSubcon.Checked Then
            If firstCondition Then
                whereClause &= "subcon LIKE @searchValue"
                firstCondition = False
            Else
                whereClause &= " OR subcon LIKE @searchValue"
            End If
        End If

        If String.IsNullOrEmpty(whereClause) Then
            MessageBox.Show("Please select at least one filter option.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Perform search using the generated WHERE clause
        SearchTeams(whereClause, searchText)
    End Sub

    ' Function to search teams based on selected filters
    Private Sub SearchTeams(whereClause As String, searchValue As String)
        Dim query As String = $"SELECT team_leaderId, team_leaderName, team_number, subcon FROM team WHERE {whereClause}"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@searchValue", "%" & searchValue & "%")

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        dgvTeam.DataSource = table
                        FormatDataGridView()
                    Else
                        MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtSearch.Text = ""
                        LoadData() ' Reload data if no results found
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error searching: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSearch.Text = ""
                End Try
            End Using
        End Using
    End Sub

    Private Sub Checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles chkTeamLeaderId.CheckedChanged, chkTeamLeaderName.CheckedChanged, chkSubcon.CheckedChanged
        ' If a checkbox is checked, uncheck all other checkboxes
        If CType(sender, Guna.UI2.WinForms.Guna2CustomCheckBox).Checked Then
            ' Uncheck the other checkboxes
            If sender Is chkTeamLeaderId Then
                chkTeamLeaderName.Checked = False
                chkSubcon.Checked = False
            ElseIf sender Is chkTeamLeaderName Then
                chkTeamLeaderId.Checked = False
                chkSubcon.Checked = False
            ElseIf sender Is chkSubcon Then
                chkTeamLeaderId.Checked = False
                chkTeamLeaderName.Checked = False
            End If
        End If
    End Sub


    Private Sub btnCrystalReport_Click(sender As Object, e As EventArgs) Handles btnCrystalReport.Click
        If String.IsNullOrEmpty(selectedTeamLeaderId) Then
            MessageBox.Show("Please select a team leader before generating a report.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedTeamNumber As String = lblTeamNumber.Text ' Get the team number from the label
        Dim reportForm As New CrystalReportData(selectedTeamLeaderId, selectedTeamNumber) ' Pass team number
        reportForm.Show()
    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        LoadData() ' Load all data into the DataGridView
        LoadTotals() ' Load the totals for Leader, Organic, and Partner
        FormatDataGridView() ' Format DataGridView headers
    End Sub

    Private Sub btnEditTeam_Click(sender As Object, e As EventArgs) Handles btnEditTeam.Click
        If dgvTeam.SelectedRows.Count = 0 Then
            MessageBox.Show("PLEASE SELECT A ROW TO EDIT.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvTeam.SelectedRows(0)
        Dim teamLeaderId As String = selectedRow.Cells("team_leaderId").Value.ToString()

        If MessageBox.Show("DO YOU WANT TO EDIT THIS TEAM?", "EDIT CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim form As New DashboardOutTransact(empId, empName)
            form.pnlAdd.Visible = False
            form.pnlSuppliers.Visible = True
            form.pnlSuppliers.Location = New Point(12, 12)
            form.IsEditMode = True
            form.SelectedTeamLeaderID = teamLeaderId
            form.Label16.Text = "MODIFY TEAM"
            form.Label15.Text = "PATH: TEAMLIST/ MODIFY"
            form.txtTeamLeaderID.Enabled = False

            ' Fill in visible values
            form.txtTeamLeaderID.Text = teamLeaderId
            form.txtTeamLeaderName.Text = selectedRow.Cells("team_leaderName").Value.ToString()
            form.txtTeamNumber.Text = selectedRow.Cells("team_number").Value.ToString()
            form.txtTypeOfSubcon.Text = selectedRow.Cells("subcon").Value.ToString()

            ' Load additional hidden values from database
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim query As String = "SELECT contact, type, date FROM team WHERE team_leaderId = @id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", teamLeaderId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            form.txtContact.Text = reader("contact").ToString()
                            form.cmbType.Text = reader("type").ToString()
                            form.dtpSDate.Value = Convert.ToDateTime(reader("date"))
                        Else
                            MessageBox.Show("TEAM DETAILS NOT FOUND.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("ERROR LOADING TEAM DETAILS: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Finally
                conn.Close()
            End Try

            form.ShowDialog()
        End If
    End Sub
End Class