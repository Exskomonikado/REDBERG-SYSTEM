Imports MySql.Data.MySqlClient

Public Class ManageAddReport
    Private employeeId As Integer
    Private employeeName As String

    Public Sub New(empId As Integer, empName As String)
        InitializeComponent() ' This call is required by the designer.
        employeeId = empId
        employeeName = empName
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim empId As Integer = employeeId ' Use class-level variable
        Dim empName As String = employeeName
        Dim reportId As String = GenerateReportId()

        If reportId Is Nothing Then Exit Sub ' Prevent inserting invalid data

        Dim dateValue As Date = dtpDate.Value
        Dim subject As String = txtSubject.Text.Trim()
        Dim description As String = txtDescription.Text.Trim()

        ' Validate date
        If dateValue > DateTime.Today Then
            MessageBox.Show("The date cannot be greater than today's date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate input fields
        If String.IsNullOrWhiteSpace(subject) OrElse String.IsNullOrWhiteSpace(description) Then
            MessageBox.Show("Please fill in all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insert Report
        If InsertReport(reportId, empId.ToString(), empName, dateValue, subject, description) Then
            InsertActivityLog(employeeId, employeeName, $"SUBMITTED A REPORT: {reportId}")

            MessageBox.Show("Report inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
        Else
            MessageBox.Show("Failed to insert report. Please check the input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function GenerateReportId() As String
        Dim reportId As String
        Dim random As New Random()
        Dim isUnique As Boolean = False

        Do
            reportId = random.Next(100000, 999999).ToString() ' Generate a random 6-digit number
            isUnique = CheckReportIdUnique(reportId) ' Check if the report ID is unique
        Loop While Not isUnique

        Return reportId
    End Function

    Private Function CheckReportIdUnique(reportId As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM reports WHERE reports_id = @reportsId"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@reportsId", reportId)

                Try
                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count = 0 ' Return true if the report ID is unique
                Catch ex As Exception
                    MessageBox.Show("Error checking report ID uniqueness: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Function GetEmployeeName(employeeId As String) As String
        Dim employeeName As String = String.Empty
        Dim query As String = "SELECT CONCAT(first_name, ' ', surname) AS full_name FROM accounts WHERE employee_id = @employeeId" ' Combine first_name and surname

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@employeeId", employeeId)

                Try
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        employeeName = result.ToString()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving employee name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        Return employeeName
    End Function

    Private Function InsertReport(reportId As String, employeeId As String, employeeName As String, dateValue As Date, subject As String, description As String) As Boolean
        Dim queryInsert As String = "INSERT INTO reports (reports_id, employee_id, employee_name, date, subject, status, description) VALUES (@reportsId, @employeeId, @employeeName, @date, @subject, @status, @description)"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(queryInsert, conn)
                cmd.Parameters.AddWithValue("@reportsId", reportId)
                cmd.Parameters.AddWithValue("@employeeId", employeeId)
                cmd.Parameters.AddWithValue("@employeeName", employeeName)
                cmd.Parameters.AddWithValue("@date", dateValue)
                cmd.Parameters.AddWithValue("@subject", subject)
                cmd.Parameters.AddWithValue("@status", "UNREAD") ' Set status to UNREAD
                cmd.Parameters.AddWithValue("@description", description)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    MessageBox.Show("Error inserting report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function
    Private Sub Clear()
        txtSubject.Clear()
        txtDescription.Clear()
        dtpDate.Value = DateTime.Now
    End Sub

    Private Sub ManageAddReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(txtSubject, "Enter the product's subject or title.")
        ToolTip1.SetToolTip(txtDescription, "Enter a brief description of the product.")
        ToolTip1.SetToolTip(dtpDate, "Select the product's expiry or relevant date.")
    End Sub
End Class