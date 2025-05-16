Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Public Class DashboardManage

    Private parent As Dashboard
    Private empId As String
    Private empName As String

    Public Sub New(parentForm As Dashboard, empId As Integer, empName As String)
        InitializeComponent()
        Me.parent = parentForm
        Me.empId = empId
        Me.empName = empName
    End Sub
    Private Sub DashboardManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load product quantities for buttons
        Dim quantities As Dictionary(Of String, Integer) = GetQuantities()
        UpdateButtonStates(quantities)

        LoadProducts()

        btnTotalModem.HoverState.FillColor = btnTotalModem.FillColor
        btnTotalHub.HoverState.FillColor = btnTotalHub.FillColor
        btnTotalCable.HoverState.FillColor = btnTotalCable.FillColor
        btnTotalRouter.HoverState.FillColor = btnTotalRouter.FillColor
        btnTotalTelpad.HoverState.FillColor = btnTotalTelpad.FillColor
        btnTotalTelset.HoverState.FillColor = btnTotalTelset.FillColor

        ToolTip1.SetToolTip(txtSearch, "Click to search")
    End Sub
    Private Function GetQuantities() As Dictionary(Of String, Integer)
        Dim quantities As New Dictionary(Of String, Integer)
        Dim query As String = "SELECT type, SUM(quantity) AS total_quantity FROM products GROUP BY type"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim type As String = reader("type").ToString().ToLower() ' Ensure lowercase type
                            Dim totalQuantity As Integer = Convert.ToInt32(reader("total_quantity"))
                            quantities(type) = totalQuantity
                        End While
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Database error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using

        Return quantities
    End Function

    Private Sub UpdateButtonStates(quantities As Dictionary(Of String, Integer))
        ' Mapping product types to their respective buttons
        Dim buttons As New Dictionary(Of String, Guna.UI2.WinForms.Guna2Button) From {
            {"modem", btnTotalModem},
            {"hub", btnTotalHub},
            {"router", btnTotalRouter},
            {"cable", btnTotalCable},
            {"telset", btnTotalTelset},
            {"telpad", btnTotalTelpad}
        }

        For Each kvp As KeyValuePair(Of String, Guna.UI2.WinForms.Guna2Button) In buttons
            Dim type As String = kvp.Key
            Dim button As Guna.UI2.WinForms.Guna2Button = kvp.Value
            Dim quantity As Integer = If(quantities.ContainsKey(type), quantities(type), 0)

            ' Correctly formatted button text (e.g., "Total Modem: 100")
            button.Text = $"Total {StrConv(type, VbStrConv.ProperCase)}: {quantity}"

            ' Improved quantity color logic using ranges
            Dim fillColor As Color
            Select Case quantity
                Case >= 100
                    fillColor = Color.SeaGreen' Green
                Case 50 To 99
                    fillColor = Color.Goldenrod ' Yellow
                Case Else
                    fillColor = Color.Firebrick ' Red
            End Select

            button.FillColor = fillColor
        Next
    End Sub

    ' Function to Load Products Table on Form Load
    Private Sub LoadProducts()
        Dim query As String = "SELECT product_id, product_name, type, quantity FROM products"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(table)
                    dgvProducts.DataSource = table ' Bind data to DataGridView
                    FormatDataGridView() ' Format the DataGridView
                Catch ex As Exception
                    MessageBox.Show("Error loading products: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Function to Format DataGridView (Hide Unwanted Columns)
    Private Sub FormatDataGridView()
        With dgvProducts
            .Columns("product_id").HeaderText = "Product ID"
            .Columns("product_name").HeaderText = "Product Name"
            .Columns("type").HeaderText = "Type"
            .Columns("quantity").HeaderText = "Quantity"

            ' Hide any additional columns if they exist
            For Each column As DataGridViewColumn In .Columns
                If column.Name <> "product_id" AndAlso column.Name <> "product_name" AndAlso column.Name <> "type" AndAlso column.Name <> "quantity" Then
                    column.Visible = False
                End If
            Next

            ' Auto-size columns for better visibility
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("Please enter a search term.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim columnName As String = ""
        If rbProductID.Checked Then
            columnName = "product_id"
        ElseIf rbProductName.Checked Then
            columnName = "product_name"
        ElseIf rbType.Checked Then
            columnName = "type"
        Else
            MessageBox.Show("Please select a search category.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SearchProducts(columnName, searchText)
    End Sub

    ' Function to Search Products Based on Selected Radio Button
    Private Sub SearchProducts(column As String, searchValue As String)
        Dim query As String = $"SELECT product_id, product_name, type, quantity FROM products WHERE {column} LIKE @searchValue"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@searchValue", "%" & searchValue & "%")

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        dgvProducts.DataSource = table
                        FormatDataGridView()
                    Else
                        MessageBox.Show("No records found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtSearch.Text = ""
                        LoadProducts()

                    End If
                Catch ex As Exception
                    MessageBox.Show("Error searching: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtSearch.Text = ""
                End Try
            End Using
        End Using
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles rbProductID.CheckedChanged, rbProductName.CheckedChanged, rbType.CheckedChanged
        If CType(sender, Guna.UI2.WinForms.Guna2CustomCheckBox).Checked Then
            ' Uncheck the other checkboxes
            If sender Is rbProductID Then
                rbProductName.Checked = False
                rbType.Checked = False
            ElseIf sender Is rbProductName Then
                rbProductID.Checked = False
                rbType.Checked = False
            ElseIf sender Is rbType Then
                rbProductID.Checked = False
                rbProductName.Checked = False
            End If
        End If
    End Sub
    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        ' Ensure the user clicked a valid row (not the header)
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dgvProducts.Rows(e.RowIndex)
            Dim productID As String = selectedRow.Cells("product_id").Value.ToString()

            ' Fetch full details from the database
            LoadProductDetails(productID)
        End If
    End Sub
    Private Sub LoadProductDetails(productID As String)
        Dim query As String = "SELECT * FROM products WHERE product_id = @productID"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@productID", productID)

                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Assign data to labels
                            lblProductID.Text = reader("product_id").ToString()
                            lblName.Text = reader("product_name").ToString()
                            lblType.Text = reader("type").ToString()
                            lblQuantity.Text = reader("quantity").ToString()
                            lblPrice.Text = reader("price").ToString()
                            lblDescription.Text = reader("description").ToString()
                            lblBarcode.Text = reader("barcode").ToString()
                            lblDate.Text = reader("exdate").ToString()
                            lblSupplierID.Text = reader("supplier_id").ToString()
                            lblSupplierName.Text = reader("supplier_name").ToString()
                            lblContact.Text = reader("contact").ToString()
                            lblAddress.Text = reader("address").ToString()

                            ' If you want to load the image
                            If Not IsDBNull(reader("photo")) Then
                                Dim imgBytes() As Byte = CType(reader("photo"), Byte())
                                Dim ms As New System.IO.MemoryStream(imgBytes)
                                picProduct.Image = Image.FromStream(ms)
                            Else
                                picProduct.Image = Nothing ' No image available
                            End If
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading product details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one product to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected products?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim productIds As New List(Of String)()

            ' Collect the IDs of the selected products
            For Each row As DataGridViewRow In dgvProducts.SelectedRows
                Dim productId As String = row.Cells("product_id").Value.ToString()
                productIds.Add(productId)
            Next

            ' Call the method to delete the products
            DeleteProducts(productIds)
            LoadProducts()
            PopulateMonths()
        End If
    End Sub
    Private Sub DeleteProducts(productIds As List(Of String))
        ' Build the parameterized query dynamically
        Dim parameters As New List(Of String)()
        Dim query As String = "DELETE FROM products WHERE product_id IN ("

        ' Create a parameter for each product ID
        For i As Integer = 0 To productIds.Count - 1
            Dim paramName As String = "@productId" & i
            parameters.Add(paramName)
            query &= paramName & ","
        Next

        ' Remove the last comma and close the parentheses
        query = query.TrimEnd(","c) & ")"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Add parameters to the command
                For i As Integer = 0 To productIds.Count - 1
                    command.Parameters.AddWithValue("@productId" & i, productIds(i))
                Next

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show($"{rowsAffected} product(s) deleted successfully.")

                        For Each pid As String In productIds
                            InsertActivityLog(empId, empName, $"DELETED A PRODUCT: ID: {pid}")
                        Next
                    Else
                        MessageBox.Show("No products were deleted.")
                    End If

                    LoadProducts() ' Refresh the DataGridView
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is ManageAdd Then
                frm.BringToFront() ' Bring the existing form to front
                frm.WindowState = FormWindowState.Normal ' Restore if minimized
                Return
            End If
        Next

        ' If the form is not open, create a new instance and show it
        Dim adddataForm As New ManageAdd(empId, empName)
        adddataForm.Show()
    End Sub

    Private Sub btnEditProduct_Click(sender As Object, e As EventArgs) Handles btnEditProduct.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to edit.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to edit this product?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Get selected row data
            Dim selectedRow As DataGridViewRow = dgvProducts.SelectedRows(0)
            Dim productId1 As String = selectedRow.Cells("product_id").Value.ToString()
            Dim productName As String = selectedRow.Cells("product_name").Value.ToString()
            Dim type As String = selectedRow.Cells("type").Value.ToString()
            Dim quantity As Integer = Convert.ToInt32(selectedRow.Cells("quantity").Value)

            ' Fetch additional details from database
            Dim additionalDetails As (Decimal, String, String, Date, String, String, String, String, Byte()) = GetProductDetails(productId1)

            ' Check if ManageProduct is already open
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is ManageProduct Then
                    frm.BringToFront()
                    Exit Sub
                End If
            Next

            ' If not open, create new instance and show it
            Dim manageProductForm As New ManageProduct(productId1, productName, type, quantity, additionalDetails, empId, empName)
            manageProductForm.pnlEditProduct.Visible = True
            manageProductForm.pnlEditProduct.Location = New Point(12, 12)
            manageProductForm.ShowDialog()
            LoadProducts()
        End If

    End Sub
    Private Function GetProductDetails(productId As String) As (price As Decimal, description As String, barcode As String, exdate As Date, supplierId As String, supplierName As String, contact As String, address As String, photo As Byte())
        Dim query As String = "SELECT price, description, barcode, exdate, supplier_id, supplier_name, contact, address, photo FROM products WHERE product_id = @product_id"

        Dim price As Decimal = 0
        Dim description As String = ""
        Dim barcode As String = ""
        Dim exdate As Date = Date.MinValue
        Dim supplierId As String = ""
        Dim supplierName As String = ""
        Dim contact As String = ""
        Dim address As String = ""
        Dim photo As Byte() = Nothing

        Using connection As New MySqlConnection("server=localhost;username=root;password=;database=imsdb")
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@product_id", productId)

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            price = reader.GetDecimal("price")
                            description = reader.GetString("description")
                            barcode = reader.GetString("barcode")
                            exdate = reader.GetDateTime("exdate")
                            supplierId = reader.GetString("supplier_id")
                            supplierName = reader.GetString("supplier_name")
                            contact = reader.GetString("contact")
                            address = reader.GetString("address")
                            photo = CType(reader("photo"), Byte())
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Return (price, description, barcode, exdate, supplierId, supplierName, contact, address, photo)
    End Function

    ' Function to filter data based on the selected month
    Private Sub FilterDataByMonth(selectedMonth As Integer)
        Dim query As String = "SELECT product_id, product_name, type, quantity, exdate FROM products WHERE MONTH(exdate) = @selectedMonth"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        dgvProducts.DataSource = table ' Display filtered results
                        FormatDataGridView() ' Apply formatting (if needed)
                    Else
                        MessageBox.Show("No records found for the selected month.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadProducts() ' Reload all products if no results are found
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error while filtering: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
    Private Sub PopulateMonths()
        cmbMonths.Items.Clear()
        Dim monthNames As String() = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        cmbMonths.Items.AddRange(monthNames)
        cmbMonths.SelectedIndex = 0 ' Default to January
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If cmbMonths.SelectedIndex <> -1 Then
            Dim selectedMonth As Integer = cmbMonths.SelectedIndex + 1 ' Convert to 1-based month index
            FilterDataByMonth(selectedMonth)
        Else
            MessageBox.Show("Please select a month.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Load product quantities for buttons
        Dim quantities As Dictionary(Of String, Integer) = GetQuantities()
        UpdateButtonStates(quantities)

        LoadProducts()

        btnTotalModem.HoverState.FillColor = btnTotalModem.FillColor
        btnTotalHub.HoverState.FillColor = btnTotalHub.FillColor
        btnTotalCable.HoverState.FillColor = btnTotalCable.FillColor
        btnTotalRouter.HoverState.FillColor = btnTotalRouter.FillColor
        btnTotalTelpad.HoverState.FillColor = btnTotalTelpad.FillColor
        btnTotalTelset.HoverState.FillColor = btnTotalTelset.FillColor

    End Sub


End Class
