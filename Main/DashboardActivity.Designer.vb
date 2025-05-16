<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardActivity
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardActivity))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnFilter = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlFilterAdmin = New System.Windows.Forms.Panel()
        Me.dtpDate2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbStaff = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblSupplierName = New System.Windows.Forms.Label()
        Me.btnTotalActivity = New Guna.UI2.WinForms.Guna2Button()
        Me.lblSupplierID = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.dgvActivity = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.pnlFilterAdmin.SuspendLayout()
        CType(Me.dgvActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ANALYTICS"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel3.Controls.Add(Me.lblContact)
        Me.Guna2Panel3.Controls.Add(Me.lblSupplierName)
        Me.Guna2Panel3.Controls.Add(Me.btnTotalActivity)
        Me.Guna2Panel3.Controls.Add(Me.lblSupplierID)
        Me.Guna2Panel3.Controls.Add(Me.lblDescription)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Location = New System.Drawing.Point(524, 30)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(264, 454)
        Me.Guna2Panel3.TabIndex = 17
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.btnFilter)
        Me.Guna2Panel2.Controls.Add(Me.pnlFilterAdmin)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.dtpDate)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel2.CustomizableEdges.BottomRight = False
        Me.Guna2Panel2.CustomizableEdges.TopLeft = False
        Me.Guna2Panel2.CustomizableEdges.TopRight = False
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 140)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(264, 314)
        Me.Guna2Panel2.TabIndex = 30
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.Transparent
        Me.btnFilter.BorderRadius = 5
        Me.btnFilter.BorderThickness = 1
        Me.btnFilter.CustomizableEdges.TopLeft = False
        Me.btnFilter.CustomizableEdges.TopRight = False
        Me.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFilter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFilter.FillColor = System.Drawing.Color.SteelBlue
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(0, 272)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(264, 42)
        Me.btnFilter.TabIndex = 34
        Me.btnFilter.Text = "FILTER"
        '
        'pnlFilterAdmin
        '
        Me.pnlFilterAdmin.Controls.Add(Me.dtpDate2)
        Me.pnlFilterAdmin.Controls.Add(Me.Label5)
        Me.pnlFilterAdmin.Controls.Add(Me.cmbStaff)
        Me.pnlFilterAdmin.Controls.Add(Me.Label2)
        Me.pnlFilterAdmin.Location = New System.Drawing.Point(7, 60)
        Me.pnlFilterAdmin.Name = "pnlFilterAdmin"
        Me.pnlFilterAdmin.Size = New System.Drawing.Size(230, 190)
        Me.pnlFilterAdmin.TabIndex = 33
        '
        'dtpDate2
        '
        Me.dtpDate2.BorderRadius = 5
        Me.dtpDate2.BorderThickness = 1
        Me.dtpDate2.Checked = True
        Me.dtpDate2.FillColor = System.Drawing.Color.SteelBlue
        Me.dtpDate2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDate2.ForeColor = System.Drawing.Color.White
        Me.dtpDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDate2.Location = New System.Drawing.Point(17, 113)
        Me.dtpDate2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDate2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDate2.Name = "dtpDate2"
        Me.dtpDate2.Size = New System.Drawing.Size(198, 47)
        Me.dtpDate2.TabIndex = 34
        Me.dtpDate2.Value = New Date(2025, 4, 28, 3, 25, 19, 103)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Date:"
        '
        'cmbStaff
        '
        Me.cmbStaff.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbStaff.BorderColor = System.Drawing.Color.Black
        Me.cmbStaff.BorderRadius = 5
        Me.cmbStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStaff.DropDownHeight = 100
        Me.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaff.FillColor = System.Drawing.Color.SteelBlue
        Me.cmbStaff.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStaff.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStaff.ForeColor = System.Drawing.Color.White
        Me.cmbStaff.IntegralHeight = False
        Me.cmbStaff.ItemHeight = 30
        Me.cmbStaff.Location = New System.Drawing.Point(15, 36)
        Me.cmbStaff.Name = "cmbStaff"
        Me.cmbStaff.Size = New System.Drawing.Size(198, 36)
        Me.cmbStaff.TabIndex = 32
        Me.cmbStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Employee:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 21)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "FILTER TABLE"
        '
        'dtpDate
        '
        Me.dtpDate.BorderRadius = 5
        Me.dtpDate.BorderThickness = 1
        Me.dtpDate.Checked = True
        Me.dtpDate.FillColor = System.Drawing.Color.SteelBlue
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDate.ForeColor = System.Drawing.Color.White
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDate.Location = New System.Drawing.Point(22, 101)
        Me.dtpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(198, 47)
        Me.dtpDate.TabIndex = 27
        Me.dtpDate.Value = New Date(2025, 4, 28, 3, 25, 19, 103)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Date:"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(295, 308)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(10, 13)
        Me.lblContact.TabIndex = 25
        Me.lblContact.Text = "."
        Me.lblContact.Visible = False
        '
        'lblSupplierName
        '
        Me.lblSupplierName.AutoSize = True
        Me.lblSupplierName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierName.Location = New System.Drawing.Point(295, 290)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(10, 13)
        Me.lblSupplierName.TabIndex = 24
        Me.lblSupplierName.Text = "."
        Me.lblSupplierName.Visible = False
        '
        'btnTotalActivity
        '
        Me.btnTotalActivity.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalActivity.BorderRadius = 5
        Me.btnTotalActivity.BorderThickness = 1
        Me.btnTotalActivity.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalActivity.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnTotalActivity.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalActivity.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnTotalActivity.FillColor = System.Drawing.Color.SteelBlue
        Me.btnTotalActivity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalActivity.ForeColor = System.Drawing.Color.White
        Me.btnTotalActivity.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalActivity.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnTotalActivity.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalActivity.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalActivity.Location = New System.Drawing.Point(22, 51)
        Me.btnTotalActivity.Name = "btnTotalActivity"
        Me.btnTotalActivity.Size = New System.Drawing.Size(198, 42)
        Me.btnTotalActivity.TabIndex = 28
        Me.btnTotalActivity.Text = "Total Activity :"
        Me.btnTotalActivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblSupplierID
        '
        Me.lblSupplierID.AutoSize = True
        Me.lblSupplierID.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierID.Location = New System.Drawing.Point(295, 272)
        Me.lblSupplierID.Name = "lblSupplierID"
        Me.lblSupplierID.Size = New System.Drawing.Size(10, 13)
        Me.lblSupplierID.TabIndex = 23
        Me.lblSupplierID.Text = "."
        Me.lblSupplierID.Visible = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoEllipsis = True
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(99, 329)
        Me.lblDescription.MaximumSize = New System.Drawing.Size(130, 16)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(0, 16)
        Me.lblDescription.TabIndex = 18
        '
        'dgvActivity
        '
        Me.dgvActivity.AllowUserToAddRows = False
        Me.dgvActivity.AllowUserToDeleteRows = False
        Me.dgvActivity.AllowUserToResizeColumns = False
        Me.dgvActivity.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvActivity.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvActivity.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActivity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvActivity.ColumnHeadersHeight = 35
        Me.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActivity.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvActivity.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvActivity.Location = New System.Drawing.Point(41, 73)
        Me.dgvActivity.Name = "dgvActivity"
        Me.dgvActivity.ReadOnly = True
        Me.dgvActivity.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActivity.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvActivity.RowHeadersVisible = False
        Me.dgvActivity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvActivity.RowTemplate.Height = 30
        Me.dgvActivity.Size = New System.Drawing.Size(461, 411)
        Me.dgvActivity.TabIndex = 22
        Me.dgvActivity.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvActivity.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvActivity.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvActivity.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvActivity.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvActivity.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvActivity.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvActivity.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray
        Me.dgvActivity.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvActivity.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvActivity.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvActivity.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvActivity.ThemeStyle.HeaderStyle.Height = 35
        Me.dgvActivity.ThemeStyle.ReadOnly = True
        Me.dgvActivity.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvActivity.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvActivity.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvActivity.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvActivity.ThemeStyle.RowsStyle.Height = 30
        Me.dgvActivity.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvActivity.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "DATA LOGS:"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me.dgvActivity
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.BorderRadius = 5
        Me.btnRefresh.BorderThickness = 1
        Me.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRefresh.FillColor = System.Drawing.Color.SteelBlue
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnRefresh.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnRefresh.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnRefresh.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(467, 30)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(35, 35)
        Me.btnRefresh.TabIndex = 33
        Me.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRefresh.TextOffset = New System.Drawing.Point(30, 0)
        '
        'DashboardActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvActivity)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardActivity"
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.pnlFilterAdmin.ResumeLayout(False)
        Me.pnlFilterAdmin.PerformLayout()
        CType(Me.dgvActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblContact As Label
    Friend WithEvents lblSupplierName As Label
    Friend WithEvents lblSupplierID As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvActivity As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents dtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnTotalActivity As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlFilterAdmin As Panel
    Friend WithEvents dtpDate2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbStaff As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnFilter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
End Class
