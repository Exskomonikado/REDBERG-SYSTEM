<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageAdd))
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.pnlAdd = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbSupplierID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSupplierName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBarcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProductName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProductID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.pnlAdd.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_ACTIVATE
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'pnlAdd
        '
        Me.pnlAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlAdd.BorderColor = System.Drawing.Color.Black
        Me.pnlAdd.BorderRadius = 5
        Me.pnlAdd.BorderThickness = 1
        Me.pnlAdd.Controls.Add(Me.Guna2Panel6)
        Me.pnlAdd.Controls.Add(Me.Guna2Panel5)
        Me.pnlAdd.Controls.Add(Me.Guna2Panel4)
        Me.pnlAdd.Controls.Add(Me.Guna2Panel3)
        Me.pnlAdd.Controls.Add(Me.Guna2Panel2)
        Me.pnlAdd.Location = New System.Drawing.Point(13, 12)
        Me.pnlAdd.Name = "pnlAdd"
        Me.pnlAdd.Size = New System.Drawing.Size(425, 576)
        Me.pnlAdd.TabIndex = 1
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Controls.Add(Me.btnCancel)
        Me.Guna2Panel6.Controls.Add(Me.btnSave)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel6.Location = New System.Drawing.Point(0, 531)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(425, 45)
        Me.Guna2Panel6.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 5
        Me.btnCancel.BorderThickness = 1
        Me.btnCancel.CustomizableEdges.BottomLeft = False
        Me.btnCancel.CustomizableEdges.TopLeft = False
        Me.btnCancel.CustomizableEdges.TopRight = False
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FillColor = System.Drawing.Color.Firebrick
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnCancel.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnCancel.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(215, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(210, 45)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 5
        Me.btnSave.BorderThickness = 1
        Me.btnSave.CustomizableEdges.BottomRight = False
        Me.btnSave.CustomizableEdges.TopLeft = False
        Me.btnSave.CustomizableEdges.TopRight = False
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.FillColor = System.Drawing.Color.SeaGreen
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnSave.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnSave.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnSave.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(209, 45)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Controls.Add(Me.Label5)
        Me.Guna2Panel5.Controls.Add(Me.txtAddress)
        Me.Guna2Panel5.Controls.Add(Me.cmbSupplierID)
        Me.Guna2Panel5.Controls.Add(Me.txtSupplierName)
        Me.Guna2Panel5.Controls.Add(Me.txtContact)
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 413)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(425, 118)
        Me.Guna2Panel5.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(13, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Supplier ID"
        '
        'txtAddress
        '
        Me.txtAddress.BorderColor = System.Drawing.Color.Black
        Me.txtAddress.BorderRadius = 5
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.Enabled = False
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(215, 64)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress.PlaceholderText = "Address"
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(205, 41)
        Me.txtAddress.TabIndex = 15
        '
        'cmbSupplierID
        '
        Me.cmbSupplierID.BackColor = System.Drawing.Color.Transparent
        Me.cmbSupplierID.BorderColor = System.Drawing.Color.Black
        Me.cmbSupplierID.BorderRadius = 5
        Me.cmbSupplierID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSupplierID.DropDownHeight = 100
        Me.cmbSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplierID.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSupplierID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSupplierID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSupplierID.ForeColor = System.Drawing.Color.Black
        Me.cmbSupplierID.IntegralHeight = False
        Me.cmbSupplierID.ItemHeight = 30
        Me.cmbSupplierID.Location = New System.Drawing.Point(4, 22)
        Me.cmbSupplierID.Name = "cmbSupplierID"
        Me.cmbSupplierID.Size = New System.Drawing.Size(205, 36)
        Me.cmbSupplierID.TabIndex = 14
        Me.cmbSupplierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSupplierName
        '
        Me.txtSupplierName.BorderColor = System.Drawing.Color.Black
        Me.txtSupplierName.BorderRadius = 5
        Me.txtSupplierName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSupplierName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupplierName.DefaultText = ""
        Me.txtSupplierName.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.txtSupplierName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSupplierName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupplierName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSupplierName.Enabled = False
        Me.txtSupplierName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupplierName.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtSupplierName.ForeColor = System.Drawing.Color.Black
        Me.txtSupplierName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSupplierName.Location = New System.Drawing.Point(4, 64)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSupplierName.PlaceholderText = "Supplier Name"
        Me.txtSupplierName.SelectedText = ""
        Me.txtSupplierName.Size = New System.Drawing.Size(205, 41)
        Me.txtSupplierName.TabIndex = 13
        '
        'txtContact
        '
        Me.txtContact.BorderColor = System.Drawing.Color.Black
        Me.txtContact.BorderRadius = 5
        Me.txtContact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContact.DefaultText = ""
        Me.txtContact.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContact.Enabled = False
        Me.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtContact.ForeColor = System.Drawing.Color.Black
        Me.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContact.Location = New System.Drawing.Point(215, 17)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContact.PlaceholderText = "Contact"
        Me.txtContact.SelectedText = ""
        Me.txtContact.Size = New System.Drawing.Size(205, 41)
        Me.txtContact.TabIndex = 12
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel4.BorderThickness = 1
        Me.Guna2Panel4.Controls.Add(Me.txtDescription)
        Me.Guna2Panel4.Controls.Add(Me.Label4)
        Me.Guna2Panel4.Controls.Add(Me.dtpDate)
        Me.Guna2Panel4.Controls.Add(Me.Label3)
        Me.Guna2Panel4.Controls.Add(Me.txtBarcode)
        Me.Guna2Panel4.Controls.Add(Me.cmbType)
        Me.Guna2Panel4.Controls.Add(Me.txtPrice)
        Me.Guna2Panel4.Controls.Add(Me.txtQuantity)
        Me.Guna2Panel4.Controls.Add(Me.txtProductName)
        Me.Guna2Panel4.Controls.Add(Me.txtProductID)
        Me.Guna2Panel4.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 207)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(425, 206)
        Me.Guna2Panel4.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.BorderColor = System.Drawing.Color.Black
        Me.txtDescription.BorderRadius = 5
        Me.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(215, 151)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDescription.PlaceholderText = "Description"
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.Size = New System.Drawing.Size(205, 41)
        Me.txtDescription.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(13, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.BorderRadius = 5
        Me.dtpDate.BorderThickness = 1
        Me.dtpDate.Checked = True
        Me.dtpDate.FillColor = System.Drawing.Color.White
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDate.Location = New System.Drawing.Point(4, 16)
        Me.dtpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(205, 36)
        Me.dtpDate.TabIndex = 9
        Me.dtpDate.Value = New Date(2025, 3, 17, 22, 13, 46, 911)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(228, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Type"
        '
        'txtBarcode
        '
        Me.txtBarcode.BorderColor = System.Drawing.Color.Black
        Me.txtBarcode.BorderRadius = 5
        Me.txtBarcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBarcode.DefaultText = ""
        Me.txtBarcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBarcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBarcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBarcode.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtBarcode.ForeColor = System.Drawing.Color.Black
        Me.txtBarcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBarcode.Location = New System.Drawing.Point(215, 105)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBarcode.PlaceholderText = "Barcode"
        Me.txtBarcode.SelectedText = ""
        Me.txtBarcode.Size = New System.Drawing.Size(205, 41)
        Me.txtBarcode.TabIndex = 8
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.Transparent
        Me.cmbType.BorderColor = System.Drawing.Color.Black
        Me.cmbType.BorderRadius = 5
        Me.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbType.DropDownHeight = 100
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbType.ForeColor = System.Drawing.Color.Black
        Me.cmbType.IntegralHeight = False
        Me.cmbType.ItemHeight = 30
        Me.cmbType.Items.AddRange(New Object() {"MODEM", "HUB", "ROUTER", "CABLE", "TELSET", "TELPAD"})
        Me.cmbType.Location = New System.Drawing.Point(215, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(205, 36)
        Me.cmbType.StartIndex = 0
        Me.cmbType.TabIndex = 6
        Me.cmbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrice
        '
        Me.txtPrice.BorderColor = System.Drawing.Color.Black
        Me.txtPrice.BorderRadius = 5
        Me.txtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(215, 58)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPrice.PlaceholderText = "Price"
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.Size = New System.Drawing.Size(205, 41)
        Me.txtPrice.TabIndex = 5
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderColor = System.Drawing.Color.Black
        Me.txtQuantity.BorderRadius = 5
        Me.txtQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantity.DefaultText = ""
        Me.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuantity.Location = New System.Drawing.Point(4, 151)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtQuantity.PlaceholderText = "Quantity"
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.Size = New System.Drawing.Size(205, 41)
        Me.txtQuantity.TabIndex = 4
        '
        'txtProductName
        '
        Me.txtProductName.BorderColor = System.Drawing.Color.Black
        Me.txtProductName.BorderRadius = 5
        Me.txtProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductName.DefaultText = ""
        Me.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductName.Location = New System.Drawing.Point(4, 104)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtProductName.PlaceholderText = "Product Name"
        Me.txtProductName.SelectedText = ""
        Me.txtProductName.Size = New System.Drawing.Size(205, 41)
        Me.txtProductName.TabIndex = 3
        '
        'txtProductID
        '
        Me.txtProductID.BorderColor = System.Drawing.Color.Black
        Me.txtProductID.BorderRadius = 5
        Me.txtProductID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductID.DefaultText = ""
        Me.txtProductID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductID.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtProductID.ForeColor = System.Drawing.Color.Black
        Me.txtProductID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductID.Location = New System.Drawing.Point(4, 57)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtProductID.PlaceholderText = "Product ID"
        Me.txtProductID.SelectedText = ""
        Me.txtProductID.Size = New System.Drawing.Size(205, 41)
        Me.txtProductID.TabIndex = 2
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.btnSubmit)
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 55)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(425, 152)
        Me.Guna2Panel3.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BorderThickness = 1
        Me.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubmit.FillColor = System.Drawing.Color.SteelBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnSubmit.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnSubmit.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnSubmit.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(0, 108)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(425, 45)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "Add Photo"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Silver
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(425, 108)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel2.CustomizableEdges.BottomRight = False
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(425, 55)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(141, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PATH: MANAGE/ ADD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD PRODUCT"
        '
        'ToolTip1
        '
        Me.ToolTip1.AllowLinksHandling = True
        Me.ToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        '
        'ManageAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(450, 600)
        Me.Controls.Add(Me.pnlAdd)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ManageAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageAdd"
        Me.pnlAdd.ResumeLayout(False)
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents pnlAdd As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbSupplierID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSupplierName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBarcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProductName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProductID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
