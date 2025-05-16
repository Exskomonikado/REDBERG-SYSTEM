<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardSettings
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlSettings = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTime = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbToggle = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpload = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvSettings = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnRestore = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBackUp = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlSettings.SuspendLayout()
        CType(Me.dgvSettings, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pnlSettings
        '
        Me.pnlSettings.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSettings.BorderColor = System.Drawing.Color.Black
        Me.pnlSettings.BorderRadius = 5
        Me.pnlSettings.BorderThickness = 1
        Me.pnlSettings.Controls.Add(Me.Label4)
        Me.pnlSettings.Controls.Add(Me.Label1)
        Me.pnlSettings.Controls.Add(Me.cmbTime)
        Me.pnlSettings.Controls.Add(Me.Label8)
        Me.pnlSettings.Controls.Add(Me.cmbToggle)
        Me.pnlSettings.Controls.Add(Me.btnSave)
        Me.pnlSettings.Controls.Add(Me.btnUpload)
        Me.pnlSettings.Controls.Add(Me.Label9)
        Me.pnlSettings.Controls.Add(Me.dgvSettings)
        Me.pnlSettings.Controls.Add(Me.btnRestore)
        Me.pnlSettings.Controls.Add(Me.btnBackUp)
        Me.pnlSettings.Controls.Add(Me.Label2)
        Me.pnlSettings.Controls.Add(Me.Label3)
        Me.pnlSettings.CustomizableEdges.BottomLeft = False
        Me.pnlSettings.CustomizableEdges.TopLeft = False
        Me.pnlSettings.CustomizableEdges.TopRight = False
        Me.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSettings.Location = New System.Drawing.Point(0, 0)
        Me.pnlSettings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(800, 530)
        Me.pnlSettings.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(457, 524)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Label4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(298, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Time"
        '
        'cmbTime
        '
        Me.cmbTime.BackColor = System.Drawing.Color.Transparent
        Me.cmbTime.BorderColor = System.Drawing.Color.Black
        Me.cmbTime.BorderRadius = 5
        Me.cmbTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTime.DropDownHeight = 100
        Me.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTime.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTime.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbTime.ForeColor = System.Drawing.Color.Black
        Me.cmbTime.IntegralHeight = False
        Me.cmbTime.ItemHeight = 30
        Me.cmbTime.Items.AddRange(New Object() {"12 PM ", "1 PM", "2 PM", "3 PM", "4 PM", "5 PM", "6 PM"})
        Me.cmbTime.Location = New System.Drawing.Point(285, 65)
        Me.cmbTime.Name = "cmbTime"
        Me.cmbTime.Size = New System.Drawing.Size(238, 36)
        Me.cmbTime.StartIndex = 0
        Me.cmbTime.TabIndex = 27
        Me.cmbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(54, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Toggled"
        '
        'cmbToggle
        '
        Me.cmbToggle.BackColor = System.Drawing.Color.Transparent
        Me.cmbToggle.BorderColor = System.Drawing.Color.Black
        Me.cmbToggle.BorderRadius = 5
        Me.cmbToggle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbToggle.DropDownHeight = 100
        Me.cmbToggle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbToggle.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbToggle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbToggle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbToggle.ForeColor = System.Drawing.Color.Black
        Me.cmbToggle.IntegralHeight = False
        Me.cmbToggle.ItemHeight = 30
        Me.cmbToggle.Location = New System.Drawing.Point(41, 65)
        Me.cmbToggle.Name = "cmbToggle"
        Me.cmbToggle.Size = New System.Drawing.Size(238, 36)
        Me.cmbToggle.StartIndex = 0
        Me.cmbToggle.TabIndex = 25
        Me.cmbToggle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 5
        Me.btnSave.BorderThickness = 1
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnSave.FillColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnSave.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnSave.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnSave.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(529, 65)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(238, 36)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "SAVE"
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.Transparent
        Me.btnUpload.BorderRadius = 5
        Me.btnUpload.BorderThickness = 1
        Me.btnUpload.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnUpload.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnUpload.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnUpload.FillColor = System.Drawing.Color.SteelBlue
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnUpload.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnUpload.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnUpload.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(529, 148)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(238, 42)
        Me.btnUpload.TabIndex = 23
        Me.btnUpload.Text = "UPLOAD"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 21)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "MANAGE BACKUP"
        '
        'dgvSettings
        '
        Me.dgvSettings.AllowUserToAddRows = False
        Me.dgvSettings.AllowUserToDeleteRows = False
        Me.dgvSettings.AllowUserToResizeColumns = False
        Me.dgvSettings.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSettings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSettings.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSettings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSettings.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSettings.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSettings.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSettings.Location = New System.Drawing.Point(41, 257)
        Me.dgvSettings.Name = "dgvSettings"
        Me.dgvSettings.ReadOnly = True
        Me.dgvSettings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSettings.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSettings.RowHeadersVisible = False
        Me.dgvSettings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSettings.RowTemplate.Height = 30
        Me.dgvSettings.Size = New System.Drawing.Size(726, 246)
        Me.dgvSettings.TabIndex = 21
        Me.dgvSettings.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSettings.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSettings.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvSettings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSettings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSettings.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgvSettings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSettings.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray
        Me.dgvSettings.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSettings.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSettings.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSettings.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSettings.ThemeStyle.HeaderStyle.Height = 35
        Me.dgvSettings.ThemeStyle.ReadOnly = True
        Me.dgvSettings.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSettings.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSettings.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSettings.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvSettings.ThemeStyle.RowsStyle.Height = 30
        Me.dgvSettings.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSettings.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.Color.Transparent
        Me.btnRestore.BorderRadius = 5
        Me.btnRestore.BorderThickness = 1
        Me.btnRestore.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnRestore.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnRestore.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnRestore.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnRestore.FillColor = System.Drawing.Color.SteelBlue
        Me.btnRestore.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRestore.ForeColor = System.Drawing.Color.White
        Me.btnRestore.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnRestore.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnRestore.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnRestore.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnRestore.Location = New System.Drawing.Point(285, 148)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(238, 42)
        Me.btnRestore.TabIndex = 19
        Me.btnRestore.Text = "RESTORE"
        '
        'btnBackUp
        '
        Me.btnBackUp.BackColor = System.Drawing.Color.Transparent
        Me.btnBackUp.BorderRadius = 5
        Me.btnBackUp.BorderThickness = 1
        Me.btnBackUp.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.btnBackUp.DisabledState.CustomBorderColor = System.Drawing.Color.Gray
        Me.btnBackUp.DisabledState.FillColor = System.Drawing.Color.Gray
        Me.btnBackUp.DisabledState.ForeColor = System.Drawing.Color.White
        Me.btnBackUp.FillColor = System.Drawing.Color.SteelBlue
        Me.btnBackUp.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBackUp.ForeColor = System.Drawing.Color.White
        Me.btnBackUp.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnBackUp.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnBackUp.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnBackUp.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnBackUp.Location = New System.Drawing.Point(41, 148)
        Me.btnBackUp.Name = "btnBackUp"
        Me.btnBackUp.Size = New System.Drawing.Size(238, 42)
        Me.btnBackUp.TabIndex = 18
        Me.btnBackUp.Text = "BACK UP"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "OPTION BUTTONS"
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 5
        Me.Guna2Elipse2.TargetControl = Me.dgvSettings
        '
        'DashboardSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.pnlSettings)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardSettings"
        Me.Text = "DashboardSettings"
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        CType(Me.dgvSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlSettings As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvSettings As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnRestore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBackUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTime As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbToggle As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
End Class
