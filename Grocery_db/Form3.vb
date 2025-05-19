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

        Try
            Dim STRSQL As String = "INSERT INTO Products (product_number, product_name, price, group_name, expiry_date, status) VALUES (?, ?, ?, ?, ?, ?)"

            Dim cmd As New Command
            cmd.ActiveConnection = CNN
            cmd.CommandText = STRSQL
            cmd.CommandType = CommandTypeEnum.adCmdText

            cmd.Parameters.Append(cmd.CreateParameter("product_number", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , prodno))
            cmd.Parameters.Append(cmd.CreateParameter("product_name", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, prodname_txt.Text.Trim()))
            cmd.Parameters.Append(cmd.CreateParameter("price", DataTypeEnum.adCurrency, ParameterDirectionEnum.adParamInput, , priceval))
            cmd.Parameters.Append(cmd.CreateParameter("group_name", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, prodgroup_txt.Text.Trim()))
            cmd.Parameters.Append(cmd.CreateParameter("expiry_date", DataTypeEnum.adDate, ParameterDirectionEnum.adParamInput, , expdate_txt.Value))
            cmd.Parameters.Append(cmd.CreateParameter("status", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, If(status_checkbox.Checked, "Available", "Unavailable")))

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

        If String.IsNullOrWhiteSpace(prodname_txt.Text) Then
            MessageBox.Show("Product name cannot be empty.")
            Exit Sub
        End If

        Try
            Dim STRSQL As String = "UPDATE Products SET product_name = ?, price = ?, group_name = ?, expiry_date = ?, status = ? WHERE product_number = ?"

            Dim cmd As New Command
            cmd.ActiveConnection = CNN
            cmd.CommandText = STRSQL
            cmd.CommandType = CommandTypeEnum.adCmdText

            cmd.Parameters.Append(cmd.CreateParameter("product_name", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, prodname_txt.Text.Trim()))
            cmd.Parameters.Append(cmd.CreateParameter("price", DataTypeEnum.adCurrency, ParameterDirectionEnum.adParamInput, , priceval))
            cmd.Parameters.Append(cmd.CreateParameter("group_name", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, prodgroup_txt.Text.Trim()))
            cmd.Parameters.Append(cmd.CreateParameter("expiry_date", DataTypeEnum.adDate, ParameterDirectionEnum.adParamInput, , expdate_txt.Value))
            cmd.Parameters.Append(cmd.CreateParameter("status", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, If(status_checkbox.Checked, "Available", "Unavailable")))
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
            Dim STRSQL As String = "DELETE FROM Products WHERE product_number = ?"
            Dim cmd As New Command
            cmd.ActiveConnection = CNN
            cmd.CommandText = STRSQL
            cmd.CommandType = CommandTypeEnum.adCmdText
            cmd.Parameters.Append(cmd.CreateParameter("product_number", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , Integer.Parse(prodno_txt.Text)))

            cmd.Execute()
            MessageBox.Show("Product deleted.")
            LoadProducts()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Delete failed: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadProducts()
        Dim RST As New Recordset
        Dim STRSQL As String = "SELECT product_number, product_name, price, group_name, expiry_date, status FROM Products"

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

            While Not RST.EOF
                dt.Rows.Add(
                    RST.Fields("product_number").Value,
                    RST.Fields("product_name").Value,
                    RST.Fields("price").Value,
                    RST.Fields("group_name").Value,
                    RST.Fields("expiry_date").Value,
                    RST.Fields("status").Value
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

    Private Sub Clear_button_Click(sender As Object, e As EventArgs) Handles Clear_button.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        prodno_txt.Clear()
        prodname_txt.Clear()
        price_txt.Clear()
        expdate_txt.Value = Date.Today()
        status_checkbox.Checked = False
    End Sub

    Private Sub Btn_load_Click(sender As Object, e As EventArgs) Handles Btn_load.Click
        LoadProducts()
    End Sub


End Class
