<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardManage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardManage))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.dgvProducts = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.rbType = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.rbProductName = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.rbProductID = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblSupplierName = New System.Windows.Forms.Label()
        Me.lblSupplierID = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picProduct = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnDeleteProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddProduct = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTotalModem = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTotalHub = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTotalRouter = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTotalCable = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTotalTelset = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTotalTelpad = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbMonths = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnFilter = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlManage = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button12 = New Guna.UI2.WinForms.Guna2Button()
        Me.ToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        Me.pnlManage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me.dgvProducts
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AllowUserToResizeColumns = False
        Me.dgvProducts.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProducts.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProducts.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducts.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProducts.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProducts.Location = New System.Drawing.Point(41, 299)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProducts.RowTemplate.Height = 30
        Me.dgvProducts.Size = New System.Drawing.Size(487, 204)
        Me.dgvProducts.TabIndex = 21
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvProducts.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray
        Me.dgvProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProducts.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProducts.ThemeStyle.HeaderStyle.Height = 35
        Me.dgvProducts.ThemeStyle.ReadOnly = True
        Me.dgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProducts.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvProducts.ThemeStyle.RowsStyle.Height = 30
        Me.dgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ANALYTICS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "TABLE DETAILS: "
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Label16)
        Me.Guna2Panel1.Controls.Add(Me.Label15)
        Me.Guna2Panel1.Controls.Add(Me.rbType)
        Me.Guna2Panel1.Controls.Add(Me.rbProductName)
        Me.Guna2Panel1.Controls.Add(Me.rbProductID)
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
        Me.Label16.Size = New System.Drawing.Size(35, 17)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(236, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 17)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Name"
        '
        'rbType
        '
        Me.rbType.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.rbType.CheckedState.BorderRadius = 2
        Me.rbType.CheckedState.BorderThickness = 1
        Me.rbType.CheckedState.FillColor = System.Drawing.Color.Black
        Me.rbType.Location = New System.Drawing.Point(336, 10)
        Me.rbType.Name = "rbType"
        Me.rbType.Size = New System.Drawing.Size(20, 20)
        Me.rbType.TabIndex = 5
        Me.rbType.Text = "Guna2CustomCheckBox3"
        Me.rbType.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rbType.UncheckedState.BorderRadius = 2
        Me.rbType.UncheckedState.BorderThickness = 1
        Me.rbType.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'rbProductName
        '
        Me.rbProductName.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.rbProductName.CheckedState.BorderRadius = 2
        Me.rbProductName.CheckedState.BorderThickness = 1
        Me.rbProductName.CheckedState.FillColor = System.Drawing.Color.Black
        Me.rbProductName.Location = New System.Drawing.Point(205, 10)
        Me.rbProductName.Name = "rbProductName"
        Me.rbProductName.Size = New System.Drawing.Size(20, 20)
        Me.rbProductName.TabIndex = 4
        Me.rbProductName.Text = "Guna2CustomCheckBox2"
        Me.rbProductName.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rbProductName.UncheckedState.BorderRadius = 2
        Me.rbProductName.UncheckedState.BorderThickness = 1
        Me.rbProductName.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'rbProductID
        '
        Me.rbProductID.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.rbProductID.CheckedState.BorderRadius = 2
        Me.rbProductID.CheckedState.BorderThickness = 1
        Me.rbProductID.CheckedState.FillColor = System.Drawing.Color.Black
        Me.rbProductID.Location = New System.Drawing.Point(71, 10)
        Me.rbProductID.Name = "rbProductID"
        Me.rbProductID.Size = New System.Drawing.Size(20, 20)
        Me.rbProductID.TabIndex = 3
        Me.rbProductID.Text = "Guna2CustomCheckBox1"
        Me.rbProductID.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.rbProductID.UncheckedState.BorderRadius = 2
        Me.rbProductID.UncheckedState.BorderThickness = 1
        Me.rbProductID.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(108, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Product ID"
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
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.lblAddress)
        Me.Guna2Panel3.Controls.Add(Me.lblContact)
        Me.Guna2Panel3.Controls.Add(Me.lblSupplierName)
        Me.Guna2Panel3.Controls.Add(Me.lblSupplierID)
        Me.Guna2Panel3.Controls.Add(Me.Label19)
        Me.Guna2Panel3.Controls.Add(Me.Label20)
        Me.Guna2Panel3.Controls.Add(Me.Label21)
        Me.Guna2Panel3.Controls.Add(Me.Label22)
        Me.Guna2Panel3.Controls.Add(Me.lblDescription)
        Me.Guna2Panel3.Controls.Add(Me.lblPrice)
        Me.Guna2Panel3.Controls.Add(Me.lblQuantity)
        Me.Guna2Panel3.Controls.Add(Me.lblType)
        Me.Guna2Panel3.Controls.Add(Me.lblName)
        Me.Guna2Panel3.Controls.Add(Me.lblBarcode)
        Me.Guna2Panel3.Controls.Add(Me.lblProductID)
        Me.Guna2Panel3.Controls.Add(Me.lblDate)
        Me.Guna2Panel3.Controls.Add(Me.Label10)
        Me.Guna2Panel3.Controls.Add(Me.Label9)
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.Controls.Add(Me.Label7)
        Me.Guna2Panel3.Controls.Add(Me.Label6)
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Controls.Add(Me.picProduct)
        Me.Guna2Panel3.Controls.Add(Me.Label4)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel3.Location = New System.Drawing.Point(548, 27)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(238, 476)
        Me.Guna2Panel3.TabIndex = 16
        '
        'lblAddress
        '
        Me.lblAddress.AutoEllipsis = True
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(295, 326)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(10, 13)
        Me.lblAddress.TabIndex = 26
        Me.lblAddress.Text = "."
        Me.lblAddress.Visible = False
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(226, 326)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Address:"
        Me.Label19.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(226, 308)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Contact: "
        Me.Label20.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(226, 290)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 13)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Name: "
        Me.Label21.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(226, 272)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 13)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Supplier ID:"
        Me.Label22.Visible = False
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
        'lblPrice
        '
        Me.lblPrice.AutoEllipsis = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(61, 303)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(156, 16)
        Me.lblPrice.TabIndex = 17
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoEllipsis = True
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(85, 272)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(132, 16)
        Me.lblQuantity.TabIndex = 16
        '
        'lblType
        '
        Me.lblType.AutoEllipsis = True
        Me.lblType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(68, 241)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(149, 16)
        Me.lblType.TabIndex = 15
        '
        'lblName
        '
        Me.lblName.AutoEllipsis = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(68, 209)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(149, 16)
        Me.lblName.TabIndex = 14
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoEllipsis = True
        Me.lblBarcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarcode.Location = New System.Drawing.Point(82, 149)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(135, 16)
        Me.lblBarcode.TabIndex = 13
        '
        'lblProductID
        '
        Me.lblProductID.AutoEllipsis = True
        Me.lblProductID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.Location = New System.Drawing.Point(99, 179)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(118, 16)
        Me.lblProductID.TabIndex = 12
        '
        'lblDate
        '
        Me.lblDate.AutoEllipsis = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(61, 121)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(156, 16)
        Me.lblDate.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Description:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Price:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Barcode:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Product ID:"
        '
        'picProduct
        '
        Me.picProduct.BackColor = System.Drawing.Color.Transparent
        Me.picProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picProduct.BorderRadius = 5
        Me.picProduct.FillColor = System.Drawing.Color.Silver
        Me.picProduct.ImageRotate = 0!
        Me.picProduct.Location = New System.Drawing.Point(17, 11)
        Me.picProduct.Name = "picProduct"
        Me.picProduct.Size = New System.Drawing.Size(200, 98)
        Me.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProduct.TabIndex = 3
        Me.picProduct.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Date:"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel4.BorderRadius = 5
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.btnDeleteProduct)
        Me.Guna2Panel4.Controls.Add(Me.btnEditProduct)
        Me.Guna2Panel4.Controls.Add(Me.btnAddProduct)
        Me.Guna2Panel4.CustomizableEdges.TopLeft = False
        Me.Guna2Panel4.CustomizableEdges.TopRight = False
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 349)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(238, 127)
        Me.Guna2Panel4.TabIndex = 0
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteProduct.BorderRadius = 5
        Me.btnDeleteProduct.BorderThickness = 1
        Me.btnDeleteProduct.CustomizableEdges.TopLeft = False
        Me.btnDeleteProduct.CustomizableEdges.TopRight = False
        Me.btnDeleteProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDeleteProduct.FillColor = System.Drawing.Color.SteelBlue
        Me.btnDeleteProduct.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteProduct.ForeColor = System.Drawing.Color.White
        Me.btnDeleteProduct.Location = New System.Drawing.Point(0, 84)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(238, 42)
        Me.btnDeleteProduct.TabIndex = 25
        Me.btnDeleteProduct.Text = "DELETE"
        '
        'btnEditProduct
        '
        Me.btnEditProduct.BackColor = System.Drawing.Color.Transparent
        Me.btnEditProduct.BorderThickness = 1
        Me.btnEditProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditProduct.FillColor = System.Drawing.Color.SteelBlue
        Me.btnEditProduct.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditProduct.ForeColor = System.Drawing.Color.White
        Me.btnEditProduct.Location = New System.Drawing.Point(0, 42)
        Me.btnEditProduct.Name = "btnEditProduct"
        Me.btnEditProduct.Size = New System.Drawing.Size(238, 42)
        Me.btnEditProduct.TabIndex = 24
        Me.btnEditProduct.Text = "EDIT"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.BackColor = System.Drawing.Color.Transparent
        Me.btnAddProduct.BorderThickness = 1
        Me.btnAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddProduct.FillColor = System.Drawing.Color.SteelBlue
        Me.btnAddProduct.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.ForeColor = System.Drawing.Color.White
        Me.btnAddProduct.Location = New System.Drawing.Point(0, 0)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(238, 42)
        Me.btnAddProduct.TabIndex = 23
        Me.btnAddProduct.Text = "ADD"
        '
        'btnTotalModem
        '
        Me.btnTotalModem.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalModem.BorderRadius = 5
        Me.btnTotalModem.BorderThickness = 1
        Me.btnTotalModem.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalModem.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnTotalModem.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalModem.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnTotalModem.FillColor = System.Drawing.Color.Gray
        Me.btnTotalModem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalModem.ForeColor = System.Drawing.Color.White
        Me.btnTotalModem.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalModem.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnTotalModem.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnTotalModem.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalModem.Location = New System.Drawing.Point(41, 148)
        Me.btnTotalModem.Name = "btnTotalModem"
        Me.btnTotalModem.Size = New System.Drawing.Size(157, 42)
        Me.btnTotalModem.TabIndex = 18
        Me.btnTotalModem.Text = "Total Modem: "
        Me.btnTotalModem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnTotalHub
        '
        Me.btnTotalHub.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalHub.BorderRadius = 5
        Me.btnTotalHub.BorderThickness = 1
        Me.btnTotalHub.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalHub.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnTotalHub.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalHub.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnTotalHub.FillColor = System.Drawing.Color.Gray
        Me.btnTotalHub.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalHub.ForeColor = System.Drawing.Color.White
        Me.btnTotalHub.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalHub.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnTotalHub.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnTotalHub.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalHub.Location = New System.Drawing.Point(204, 150)
        Me.btnTotalHub.Name = "btnTotalHub"
        Me.btnTotalHub.Size = New System.Drawing.Size(157, 45)
        Me.btnTotalHub.TabIndex = 19
        Me.btnTotalHub.Text = "Total Hub: "
        Me.btnTotalHub.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnTotalRouter
        '
        Me.btnTotalRouter.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalRouter.BorderRadius = 5
        Me.btnTotalRouter.BorderThickness = 1
        Me.btnTotalRouter.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalRouter.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnTotalRouter.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalRouter.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnTotalRouter.FillColor = System.Drawing.Color.Gray
        Me.btnTotalRouter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalRouter.ForeColor = System.Drawing.Color.White
        Me.btnTotalRouter.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalRouter.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnTotalRouter.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnTotalRouter.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalRouter.Location = New System.Drawing.Point(367, 148)
        Me.btnTotalRouter.Name = "btnTotalRouter"
        Me.btnTotalRouter.Size = New System.Drawing.Size(157, 45)
        Me.btnTotalRouter.TabIndex = 20
        Me.btnTotalRouter.Text = "Total Router: "
        Me.btnTotalRouter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnTotalCable
        '
        Me.btnTotalCable.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalCable.BorderRadius = 5
        Me.btnTotalCable.BorderThickness = 1
        Me.btnTotalCable.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalCable.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnTotalCable.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalCable.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnTotalCable.FillColor = System.Drawing.Color.Gray
        Me.btnTotalCable.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalCable.ForeColor = System.Drawing.Color.White
        Me.btnTotalCable.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalCable.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnTotalCable.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnTotalCable.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalCable.Location = New System.Drawing.Point(41, 196)
        Me.btnTotalCable.Name = "btnTotalCable"
        Me.btnTotalCable.Size = New System.Drawing.Size(157, 42)
        Me.btnTotalCable.TabIndex = 22
        Me.btnTotalCable.Text = "Total Cable: "
        Me.btnTotalCable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnTotalTelset
        '
        Me.btnTotalTelset.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalTelset.BorderRadius = 5
        Me.btnTotalTelset.BorderThickness = 1
        Me.btnTotalTelset.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalTelset.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnTotalTelset.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalTelset.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnTotalTelset.FillColor = System.Drawing.Color.Gray
        Me.btnTotalTelset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalTelset.ForeColor = System.Drawing.Color.White
        Me.btnTotalTelset.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalTelset.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnTotalTelset.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnTotalTelset.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalTelset.Location = New System.Drawing.Point(204, 199)
        Me.btnTotalTelset.Name = "btnTotalTelset"
        Me.btnTotalTelset.Size = New System.Drawing.Size(157, 42)
        Me.btnTotalTelset.TabIndex = 23
        Me.btnTotalTelset.Text = "Total Telset: "
        Me.btnTotalTelset.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnTotalTelpad
        '
        Me.btnTotalTelpad.BackColor = System.Drawing.Color.Transparent
        Me.btnTotalTelpad.BorderRadius = 5
        Me.btnTotalTelpad.BorderThickness = 1
        Me.btnTotalTelpad.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalTelpad.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnTotalTelpad.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnTotalTelpad.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnTotalTelpad.FillColor = System.Drawing.Color.Gray
        Me.btnTotalTelpad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTotalTelpad.ForeColor = System.Drawing.Color.White
        Me.btnTotalTelpad.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnTotalTelpad.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnTotalTelpad.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnTotalTelpad.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnTotalTelpad.Location = New System.Drawing.Point(367, 199)
        Me.btnTotalTelpad.Name = "btnTotalTelpad"
        Me.btnTotalTelpad.Size = New System.Drawing.Size(157, 42)
        Me.btnTotalTelpad.TabIndex = 24
        Me.btnTotalTelpad.Text = "Total Telpad: "
        Me.btnTotalTelpad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cmbMonths
        '
        Me.cmbMonths.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbMonths.BorderColor = System.Drawing.Color.Black
        Me.cmbMonths.BorderRadius = 5
        Me.cmbMonths.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMonths.DropDownHeight = 100
        Me.cmbMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonths.FillColor = System.Drawing.Color.SteelBlue
        Me.cmbMonths.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMonths.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMonths.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMonths.ForeColor = System.Drawing.Color.White
        Me.cmbMonths.IntegralHeight = False
        Me.cmbMonths.ItemHeight = 30
        Me.cmbMonths.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.cmbMonths.Location = New System.Drawing.Point(213, 256)
        Me.cmbMonths.Name = "cmbMonths"
        Me.cmbMonths.Size = New System.Drawing.Size(157, 36)
        Me.cmbMonths.StartIndex = 0
        Me.cmbMonths.TabIndex = 26
        Me.cmbMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.Transparent
        Me.btnFilter.BorderRadius = 5
        Me.btnFilter.BorderThickness = 1
        Me.btnFilter.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnFilter.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnFilter.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnFilter.FillColor = System.Drawing.Color.SteelBlue
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFilter.ForeColor = System.Drawing.Color.White
        Me.btnFilter.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnFilter.HoverState.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnFilter.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnFilter.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnFilter.Location = New System.Drawing.Point(376, 256)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(107, 36)
        Me.btnFilter.TabIndex = 27
        Me.btnFilter.Text = "FILTER"
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
        Me.Guna2Button1.Location = New System.Drawing.Point(489, 256)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(35, 35)
        Me.Guna2Button1.TabIndex = 28
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(30, 0)
        '
        'pnlManage
        '
        Me.pnlManage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlManage.BorderColor = System.Drawing.Color.Black
        Me.pnlManage.BorderRadius = 5
        Me.pnlManage.BorderThickness = 1
        Me.pnlManage.Controls.Add(Me.Guna2Button1)
        Me.pnlManage.Controls.Add(Me.btnFilter)
        Me.pnlManage.Controls.Add(Me.cmbMonths)
        Me.pnlManage.Controls.Add(Me.btnTotalTelpad)
        Me.pnlManage.Controls.Add(Me.btnTotalTelset)
        Me.pnlManage.Controls.Add(Me.btnTotalCable)
        Me.pnlManage.Controls.Add(Me.dgvProducts)
        Me.pnlManage.Controls.Add(Me.btnTotalRouter)
        Me.pnlManage.Controls.Add(Me.btnTotalHub)
        Me.pnlManage.Controls.Add(Me.btnTotalModem)
        Me.pnlManage.Controls.Add(Me.Guna2Panel3)
        Me.pnlManage.Controls.Add(Me.btnSearch)
        Me.pnlManage.Controls.Add(Me.txtSearch)
        Me.pnlManage.Controls.Add(Me.Guna2Panel1)
        Me.pnlManage.Controls.Add(Me.Label2)
        Me.pnlManage.Controls.Add(Me.Guna2Button12)
        Me.pnlManage.Controls.Add(Me.Label3)
        Me.pnlManage.CustomizableEdges.BottomLeft = False
        Me.pnlManage.CustomizableEdges.TopLeft = False
        Me.pnlManage.CustomizableEdges.TopRight = False
        Me.pnlManage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlManage.Location = New System.Drawing.Point(0, 0)
        Me.pnlManage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlManage.Name = "pnlManage"
        Me.pnlManage.Size = New System.Drawing.Size(800, 530)
        Me.pnlManage.TabIndex = 2
        '
        'Guna2Button12
        '
        Me.Guna2Button12.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button12.ForeColor = System.Drawing.Color.White
        Me.Guna2Button12.Location = New System.Drawing.Point(41, 116)
        Me.Guna2Button12.Name = "Guna2Button12"
        Me.Guna2Button12.Size = New System.Drawing.Size(10, 0)
        Me.Guna2Button12.TabIndex = 4
        Me.Guna2Button12.Text = "Guna2Button12"
        '
        'ToolTip1
        '
        Me.ToolTip1.AllowLinksHandling = True
        Me.ToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'DashboardManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.pnlManage)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardManage"
        Me.Text = "DashboardManage"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.picProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.pnlManage.ResumeLayout(False)
        Me.pnlManage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents dgvProducts As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents pnlManage As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFilter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbMonths As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnTotalTelpad As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTotalTelset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTotalCable As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTotalRouter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTotalHub As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTotalModem As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblSupplierName As Label
    Friend WithEvents lblSupplierID As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblBarcode As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picProduct As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnDeleteProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddProduct As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents rbType As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents rbProductName As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents rbProductID As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button12 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
