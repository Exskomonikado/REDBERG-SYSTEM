<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlLogin = New Guna.UI2.WinForms.Guna2Panel()
        Me.chkShowPassword = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlForgotPassword = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtReEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.ToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.pnlLogin.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForgotPassword.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_ACTIVATE
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'btnLogin
        '
        Me.btnLogin.BorderRadius = 5
        Me.btnLogin.BorderThickness = 1
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(29, 259)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(294, 45)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Sign In"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 30
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.Black
        Me.txtPassword.BorderRadius = 5
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(29, 173)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(294, 41)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextOffset = New System.Drawing.Point(10, 0)
        '
        'txtUsername
        '
        Me.txtUsername.BorderColor = System.Drawing.Color.Black
        Me.txtUsername.BorderRadius = 5
        Me.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(29, 125)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(294, 41)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "INVENTORY MANAGEMENT SYSTEM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 45)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "REDBERG CORP."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(318, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "______________________________________________________________"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(114, 423)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(166, 15)
        Me.Guna2HtmlLabel2.TabIndex = 35
        Me.Guna2HtmlLabel2.Text = "@ALL RIGHTS RESERVED 2025"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 5
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(248, 220)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(65, 19)
        Me.Guna2HtmlLabel1.TabIndex = 37
        Me.Guna2HtmlLabel1.Text = "Click Here"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Forgot Password? "
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.BorderThickness = 1
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(52, 352)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(294, 45)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "Close"
        '
        'pnlLogin
        '
        Me.pnlLogin.Controls.Add(Me.chkShowPassword)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.Label4)
        Me.pnlLogin.Controls.Add(Me.Label1)
        Me.pnlLogin.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnlLogin.Controls.Add(Me.Label2)
        Me.pnlLogin.Controls.Add(Me.txtUsername)
        Me.pnlLogin.Controls.Add(Me.Label5)
        Me.pnlLogin.Controls.Add(Me.Label3)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlLogin.Location = New System.Drawing.Point(23, 19)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(350, 330)
        Me.pnlLogin.TabIndex = 39
        '
        'chkShowPassword
        '
        Me.chkShowPassword.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkShowPassword.CheckedState.BorderRadius = 2
        Me.chkShowPassword.CheckedState.BorderThickness = 1
        Me.chkShowPassword.CheckedState.FillColor = System.Drawing.Color.Black
        Me.chkShowPassword.Location = New System.Drawing.Point(293, 184)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(20, 20)
        Me.chkShowPassword.TabIndex = 39
        Me.chkShowPassword.Text = "Guna2CustomCheckBox2"
        Me.chkShowPassword.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkShowPassword.UncheckedState.BorderRadius = 2
        Me.chkShowPassword.UncheckedState.BorderThickness = 1
        Me.chkShowPassword.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.REDBERG_SYSTEM.My.Resources.Resources.IconR
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(11, 18)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 33
        Me.Guna2PictureBox1.TabStop = False
        '
        'pnlForgotPassword
        '
        Me.pnlForgotPassword.Controls.Add(Me.Guna2PictureBox2)
        Me.pnlForgotPassword.Controls.Add(Me.txtReEmail)
        Me.pnlForgotPassword.Controls.Add(Me.Label6)
        Me.pnlForgotPassword.Controls.Add(Me.Label7)
        Me.pnlForgotPassword.Controls.Add(Me.Label8)
        Me.pnlForgotPassword.Controls.Add(Me.txtEmail)
        Me.pnlForgotPassword.Controls.Add(Me.Label9)
        Me.pnlForgotPassword.Controls.Add(Me.Label10)
        Me.pnlForgotPassword.Controls.Add(Me.btnSubmit)
        Me.pnlForgotPassword.Location = New System.Drawing.Point(417, 19)
        Me.pnlForgotPassword.Name = "pnlForgotPassword"
        Me.pnlForgotPassword.Size = New System.Drawing.Size(355, 330)
        Me.pnlForgotPassword.TabIndex = 40
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.REDBERG_SYSTEM.My.Resources.Resources.IconR
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(11, 18)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 39
        Me.Guna2PictureBox2.TabStop = False
        '
        'txtReEmail
        '
        Me.txtReEmail.BorderColor = System.Drawing.Color.Black
        Me.txtReEmail.BorderRadius = 5
        Me.txtReEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReEmail.DefaultText = ""
        Me.txtReEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtReEmail.ForeColor = System.Drawing.Color.Black
        Me.txtReEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReEmail.Location = New System.Drawing.Point(30, 184)
        Me.txtReEmail.Name = "txtReEmail"
        Me.txtReEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtReEmail.PlaceholderText = "Confirm email"
        Me.txtReEmail.SelectedText = ""
        Me.txtReEmail.Size = New System.Drawing.Size(294, 41)
        Me.txtReEmail.TabIndex = 5
        Me.txtReEmail.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Forgot Password? "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(275, 45)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "REDBERG CORP."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(81, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "INVENTORY MANAGEMENT SYSTEM"
        '
        'txtEmail
        '
        Me.txtEmail.BorderColor = System.Drawing.Color.Black
        Me.txtEmail.BorderRadius = 5
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(31, 136)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.PlaceholderText = "Enter email"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(294, 41)
        Me.txtEmail.TabIndex = 4
        Me.txtEmail.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(131, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 17)
        Me.Label9.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 307)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(318, 17)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "______________________________________________________________"
        '
        'btnSubmit
        '
        Me.btnSubmit.BorderRadius = 5
        Me.btnSubmit.BorderThickness = 1
        Me.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmit.FillColor = System.Drawing.Color.SeaGreen
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(29, 259)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(294, 45)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        '
        'ToolTip1
        '
        Me.ToolTip1.AllowLinksHandling = True
        Me.ToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(400, 450)
        Me.Controls.Add(Me.pnlForgotPassword)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOG IN "
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForgotPassword.ResumeLayout(False)
        Me.pnlForgotPassword.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlLogin As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlForgotPassword As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtReEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents chkShowPassword As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
