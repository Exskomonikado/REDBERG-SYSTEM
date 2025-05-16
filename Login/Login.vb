Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Net

Public Class Login
    Private Const MaxAttempts As Integer = 5
    Dim cmd As MySqlCommand

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
        pnlLogin.Visible = True
        pnlForgotPassword.Visible = False
        btnCancel.Text = "Close"
        Label6.Text = "Forgot Password?" ' Set the label text

        ToolTip1.SetToolTip(txtUsername, "Enter your username")
        ToolTip1.SetToolTip(txtPassword, "Enter your password")
        ToolTip1.SetToolTip(txtEmail, "Enter your email")
        ToolTip1.SetToolTip(txtReEmail, "Enter your email again")

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
        End If
    End Sub
    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtReEmail.Focus()
        End If
    End Sub
    Private Sub txtReEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSubmit.PerformClick()
        End If
    End Sub
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar ' Show password
        Else
            txtPassword.PasswordChar = "●"c ' Hide password using bullet
        End If
    End Sub


    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Retrieve UserID and other details
                Dim userID As Integer? = Nothing
                Dim empType As String = ""
                Dim fullName As String = ""

                Dim getUserIDQuery As String = "SELECT employee_id, type, first_name, surname FROM accounts WHERE username = @username"
                Using getUserIDCmd As New MySqlCommand(getUserIDQuery, connection)
                    getUserIDCmd.Parameters.AddWithValue("@username", username)
                    Using reader As MySqlDataReader = getUserIDCmd.ExecuteReader()
                        If reader.Read() Then
                            userID = Convert.ToInt32(reader("employee_id"))
                            empType = reader("type").ToString()
                            fullName = reader("first_name").ToString() & " " & reader("surname").ToString()
                        End If
                    End Using
                End Using

                If Not userID.HasValue Then
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Check lockout status
                Dim failedAttempts As Integer = 0
                Dim lockoutEndTime As DateTime? = Nothing
                Dim lockoutQuery As String = "SELECT FailedAttempts, LockoutEndTime FROM userlockout WHERE UserID = @UserID"
                Using lockoutCommand As New MySqlCommand(lockoutQuery, connection)
                    lockoutCommand.Parameters.AddWithValue("@UserID", userID)
                    Using reader As MySqlDataReader = lockoutCommand.ExecuteReader()
                        If reader.Read() Then
                            failedAttempts = reader.GetInt32("FailedAttempts")
                            If Not reader.IsDBNull(reader.GetOrdinal("LockoutEndTime")) Then
                                lockoutEndTime = reader.GetDateTime("LockoutEndTime")
                            End If
                        End If
                    End Using
                End Using

                If lockoutEndTime.HasValue AndAlso lockoutEndTime > DateTime.Now Then
                    MessageBox.Show("Your account is locked. Please try again later.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' Validate credentials
                Dim query As String = "SELECT * FROM accounts WHERE username = @username AND password = @password"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password) ' Consider hashing the password
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' Successful login
                            reader.Close() ' Close reader before updating failed attempts
                            ResetFailedAttempts(userID, connection)

                            InsertActivityLog(userID.Value, fullName, "USER LOGGED IN.")

                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Open Dashboard and pass data
                            Dim dashboard As New Dashboard(userID.Value, fullName) ' ✅ Pass the actual values
                            dashboard.EmployeeID = userID.ToString()
                            dashboard.EmployeeType = empType
                            dashboard.FullName = fullName
                            dashboard.Show()

                            txtUsername.Text = ""
                            txtPassword.Text = ""

                            Me.Hide()
                            Exit Sub
                        End If
                    End Using
                End Using

                ' Failed login
                IncrementFailedAttempts(userID, connection)
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Clear()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub IncrementFailedAttempts(userID As Integer, connection As MySqlConnection)
        Try
            Dim updateQuery As String = "INSERT INTO userlockout (UserID, FailedAttempts, LockoutEndTime) " &
                                        "VALUES (@UserID, 1, NULL) " &
                                        "ON DUPLICATE KEY UPDATE " &
                                        "FailedAttempts = FailedAttempts + 1, " &
                                        "LockoutEndTime = CASE WHEN FailedAttempts + 1 >= @MaxAttempts THEN NOW() + INTERVAL 10 MINUTE ELSE NULL END"

            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                command.Parameters.AddWithValue("@MaxAttempts", MaxAttempts)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating failed attempts: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ResetFailedAttempts(userID As Integer, connection As MySqlConnection)
        Try
            Dim resetQuery As String = "UPDATE userlockout SET FailedAttempts = 0, LockoutEndTime = NULL WHERE UserID = @UserID"
            Using command As New MySqlCommand(resetQuery, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error resetting failed attempts: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If btnCancel.Text = "Close" Then
            Me.Close()

        ElseIf btnCancel.Text = "Cancel" Then
            btnCancel.Text = "Close"
            pnlForgotPassword.Visible = False
            pnlLogin.Visible = True

        ElseIf btnCancel.Text = "Back" Then
            Me.Hide()

            txtEmail.Text = ""
            pnlLogin.Visible = True
            pnlForgotPassword.Visible = False
            btnCancel.Text = "Cancel"

        End If
    End Sub
    Private Sub Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Label6.Text = "Change Password" Then
            Code.btnCancel.Visible = False
        Else
            Code.btnCancel.Visible = True
        End If

        ' Check if the emails match before proceeding
        If txtEmail.Text <> txtReEmail.Text Then
            MessageBox.Show("Emails do not match. Please re-enter the email correctly.", "Mismatch Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub ' Stop execution if emails do not match
        End If

        Dim email As String = txtEmail.Text
        Dim verificationCode As String = GenerateVerificationCode()
        Dim userPassword As String = String.Empty

        Try
            conn.Open()
            Dim checkQuery As String = "SELECT COUNT(*) FROM accounts WHERE gmail=@email"
            Dim checkCmd As New MySqlCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("@email", email)

            Dim emailExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If emailExists > 0 Then
                Dim passwordQuery As String = "SELECT password FROM accounts WHERE gmail=@email"
                Dim passwordCmd As New MySqlCommand(passwordQuery, conn)
                passwordCmd.Parameters.AddWithValue("@email", email)
                userPassword = passwordCmd.ExecuteScalar().ToString()

                Dim updateQuery As String = "UPDATE accounts SET code=@code WHERE gmail=@email"
                Dim cmd As New MySqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@code", verificationCode)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.ExecuteNonQuery()

                If SendEmail(email, verificationCode, userPassword) Then
                    Dim verifyForm As New Code()
                    verifyForm.expectedCode = verificationCode ' Set the expected verification code
                    verifyForm.userEmail = email ' Pass the email to the code form
                    verifyForm.Show() ' Show the verification form
                    Me.Hide() ' Hide login form
                    txtEmail.Text = ""
                    txtReEmail.Text = ""
                End If
            Else
                MessageBox.Show("The email address does not exist in our records. Please check and try again.", "Email Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtEmail.Text = ""
                txtReEmail.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Function GenerateVerificationCode() As String
        Dim rand As New Random()
        Return rand.Next(100000, 999999).ToString()
    End Function
    Private Function SendEmail(recipient As String, code As String, password As String) As Boolean
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("shinichikudo14q@gmail.com", "Verification Service")
            mail.To.Add(recipient)
            mail.Subject = "Password Reset Code"

            ' HTML email body
            Dim emailBody As String = $"
        <!DOCTYPE html>
        <html lang='en'>
        <head>
            <meta charset='UTF-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
            <title>Password Reset Code</title>
            <style>
                body {{
                    font-family: Arial, sans-serif;
                    background-color: #f4f4f4;
                    margin: 0;
                    padding: 20px;
                }}
                .container {{
                    max-width: 600px;
                    margin: auto;
                    background: #000000;
                    padding: 20px;
                    border-radius: 8px;
                    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
                }}
                h1 {{
                    color: #ffffff;
                    text-align: center;
                    font-size: 24px;
                    font-weight: bold;
                    margin-bottom: 20px;
                }}
                p {{
                    color: #ffffff;
                    line-height: 1.6;
                    font-size: 16px;
                }}
                .code {{
                    background-color: #e3c8cd;
                    border-left: 6px solid #800000;
                    padding: 15px;
                    margin: 20px 0;
                    font-size: 18px;
                    font-weight: bold;
                    text-align: center;
                    border-radius: 4px;
                }}
                .footer {{
                    margin-top: 30px;
                    font-size: 14px;
                    color: #777;
                    text-align: right;
                }}
                .footer a {{
                    color: #2196F3;
                    text-decoration: none;
                }}
                .footer a:hover {{
                    text-decoration: underline;
                }}
            </style>
        </head>
        <body>
            <div class='container'>
                <h1>PASSWORD RESET REQUEST</h1>
                <p>Dear User,</p>
                <p>We received a request to reset your password. Please use the verification code below to proceed:</p>
                <div class='code'>
                    Your Verification Code: <span id='verification-code'>{code}</span><br>
                    Your Password: <span id='password'>{password}</span>
                </div>
                <p>If you did not request this code, please ignore this email.</p>
                <br>
                <div class='footer'>
                    <p>Thank you!</p>
                    <p>DCSA DEVELOPERS</p>
                </div>
            </div>
        </body>
        </html>"

            mail.IsBodyHtml = True ' Set to true to indicate that the body is HTML
            mail.Body = emailBody ' Set the email body to the HTML content

            ' Configure SMTP server
            Dim smtpServer As New SmtpClient("smtp-relay.brevo.com") With {
            .Port = 587, ' Try 465 if 587 does not work
            .EnableSsl = True, ' Use TLS for security
            .DeliveryMethod = SmtpDeliveryMethod.Network,
            .UseDefaultCredentials = False, ' Important for authentication
            .Credentials = New NetworkCredential("848c0c001@smtp-brevo.com", "xsmtpsib-129feb9d762609dd5efee7ab36aa78d1026df438628d90aaa90d5f89d572fbbb-wAdzN4rUOVhY32P5")
            }

            smtpServer.Send(mail)
            MessageBox.Show("Code sent successfully to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True

        Catch ex As SmtpException
            MessageBox.Show("SMTP Error: " & ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Catch ex As Exception
            MessageBox.Show("General Error sending email: " & ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click
        btnCancel.Text = "Cancel" ' Set the initial text for the button
        Label6.Text = "Forgot Password?" ' Set the label text

        If pnlLogin.Visible = True Then
            pnlLogin.Visible = False
            pnlForgotPassword.Visible = True
            btnCancel.Text = "Cancel"
            pnlForgotPassword.Location = New Point(23, 19)
        End If

        If btnCancel.Text = "Close" Then
            btnCancel.Text = "Cancel"
        End If
    End Sub


End Class
