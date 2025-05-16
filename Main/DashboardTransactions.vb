Imports MySql.Data.MySqlClient
Public Class DashboardTransactions
    Private parent As Dashboard
    Private empId As String
    Private empName As String

    ' Constructor to receive values
    Public Sub New(parentForm As Dashboard, empId As String, empName As String)
        InitializeComponent()
        Me.parent = parentForm
        Me.empId = empId
        Me.empName = empName
    End Sub

    Private Sub DashboardTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbtable.Items.Clear()
        cmbtable.Items.Add("INBOUND")
        cmbtable.Items.Add("SUPPLIERS")
        cmbtable.SelectedIndex = 0 ' Default to INBOUND

        LoadIntransacData()
        UpdateButtonCounts()

        LoadIntransacData()
        UpdateButtonCounts()

        ToolTip1.SetToolTip(txtSearch, "Click to search")
        ToolTip1.SetToolTip(btnShow, "To outbound form")

    End Sub
    Private Sub LoadIntransacData()
        Dim query As String

        ' Check if the user is ADMIN or STAFF
        If parent.EmployeeType = "ADMIN" Then
            ' Admin can see all data
            query = "SELECT date, transaction_id, employee_id, employee_name, supplier_id, supplier_name, product_id, product_name, quantity FROM intransac"
        ElseIf parent.EmployeeType = "STAFF" Then
            ' Staff can only see their own data
            query = "SELECT date, transaction_id, employee_id, employee_name, supplier_id, supplier_name, product_id, product_name, quantity FROM intransac WHERE employee_id = @empId"
        Else
            ' Default case (no data)
            dgvTransact.DataSource = Nothing
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameter for STAFF users
                If parent.EmployeeType = "STAFF" Then
                    cmd.Parameters.AddWithValue("@empId", empId)
                End If

                Try
                    conn.Open()
                    Dim dt As New DataTable()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    ' Set the DataSource of the DataGridView
                    dgvTransact.DataSource = dt

                    ' Format the DataGridView
                    FormatDataGridView()
                Catch ex As Exception
                    MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
    Private Sub FormatDataGridView()
        ' Set the column headers to uppercase and remove underlines
        For Each column As DataGridViewColumn In dgvTransact.Columns
            column.HeaderText = column.HeaderText.ToUpper().Replace("_", " ") ' Convert to uppercase and replace underscores
        Next
        With dgvTransact
            .Columns("transaction_id").HeaderText = "Transact ID"
            .Columns("supplier_name").HeaderText = "Supplier"
            .Columns("product_name").HeaderText = "Product"
            .Columns("quantity").HeaderText = "Quantity"
        End With

        ' Hide unwanted columns
        dgvTransact.Columns("date").Visible = False
        dgvTransact.Columns("employee_id").Visible = False
        dgvTransact.Columns("employee_name").Visible = False
        dgvTransact.Columns("supplier_id").Visible = False
        dgvTransact.Columns("product_id").Visible = False

        ' Optionally, you can set other properties of the DataGridView here
        dgvTransact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Adjust column widths
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim()

        ' Ensure user enters a search term
        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("Please enter a search term.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LoadIntransacData()
            Return
        End If

        ' Determine which checkbox is checked
        Dim columnName As String = ""
        If chkTransactionID.Checked Then
            columnName = "transaction_id"
        ElseIf chkEmployeeID.Checked Then
            columnName = "employee_id"
        ElseIf chkProductID.Checked Then
            columnName = "product_id"
        Else
            MessageBox.Show("Please select a search category.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            LoadIntransacData()
            Return
        End If

        ' Call function to perform search
        SearchTransactions(columnName, searchText)
    End Sub
    Private Sub SearchTransactions(column As String, searchValue As String)
        Dim query As String = $"SELECT transaction_id, employee_id, product_id, quantity, date FROM intransac WHERE {column} LIKE @searchValue"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@searchValue", "%" & searchValue & "%")

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        dgvTransact.DataSource = table
                    Else
                        MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtSearch.Text = ""
                        LoadIntransacData() ' Reload all transactions if no match is found
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error searching: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSearch.Text = ""
                    LoadIntransacData()
                End Try
            End Using
        End Using
    End Sub

    ' Ensure only one CheckBox is selected at a time
    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransactionID.CheckedChanged, chkEmployeeID.CheckedChanged, chkProductID.CheckedChanged
        Dim checkBox As Guna.UI2.WinForms.Guna2CustomCheckBox = CType(sender, Guna.UI2.WinForms.Guna2CustomCheckBox)

        If checkBox.Checked Then
            ' Uncheck the other checkboxes
            If checkBox Is chkTransactionID Then
                chkEmployeeID.Checked = False
                chkProductID.Checked = False
            ElseIf checkBox Is chkEmployeeID Then
                chkTransactionID.Checked = False
                chkProductID.Checked = False
            ElseIf checkBox Is chkProductID Then
                chkTransactionID.Checked = False
                chkEmployeeID.Checked = False
            End If
        End If
    End Sub

    Private Function GetTotalInbound() As Integer
        Dim total As Integer = 0
        Dim query As String

        ' Check employee type and set query accordingly
        If parent.EmployeeType = "ADMIN" Then
            ' Admin sees the total count of all transactions
            query = "SELECT COUNT(*) FROM intransac"
        ElseIf parent.EmployeeType = "STAFF" Then
            ' Staff sees only their own transactions
            query = "SELECT COUNT(*) FROM intransac WHERE employee_id = @empId"
        Else
            ' Invalid type, return 0
            Return 0
        End If

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameter for STAFF users
                If parent.EmployeeType = "STAFF" Then
                    cmd.Parameters.AddWithValue("@empId", empId)
                End If

                Try
                    conn.Open()
                    total = Convert.ToInt32(cmd.ExecuteScalar())
                Catch ex As Exception
                    MessageBox.Show("Error fetching total inbound: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        Return total
    End Function


    ' Function to Get Total Suppliers
    Private Function GetTotalSuppliers() As Integer
        Dim total As Integer = 0
        Dim query As String = "SELECT COUNT(*) FROM supplier"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    total = Convert.ToInt32(cmd.ExecuteScalar())
                Catch ex As Exception
                    MessageBox.Show("Error fetching total suppliers: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        Return total
    End Function
    Private Sub UpdateButtonCounts()
        btnTotalInbound.Text = "Total Inbound: " & GetTotalInbound()
        btnTotalSupplier.Text = "Total Suppliers: " & GetTotalSuppliers()
    End Sub

    Private Sub dgvTransact_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransact.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvTransact.Rows(e.RowIndex)

            ' Check if the selected table is "SUPPLIERS"
            If cmbtable.SelectedItem.ToString() = "SUPPLIERS" Then
                ' Fetch supplier details based on supplier_id
                Dim supplierID As String = selectedRow.Cells("supplier_id").Value.ToString()
                Dim supplierName As String = selectedRow.Cells("supplier_name").Value.ToString()

                ' Show supplier name and ID
                lblSsupplierID.Text = supplierID
                lblSsupplierName.Text = supplierName

                ' Query to get the additional supplier details: date, contact, and address
                Dim query As String = "SELECT date, contact, address FROM supplier WHERE supplier_id = @supplierID"

                Using conn As New MySqlConnection(connectionString)
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@supplierID", supplierID)
                        Try
                            conn.Open()
                            Dim reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                ' Display additional details in labels
                                lblDdate.Text = reader("date").ToString()
                                lblCcontact.Text = reader("contact").ToString()
                                lblAaddress.Text = reader("address").ToString()
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Error fetching supplier details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End Using
                End Using

                ' Make the supplier panel visible
                pnlSuppliers.Visible = True
            ElseIf cmbtable.SelectedItem.ToString() = "INBOUND" Then
                ' Display inbound transaction details (as you had previously)
                Dim transactionID As String = selectedRow.Cells("transaction_id").Value.ToString()

                ' Fetch full details based on transaction_id
                Dim query As String = "SELECT * FROM intransac WHERE transaction_id = @transactionID"

                Using conn As New MySqlConnection(connectionString)
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@transactionID", transactionID)
                        Try
                            conn.Open()
                            Dim reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                lblDate.Text = reader("date").ToString()
                                lblTransactionID.Text = reader("transaction_id").ToString()
                                lblEmployeeID.Text = reader("employee_id").ToString()
                                lblEmployeeName.Text = reader("employee_name").ToString()
                                lblSupplierID.Text = reader("supplier_id").ToString()
                                lblSupplierName.Text = reader("supplier_name").ToString()
                                lblProductID.Text = reader("product_id").ToString()
                                lblProductName.Text = reader("product_name").ToString()
                                lblQuantity.Text = reader("quantity").ToString()
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Error fetching details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End Using
                End Using

                pnlSuppliers.Visible = False ' Hide supplier panel when viewing transactions
            End If
        End If
    End Sub

    Private Sub btnTransacts_Click(sender As Object, e As EventArgs) Handles btnTransacts.Click
        ' Check if ManageTransact is already open
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is ManageTransact Then
                Dim existingForm As ManageTransact = CType(frm, ManageTransact)
                existingForm.BringToFront()
                ' Update panel visibility
                existingForm.pnlAdd.Visible = True
                existingForm.pnlSuppliers.Visible = False
                Exit Sub
            End If
        Next

        ' If not open, create a new instance
        Dim transactsForm As New ManageTransact(empId, empName) ' Pass actual values here
        transactsForm.pnlAdd.Visible = True
        transactsForm.pnlSuppliers.Visible = False
        transactsForm.Show()
    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        ' Check if ManageTransact is already open
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is ManageTransact Then
                Dim existingForm As ManageTransact = CType(frm, ManageTransact)
                existingForm.BringToFront()

                ' ✅ CLEAR any previous edit mode
                existingForm.ClearSupplierFields() ' <-- Create this method inside ManageTransact

                existingForm.Label16.Text = "ADD SUPPLIER"
                existingForm.Label15.Text = "PATH: TRANSACTIONS/ ADD SUPPLIER"
                existingForm.txtSSupplierID.Enabled = True
                existingForm.Label16.Location = New Point(131, 4)
                existingForm.Label15.Location = New Point(106, 34)

                ' ✅ UPDATE UI
                existingForm.pnlAdd.Visible = False
                existingForm.pnlSuppliers.Visible = True
                existingForm.pnlSuppliers.Location = New Point(12, 12)

                Exit Sub
            End If
        Next

        ' If not open, create a new instance
        Dim transactsForm As New ManageTransact(empId, empName)
        transactsForm.Show()

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        ' ✅ Get the Dashboard instance correctly
        Dim dashboardInstance As Dashboard = Nothing

        ' ✅ Loop through open forms to find Dashboard
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is Dashboard Then
                dashboardInstance = CType(frm, Dashboard)
                Exit For
            End If
        Next

        ' ✅ Check if Dashboard was found
        If dashboardInstance IsNot Nothing Then
            Dim transactsForm As New ManageOutTransact(parent, empId, empName) ' ✅ Pass parameters
            LoadFormIntoPanel(dashboardInstance.pnlforms, transactsForm) ' ✅ Load into pnlForms
        Else
            MessageBox.Show("Dashboard instance not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        parent.lblSubTitle.Text = "PATH: TRANSACTION/ OUTBOUND"
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If cmbtable.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a table to refresh.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedTable As String = cmbtable.SelectedItem.ToString()

        If selectedTable = "INBOUND" Then
            LoadIntransacData()
        ElseIf selectedTable = "SUPPLIERS" Then
            LoadSupplierData()
        End If

        UpdateButtonCounts()
    End Sub

    Private Sub cmbtable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtable.SelectedIndexChanged
        Dim selectedTable As String = cmbtable.SelectedItem.ToString()

        If selectedTable = "INBOUND" Then
            LoadIntransacData()
            pnlSuppliers.Visible = False ' 🔒 Hide supplier details when not needed
            btnEdit.Visible = False
            btnDelete.Visible = False

        ElseIf selectedTable = "SUPPLIERS" Then
            LoadSupplierData()
            pnlSuppliers.Visible = True ' ✅ Show supplier details
            btnEdit.Visible = True
            btnDelete.Visible = True
        End If

    End Sub
    Private Sub LoadSupplierData()
        Dim query As String = "SELECT supplier_id, supplier_name FROM supplier"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim dt As New DataTable()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                    dgvTransact.DataSource = dt

                    ' Ensure both columns are visible
                    dgvTransact.Columns("supplier_id").Visible = True
                    dgvTransact.Columns("supplier_name").Visible = True

                    ' Optional: Rename headers
                    dgvTransact.Columns("supplier_id").HeaderText = "Supplier ID"
                    dgvTransact.Columns("supplier_name").HeaderText = "Supplier Name"

                    ' Fit columns
                    dgvTransact.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                Catch ex As Exception
                    MessageBox.Show("Error loading suppliers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Make sure we're in the SUPPLIERS table
        If cmbtable.SelectedItem.ToString() <> "SUPPLIERS" Then
            MessageBox.Show("You can only delete suppliers from the SUPPLIERS view.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure there are selected rows
        If dgvTransact.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one supplier to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm delete action
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected supplier(s)?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then Return

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim transaction As MySqlTransaction = conn.BeginTransaction()


            Try
                For Each row As DataGridViewRow In dgvTransact.SelectedRows
                    If Not row.IsNewRow Then
                        Dim supplierID As String = row.Cells("supplier_id").Value.ToString()
                        Dim deleteQuery As String = "DELETE FROM supplier WHERE supplier_id = @supplierID"

                        Using cmd As New MySqlCommand(deleteQuery, conn, transaction)
                            cmd.Parameters.AddWithValue("@supplierID", supplierID)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' ✅ Log each deletion
                        InsertActivityLog(empId, empName, $"DELETED SUPPLIER: {supplierID}")
                    End If
                Next

                transaction.Commit() ' <-- Add this
            Catch ex As Exception
                    transaction.Rollback()
                MessageBox.Show("Error deleting supplier(s): " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        ' Refresh DataGrid and counts
        LoadSupplierData()
        UpdateButtonCounts()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Ensure the "SUPPLIERS" table is selected
        If cmbtable.SelectedItem.ToString() <> "SUPPLIERS" Then
            MessageBox.Show("Please switch to the SUPPLIERS tab to edit supplier data.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if a row is selected
        If dgvTransact.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a supplier to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm edit action
        Dim confirmResult As DialogResult = MessageBox.Show("Do you want to edit the selected supplier?", "Edit Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then Return

        ' Get selected row data
        Dim selectedRow As DataGridViewRow = dgvTransact.SelectedRows(0)
        Dim supplierID As String = selectedRow.Cells("supplier_id").Value.ToString()
        Dim supplierName As String = selectedRow.Cells("supplier_name").Value.ToString()

        ' Fetch the complete supplier details from the database
        Dim dateVal As String = "", contact As String = "", address As String = ""

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT date, contact, address FROM supplier WHERE supplier_id = @supplierID"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@supplierID", supplierID)
                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            dateVal = reader("date").ToString()
                            contact = reader("contact").ToString()
                            address = reader("address").ToString()
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error retrieving supplier details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            End Using
        End Using

        ' Open ManageTransact and populate fields
        Dim manageForm As ManageTransact = Nothing
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is ManageTransact Then
                manageForm = CType(frm, ManageTransact)
                Exit For
            End If
        Next

        ' Create new instance if not already open
        If manageForm Is Nothing Then
            manageForm = New ManageTransact(empId, empName)
            manageForm.Label16.Text = "UPDATE SUPPLIER"
            manageForm.Label15.Text = "PATH: TRANSACTIONS/ UPDATE SUPPLIER"
            manageForm.Label16.Location = New Point(117, 4)
            manageForm.Label15.Location = New Point(99, 34)
            manageForm.Show()
        End If

        manageForm.isEditMode = True
        manageForm.originalSupplierID = supplierID

        ' Show supplier panel and populate fields
        With manageForm
            .BringToFront()
            .pnlAdd.Visible = False
            .pnlSuppliers.Visible = True
            .pnlSuppliers.Location = New Point(12, 12)
            .txtSSupplierID.Enabled = False

            ' Populate fields
            .txtSSupplierID.Text = supplierID
            .txtSSupplierName.Text = supplierName
            .txtSContact.Text = contact
            .txtSAddress.Text = address

            ' Convert string to DateTime for DateTimePicker
            Dim parsedDate As DateTime
            If DateTime.TryParse(dateVal, parsedDate) Then
                .dtpSDate.Value = parsedDate
            End If
        End With
    End Sub

End Class