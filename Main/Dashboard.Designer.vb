<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlSidebar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnActivity = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAccounts = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTeamList = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTransactions = New Guna.UI2.WinForms.Guna2Button()
        Me.btnManage = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlTopbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnChangePassword = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSubTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlforms = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlSidebar.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.pnlTopbar.SuspendLayout()
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
        'pnlSidebar
        '
        Me.pnlSidebar.BorderColor = System.Drawing.Color.Black
        Me.pnlSidebar.BorderRadius = 5
        Me.pnlSidebar.BorderThickness = 1
        Me.pnlSidebar.Controls.Add(Me.btnActivity)
        Me.pnlSidebar.Controls.Add(Me.btnSettings)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.Guna2Panel4)
        Me.pnlSidebar.Controls.Add(Me.btnAccounts)
        Me.pnlSidebar.Controls.Add(Me.btnReports)
        Me.pnlSidebar.Controls.Add(Me.btnTeamList)
        Me.pnlSidebar.Controls.Add(Me.btnTransactions)
        Me.pnlSidebar.Controls.Add(Me.btnManage)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.Guna2Panel2)
        Me.pnlSidebar.Controls.Add(Me.Guna2Panel1)
        Me.pnlSidebar.CustomizableEdges.BottomRight = False
        Me.pnlSidebar.CustomizableEdges.TopRight = False
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(200, 600)
        Me.pnlSidebar.TabIndex = 3
        '
        'btnActivity
        '
        Me.btnActivity.BorderThickness = 1
        Me.btnActivity.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnActivity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnActivity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnActivity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnActivity.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActivity.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnActivity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnActivity.ForeColor = System.Drawing.Color.Black
        Me.btnActivity.Image = Global.REDBERG_SYSTEM.My.Resources.Resources.activity
        Me.btnActivity.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnActivity.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnActivity.Location = New System.Drawing.Point(0, 408)
        Me.btnActivity.Name = "btnActivity"
        Me.btnActivity.Size = New System.Drawing.Size(200, 45)
        Me.btnActivity.TabIndex = 12
        Me.btnActivity.Text = "Data Log"
        Me.btnActivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnActivity.TextOffset = New System.Drawing.Point(30, 0)
        '
        'btnSettings
        '
        Me.btnSettings.BorderThickness = 1
        Me.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSettings.FillColor = System.Drawing.Color.Transparent
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSettings.ForeColor = System.Drawing.Color.Black
        Me.btnSettings.Image = Global.REDBERG_SYSTEM.My.Resources.Resources.logoSettings
        Me.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSettings.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnSettings.Location = New System.Drawing.Point(0, 500)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(200, 45)
        Me.btnSettings.TabIndex = 11
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSettings.TextOffset = New System.Drawing.Point(30, 0)
        '
        'btnLogout
        '
        Me.btnLogout.BorderThickness = 1
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Image = Global.REDBERG_SYSTEM.My.Resources.Resources.logoExit
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnLogout.Location = New System.Drawing.Point(0, 545)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 45)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.TextOffset = New System.Drawing.Point(30, 0)
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel4.BorderRadius = 5
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.CustomizableEdges.BottomRight = False
        Me.Guna2Panel4.CustomizableEdges.TopLeft = False
        Me.Guna2Panel4.CustomizableEdges.TopRight = False
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 590)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(200, 10)
        Me.Guna2Panel4.TabIndex = 10
        '
        'btnAccounts
        '
        Me.btnAccounts.BorderThickness = 1
        Me.btnAccounts.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAccounts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAccounts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAccounts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAccounts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccounts.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnAccounts.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAccounts.ForeColor = System.Drawing.Color.Black
        Me.btnAccounts.Image = Global.REDBERG_SYSTEM.My.Resources.Resources.logoAccounts
        Me.btnAccounts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAccounts.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnAccounts.Location = New System.Drawing.Point(0, 363)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(200, 45)
        Me.btnAccounts.TabIndex = 8
        Me.btnAccounts.Text = "Accounts"
        Me.btnAccounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAccounts.TextOffset = New System.Drawing.Point(30, 0)
        '
        'btnReports
        '
        Me.btnReports.BorderThickness = 1
        Me.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReports.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReports.ForeColor = System.Drawing.Color.Black
        Me.btnReports.Image = Global.REDBERG_SYSTEM.My.Resources.Resources.logoReports
        Me.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReports.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnReports.Location = New System.Drawing.Point(0, 318)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(200, 45)
        Me.btnReports.TabIndex = 7
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReports.TextOffset = New System.Drawing.Point(30, 0)
        '
        'btnTeamList
        '
        Me.btnTeamList.BorderThickness = 1
        Me.btnTeamList.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTeamList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTeamList.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTeamList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTeamList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTeamList.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnTeamList.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTeamList.ForeColor = System.Drawing.Color.Black
        Me.btnTeamList.Image = Global.REDBERG_SYSTEM.My.Resources.Resources.logoList
        Me.btnTeamList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTeamList.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnTeamList.Location = New System.Drawing.Point(0, 273)
        Me.btnTeamList.Name = "btnTeamList"
        Me.btnTeamList.Size = New System.Drawing.Size(200, 45)
        Me.btnTeamList.TabIndex = 6
        Me.btnTeamList.Text = "Team List"
        Me.btnTeamList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTeamList.TextOffset = New System.Drawing.Point(30, 0)
        '
        'btnTransactions
        '
        Me.btnTransactions.BorderThickness = 1
        Me.btnTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTransactions.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransactions.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnTransactions.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTransactions.ForeColor = System.Drawing.Color.Black
        Me.btnTransactions.Image = Global.REDBERG_SYSTEM.My.Resources.Resources.logoTransactions
        Me.btnTransactions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTransactions.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnTransactions.Location = New System.Drawing.Point(0, 228)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(200, 45)
        Me.btnTransactions.TabIndex = 5
        Me.btnTransactions.Text = "Transactions"
        Me.btnTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTransactions.TextOffset = New System.Drawing.Point(30, 0)
        '
        'btnManage
        '
        Me.btnManage.BorderThickness = 1
        Me.btnManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnManage.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManage.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnManage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnManage.ForeColor = System.Drawing.Color.Black
        Me.btnManage.Image = CType(resources.GetObject("btnManage.Image"), System.Drawing.Image)
        Me.btnManage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnManage.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnManage.Location = New System.Drawing.Point(0, 183)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(200, 45)
        Me.btnManage.TabIndex = 4
        Me.btnManage.Text = "Manage"
        Me.btnManage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnManage.TextOffset = New System.Drawing.Point(30, 0)
        '
        'btnDashboard
        '
        Me.btnDashboard.BorderThickness = 1
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FillColor = System.Drawing.Color.WhiteSmoke
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDashboard.ForeColor = System.Drawing.Color.Black
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btnDashboard.Location = New System.Drawing.Point(0, 138)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(200, 45)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.TextOffset = New System.Drawing.Point(30, 0)
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel2.CustomizableEdges.BottomRight = False
        Me.Guna2Panel2.CustomizableEdges.TopLeft = False
        Me.Guna2Panel2.CustomizableEdges.TopRight = False
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(200, 38)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel1.CustomizableEdges.BottomRight = False
        Me.Guna2Panel1.CustomizableEdges.TopRight = False
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(17, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "CORPORATION "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 45)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "REDBERG"
        '
        'pnlTopbar
        '
        Me.pnlTopbar.BorderColor = System.Drawing.Color.Black
        Me.pnlTopbar.BorderRadius = 5
        Me.pnlTopbar.BorderThickness = 1
        Me.pnlTopbar.Controls.Add(Me.btnChangePassword)
        Me.pnlTopbar.Controls.Add(Me.Label3)
        Me.pnlTopbar.Controls.Add(Me.Label2)
        Me.pnlTopbar.Controls.Add(Me.lblSubTitle)
        Me.pnlTopbar.Controls.Add(Me.lblTitle)
        Me.pnlTopbar.CustomizableEdges.BottomLeft = False
        Me.pnlTopbar.CustomizableEdges.BottomRight = False
        Me.pnlTopbar.CustomizableEdges.TopLeft = False
        Me.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopbar.Location = New System.Drawing.Point(200, 0)
        Me.pnlTopbar.Name = "pnlTopbar"
        Me.pnlTopbar.Size = New System.Drawing.Size(800, 70)
        Me.pnlTopbar.TabIndex = 4
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BorderColor = System.Drawing.Color.Transparent
        Me.btnChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnChangePassword.FillColor = System.Drawing.Color.Transparent
        Me.btnChangePassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnChangePassword.ForeColor = System.Drawing.Color.Transparent
        Me.btnChangePassword.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnChangePassword.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnChangePassword.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnChangePassword.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnChangePassword.Image = CType(resources.GetObject("btnChangePassword.Image"), System.Drawing.Image)
        Me.btnChangePassword.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnChangePassword.Location = New System.Drawing.Point(752, 18)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.ShadowDecoration.BorderRadius = 0
        Me.btnChangePassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnChangePassword.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.btnChangePassword.Size = New System.Drawing.Size(40, 40)
        Me.btnChangePassword.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(522, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "JOHN DOE SMITH"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(519, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DEVELOPER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTitle
        '
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblSubTitle.Location = New System.Drawing.Point(24, 45)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(125, 19)
        Me.lblSubTitle.TabIndex = 1
        Me.lblSubTitle.Text = "PATH: DASHBOARD"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(17, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(192, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "DASHBOARD"
        '
        'pnlforms
        '
        Me.pnlforms.BorderColor = System.Drawing.Color.Black
        Me.pnlforms.BorderRadius = 5
        Me.pnlforms.BorderThickness = 1
        Me.pnlforms.CustomizableEdges.BottomLeft = False
        Me.pnlforms.CustomizableEdges.TopLeft = False
        Me.pnlforms.CustomizableEdges.TopRight = False
        Me.pnlforms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlforms.Location = New System.Drawing.Point(200, 70)
        Me.pnlforms.Name = "pnlforms"
        Me.pnlforms.Size = New System.Drawing.Size(800, 530)
        Me.pnlforms.TabIndex = 5
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnlforms)
        Me.Controls.Add(Me.pnlTopbar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.pnlSidebar.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.pnlTopbar.ResumeLayout(False)
        Me.pnlTopbar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlSidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlforms As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlTopbar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblSubTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTeamList As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTransactions As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnManage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAccounts As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnActivity As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnChangePassword As Guna.UI2.WinForms.Guna2CircleButton
End Class
