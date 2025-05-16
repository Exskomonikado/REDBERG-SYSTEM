Imports MySql.Data.MySqlClient

Public Class DashboardForms
    Public Property EmployeeID As String
    Public Property EmployeeType As String
    Public Property FullName As String

    ' Declare connection object
    Private conn As New MySqlConnection(connectionString)
    ' Load event to update button text with total counts
    Private Sub DashboardForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateButtonCounts()

        cmbCollectTable.Items.Add("PRODUCTS")
        cmbCollectTable.Items.Add("SUPPLIERS")
        cmbCollectTable.SelectedItem = "PRODUCTS" ' Set the default selected item
        PopulateTable("PRODUCTS") ' Load data for the products table

    End Sub

    ' Function to update button texts with total counts
    Public Sub UpdateButtonCounts()
        btnTotalStocks.Text = "Total Stocks: " & GetRecordCount("products") ' Always total stocks

        If EmployeeType = "ADMIN" Then
            btnTotalReports.Text = "Total Reports: " & GetRecordCount("reports")
            btnTotalInbound.Text = "Total Inbound: " & GetRecordCount("intransac")
            btnTotalOutbound.Text = "Total Outbound: " & GetRecordCount("outtransact")

        ElseIf EmployeeType = "STAFF" Then

            btnTotalReports.Text = "Total Reports: " & GetRecordCount("reports", FullName)
            btnTotalInbound.Text = "Total Inbound: " & GetRecordCount("intransac", FullName)
            btnTotalOutbound.Text = "Total Outbound: " & GetRecordCount("outtransact", FullName)

        End If
    End Sub

    Public Function GetRecordCount(tableName As String, Optional employeeName As String = "") As Integer
        Dim count As Integer = 0
        Try
            conn.Open()

            Dim query As String = ""
            If employeeName = "" Then
                query = "SELECT COUNT(*) FROM " & tableName
            Else
                ' Build query depending on table
                Select Case tableName
                    Case "reports"
                        query = "SELECT COUNT(*) FROM reports WHERE employee_name = @employeeName"
                    Case "intransac"
                        query = "SELECT COUNT(*) FROM intransac WHERE employee_name = @employeeName"
                    Case "outtransact"
                        query = "SELECT COUNT(*) FROM outtransact WHERE employee_name = @employeeName"
                    Case Else
                        query = "SELECT COUNT(*) FROM " & tableName ' If no employee_name field
                End Select
            End If

            Dim cmd As New MySqlCommand(query, conn)

            If employeeName <> "" Then
                cmd.Parameters.AddWithValue("@employeeName", employeeName)
            End If

            count = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error retrieving count from " & tableName & ": " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        Return count
    End Function

    Private Sub PopulateTable(tableName As String)
        Dim query As String = ""

        ' Define the query based on the selected table
        Select Case tableName
            Case "PRODUCTS"
                query = "SELECT product_id, product_name, type, quantity FROM products"
            Case "SUPPLIERS"
                query = "SELECT supplier_id, supplier_name FROM supplier"

            Case Else
                MessageBox.Show("Invalid table selected.")
                Return
        End Select

        ' Load data into the DataGridView
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Try
                    conn.Open()
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvTable.DataSource = table

                    ' Format the column headers
                    For Each column As DataGridViewColumn In dgvTable.Columns
                        column.HeaderText = column.HeaderText.ToUpper().Replace("_", " ") ' Convert to uppercase and replace underscores with spaces
                    Next
                Catch ex As Exception
                    MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub cmbCollectTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCollectTable.SelectedIndexChanged
        Dim selectedTable As String = cmbCollectTable.SelectedItem.ToString()
        PopulateTable(selectedTable)
    End Sub

End Class
