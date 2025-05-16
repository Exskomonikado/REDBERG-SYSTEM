Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class CrystalReportData
    Dim con1 As MySqlConnection
    Dim cmd1 As MySqlCommand
    Dim adp1 As MySqlDataAdapter
    Dim dtb As New DataTable
    Dim myrpt As New CrystalReport1 ' Make sure your Crystal Report is named "CrystalReport1"
    Private teamLeaderId As String ' Class-level variabl
    Private teamNumber As String ' Add this


    Public Sub New(selectedId As String, selectedTeamNumber As String)
        InitializeComponent()
        teamLeaderId = selectedId
        teamNumber = selectedTeamNumber ' Store the passed team number
        viewdata() ' Fetch data when the form loads
    End Sub


    ' Function to retrieve data from the database
    Sub viewdata()
        Try
            con1 = New MySqlConnection("Server=192.168.1.1;Port=3306;Database=imsdb;Uid=remoteuser;Pwd=userpassword;")
            con1.Open()

            ' Updated query with team number filter and all requested columns
            Dim query As String = "SELECT o.id, o.transaction_id, o.date, o.employee_id, " &
                             "o.employee_name, o.team_leaderId, o.team_leaderName, " &
                             "o.team_number, o.product_id, p.product_name, o.type, " &
                             "o.price, o.quantity " &
                             "FROM outtransact o " &
                             "JOIN products p ON o.product_id = p.product_id " &
                             "WHERE o.team_number = @teamNumber"

            cmd1 = New MySqlCommand(query, con1)
            cmd1.Parameters.AddWithValue("@teamNumber", teamNumber) ' Bind team number parameter
            adp1 = New MySqlDataAdapter(cmd1)
            dtb.Clear() ' Clear old data before refilling
            adp1.Fill(dtb)

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con1.Close()
            con1.Dispose()
        End Try
    End Sub

    ' Load data into Crystal Report
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtb.Clear() ' Clear old data
        viewdata() ' Fetch new data

        ' Check if data exists before setting it to the report
        If dtb.Rows.Count > 0 Then
            myrpt.SetDataSource(dtb)
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = myrpt
        Else
            MessageBox.Show("No data found for the report.", "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Print Button Functionality
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If myrpt IsNot Nothing AndAlso dtb.Rows.Count > 0 Then
            myrpt.PrintToPrinter(1, False, 0, 0) ' 1 copy, no collate, all pages
        Else
            MessageBox.Show("Please generate the report first before printing.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        dtb.Clear()
        viewdata()
        If dtb.Rows.Count > 0 Then
            myrpt.Refresh()
            CrystalReportViewer1.RefreshReport()
        Else
            MessageBox.Show("No data available to refresh.", "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ' First check if there's data to export
        If myrpt Is Nothing OrElse dtb.Rows.Count = 0 Then
            MessageBox.Show("Please generate the report first before exporting.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ask for confirmation before saving
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to save this report? After saving, the current report data will be cleared.",
                                                   "Confirm Save",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Return
        End If

        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF Files|*.pdf|Excel Files|*.xls|Word Files|*.doc"
            saveFileDialog.Title = "Save Report"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog.FileName
                Select Case System.IO.Path.GetExtension(filePath).ToLower()
                    Case ".pdf"
                        myrpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, filePath)
                    Case ".xls"
                        myrpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, filePath)
                    Case ".doc"
                        myrpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, filePath)
                End Select

                ' Clear the report after successful save
                ClearReport()

                MessageBox.Show("Report exported successfully and cleared for new data!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting report: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' New method to clear the report
    Private Sub ClearReport()
        ' Clear the data table
        dtb.Clear()

        ' Clear the report source
        CrystalReportViewer1.ReportSource = Nothing

        ' Create a new report instance
        myrpt = New CrystalReport1()

        ' Optional: Refresh the viewer
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If myrpt IsNot Nothing AndAlso dtb.Rows.Count > 0 Then
            Try
                Dim printDialog As New PrintDialog()
                Dim printDoc As New System.Drawing.Printing.PrintDocument()

                printDialog.Document = printDoc

                ' Show print dialog to user
                If printDialog.ShowDialog() = DialogResult.OK Then
                    ' Set the selected printer
                    myrpt.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName

                    ' Print the report
                    myrpt.PrintToPrinter(printDialog.PrinterSettings.Copies, False, printDialog.PrinterSettings.FromPage, printDialog.PrinterSettings.ToPage)

                    MessageBox.Show("Report sent to printer successfully!", "Print Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error printing report: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please generate the report first before printing.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Close()
    End Sub
End Class