Imports MySql.Data.MySqlClient

Public Class DashboardActivity

    Public Property CurrentUserFullName As String
    Public Property CurrentUserType As String ' Admin or Staff

    Private Sub DashboardActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show or hide the panel based on the user type
        If CurrentUserType = "ADMIN" Then
            pnlFilterAdmin.Visible = True
            PopulateStaffComboBox() ' Populate cmbStaff with staff and admin
        Else
            pnlFilterAdmin.Visible = False
        End If

        ' Load activity log for today (current date) when the form loads
        LoadActivityLog(DateTime.Now)
    End Sub

    Private Sub LoadActivityLog(selectedDate As Date?, Optional selectedStaff As String = "")
        Try
            Dim dt As New DataTable()
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Base query logic: If staff, filter by their user_name, if admin, allow filtering by staff
                Dim query As String = "SELECT activity AS 'Activity', timestamp AS 'Timestamp' FROM activity_log WHERE 1=1"

                ' If staff is logged in, always filter by their user_name
                If CurrentUserType = "STAFF" Then
                    query &= " AND user_name = @userName"
                End If

                ' If a date is provided, filter by that date
                If selectedDate.HasValue Then
                    query &= " AND DATE(timestamp) = @selectedDate"
                End If

                ' If a specific staff member is selected by the admin, filter by that staff's name
                If CurrentUserType = "ADMIN" AndAlso Not String.IsNullOrEmpty(selectedStaff) Then
                    query &= " AND user_name = @staffName"
                End If

                query &= " ORDER BY timestamp DESC"

                Using cmd As New MySqlCommand(query, conn)
                    ' Always filter by the currently logged-in user for staff
                    cmd.Parameters.AddWithValue("@userName", CurrentUserFullName)

                    ' Add the date parameter if selected
                    If selectedDate.HasValue Then
                        cmd.Parameters.AddWithValue("@selectedDate", selectedDate.Value.ToString("yyyy-MM-dd"))
                    End If

                    ' If an admin is filtering by a staff member, add the staff name parameter
                    If CurrentUserType = "ADMIN" AndAlso Not String.IsNullOrEmpty(selectedStaff) Then
                        cmd.Parameters.AddWithValue("@staffName", selectedStaff)
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            ' Display the data in the DataGridView
            If dt.Rows.Count > 0 Then
                dgvActivity.DataSource = dt

                ' FORMAT HEADERS
                For Each col As DataGridViewColumn In dgvActivity.Columns
                    col.HeaderText = col.HeaderText.ToUpper().Replace("_", " ")
                Next

                dgvActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                btnTotalActivity.Text = "TOTAL LOGS: " & dt.Rows.Count.ToString()
            Else
                dgvActivity.DataSource = Nothing
                btnTotalActivity.Text = "TOTAL LOGS: 0"
                MessageBox.Show("NO ACTIVITY FOUND FOR SELECTED DATE.", "NO LOGS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading activity log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If CurrentUserType = "ADMIN" Then
            ' Admin can use dtpDate2 to filter
            ' Check if a staff member is selected and a date is selected
            If cmbStaff.SelectedItem IsNot Nothing AndAlso dtpDate2.Value <> Nothing Then
                ' Load the activity log for the selected staff member on the selected date
                LoadActivityLog(dtpDate2.Value, cmbStaff.SelectedItem.ToString())
            Else
                ' If no staff member or date is selected, show a prompt
                MessageBox.Show("Please select both a staff member and a date to filter the activity logs.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            ' Staff can use dtpDate to filter
            If dtpDate.Value <> Nothing Then
                LoadActivityLog(dtpDate.Value)
            Else
                MessageBox.Show("Please select a date to filter your activity logs.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub PopulateStaffComboBox()
        ' Populate cmbStaff with staff members
        Try
            ' Clear the existing items in the combo box to avoid duplicates
            cmbStaff.Items.Clear()

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                ' Query to get the full names of users with type = 'STAFF'
                Dim query As String = "SELECT CONCAT(first_name, ' ', surname) AS full_name FROM accounts"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Loop through the result set and add the full names to the combo box
                        While reader.Read()
                            Dim fullName As String = reader("full_name").ToString()
                            If Not String.IsNullOrEmpty(fullName) Then
                                cmbStaff.Items.Add(fullName)
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error populating staff combo box: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadActivityLog(DateTime.Now)
    End Sub

    Private Sub dgvActivity_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActivity.CellContentClick

    End Sub
End Class
