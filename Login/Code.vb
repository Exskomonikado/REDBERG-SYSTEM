Imports MySql.Data.MySqlClient
Public Class Code
    Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=imsdb")
    Dim cmd As MySqlCommand
    Public expectedCode As String
    Public userEmail As String

    Private Sub Code_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlChangePassword.Visible = False
        pnlVerifyCode.Visible = True

        If Login.Label6.Text = "Change Password" Then
            btnCancel.Visible = False
        Else
            btnCancel.Visible = True
        End If

        ToolTip1.SetToolTip(txtCode, "Enter the code")
        ToolTip1.SetToolTip(txtReCode, "Enter the code again")
        ToolTip1.SetToolTip(txtOldPassword, "Enter your old password")
        ToolTip1.SetToolTip(txtNewPassword, "Enter your new password")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Login.Show()
        Me.Close()
        Clear()

        Login.pnlLogin.Visible = True
        Login.pnlForgotPassword.Visible = False

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Check if the codes match before proceeding
        If txtCode.Text <> txtReCode.Text Then
            MessageBox.Show("Verification codes do not match. Please re-enter the code correctly.", "Mismatch Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub ' Stop execution if codes do not match
        End If

        ' Check if the entered code matches the expected verification code
        If txtCode.Text = expectedCode Then
            MessageBox.Show("Verification successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If pnlVerifyCode.Visible = True Then
                pnlVerifyCode.Visible = False
                pnlChangePassword.Visible = True
                pnlChangePassword.Location = New Point(23, 19)
            End If
        Else
            MessageBox.Show("Incorrect verification code. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Clear()
        End If
    End Sub
    Private Sub Clear()
        txtCode.Text = ""
        txtReCode.Text = ""
        Login.txtUsername.Text = ""
        Login.txtPassword.Text = ""
    End Sub
    Private Sub Clear1()
        txtOldPassword.Text = ""
        txtNewPassword.Text = ""
        Login.txtUsername.Text = ""
        Login.txtPassword.Text = ""
    End Sub
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtOldPassword.PasswordChar = ControlChars.NullChar ' Show password
        Else
            txtOldPassword.PasswordChar = "●"c ' Hide password using bullet
        End If
    End Sub


    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim oldPassword As String = txtOldPassword.Text
        Dim newPassword As String = txtNewPassword.Text

        If String.IsNullOrWhiteSpace(oldPassword) Or String.IsNullOrWhiteSpace(newPassword) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If oldPassword = newPassword Then
            MessageBox.Show("New password must be different from the old password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conn.Open()
            Dim checkQuery As String = "SELECT COUNT(*) FROM accounts WHERE gmail=@email AND password=@oldPassword"
            cmd = New MySqlCommand(checkQuery, conn)
            cmd.Parameters.AddWithValue("@email", userEmail)
            cmd.Parameters.AddWithValue("@oldPassword", oldPassword)

            Dim passwordMatch As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If passwordMatch > 0 Then

                Dim updateQuery As String = "UPDATE accounts SET password=@newPassword WHERE gmail=@email"
                cmd = New MySqlCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@newPassword", newPassword)
                cmd.Parameters.AddWithValue("@email", userEmail)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If Login.Label6.Text = "Change Password" Then
                    Application.Restart()

                Else
                    Me.Close()

                    Login.Show()
                    Login.btnCancel.Text = "Cancel"

                    Login.pnlLogin.Visible = True
                    Login.pnlForgotPassword.Visible = False
                    Clear1()

                End If


            Else
                MessageBox.Show("Old password is incorrect. Please try again.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Clear1()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtReCode.Focus()
        End If
    End Sub
    Private Sub txtReCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSubmit.PerformClick()
        End If
    End Sub
    Private Sub txtOldPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOldPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNewPassword.Focus()
        End If
    End Sub
    Private Sub txtNewPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNewPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnChangePassword.PerformClick()
        End If
    End Sub

    Private Sub chkShowPassword2_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword2.CheckedChanged
        If chkShowPassword.Checked Then
            txtNewPassword.PasswordChar = ControlChars.NullChar ' Show password
        Else
            txtNewPassword.PasswordChar = "●"c ' Hide password using bullet
        End If
    End Sub
End Class