<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Code
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlVerifyCode = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtReCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlChangePassword = New Guna.UI2.WinForms.Guna2Panel()
        Me.chkShowPassword2 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.chkShowPassword = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtNewPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOldPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnChangePassword = New Guna.UI2.WinForms.Guna2Button()
        Me.ToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.pnlVerifyCode.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlChangePassword.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_ACTIVATE
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 5
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlVerifyCode
        '
        Me.pnlVerifyCode.Controls.Add(Me.Guna2PictureBox2)
        Me.pnlVerifyCode.Controls.Add(Me.txtReCode)
        Me.pnlVerifyCode.Controls.Add(Me.Label6)
        Me.pnlVerifyCode.Controls.Add(Me.Label7)
        Me.pnlVerifyCode.Controls.Add(Me.Label8)
        Me.pnlVerifyCode.Controls.Add(Me.txtCode)
        Me.pnlVerifyCode.Controls.Add(Me.Label10)
        Me.pnlVerifyCode.Controls.Add(Me.btnSubmit)
        Me.pnlVerifyCode.Location = New System.Drawing.Point(23, 19)
        Me.pnlVerifyCode.Name = "pnlVerifyCode"
        Me.pnlVerifyCode.Size = New System.Drawing.Size(350, 330)
        Me.pnlVerifyCode.TabIndex = 0
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.REDBERG_SYSTEM.My.Resources.Resources.IconR
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(11, 18)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 47
        Me.Guna2PictureBox2.TabStop = False
        '
        'txtReCode
        '
        Me.txtReCode.BorderColor = System.Drawing.Color.Black
        Me.txtReCode.BorderRadius = 5
        Me.txtReCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReCode.DefaultText = ""
        Me.txtReCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReCode.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtReCode.ForeColor = System.Drawing.Color.Black
        Me.txtReCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReCode.Location = New System.Drawing.Point(31, 183)
        Me.txtReCode.Name = "txtReCode"
        Me.txtReCode.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtReCode.PlaceholderText = "Confirm code"
        Me.txtReCode.SelectedText = ""
        Me.txtReCode.Size = New System.Drawing.Size(294, 41)
        Me.txtReCode.TabIndex = 42
        Me.txtReCode.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 17)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Enter the code we've given:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(275, 45)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "REDBERG CORP."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(77, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "INVENTORY MANAGEMENT SYSTEM"
        '
        'txtCode
        '
        Me.txtCode.BorderColor = System.Drawing.Color.Black
        Me.txtCode.BorderRadius = 5
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCode.DefaultText = ""
        Me.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCode.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtCode.ForeColor = System.Drawing.Color.Black
        Me.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(31, 136)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCode.PlaceholderText = "Enter code"
        Me.txtCode.SelectedText = ""
        Me.txtCode.Size = New System.Drawing.Size(294, 41)
        Me.txtCode.TabIndex = 41
        Me.txtCode.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 307)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(318, 17)
        Me.Label10.TabIndex = 45
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
        Me.btnSubmit.TabIndex = 43
        Me.btnSubmit.Text = "Submit"
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
        Me.btnCancel.Location = New System.Drawing.Point(51, 352)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(294, 45)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Close"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(114, 423)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(166, 15)
        Me.Guna2HtmlLabel2.TabIndex = 38
        Me.Guna2HtmlLabel2.Text = "@ALL RIGHTS RESERVED 2025"
        '
        'pnlChangePassword
        '
        Me.pnlChangePassword.Controls.Add(Me.chkShowPassword2)
        Me.pnlChangePassword.Controls.Add(Me.chkShowPassword)
        Me.pnlChangePassword.Controls.Add(Me.Guna2PictureBox1)
        Me.pnlChangePassword.Controls.Add(Me.txtNewPassword)
        Me.pnlChangePassword.Controls.Add(Me.Label1)
        Me.pnlChangePassword.Controls.Add(Me.Label2)
        Me.pnlChangePassword.Controls.Add(Me.Label3)
        Me.pnlChangePassword.Controls.Add(Me.txtOldPassword)
        Me.pnlChangePassword.Controls.Add(Me.Label4)
        Me.pnlChangePassword.Controls.Add(Me.btnChangePassword)
        Me.pnlChangePassword.Location = New System.Drawing.Point(395, 19)
        Me.pnlChangePassword.Name = "pnlChangePassword"
        Me.pnlChangePassword.Size = New System.Drawing.Size(350, 330)
        Me.pnlChangePassword.TabIndex = 39
        '
        'chkShowPassword2
        '
        Me.chkShowPassword2.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkShowPassword2.CheckedState.BorderRadius = 2
        Me.chkShowPassword2.CheckedState.BorderThickness = 1
        Me.chkShowPassword2.CheckedState.FillColor = System.Drawing.Color.Black
        Me.chkShowPassword2.Location = New System.Drawing.Point(293, 194)
        Me.chkShowPassword2.Name = "chkShowPassword2"
        Me.chkShowPassword2.Size = New System.Drawing.Size(20, 20)
        Me.chkShowPassword2.TabIndex = 50
        Me.chkShowPassword2.Text = "Guna2CustomCheckBox2"
        Me.chkShowPassword2.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkShowPassword2.UncheckedState.BorderRadius = 2
        Me.chkShowPassword2.UncheckedState.BorderThickness = 1
        Me.chkShowPassword2.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'chkShowPassword
        '
        Me.chkShowPassword.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkShowPassword.CheckedState.BorderRadius = 2
        Me.chkShowPassword.CheckedState.BorderThickness = 1
        Me.chkShowPassword.CheckedState.FillColor = System.Drawing.Color.Black
        Me.chkShowPassword.Location = New System.Drawing.Point(293, 146)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(20, 20)
        Me.chkShowPassword.TabIndex = 49
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
        Me.Guna2PictureBox1.TabIndex = 48
        Me.Guna2PictureBox1.TabStop = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BorderColor = System.Drawing.Color.Black
        Me.txtNewPassword.BorderRadius = 5
        Me.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPassword.DefaultText = ""
        Me.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Black
        Me.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(31, 183)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNewPassword.PlaceholderText = "New password"
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.Size = New System.Drawing.Size(294, 41)
        Me.txtNewPassword.TabIndex = 42
        Me.txtNewPassword.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 17)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Enter the old and new passwords:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 45)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "REDBERG CORP."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "INVENTORY MANAGEMENT SYSTEM"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.BorderColor = System.Drawing.Color.Black
        Me.txtOldPassword.BorderRadius = 5
        Me.txtOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOldPassword.DefaultText = ""
        Me.txtOldPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOldPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOldPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOldPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOldPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOldPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtOldPassword.ForeColor = System.Drawing.Color.Black
        Me.txtOldPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOldPassword.Location = New System.Drawing.Point(31, 136)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtOldPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOldPassword.PlaceholderText = "Old password"
        Me.txtOldPassword.SelectedText = ""
        Me.txtOldPassword.Size = New System.Drawing.Size(294, 41)
        Me.txtOldPassword.TabIndex = 41
        Me.txtOldPassword.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(318, 17)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "______________________________________________________________"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BorderRadius = 5
        Me.btnChangePassword.BorderThickness = 1
        Me.btnChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnChangePassword.FillColor = System.Drawing.Color.SeaGreen
        Me.btnChangePassword.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnChangePassword.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Location = New System.Drawing.Point(29, 259)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(294, 45)
        Me.btnChangePassword.TabIndex = 43
        Me.btnChangePassword.Text = "Submit"
        '
        'ToolTip1
        '
        Me.ToolTip1.AllowLinksHandling = True
        Me.ToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'Code
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(819, 450)
        Me.Controls.Add(Me.pnlChangePassword)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pnlVerifyCode)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Code"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code"
        Me.pnlVerifyCode.ResumeLayout(False)
        Me.pnlVerifyCode.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlChangePassword.ResumeLayout(False)
        Me.pnlChangePassword.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlVerifyCode As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtReCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlChangePassword As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtNewPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOldPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnChangePassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
    Friend WithEvents chkShowPassword2 As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents chkShowPassword As Guna.UI2.WinForms.Guna2CustomCheckBox
End Class
