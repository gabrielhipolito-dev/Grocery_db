Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            CNN.ConnectionString = "Provider=SQLOLEDB;Data Source=GABRIEL;Initial Catalog=INVENTORY;Integrated Security=SSPI;"
            CNN.Open()
            LoadProducts()
        Catch ex As Exception
            MessageBox.Show("Connection error: " & ex.Message)
        End Try

    End Sub
    Private Sub LoadProducts()
        ' Delete expired products first
        Try
            Dim rs As New Recordset
            Dim sql As String = "SELECT ps.product_number, ps.product_name, pc.group_name, ps.price, ps.expiry_date, ps.quantity, ps.status " &
                                "FROM ProductStock ps INNER JOIN ProductCatalog pc ON ps.product_name = pc.product_name"
            rs.Open(sql, CNN, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)
            Dim dt As New DataTable
            dt.Columns.Add("Product Number", GetType(Integer))
            dt.Columns.Add("Product Name", GetType(String))
            dt.Columns.Add("Group Name", GetType(String))
            dt.Columns.Add("Price", GetType(Decimal))
            dt.Columns.Add("Expiry Date", GetType(Date))
            dt.Columns.Add("Quantity", GetType(Integer))
            dt.Columns.Add("Status", GetType(String))

            While Not rs.EOF
                dt.Rows.Add(rs.Fields("product_number").Value,
                            rs.Fields("product_name").Value,
                            rs.Fields("group_name").Value,
                            rs.Fields("price").Value,
                            rs.Fields("expiry_date").Value,
                            rs.Fields("quantity").Value,
                            rs.Fields("status").Value)
                rs.MoveNext()
            End While
            DataGridView1.DataSource = dt
            rs.Close()
        Catch ex As Exception
            MessageBox.Show("Load error: " & ex.Message)
        End Try
    End Sub

    Private Sub Btn_search1_Click(sender As Object, e As EventArgs) Handles Btn_search1.Click
        Dim searchText As String = tb_search.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            LoadProducts() ' or your method to load all products
            Return
        End If

        Dim RST As New Recordset
        Dim STRSQL As String = "
        SELECT 
            ps.product_number, 
            pc.product_name, 
            ps.price, 
            pc.group_name, 
            ps.expiry_date, 
            ps.status, 
            ps.quantity 
        FROM ProductStock ps
        INNER JOIN ProductCatalog pc ON ps.product_name = pc.product_name
        WHERE
            CAST(ps.product_number AS NVARCHAR) LIKE ? OR
            pc.product_name LIKE ? OR
            CAST(ps.price AS NVARCHAR) LIKE ? OR
            pc.group_name LIKE ? OR
            ps.status LIKE ? OR
            CAST(ps.quantity AS NVARCHAR) LIKE ?
    "

        Try
            If CNN.State = 0 Then CNN.Open()

            Dim cmd As New Command
            cmd.ActiveConnection = CNN
            cmd.CommandText = STRSQL
            cmd.CommandType = CommandTypeEnum.adCmdText

            Dim paramValue As String = "%" & searchText & "%"

            ' Append 6 parameters for each ?
            For i As Integer = 1 To 6
                cmd.Parameters.Append(cmd.CreateParameter("param" & i, DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 50, paramValue))
            Next

            RST = cmd.Execute()

            Dim dt As New DataTable
            dt.Columns.Add("product_number", GetType(Integer))
            dt.Columns.Add("product_name", GetType(String))
            dt.Columns.Add("price", GetType(Decimal))
            dt.Columns.Add("group_name", GetType(String))
            dt.Columns.Add("expiry_date", GetType(Date))
            dt.Columns.Add("status", GetType(String))
            dt.Columns.Add("quantity", GetType(Integer))

            While Not RST.EOF
                dt.Rows.Add(
                RST.Fields("product_number").Value,
                RST.Fields("product_name").Value,
                RST.Fields("price").Value,
                RST.Fields("group_name").Value,
                RST.Fields("expiry_date").Value,
                RST.Fields("status").Value,
                RST.Fields("quantity").Value
            )
                RST.MoveNext()
            End While

            DataGridView1.DataSource = dt
            DataGridView1.AutoResizeColumns()
            RST.Close()

        Catch ex As Exception
            MessageBox.Show("Search failed: " & ex.Message)
        End Try
    End Sub


End Class