<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageOutTransact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageOutTransact))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTransact = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnShow = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvTransact = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnTotalTeam = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTotalOutbound = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.lblTeamNumber = New System.Windows.Forms.Label()
        Me.lblTeamLeaderName = New System.Windows.Forms.Label()
        Me.lblTeamLeaderID = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblTransactionDate = New System.Windows.Forms.Label()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.lblTransactionID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTransaction = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAddSupplier = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTransacts = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkProductName = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.chkEmployeeID = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.chkTransactionID = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Button12 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.ToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.pnlTransact.SuspendLayout()
        CType(Me.dgvTransact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTransact
        '
        Me.pnlTransact.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTransact.BorderColor = System.Drawing.Color.Black
        Me.pnlTransact.BorderRadius = 5
        Me.pnlTransact.BorderThickness = 1
        Me.pnlTransact.Controls.Add(Me.Guna2Button1)
        Me.pnlTransact.Controls.Add(Me.btnShow)
        Me.pnlTransact.Controls.Add(Me.dgvTransact)
        Me.pnlTransact.Controls.Add(Me.btnTotalTeam)
        Me.pnlTransact.Controls.Add(Me.btnTotalOutbound)
        Me.pnlTransact.Controls.Add(Me.Guna2Panel3)
        Me.pnlTransact.Controls.Add(Me.btnSearch)
        Me.pnlTransact.Controls.Add(Me.txtSearch)
        Me.pnlTransact.Controls.Add(Me.Guna2Panel1)
        Me.pnlTransact.Controls.Add(Me.Label2)
        Me.pnlTransact.Controls.Add(Me.Guna2Button12)
        Me.pnlTransact.Controls.Add(Me.Label3)
        Me.pnlTransact.CustomizableEdges.BottomLeft = False
        Me.pnlTransact.CustomizableEdges.TopLeft = False
        Me.pnlTransact.CustomizableEdges.TopRight = False
        Me.pnlTransact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTransact.Location = New System.Drawing.Point(0, 0)
        Me.pnlTransact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlTransact.Name = "pnlTransact"
        Me.pnlTransact.Size = New System.Drawing.Size(800, 530)
        Me.pnlTransact.TabIndex = 4
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
        Me.Guna2Button1.Location = New System.Drawing.Point(488, 244)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(35, 35)
        Me.Guna2Button1.TabIndex = 31
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(30, 0)
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Transparent
        Me.btnShow.BorderRadius = 5
        Me.btnShow.BorderThickness = 1
        Me.btnShow.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnShow.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnShow.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnShow.FillColor = System.Drawing.Color.SeaGreen
        Me.btnShow.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnShow.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnShow.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnShow.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(285, 119)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(238, 42)
        Me.btnShow.TabIndex = 22
        Me.btnShow.Text = "Make Inbound Transactions"
        '
        'dgvTransact
        '
        Me.dgvTransact.AllowUserToAddRows = False
        Me.dgvTransact.AllowUserToDeleteRows = False
        Me.dgvTransact.AllowUserToResizeColumns = False
        Me.dgvTransact.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvTransact.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransact.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransact.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTransact.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransact.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTransact.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTransact.Location = New System.Drawing.Point(41, 288)
        Me.dgvTransact.Name = "dgvTransact"
        Me.dgvTransact.ReadOnly = True
        Me.dgvTransact.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransact.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTransact.RowHeadersVisible = False
        Me.dgvTransact.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTransact.RowTemplate.Height = 30
        Me.dgvTransact.Size = New System.Drawing.Size(487, 215)
        Me.dgvTransact.TabIndex = 21
        Me.dgvTransact.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTransact.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTransact.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvTransact.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTransact.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvTransact.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvTransact.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTransact.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray
        Me.dgvTransact.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTransact.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTransact.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvTransact.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTransact.ThemeStyle.HeaderStyle.Height = 35
        Me.dgvTransact.ThemeStyle.ReadOnly = True
        Me.dgvTransact.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTransact.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTransact.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTransact.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvTransact.ThemeStyle.RowsStyle.Height = 30
        Me.dgvTransact.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTransact.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnTotalTeam
        '
        Me.btnTotalTeam.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalTeam.BorderRadius = 5
        Me.btnTotalTeam.BorderThickness = 1
        Me.btnTotalTeam.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalTeam.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnTotalTeam.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalTeam.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnTotalTeam.FillColor = System.Drawing.Color.SteelBlue
        Me.btnTotalTeam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalTeam.ForeColor = System.Drawing.Color.White
        Me.btnTotalTeam.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalTeam.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnTotalTeam.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalTeam.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalTeam.Location = New System.Drawing.Point(285, 181)
        Me.btnTotalTeam.Name = "btnTotalTeam"
        Me.btnTotalTeam.Size = New System.Drawing.Size(238, 42)
        Me.btnTotalTeam.TabIndex = 19
        Me.btnTotalTeam.Text = "Total Team: "
        Me.btnTotalTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnTotalOutbound
        '
        Me.btnTotalOutbound.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalOutbound.BorderRadius = 5
        Me.btnTotalOutbound.BorderThickness = 1
        Me.btnTotalOutbound.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalOutbound.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnTotalOutbound.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalOutbound.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnTotalOutbound.FillColor = System.Drawing.Color.SteelBlue
        Me.btnTotalOutbound.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalOutbound.ForeColor = System.Drawing.Color.White
        Me.btnTotalOutbound.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalOutbound.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnTotalOutbound.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalOutbound.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalOutbound.Location = New System.Drawing.Point(41, 181)
        Me.btnTotalOutbound.Name = "btnTotalOutbound"
        Me.btnTotalOutbound.Size = New System.Drawing.Size(238, 42)
        Me.btnTotalOutbound.TabIndex = 18
        Me.btnTotalOutbound.Text = "Total Outbound: "
        Me.btnTotalOutbound.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.lblQuantity)
        Me.Guna2Panel3.Controls.Add(Me.Label19)
        Me.Guna2Panel3.Controls.Add(Me.Label18)
        Me.Guna2Panel3.Controls.Add(Me.Label17)
        Me.Guna2Panel3.Controls.Add(Me.Label12)
        Me.Guna2Panel3.Controls.Add(Me.lblProductID)
        Me.Guna2Panel3.Controls.Add(Me.lblTeamNumber)
        Me.Guna2Panel3.Controls.Add(Me.lblTeamLeaderName)
        Me.Guna2Panel3.Controls.Add(Me.lblTeamLeaderID)
        Me.Guna2Panel3.Controls.Add(Me.lblEmployeeName)
        Me.Guna2Panel3.Controls.Add(Me.lblTransactionDate)
        Me.Guna2Panel3.Controls.Add(Me.lblEmployeeID)
        Me.Guna2Panel3.Controls.Add(Me.lblTransactionID)
        Me.Guna2Panel3.Controls.Add(Me.Label10)
        Me.Guna2Panel3.Controls.Add(Me.Label9)
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.Controls.Add(Me.Label7)
        Me.Guna2Panel3.Controls.Add(Me.Label6)
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Controls.Add(Me.lblTransaction)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel3.Location = New System.Drawing.Point(548, 27)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(238, 476)
        Me.Guna2Panel3.TabIndex = 16
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoEllipsis = True
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(95, 347)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(116, 17)
        Me.lblQuantity.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(14, 347)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 17)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Quantity:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(14, 195)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(158, 20)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "OUTBOUND DETAILS"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(147, 20)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "EMPLOYEE DETAILS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(14, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(179, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "TRANSACTION DETAILS"
        '
        'lblProductID
        '
        Me.lblProductID.AutoEllipsis = True
        Me.lblProductID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(95, 319)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(116, 17)
        Me.lblProductID.TabIndex = 18
        '
        'lblTeamNumber
        '
        Me.lblTeamNumber.AutoEllipsis = True
        Me.lblTeamNumber.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamNumber.Location = New System.Drawing.Point(81, 288)
        Me.lblTeamNumber.Name = "lblTeamNumber"
        Me.lblTeamNumber.Size = New System.Drawing.Size(133, 17)
        Me.lblTeamNumber.TabIndex = 17
        '
        'lblTeamLeaderName
        '
        Me.lblTeamLeaderName.AutoEllipsis = True
        Me.lblTeamLeaderName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamLeaderName.Location = New System.Drawing.Point(78, 257)
        Me.lblTeamLeaderName.Name = "lblTeamLeaderName"
        Me.lblTeamLeaderName.Size = New System.Drawing.Size(133, 17)
        Me.lblTeamLeaderName.TabIndex = 16
        '
        'lblTeamLeaderID
        '
        Me.lblTeamLeaderID.AutoEllipsis = True
        Me.lblTeamLeaderID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamLeaderID.Location = New System.Drawing.Point(81, 228)
        Me.lblTeamLeaderID.Name = "lblTeamLeaderID"
        Me.lblTeamLeaderID.Size = New System.Drawing.Size(133, 17)
        Me.lblTeamLeaderID.TabIndex = 15
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoEllipsis = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.Location = New System.Drawing.Point(68, 164)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(146, 17)
        Me.lblEmployeeName.TabIndex = 14
        '
        'lblTransactionDate
        '
        Me.lblTransactionDate.AutoEllipsis = True
        Me.lblTransactionDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionDate.Location = New System.Drawing.Point(68, 71)
        Me.lblTransactionDate.Name = "lblTransactionDate"
        Me.lblTransactionDate.Size = New System.Drawing.Size(146, 17)
        Me.lblTransactionDate.TabIndex = 13
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoEllipsis = True
        Me.lblEmployeeID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeID.Location = New System.Drawing.Point(53, 132)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(161, 17)
        Me.lblEmployeeID.TabIndex = 12
        '
        'lblTransactionID
        '
        Me.lblTransactionID.AutoEllipsis = True
        Me.lblTransactionID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionID.Location = New System.Drawing.Point(53, 45)
        Me.lblTransactionID.Name = "lblTransactionID"
        Me.lblTransactionID.Size = New System.Drawing.Size(161, 17)
        Me.lblTransactionID.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 319)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Product ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Team ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "DATE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID:"
        '
        'lblTransaction
        '
        Me.lblTransaction.AutoSize = True
        Me.lblTransaction.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaction.Location = New System.Drawing.Point(14, 45)
        Me.lblTransaction.Name = "lblTransaction"
        Me.lblTransaction.Size = New System.Drawing.Size(25, 17)
        Me.lblTransaction.TabIndex = 2
        Me.lblTransaction.Text = "ID:"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel4.BorderRadius = 5
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.btnAddSupplier)
        Me.Guna2Panel4.Controls.Add(Me.btnTransacts)
        Me.Guna2Panel4.CustomizableEdges.TopLeft = False
        Me.Guna2Panel4.CustomizableEdges.TopRight = False
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 391)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(238, 85)
        Me.Guna2Panel4.TabIndex = 0
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.BackColor = System.Drawing.Color.Transparent
        Me.btnAddSupplier.BorderRadius = 5
        Me.btnAddSupplier.BorderThickness = 1
        Me.btnAddSupplier.CustomizableEdges.TopLeft = False
        Me.btnAddSupplier.CustomizableEdges.TopRight = False
        Me.btnAddSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddSupplier.FillColor = System.Drawing.Color.SteelBlue
        Me.btnAddSupplier.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSupplier.ForeColor = System.Drawing.Color.White
        Me.btnAddSupplier.Location = New System.Drawing.Point(0, 42)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(238, 42)
        Me.btnAddSupplier.TabIndex = 24
        Me.btnAddSupplier.Text = "ADD TEAM"
        '
        'btnTransacts
        '
        Me.btnTransacts.BackColor = System.Drawing.Color.Transparent
        Me.btnTransacts.BorderThickness = 1
        Me.btnTransacts.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTransacts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTransacts.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTransacts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTransacts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransacts.FillColor = System.Drawing.Color.SteelBlue
        Me.btnTransacts.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransacts.ForeColor = System.Drawing.Color.White
        Me.btnTransacts.Location = New System.Drawing.Point(0, 0)
        Me.btnTransacts.Name = "btnTransacts"
        Me.btnTransacts.Size = New System.Drawing.Size(238, 42)
        Me.btnTransacts.TabIndex = 23
        Me.btnTransacts.Text = "TRANSACT"
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
        Me.Guna2Panel1.Controls.Add(Me.Label16)
        Me.Guna2Panel1.Controls.Add(Me.Label15)
        Me.Guna2Panel1.Controls.Add(Me.chkProductName)
        Me.Guna2Panel1.Controls.Add(Me.chkEmployeeID)
        Me.Guna2Panel1.Controls.Add(Me.chkTransactionID)
        Me.Guna2Panel1.Controls.Add(Me.Label14)
        Me.Guna2Panel1.Controls.Add(Me.Label13)
        Me.Guna2Panel1.Location = New System.Drawing.Point(41, 69)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(483, 41)
        Me.Guna2Panel1.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(370, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Product Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(236, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Employee ID"
        '
        'chkProductName
        '
        Me.chkProductName.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkProductName.CheckedState.BorderRadius = 2
        Me.chkProductName.CheckedState.BorderThickness = 1
        Me.chkProductName.CheckedState.FillColor = System.Drawing.Color.Black
        Me.chkProductName.Location = New System.Drawing.Point(336, 10)
        Me.chkProductName.Name = "chkProductName"
        Me.chkProductName.Size = New System.Drawing.Size(20, 20)
        Me.chkProductName.TabIndex = 5
        Me.chkProductName.Text = "Guna2CustomCheckBox3"
        Me.chkProductName.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkProductName.UncheckedState.BorderRadius = 2
        Me.chkProductName.UncheckedState.BorderThickness = 1
        Me.chkProductName.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'chkEmployeeID
        '
        Me.chkEmployeeID.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkEmployeeID.CheckedState.BorderRadius = 2
        Me.chkEmployeeID.CheckedState.BorderThickness = 1
        Me.chkEmployeeID.CheckedState.FillColor = System.Drawing.Color.Black
        Me.chkEmployeeID.Location = New System.Drawing.Point(205, 10)
        Me.chkEmployeeID.Name = "chkEmployeeID"
        Me.chkEmployeeID.Size = New System.Drawing.Size(20, 20)
        Me.chkEmployeeID.TabIndex = 4
        Me.chkEmployeeID.Text = "Guna2CustomCheckBox2"
        Me.chkEmployeeID.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkEmployeeID.UncheckedState.BorderRadius = 2
        Me.chkEmployeeID.UncheckedState.BorderThickness = 1
        Me.chkEmployeeID.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'chkTransactionID
        '
        Me.chkTransactionID.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkTransactionID.CheckedState.BorderRadius = 2
        Me.chkTransactionID.CheckedState.BorderThickness = 1
        Me.chkTransactionID.CheckedState.FillColor = System.Drawing.Color.Black
        Me.chkTransactionID.Location = New System.Drawing.Point(71, 10)
        Me.chkTransactionID.Name = "chkTransactionID"
        Me.chkTransactionID.Size = New System.Drawing.Size(20, 20)
        Me.chkTransactionID.TabIndex = 3
        Me.chkTransactionID.Text = "Guna2CustomCheckBox1"
        Me.chkTransactionID.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.chkTransactionID.UncheckedState.BorderRadius = 2
        Me.chkTransactionID.UncheckedState.BorderThickness = 1
        Me.chkTransactionID.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(108, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Transact ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Filters: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 252)
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
        Me.Guna2Button12.Location = New System.Drawing.Point(41, 151)
        Me.Guna2Button12.Name = "Guna2Button12"
        Me.Guna2Button12.Size = New System.Drawing.Size(10, 0)
        Me.Guna2Button12.TabIndex = 4
        Me.Guna2Button12.Text = "Guna2Button12"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ANALYTICS"
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_ACTIVATE
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 5
        Me.Guna2Elipse1.TargetControl = Me.dgvTransact
        '
        'ToolTip1
        '
        Me.ToolTip1.AllowLinksHandling = True
        Me.ToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'ManageOutTransact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.pnlTransact)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageOutTransact"
        Me.Text = "ManageOutTransact"
        Me.pnlTransact.ResumeLayout(False)
        Me.pnlTransact.PerformLayout()
        CType(Me.dgvTransact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTransact As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnShow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvTransact As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnTotalTeam As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTotalOutbound As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents lblTeamNumber As Label
    Friend WithEvents lblTeamLeaderName As Label
    Friend WithEvents lblTeamLeaderID As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblTransactionDate As Label
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTransaction As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddSupplier As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTransacts As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents chkProductName As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents chkEmployeeID As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents chkTransactionID As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button12 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
