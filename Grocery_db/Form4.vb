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
            Dim deleteExpired As New Command
            deleteExpired.ActiveConnection = CNN
            deleteExpired.CommandText = "DELETE FROM Products WHERE expiry_date < GETDATE()"
            deleteExpired.CommandType = CommandTypeEnum.adCmdText
            deleteExpired.Execute()
        Catch ex As Exception
            MessageBox.Show("Error removing expired products: " & ex.Message)
            Exit Sub
        End Try

        ' Load remaining products
        Dim RST As New Recordset
        Dim STRSQL As String = "SELECT product_number, product_name, price, group_name, expiry_date, status, quantity FROM Products"

        Try
            If CNN.State = 0 Then CNN.Open()
            RST.Open(STRSQL, CNN, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

            Dim dt As New DataTable
            dt.Columns.Add("product_number")
            dt.Columns.Add("product_name")
            dt.Columns.Add("price", GetType(Decimal))
            dt.Columns.Add("group_name")
            dt.Columns.Add("expiry_date", GetType(DateTime))
            dt.Columns.Add("status")
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
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

    Private Sub Btn_search1_Click(sender As Object, e As EventArgs) Handles Btn_search1.Click
        Dim searchText As String = tb_search.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            LoadProducts() ' If empty, load all
            Return
        End If

        Dim RST As New Recordset
        Dim STRSQL As String = "SELECT product_number, product_name, price, group_name, expiry_date, status, quantity FROM Products WHERE " &
                               "CAST(product_number AS NVARCHAR) LIKE ? OR " &
                               "product_name LIKE ? OR " &
                               "CAST(price AS NVARCHAR) LIKE ? OR " &
                               "group_name LIKE ? OR " &
                               "status LIKE ?"

        Try
            If CNN.State = 0 Then CNN.Open()

            Dim cmd As New Command
            cmd.ActiveConnection = CNN
            cmd.CommandText = STRSQL
            cmd.CommandType = CommandTypeEnum.adCmdText

            ' Using wildcard search for all text fields
            Dim paramValue As String = "%" & searchText & "%"
            cmd.Parameters.Append(cmd.CreateParameter("param1", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 50, paramValue))
            cmd.Parameters.Append(cmd.CreateParameter("param2", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, paramValue))
            cmd.Parameters.Append(cmd.CreateParameter("param3", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 50, paramValue))
            cmd.Parameters.Append(cmd.CreateParameter("param4", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, paramValue))
            cmd.Parameters.Append(cmd.CreateParameter("param5", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, paramValue))

            RST = cmd.Execute()

            Dim dt As New DataTable
            dt.Columns.Add("product_number")
            dt.Columns.Add("product_name")
            dt.Columns.Add("price", GetType(Decimal))
            dt.Columns.Add("group_name")
            dt.Columns.Add("expiry_date", GetType(DateTime))
            dt.Columns.Add("status")
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