Imports ADODB
Imports System.Data

Public Class Form3
    Dim CNN As New Connection

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CNN.ConnectionString = "Provider=SQLOLEDB;Data Source=GABRIEL;Initial Catalog=INVENTORY;Integrated Security=SSPI;"
            CNN.Open()
            LoadProducts()
        Catch ex As Exception
            MessageBox.Show("Connection error: " & ex.Message)
        End Try
    End Sub

    Private Sub Save_button_Click(sender As Object, e As EventArgs) Handles Save_button.Click
        Dim prodno As Integer
        If Not Integer.TryParse(prodno_txt.Text, prodno) Then
            MessageBox.Show("Product Number must be a whole number.")
            Exit Sub
        End If

        Dim priceval As Decimal
        If Not Decimal.TryParse(price_txt.Text, priceval) Then
            MessageBox.Show("Price must be a decimal.")
            Exit Sub
        End If

        Dim quantityval As Integer
        If Not Integer.TryParse(quantity_txt.Text, quantityval) OrElse quantityval < 0 Then
            MessageBox.Show("Quantity must be a non-negative whole number.")
            Exit Sub
        End If

        Dim expiryDate As Date = expdate_txt.Value.Date
        If expiryDate < Date.Today Then
            MessageBox.Show("Warning: The expiry date entered is already expired!", "Expiry Date Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim statusVal As String = If(quantityval > 0, "Available", "Unavailable")

        Try
            Dim STRSQL As String = "INSERT INTO Products (product_number, product_name, price, group_name, expiry_date, status, quantity) VALUES (?, ?, ?, ?, ?, ?, ?)"

            Dim cmd As New Command
            cmd.ActiveConnection = CNN
            cmd.CommandText = STRSQL
            cmd.CommandType = CommandTypeEnum.adCmdText

            cmd.Parameters.Append(cmd.CreateParameter("product_number", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , prodno))
            cmd.Parameters.Append(cmd.CreateParameter("product_name", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, prodname_txt.Text.Trim()))
            cmd.Parameters.Append(cmd.CreateParameter("price", DataTypeEnum.adCurrency, ParameterDirectionEnum.adParamInput, , priceval))
            cmd.Parameters.Append(cmd.CreateParameter("group_name", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, prodgroup_txt.Text.Trim()))
            cmd.Parameters.Append(cmd.CreateParameter("expiry_date", DataTypeEnum.adDate, ParameterDirectionEnum.adParamInput, , expiryDate))
            cmd.Parameters.Append(cmd.CreateParameter("status", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, statusVal))
            cmd.Parameters.Append(cmd.CreateParameter("quantity", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , quantityval))

            cmd.Execute()
            MessageBox.Show("Product saved!")
            LoadProducts()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error saving product: " & ex.Message)
        End Try
    End Sub

    Private Sub Update_button_Click(sender As Object, e As EventArgs) Handles Update_button.Click
        Dim prodno As Integer
        If Not Integer.TryParse(prodno_txt.Text, prodno) OrElse prodno <= 0 Then
            MessageBox.Show("Please enter a valid positive product number.")
            Exit Sub
        End If

        Dim priceval As Decimal
        If Not Decimal.TryParse(price_txt.Text, priceval) OrElse priceval < 0 Then
            MessageBox.Show("Please enter a valid non-negative price value.")
            Exit Sub
        End If

        Dim quantityval As Integer
        If Not Integer.TryParse(quantity_txt.Text, quantityval) OrElse quantityval < 0 Then
            MessageBox.Show("Quantity must be a non-negative whole number.")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(prodname_txt.Text) Then
            MessageBox.Show("Product name cannot be empty.")
            Exit Sub
        End If

        Dim expiryDate As Date = expdate_txt.Value.Date
        If expiryDate < Date.Today Then
            MessageBox.Show("Warning: The expiry date entered is already expired!", "Expiry Date Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim statusVal As String = If(quantityval > 0, "Available", "Unavailable")

        Try
            Dim STRSQL As String = "UPDATE Products SET product_name = ?, price = ?, group_name = ?, expiry_date = ?, status = ?, quantity = ? WHERE product_number = ?"

            Dim cmd As New Command
            cmd.ActiveConnection = CNN
            cmd.CommandText = STRSQL
            cmd.CommandType = CommandTypeEnum.adCmdText

            cmd.Parameters.Append(cmd.CreateParameter("product_name", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, prodname_txt.Text.Trim()))
            cmd.Parameters.Append(cmd.CreateParameter("price", DataTypeEnum.adCurrency, ParameterDirectionEnum.adParamInput, , priceval))
            cmd.Parameters.Append(cmd.CreateParameter("group_name", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, prodgroup_txt.Text.Trim()))
            cmd.Parameters.Append(cmd.CreateParameter("expiry_date", DataTypeEnum.adDate, ParameterDirectionEnum.adParamInput, , expiryDate))
            cmd.Parameters.Append(cmd.CreateParameter("status", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, statusVal))
            cmd.Parameters.Append(cmd.CreateParameter("quantity", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , quantityval))
            cmd.Parameters.Append(cmd.CreateParameter("product_number", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , prodno))

            Dim affected As Object = 0
            cmd.Execute(affected, , ExecuteOptionEnum.adExecuteNoRecords)

            If CInt(affected) > 0 Then
                MessageBox.Show("Product updated!")
                LoadProducts()
                ClearFields()
            Else
                MessageBox.Show("No product found with that number.")
            End If
        Catch ex As Exception
            MessageBox.Show("Update failed: " & ex.Message)
        End Try
    End Sub

    Private Sub Delete_button_Click(sender As Object, e As EventArgs) Handles Delete_button.Click
        Try
            Dim productNumber As Integer
            If Not Integer.TryParse(prodno_txt.Text, productNumber) Then
                MessageBox.Show("Please enter a valid product number.")
                Return
            End If

            Dim confirmResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.Yes Then
                Dim STRSQL As String = "DELETE FROM Products WHERE product_number = ?"
                Dim cmd As New ADODB.Command
                cmd.ActiveConnection = CNN
                cmd.CommandText = STRSQL
                cmd.CommandType = ADODB.CommandTypeEnum.adCmdText

                cmd.Parameters.Append(cmd.CreateParameter("product_number", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, , productNumber))

                cmd.Execute()
                MessageBox.Show("Product deleted.")
                LoadProducts()
                ClearFields()
            End If
        Catch ex As Exception
            MessageBox.Show("Delete failed: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadProducts()
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

            ' Highlight expired rows in red and make them read-only
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim expiryDate As Date = Convert.ToDateTime(row.Cells("expiry_date").Value)
                If expiryDate < Date.Today Then
                    row.DefaultCellStyle.ForeColor = Color.Red
                    row.ReadOnly = True
                    row.DefaultCellStyle.Font = New Font(DataGridView1.Font, FontStyle.Italic)
                End If
            Next

            RST.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub


    Private Sub Clear_button_Click(sender As Object, e As EventArgs) Handles Clear_button.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        prodno_txt.Clear()
        prodname_txt.Clear()
        price_txt.Clear()
        quantity_txt.Clear()
        expdate_txt.Value = Date.Today()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim searchText As String = txt_searchbox.Text.Trim()

        If String.IsNullOrEmpty(searchText) Then
            LoadProducts()
            Return
        End If

        Dim RST As New Recordset
        Dim STRSQL As String = "SELECT product_number, product_name, price, group_name, expiry_date, status, quantity FROM Products WHERE " &
                               "CAST(product_number AS NVARCHAR) LIKE ? OR " &
                               "product_name LIKE ? OR " &
                               "CAST(price AS NVARCHAR) LIKE ? OR " &
                               "group_name LIKE ? OR " &
                               "status LIKE ? OR " &
                               "CAST(quantity AS NVARCHAR) LIKE ? OR " &
                               "CONVERT(NVARCHAR, expiry_date, 23) LIKE ?"

        Try
            If CNN.State = 0 Then CNN.Open()

            Dim cmd As New Command
            cmd.ActiveConnection = CNN
            cmd.CommandText = STRSQL
            cmd.CommandType = CommandTypeEnum.adCmdText

            Dim paramValue As String = "%" & searchText & "%"
            For i As Integer = 1 To 7
                cmd.Parameters.Append(cmd.CreateParameter("param" & i, DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, paramValue))
            Next

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

            ' Re-apply expired styling
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim expiryDate As Date = Convert.ToDateTime(row.Cells("expiry_date").Value)
                If expiryDate < Date.Today Then
                    row.DefaultCellStyle.ForeColor = Color.Red
                    row.ReadOnly = True
                    row.DefaultCellStyle.Font = New Font(DataGridView1.Font, FontStyle.Italic)
                End If
            Next

            RST.Close()
        Catch ex As Exception
            MessageBox.Show("Search failed: " & ex.Message)
        End Try
    End Sub

End Class
