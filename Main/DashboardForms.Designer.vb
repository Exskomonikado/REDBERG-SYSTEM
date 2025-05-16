<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForms
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.pnlDashboard = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnTotalReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTotalOutbound = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbCollectTable = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTotalInbound = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvTable = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTotalStocks = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlDashboard.SuspendLayout()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'pnlDashboard
        '
        Me.pnlDashboard.BorderColor = System.Drawing.Color.Black
        Me.pnlDashboard.BorderRadius = 5
        Me.pnlDashboard.BorderThickness = 1
        Me.pnlDashboard.Controls.Add(Me.btnTotalReports)
        Me.pnlDashboard.Controls.Add(Me.btnTotalOutbound)
        Me.pnlDashboard.Controls.Add(Me.cmbCollectTable)
        Me.pnlDashboard.Controls.Add(Me.Label1)
        Me.pnlDashboard.Controls.Add(Me.btnTotalInbound)
        Me.pnlDashboard.Controls.Add(Me.dgvTable)
        Me.pnlDashboard.Controls.Add(Me.Guna2Button4)
        Me.pnlDashboard.Controls.Add(Me.Guna2Button3)
        Me.pnlDashboard.Controls.Add(Me.Guna2Button2)
        Me.pnlDashboard.Controls.Add(Me.btnTotalStocks)
        Me.pnlDashboard.Controls.Add(Me.Label6)
        Me.pnlDashboard.CustomizableEdges.BottomLeft = False
        Me.pnlDashboard.CustomizableEdges.TopLeft = False
        Me.pnlDashboard.CustomizableEdges.TopRight = False
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnlDashboard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(800, 530)
        Me.pnlDashboard.TabIndex = 0
        '
        'btnTotalReports
        '
        Me.btnTotalReports.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalReports.BorderRadius = 5
        Me.btnTotalReports.BorderThickness = 1
        Me.btnTotalReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTotalReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTotalReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTotalReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTotalReports.FillColor = System.Drawing.Color.SteelBlue
        Me.btnTotalReports.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalReports.ForeColor = System.Drawing.Color.White
        Me.btnTotalReports.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalReports.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnTotalReports.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalReports.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalReports.Location = New System.Drawing.Point(402, 65)
        Me.btnTotalReports.Name = "btnTotalReports"
        Me.btnTotalReports.Size = New System.Drawing.Size(355, 45)
        Me.btnTotalReports.TabIndex = 8
        Me.btnTotalReports.Text = "Total Reports:"
        Me.btnTotalReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTotalReports.TextOffset = New System.Drawing.Point(30, 0)
        '
        'btnTotalOutbound
        '
        Me.btnTotalOutbound.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalOutbound.BorderRadius = 5
        Me.btnTotalOutbound.BorderThickness = 1
        Me.btnTotalOutbound.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTotalOutbound.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTotalOutbound.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTotalOutbound.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTotalOutbound.FillColor = System.Drawing.Color.SteelBlue
        Me.btnTotalOutbound.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalOutbound.ForeColor = System.Drawing.Color.White
        Me.btnTotalOutbound.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalOutbound.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnTotalOutbound.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalOutbound.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalOutbound.Location = New System.Drawing.Point(402, 116)
        Me.btnTotalOutbound.Name = "btnTotalOutbound"
        Me.btnTotalOutbound.Size = New System.Drawing.Size(355, 45)
        Me.btnTotalOutbound.TabIndex = 10
        Me.btnTotalOutbound.Text = "Total Outbound:"
        Me.btnTotalOutbound.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTotalOutbound.TextOffset = New System.Drawing.Point(30, 0)
        '
        'cmbCollectTable
        '
        Me.cmbCollectTable.BackColor = System.Drawing.Color.Transparent
        Me.cmbCollectTable.BorderColor = System.Drawing.Color.Black
        Me.cmbCollectTable.BorderRadius = 5
        Me.cmbCollectTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCollectTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCollectTable.FillColor = System.Drawing.Color.SteelBlue
        Me.cmbCollectTable.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCollectTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCollectTable.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCollectTable.ForeColor = System.Drawing.Color.White
        Me.cmbCollectTable.ItemHeight = 30
        Me.cmbCollectTable.Location = New System.Drawing.Point(567, 189)
        Me.cmbCollectTable.Name = "cmbCollectTable"
        Me.cmbCollectTable.Size = New System.Drawing.Size(190, 36)
        Me.cmbCollectTable.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TABLE DETAILS: "
        '
        'btnTotalInbound
        '
        Me.btnTotalInbound.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalInbound.BorderRadius = 5
        Me.btnTotalInbound.BorderThickness = 1
        Me.btnTotalInbound.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTotalInbound.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTotalInbound.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTotalInbound.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTotalInbound.FillColor = System.Drawing.Color.SteelBlue
        Me.btnTotalInbound.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalInbound.ForeColor = System.Drawing.Color.White
        Me.btnTotalInbound.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalInbound.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnTotalInbound.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalInbound.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalInbound.Location = New System.Drawing.Point(41, 116)
        Me.btnTotalInbound.Name = "btnTotalInbound"
        Me.btnTotalInbound.Size = New System.Drawing.Size(355, 45)
        Me.btnTotalInbound.TabIndex = 9
        Me.btnTotalInbound.Text = "Total Inbound: "
        Me.btnTotalInbound.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTotalInbound.TextOffset = New System.Drawing.Point(30, 0)
        '
        'dgvTable
        '
        Me.dgvTable.AllowUserToAddRows = False
        Me.dgvTable.AllowUserToDeleteRows = False
        Me.dgvTable.AllowUserToResizeColumns = False
        Me.dgvTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTable.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTable.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTable.Location = New System.Drawing.Point(41, 231)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.ReadOnly = True
        Me.dgvTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTable.RowHeadersVisible = False
        Me.dgvTable.RowHeadersWidth = 51
        Me.dgvTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTable.RowTemplate.Height = 30
        Me.dgvTable.Size = New System.Drawing.Size(716, 272)
        Me.dgvTable.TabIndex = 7
        Me.dgvTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTable.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvTable.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray
        Me.dgvTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTable.ThemeStyle.HeaderStyle.Height = 35
        Me.dgvTable.ThemeStyle.ReadOnly = True
        Me.dgvTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvTable.ThemeStyle.RowsStyle.Height = 30
        Me.dgvTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Button4
        '
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(347, 116)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(10, 0)
        Me.Guna2Button4.TabIndex = 6
        Me.Guna2Button4.Text = "Guna2Button4"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(347, 65)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(10, 0)
        Me.Guna2Button3.TabIndex = 5
        Me.Guna2Button3.Text = "Guna2Button3"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(41, 116)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(10, 0)
        Me.Guna2Button2.TabIndex = 4
        Me.Guna2Button2.Text = "Guna2Button2"
        '
        'btnTotalStocks
        '
        Me.btnTotalStocks.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalStocks.BorderRadius = 5
        Me.btnTotalStocks.BorderThickness = 1
        Me.btnTotalStocks.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTotalStocks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTotalStocks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTotalStocks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTotalStocks.FillColor = System.Drawing.Color.SteelBlue
        Me.btnTotalStocks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalStocks.ForeColor = System.Drawing.Color.White
        Me.btnTotalStocks.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalStocks.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnTotalStocks.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalStocks.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalStocks.Location = New System.Drawing.Point(41, 65)
        Me.btnTotalStocks.Name = "btnTotalStocks"
        Me.btnTotalStocks.Size = New System.Drawing.Size(355, 45)
        Me.btnTotalStocks.TabIndex = 3
        Me.btnTotalStocks.Text = "Total Stocks: "
        Me.btnTotalStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTotalStocks.TextOffset = New System.Drawing.Point(30, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 21)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "ANALYTICS"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 5
        Me.Guna2Elipse1.TargetControl = Me.dgvTable
        '
        'DashboardForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DashboardForms"
        Me.Text = "Forms"
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlDashboard.PerformLayout()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents pnlDashboard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvTable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTotalStocks As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTotalOutbound As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTotalInbound As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTotalReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents cmbCollectTable As Guna.UI2.WinForms.Guna2ComboBox
End Class
