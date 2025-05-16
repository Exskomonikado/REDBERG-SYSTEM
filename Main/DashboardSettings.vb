Imports MySql.Data.MySqlClient
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v3
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports System.IO
Imports System.Diagnostics
Imports System.Threading
Imports System.Timers

Public Class DashboardSettings

    Dim backupFolder As String = "C:\xampp\mysql\backup\folderdb"
    Dim backupFile As String = Path.Combine(backupFolder, "imsdb.sql")
    Dim credentialPath As String = "C:\gdrive\client_secret.json"
    Dim autoBackupEnabled As Boolean = False
    Dim backupInterval As Double = 60000 ' Default: 1 Minute (60000 ms)
    Dim backupTime As String = ""
    Dim backupTimer As New System.Windows.Forms.Timer()

    Private Sub CreateBackupFolder()
        If Not Directory.Exists(backupFolder) Then
            Directory.CreateDirectory(backupFolder)
        End If
    End Sub

    Private Sub btnBackUp_Click(sender As Object, e As EventArgs) Handles btnBackUp.Click
        CreateBackupFolder()

        Dim dbUser As String = "root"
        Dim dbPassword As String = ""
        Dim dbName As String = "imsdb"
        Dim mysqlDumpPath As String = "C:\xampp\mysql\bin\mysqldump.exe"

        Try
            Dim process As New Process()
            process.StartInfo.FileName = mysqlDumpPath
            process.StartInfo.Arguments = "--user=" & dbUser & " --password=" & dbPassword & " --databases " & dbName & " -r """ & backupFile & """"
            process.StartInfo.UseShellExecute = False
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()

            MessageBox.Show("Database backup saved to: " & backupFile, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Backup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Dim dbUser As String = "root"
        Dim dbPassword As String = ""
        Dim dbName As String = "imsdb"
        Dim mysqlPath As String = "C:\xampp\mysql\bin\mysql.exe"

        If Not File.Exists(backupFile) Then
            MessageBox.Show("Backup file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim process As New Process()
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = "/c """ & mysqlPath & " --user=" & dbUser & " --password=" & dbPassword & " " & dbName & " < """ & backupFile & """"
            process.StartInfo.UseShellExecute = False
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.WaitForExit()

            MessageBox.Show("Database restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Restore Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Try
            UploadFileToGoogleDrive(backupFile)
        Catch ex As Exception
            MessageBox.Show("Error uploading to Google Drive: " & ex.Message, "Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Check if auto-backup is enabled (assuming you have a checkbox named chkAutoBackup)
        ' If you don't have this checkbox, you can remove this check
        ' autoBackupEnabled = chkAutoBackup.Checked

        ' For now, we'll assume auto-backup is always enabled when Save is clicked
        autoBackupEnabled = True

        ' Get the selected time from your combobox (assuming it's named cmbTime)
        If cmbTime.SelectedItem IsNot Nothing Then
            backupTime = cmbTime.SelectedItem.ToString()

            ' Start a background thread to monitor the backup time
            Dim backupThread As New Threading.Thread(AddressOf MonitorBackupTime)
            backupThread.IsBackground = True
            backupThread.Start()

            MessageBox.Show("Auto-backup set at " & backupTime, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please select a backup time first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UploadFileToGoogleDrive(filePath As String)
        If Not File.Exists(filePath) Then
            MessageBox.Show("Backup file not found at: " & filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim credential As UserCredential
        Try
            Using stream = New FileStream(credentialPath, FileMode.Open, FileAccess.Read)
                Dim credPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), ".credentials\drive-dotnet.json")
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    {DriveService.Scope.DriveFile},
                    "user",
                    CancellationToken.None,
                    New FileDataStore(credPath, True)).Result
            End Using

            Dim service = New DriveService(New BaseClientService.Initializer() With {
                .HttpClientInitializer = credential,
                .ApplicationName = "MyDatabaseBackupApp"
            })

            Dim folderId As String = "1tOMvxYVQVWPZqmGDObCYmbY3Z1idshb_"
            Dim fileMetadata = New Google.Apis.Drive.v3.Data.File() With {
                .Name = Path.GetFileName(filePath),
                .MimeType = "application/octet-stream",
                .Parents = New List(Of String) From {folderId}
            }

            Using stream = New FileStream(filePath, FileMode.Open)
                Dim request = service.Files.Create(fileMetadata, stream, "application/octet-stream")
                request.Fields = "id"
                Dim uploadResult = request.Upload()

                If uploadResult.Status = Google.Apis.Upload.UploadStatus.Failed Then
                    MessageBox.Show("File upload failed. Error: " & uploadResult.Exception.Message, "Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim uploadedFileId As String = request.ResponseBody.Id
                MessageBox.Show("Database backup uploaded to Google Drive successfully!", "Upload Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                SaveBackupHistory(Path.GetFileName(filePath), New FileInfo(filePath).Length / 1024, uploadedFileId)
            End Using

            LoadBackupHistory()

        Catch ex As Exception
            MessageBox.Show("An error occurred during upload: " & ex.Message, "Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveBackupHistory(fileName As String, fileSize As Integer, gdriveFileId As String)


        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim query As String = "INSERT INTO backup_history (filename, upload_date, file_size_kb, gdrive_file_id) VALUES (@filename, @upload_date, @filesize, @gdriveid)"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@filename", fileName)
                cmd.Parameters.AddWithValue("@upload_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.Parameters.AddWithValue("@filesize", fileSize)
                cmd.Parameters.AddWithValue("@gdriveid", gdriveFileId)

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub GetGoogleDriveStorage()
        Try
            Dim credential As UserCredential
            Using stream = New FileStream(credentialPath, FileMode.Open, FileAccess.Read)
                Dim credPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), ".credentials\drive-dotnet.json")
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    {DriveService.Scope.DriveMetadataReadonly},
                    "user",
                    CancellationToken.None,
                    New FileDataStore(credPath, True)
                ).Result
            End Using

            Dim service = New DriveService(New BaseClientService.Initializer() With {
                .HttpClientInitializer = credential,
                .ApplicationName = "MyDatabaseBackupApp"
            })

            Dim aboutRequest = service.About.Get()
            aboutRequest.Fields = "storageQuota"
            Dim about = aboutRequest.Execute()

            Dim totalStorage As Long = about.StorageQuota.Limit
            Dim usedStorage As Long = about.StorageQuota.Usage
            Dim freeStorage As Long = totalStorage - usedStorage

            Dim usedPercentage As Integer = CInt((usedStorage / totalStorage) * 100)

            ' Update your storage label (assuming it's named lblStorage)
            ' lblStorage.Text = $"Used: {Math.Round(usedStorage / (1024.0 * 1024 * 1024), 2)} GB / {Math.Round(totalStorage / (1024.0 * 1024 * 1024), 2)} GB"
        Catch ex As Exception
            MessageBox.Show("Error retrieving Google Drive storage info: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadBackupHistory()


        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            Dim query As String = "SELECT filename, upload_date, file_size_kb, gdrive_file_id FROM backup_history ORDER BY upload_date DESC"

            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()

            adapter.Fill(table)

            dgvSettings.DataSource = table

            For Each column As DataGridViewColumn In dgvSettings.Columns
                column.HeaderText = column.HeaderText.ToUpper()
                column.HeaderCell.Style.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular)
            Next
        End Using
    End Sub

    Private Sub PerformAutoBackup(sender As Object, e As EventArgs)
        If autoBackupEnabled Then
            If Me.InvokeRequired Then
                Me.Invoke(Sub()
                              btnBackUp.PerformClick()
                              btnUpload.PerformClick()
                          End Sub)
            Else
                btnBackUp.PerformClick()
                btnUpload.PerformClick()
            End If
        End If
    End Sub

    Private Sub MonitorBackupTime()
        While autoBackupEnabled
            Dim currentTime As String = DateTime.Now.ToString("h tt")
            If currentTime = backupTime Then
                PerformAutoBackup(Nothing, Nothing)
                Threading.Thread.Sleep(60000)
            End If
            Threading.Thread.Sleep(5000)
        End While
    End Sub

    Private Sub DashboardSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize time selection
        For i As Integer = 1 To 12
            cmbTime.Items.Add(i.ToString("00") & " AM")
            cmbTime.Items.Add(i.ToString("00") & " PM")
        Next

        ' Initialize toggle options
        cmbToggle.Items.Add("On")
        cmbToggle.Items.Add("Off")
        cmbToggle.SelectedIndex = 1 ' Default to "Off"

        LoadBackupHistory()
        GetGoogleDriveStorage()
    End Sub

    Private Sub cmbToggle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbToggle.SelectedIndexChanged
        ' Assuming cmbToggle has items "On" and "Off"
        If cmbToggle.SelectedItem IsNot Nothing Then
            If cmbToggle.SelectedItem.ToString() = "Off" Then
                ' Disable auto-backup and the time selection
                autoBackupEnabled = False
                cmbTime.Enabled = False
                btnSave.Enabled = False

                ' Stop any existing backup timer
                If backupTimer IsNot Nothing Then
                    backupTimer.Stop()
                End If
            Else
                ' Enable auto-backup settings
                cmbTime.Enabled = True
                btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmbTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTime.SelectedIndexChanged
        ' You can add any additional time selection change logic here if needed
    End Sub
End Class