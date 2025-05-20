Public Class Form4

    Private CNN As New ADODB.Connection
    Private RST As ADODB.Recordset ' Declare once

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
        Try
            ' Close RST if already open
            If RST IsNot Nothing Then
                If RST.State = 1 Then ' Open
                    RST.Close()
                End If
                RST = Nothing
            End If

            RST = New ADODB.Recordset
            Dim sql As String = "SELECT ps.product_number, ps.product_name, pc.group_name, ps.price, ps.expiry_date, ps.quantity, ps.status " &
                                "FROM ProductStock ps INNER JOIN ProductCatalog pc ON ps.product_name = pc.product_name"
            RST.Open(sql, CNN, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

            Dim dt As New DataTable
            dt.Columns.Add("Product Number", GetType(Integer))
            dt.Columns.Add("Product Name", GetType(String))
            dt.Columns.Add("Group Name", GetType(String))
            dt.Columns.Add("Price", GetType(Decimal))
            dt.Columns.Add("Expiry Date", GetType(Date))
            dt.Columns.Add("Quantity", GetType(Integer))
            dt.Columns.Add("Status", GetType(String))

            While Not RST.EOF
                dt.Rows.Add(RST.Fields("product_number").Value,
                            RST.Fields("product_name").Value,
                            RST.Fields("group_name").Value,
                            RST.Fields("price").Value,
                            RST.Fields("expiry_date").Value,
                            RST.Fields("quantity").Value,
                            RST.Fields("status").Value)
                RST.MoveNext()
            End While

            DataGridView1.DataSource = dt

            RST.Close()
            RST = Nothing

        Catch ex As Exception
            MessageBox.Show("Load error: " & ex.Message)
        End Try
    End Sub

    Private Sub Btn_search1_Click(sender As Object, e As EventArgs) Handles Btn_search1.Click
        Dim searchText As String = tb_search.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            LoadProducts()
            Return
        End If

        Try
            ' Close RST if already open
            If RST IsNot Nothing Then
                If RST.State = 1 Then
                    RST.Close()
                End If
                RST = Nothing
            End If

            Dim cmd As New ADODB.Command
            cmd.ActiveConnection = CNN

            cmd.CommandText = "
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
                    CAST(ps.quantity AS NVARCHAR) LIKE ?"

            cmd.CommandType = CommandTypeEnum.adCmdText

            Dim paramValue As String = "%" & searchText & "%"

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
            RST = Nothing

        Catch ex As Exception
            MessageBox.Show("Search failed: " & ex.Message)
        End Try
    End Sub

End Class
