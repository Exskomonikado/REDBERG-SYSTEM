<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardReports))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlReports = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbStatusFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dgvReports = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnTotalUnread = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTotalReports = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblReportDate = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblReportID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkSubject = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.chkReportID = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Button12 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.ToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.pnlReports.SuspendLayout()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 5
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlReports
        '
        Me.pnlReports.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlReports.BorderColor = System.Drawing.Color.Black
        Me.pnlReports.BorderRadius = 5
        Me.pnlReports.BorderThickness = 1
        Me.pnlReports.Controls.Add(Me.Guna2Button1)
        Me.pnlReports.Controls.Add(Me.cmbStatusFilter)
        Me.pnlReports.Controls.Add(Me.dgvReports)
        Me.pnlReports.Controls.Add(Me.btnTotalUnread)
        Me.pnlReports.Controls.Add(Me.btnTotalReports)
        Me.pnlReports.Controls.Add(Me.Guna2Panel3)
        Me.pnlReports.Controls.Add(Me.btnSearch)
        Me.pnlReports.Controls.Add(Me.txtSearch)
        Me.pnlReports.Controls.Add(Me.Guna2Panel1)
        Me.pnlReports.Controls.Add(Me.Label2)
        Me.pnlReports.Controls.Add(Me.Guna2Button12)
        Me.pnlReports.Controls.Add(Me.Label3)
        Me.pnlReports.CustomizableEdges.BottomLeft = False
        Me.pnlReports.CustomizableEdges.TopLeft = False
        Me.pnlReports.CustomizableEdges.TopRight = False
        Me.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReports.Location = New System.Drawing.Point(0, 0)
        Me.pnlReports.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.Size = New System.Drawing.Size(800, 530)
        Me.pnlReports.TabIndex = 4
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.SteelBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.Gray
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.Location = New System.Drawing.Point(488, 212)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(35, 35)
        Me.Guna2Button1.TabIndex = 29
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(30, 0)
        '
        'cmbStatusFilter
        '
        Me.cmbStatusFilter.BackColor = System.Drawing.Color.Transparent
        Me.cmbStatusFilter.BorderColor = System.Drawing.Color.Black
        Me.cmbStatusFilter.BorderRadius = 5
        Me.cmbStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatusFilter.FillColor = System.Drawing.Color.SteelBlue
        Me.cmbStatusFilter.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatusFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStatusFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStatusFilter.ForeColor = System.Drawing.Color.White
        Me.cmbStatusFilter.ItemHeight = 30
        Me.cmbStatusFilter.Items.AddRange(New Object() {"UNREAD", "READ"})
        Me.cmbStatusFilter.Location = New System.Drawing.Point(285, 212)
        Me.cmbStatusFilter.Name = "cmbStatusFilter"
        Me.cmbStatusFilter.Size = New System.Drawing.Size(197, 36)
        Me.cmbStatusFilter.StartIndex = 0
        Me.cmbStatusFilter.TabIndex = 22
        Me.cmbStatusFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvReports
        '
        Me.dgvReports.AllowUserToAddRows = False
        Me.dgvReports.AllowUserToDeleteRows = False
        Me.dgvReports.AllowUserToResizeColumns = False
        Me.dgvReports.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvReports.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReports.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReports.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReports.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReports.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReports.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvReports.Location = New System.Drawing.Point(41, 257)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.ReadOnly = True
        Me.dgvReports.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReports.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReports.RowHeadersVisible = False
        Me.dgvReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvReports.RowTemplate.Height = 30
        Me.dgvReports.Size = New System.Drawing.Size(487, 246)
        Me.dgvReports.TabIndex = 21
        Me.dgvReports.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvReports.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvReports.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvReports.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvReports.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvReports.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvReports.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvReports.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray
        Me.dgvReports.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvReports.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvReports.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvReports.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReports.ThemeStyle.HeaderStyle.Height = 35
        Me.dgvReports.ThemeStyle.ReadOnly = True
        Me.dgvReports.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvReports.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvReports.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvReports.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvReports.ThemeStyle.RowsStyle.Height = 30
        Me.dgvReports.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvReports.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnTotalUnread
        '
        Me.btnTotalUnread.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalUnread.BorderRadius = 5
        Me.btnTotalUnread.BorderThickness = 1
        Me.btnTotalUnread.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalUnread.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnTotalUnread.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalUnread.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnTotalUnread.FillColor = System.Drawing.Color.SteelBlue
        Me.btnTotalUnread.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalUnread.ForeColor = System.Drawing.Color.White
        Me.btnTotalUnread.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalUnread.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnTotalUnread.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalUnread.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalUnread.Location = New System.Drawing.Point(285, 156)
        Me.btnTotalUnread.Name = "btnTotalUnread"
        Me.btnTotalUnread.Size = New System.Drawing.Size(238, 42)
        Me.btnTotalUnread.TabIndex = 19
        Me.btnTotalUnread.Text = "Total Unread: "
        Me.btnTotalUnread.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnTotalReports
        '
        Me.btnTotalReports.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalReports.BorderRadius = 5
        Me.btnTotalReports.BorderThickness = 1
        Me.btnTotalReports.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalReports.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnTotalReports.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalReports.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnTotalReports.FillColor = System.Drawing.Color.SteelBlue
        Me.btnTotalReports.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalReports.ForeColor = System.Drawing.Color.White
        Me.btnTotalReports.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalReports.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnTotalReports.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalReports.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalReports.Location = New System.Drawing.Point(41, 156)
        Me.btnTotalReports.Name = "btnTotalReports"
        Me.btnTotalReports.Size = New System.Drawing.Size(238, 42)
        Me.btnTotalReports.TabIndex = 18
        Me.btnTotalReports.Text = "Total Reports: "
        Me.btnTotalReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.lblStatus)
        Me.Guna2Panel3.Controls.Add(Me.Label10)
        Me.Guna2Panel3.Controls.Add(Me.Label18)
        Me.Guna2Panel3.Controls.Add(Me.Label17)
        Me.Guna2Panel3.Controls.Add(Me.Label12)
        Me.Guna2Panel3.Controls.Add(Me.lblEmployeeName)
        Me.Guna2Panel3.Controls.Add(Me.lblEmployeeID)
        Me.Guna2Panel3.Controls.Add(Me.lblDescription)
        Me.Guna2Panel3.Controls.Add(Me.lblReportDate)
        Me.Guna2Panel3.Controls.Add(Me.lblSubject)
        Me.Guna2Panel3.Controls.Add(Me.lblReportID)
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.Controls.Add(Me.Label7)
        Me.Guna2Panel3.Controls.Add(Me.Label6)
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Controls.Add(Me.Label4)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel3.Location = New System.Drawing.Point(548, 27)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(238, 476)
        Me.Guna2Panel3.TabIndex = 16
        '
        'lblStatus
        '
        Me.lblStatus.AutoEllipsis = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(70, 347)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(139, 17)
        Me.lblStatus.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 347)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Status:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 249)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 20)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "EMPLOYEE"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 114)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 20)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "CONTENT "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "REPORT DETAILS"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoEllipsis = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.Location = New System.Drawing.Point(70, 313)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(139, 17)
        Me.lblEmployeeName.TabIndex = 16
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoEllipsis = True
        Me.lblEmployeeID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeID.Location = New System.Drawing.Point(55, 282)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(154, 17)
        Me.lblEmployeeID.TabIndex = 15
        '
        'lblDescription
        '
        Me.lblDescription.AutoEllipsis = True
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(18, 192)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(204, 47)
        Me.lblDescription.TabIndex = 14
        '
        'lblReportDate
        '
        Me.lblReportDate.AutoEllipsis = True
        Me.lblReportDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportDate.Location = New System.Drawing.Point(68, 77)
        Me.lblReportDate.Name = "lblReportDate"
        Me.lblReportDate.Size = New System.Drawing.Size(154, 17)
        Me.lblReportDate.TabIndex = 13
        '
        'lblSubject
        '
        Me.lblSubject.AutoEllipsis = True
        Me.lblSubject.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(68, 144)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(154, 17)
        Me.lblSubject.TabIndex = 12
        '
        'lblReportID
        '
        Me.lblReportID.AutoEllipsis = True
        Me.lblReportID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportID.Location = New System.Drawing.Point(55, 51)
        Me.lblReportID.Name = "lblReportID"
        Me.lblReportID.Size = New System.Drawing.Size(154, 17)
        Me.lblReportID.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 313)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Content:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "DATE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Subject:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ID:"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel4.BorderRadius = 5
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.btnAdd)
        Me.Guna2Panel4.Controls.Add(Me.btnRemove)
        Me.Guna2Panel4.Controls.Add(Me.btnUpdate)
        Me.Guna2Panel4.CustomizableEdges.TopLeft = False
        Me.Guna2Panel4.CustomizableEdges.TopRight = False
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 391)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(238, 85)
        Me.Guna2Panel4.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderRadius = 5
        Me.btnAdd.BorderThickness = 1
        Me.btnAdd.CustomizableEdges.TopLeft = False
        Me.btnAdd.CustomizableEdges.TopRight = False
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.SteelBlue
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(238, 42)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "ADD"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.BorderRadius = 5
        Me.btnRemove.BorderThickness = 1
        Me.btnRemove.CustomizableEdges.TopLeft = False
        Me.btnRemove.CustomizableEdges.TopRight = False
        Me.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRemove.FillColor = System.Drawing.Color.SteelBlue
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(0, 42)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(238, 42)
        Me.btnRemove.TabIndex = 24
        Me.btnRemove.Text = "REMOVE"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BorderThickness = 1
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUpdate.FillColor = System.Drawing.Color.SteelBlue
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(0, 0)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(238, 42)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "READ"
        '
        'btnSearch
        '
        Me.btnSearch.BorderRadius = 5
        Me.btnSearch.BorderThickness = 1
        Me.btnSearch.CustomizableEdges.BottomLeft = False
        Me.btnSearch.CustomizableEdges.TopLeft = False
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.SteelBlue
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(385, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(139, 36)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.Black
        Me.txtSearch.BorderRadius = 5
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(41, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = ""
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(356, 36)
        Me.txtSearch.TabIndex = 14
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Label15)
        Me.Guna2Panel1.Controls.Add(Me.chkSubject)
        Me.Guna2Panel1.Controls.Add(Me.chkReportID)
        Me.Guna2Panel1.Controls.Add(Me.Label14)
        Me.Guna2Panel1.Controls.Add(Me.Label13)
        Me.Guna2Panel1.Location = New System.Drawing.Point(41, 69)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(483, 41)
        Me.Guna2Panel1.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(236, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 17)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Subject"
        '
        'chkSubject
        '
        Me.chkSubject.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkSubject.CheckedState.BorderRadius = 2
        Me.chkSubject.CheckedState.BorderThickness = 1
        Me.chkSubject.CheckedState.FillColor = System.Drawing.Color.Black
        Me.chkSubject.Location = New System.Drawing.Point(205, 10)
        Me.chkSubject.Name = "chkSubject"
        Me.chkSubject.Size = New System.Drawing.Size(20, 20)
        Me.chkSubject.TabIndex = 4
        Me.chkSubject.Text = "Guna2CustomCheckBox2"
        Me.chkSubject.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkSubject.UncheckedState.BorderRadius = 2
        Me.chkSubject.UncheckedState.BorderThickness = 1
        Me.chkSubject.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'chkReportID
        '
        Me.chkReportID.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkReportID.CheckedState.BorderRadius = 2
        Me.chkReportID.CheckedState.BorderThickness = 1
        Me.chkReportID.CheckedState.FillColor = System.Drawing.Color.Black
        Me.chkReportID.Location = New System.Drawing.Point(71, 10)
        Me.chkReportID.Name = "chkReportID"
        Me.chkReportID.Size = New System.Drawing.Size(20, 20)
        Me.chkReportID.TabIndex = 3
        Me.chkReportID.Text = "Guna2CustomCheckBox1"
        Me.chkReportID.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkReportID.UncheckedState.BorderRadius = 2
        Me.chkReportID.UncheckedState.BorderThickness = 1
        Me.chkReportID.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(108, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 17)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Report ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Filters: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "TABLE DETAILS: "
        '
        'Guna2Button12
        '
        Me.Guna2Button12.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button12.ForeColor = System.Drawing.Color.White
        Me.Guna2Button12.Location = New System.Drawing.Point(41, 126)
        Me.Guna2Button12.Name = "Guna2Button12"
        Me.Guna2Button12.Size = New System.Drawing.Size(10, 0)
        Me.Guna2Button12.TabIndex = 4
        Me.Guna2Button12.Text = "Guna2Button12"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ANALYTICS"
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 5
        Me.Guna2Elipse2.TargetControl = Me.dgvReports
        '
        'ToolTip1
        '
        Me.ToolTip1.AllowLinksHandling = True
        Me.ToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'DashboardReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.pnlReports)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DashboardReports"
        Me.Text = "DashboardReports"
        Me.pnlReports.ResumeLayout(False)
        Me.pnlReports.PerformLayout()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlReports As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvReports As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnTotalUnread As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTotalReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblReportDate As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblReportID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents chkSubject As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents chkReportID As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button12 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbStatusFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
