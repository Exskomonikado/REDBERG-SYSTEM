Imports MySql.Data.MySqlClient

Public Class ManageOutTransact
    Private parentForm As Dashboard
    Private empId As String
    Private empName As String

    Public Sub New(parent As Dashboard, empId As Integer, empName As String)
        InitializeComponent()
        Me.parentForm = parent
        Me.empId = empId
        Me.empName = empName
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim form10 As New DashboardTransactions(parentForm, empId, empName)
        Connection.LoadFormIntoPanel(parentForm.pnlforms, form10)

        parentForm.lblSubTitle.Text = "PATH: TRANSACTION/ INBOUND"

    End Sub

    Private Sub btnTransacts_Click(sender As Object, e As EventArgs) Handles btnTransacts.Click
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is DashboardOutTransact Then
                frm.BringToFront()
                Exit Sub
            End If
        Next

        ' If not open, create a new instance
        Dim transactsForm As New DashboardOutTransact(empId, empName) ' Pass actual values here
        transactsForm.pnlAdd.Visible = True
        transactsForm.pnlSuppliers.Visible = False
        transactsForm.Show()
    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is DashboardOutTransact Then
                frm.BringToFront()
                Exit Sub
            End If
        Next

        ' If not open, create a new instance
        Dim transactsForm As New DashboardOutTransact(empId, empName) ' Pass actual values here
        transactsForm.pnlAdd.Visible = False
        transactsForm.pnlSuppliers.Visible = True
        transactsForm.pnlSuppliers.Location = New Point(12, 12)
        transactsForm.Show()
    End Sub

    Private Sub ManageOutTransact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOutTransactData()
        LoadOutboundCounts()

        ToolTip1.SetToolTip(txtSearch, "Click to search")
    End Sub

    Public Sub LoadOutTransactData()
        Dim query As String

        ' If ADMIN, show all data. If STAFF, show only their transactions.
        If parentForm.EmployeeType = "ADMIN" Then
            query = "SELECT transaction_id, date, employee_id, employee_name, team_leaderId, team_leaderName, team_number, product_id, product_name, type, price, quantity FROM outtransact"
        ElseIf parentForm.EmployeeType = "STAFF" Then
            query = "SELECT transaction_id, date, employee_id, employee_name, team_leaderId, team_leaderName, team_number, product_id, product_name, type, price, quantity FROM outtransact WHERE employee_id = @empId"
        Else
            ' Invalid user type, exit function
            Return
        End If

        ' Connect to database
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                ' If STAFF, filter by employee_id
                If parentForm.EmployeeType = "STAFF" Then
                    cmd.Parameters.AddWithValue("@empId", empId)
                End If

                Try
                    conn.Open()
                    dgvTransact.Columns.Clear()
                    dgvTransact.Columns.Add("transaction_id", "Transaction ID")
                    dgvTransact.Columns.Add("employee_id", "Employee ID")
                    dgvTransact.Columns.Add("team_leaderId", "Team Leader ID")
                    dgvTransact.Columns.Add("product_name", "Product Name")

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvTransact.Rows.Clear()
                        While reader.Read()
                            dgvTransact.Rows.Add(
                            reader("transaction_id").ToString(),
                            reader("employee_id").ToString(),
                            reader("team_leaderId").ToString(),
                            reader("product_name").ToString()
                        )
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading transaction data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
    Private Sub dgvTransact_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransact.CellClick
        If e.RowIndex >= 0 Then ' Check if a valid row is clicked
            ' Get the values from the selected row and fetch the remaining data
            Dim selectedRow As DataGridViewRow = dgvTransact.Rows(e.RowIndex)

            ' Define the transaction_id that was clicked (you will us
            ' e this to fetch the full details)
            Dim transactionId As String = selectedRow.Cells("transaction_id").Value.ToString()

            ' Now fetch the full details for this transaction_id
            FetchFullTransactionDetails(transactionId)
        End If
    End Sub
    Private Sub FetchFullTransactionDetails(transactionId As String)
        ' Define the query to get the full details for a specific transaction_id
        Dim query As String = "SELECT transaction_id, date, employee_id, employee_name, team_leaderId, team_leaderName, team_number, product_id, product_name, type, price, quantity FROM outtransact WHERE transaction_id = @transaction_id"

        ' Use MySqlConnection to connect to the database.
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@transaction_id", transactionId)

                Try
                    ' Open the connection to the database.
                    conn.Open()

                    ' Execute the query and get the result using MySqlDataReader.
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Check if there's data returned
                        If reader.Read() Then
                            ' Update the labels with the fetched data
                            lblTransactionID.Text = reader("transaction_id").ToString()
                            lblTransactionDate.Text = reader("date").ToString()
                            lblEmployeeID.Text = reader("employee_id").ToString()
                            lblEmployeeName.Text = reader("employee_name").ToString()
                            lblTeamLeaderID.Text = reader("team_leaderId").ToString()
                            lblTeamLeaderName.Text = reader("team_leaderName").ToString()
                            lblTeamNumber.Text = reader("team_number").ToString()
                            lblTeamNumber.Text = reader("product_id").ToString()
                            lblProductID.Text = reader("product_name").ToString()
                            lblQuantity.Text = reader("quantity").ToString()
                        End If
                    End Using
                Catch ex As Exception
                    ' If there's an error, show a message box.
                    MessageBox.Show("Error fetching transaction details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Load outbound transaction counts and team counts
    Public Sub LoadOutboundCounts()
        Dim totalOutboundQuery As String
        Dim totalTeamQuery As String = "SELECT COUNT(*) FROM team"

        ' Determine query based on employee type
        If parentForm.EmployeeType = "ADMIN" Then
            totalOutboundQuery = "SELECT COUNT(*) FROM outtransact"
        ElseIf parentForm.EmployeeType = "STAFF" Then
            totalOutboundQuery = "SELECT COUNT(*) FROM outtransact WHERE employee_id = @empId"
        Else
            ' Invalid user type, exit function
            Return
        End If

        ' Connect to database
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Get total outbound transactions
                Using cmdOutbound As New MySqlCommand(totalOutboundQuery, conn)
                    If parentForm.EmployeeType = "STAFF" Then
                        cmdOutbound.Parameters.AddWithValue("@empId", empId)
                    End If

                    Dim totalOutbound As Integer = Convert.ToInt32(cmdOutbound.ExecuteScalar())
                    btnTotalOutbound.Text = "Total Outbound: " & totalOutbound.ToString()
                End Using

                ' Get total unique teams
                Using cmdTeam As New MySqlCommand(totalTeamQuery, conn)
                    Dim totalTeams As Integer = Convert.ToInt32(cmdTeam.ExecuteScalar())
                    btnTotalTeam.Text = "Total Teams: " & totalTeams.ToString()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading outbound counts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim()

        ' Ensure user enters a search term
        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("Please enter a search term.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LoadOutTransactData() ' Reload data if no search term entered
            Return
        End If

        ' Determine which checkbox is checked
        Dim columnName As String = ""
        If chkTransactionID.Checked Then
            columnName = "transaction_id"
        ElseIf chkEmployeeID.Checked Then
            columnName = "employee_id"
        ElseIf chkProductName.Checked Then
            columnName = "product_name"
        Else
            MessageBox.Show("Please select a search category.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LoadOutTransactData() ' Reload data if no filter selected
            Return
        End If

        ' Call function to perform search
        SearchTransactions(columnName, searchText)
    End Sub
    Private Sub SearchTransactions(column As String, searchValue As String)
        Dim query As String = $"SELECT transaction_id, employee_id, team_leaderId, product_name FROM outtransact WHERE {column} LIKE @searchValue"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@searchValue", "%" & searchValue & "%")

                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dgvTransact.Columns.Clear() ' Clear existing columns
                        dgvTransact.Rows.Clear()    ' Clear existing rows

                        ' Re-add only the required columns
                        dgvTransact.Columns.Add("transaction_id", "Transaction ID")
                        dgvTransact.Columns.Add("employee_id", "Employee ID")
                        dgvTransact.Columns.Add("team_leaderId", "Team Leader ID")
                        dgvTransact.Columns.Add("product_name", "Product Name")

                        If reader.HasRows Then
                            While reader.Read()
                                dgvTransact.Rows.Add(
                                reader("transaction_id").ToString(),
                                reader("employee_id").ToString(),
                                reader("team_leaderId").ToString(),
                                reader("product_name").ToString()
                            )
                            End While
                        Else
                            MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtSearch.Clear()
                            LoadOutTransactData()
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error searching: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSearch.Clear()
                    LoadOutTransactData()
                End Try
            End Using
        End Using
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransactionID.CheckedChanged, chkEmployeeID.CheckedChanged, chkProductName.CheckedChanged
        Dim checkBox As Guna.UI2.WinForms.Guna2CustomCheckBox = CType(sender, Guna.UI2.WinForms.Guna2CustomCheckBox)

        If checkBox.Checked Then
            ' Uncheck the other checkboxes
            If checkBox Is chkTransactionID Then
                chkEmployeeID.Checked = False
                chkProductName.Checked = False
            ElseIf checkBox Is chkEmployeeID Then
                chkTransactionID.Checked = False
                chkProductName.Checked = False
            ElseIf checkBox Is chkProductName Then
                chkTransactionID.Checked = False
                chkEmployeeID.Checked = False
            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        LoadOutTransactData()
        LoadOutboundCounts()
    End Sub

End Class