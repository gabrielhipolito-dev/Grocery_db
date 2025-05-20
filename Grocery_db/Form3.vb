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
        Try
            ' Validate product number
            Dim prodno As Integer
            If Not Integer.TryParse(prodno_txt.Text, prodno) Then
                MessageBox.Show("Product Number must be a whole number.")
                Exit Sub
            End If

            ' Validate price
            Dim priceval As Decimal
            If Not Decimal.TryParse(price_txt.Text, priceval) Then
                MessageBox.Show("Price must be a decimal.")
                Exit Sub
            End If

            ' Validate quantity
            Dim quantityval As Integer
            If Not Integer.TryParse(quantity_txt.Text, quantityval) OrElse quantityval < 0 Then
                MessageBox.Show("Quantity must be a non-negative whole number.")
                Exit Sub
            End If

            ' Expiry validation: must be at least 7 days from today
            Dim expiryDate As Date = expdate_txt.Value.Date
            If expiryDate < Date.Today.AddDays(7) Then
                MessageBox.Show("Expiry date must be at least 7 days from today.")
                Exit Sub
            End If

            Dim productName As String = prodname_txt.Text.Trim()
            Dim groupName As String = prodgroup_txt.Text.Trim()
            Dim statusVal As String = If(quantityval > 0, "Available", "Unavailable")

            ' 1. Insert into ProductCatalog if not exists
            Dim checkCatalog As New Command
            checkCatalog.ActiveConnection = CNN
            checkCatalog.CommandText = "IF NOT EXISTS (SELECT 1 FROM ProductCatalog WHERE product_name = ?) INSERT INTO ProductCatalog (product_name, group_name) VALUES (?, ?)"
            checkCatalog.CommandType = CommandTypeEnum.adCmdText
            checkCatalog.Parameters.Append(checkCatalog.CreateParameter("product_name_check", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, productName))
            checkCatalog.Parameters.Append(checkCatalog.CreateParameter("product_name", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, productName))
            checkCatalog.Parameters.Append(checkCatalog.CreateParameter("group_name", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, groupName))
            checkCatalog.Execute()

            ' 2. Insert into ProductStock
            Dim STRSQL As String = "INSERT INTO ProductStock (product_number, product_name, price, expiry_date, quantity, status) VALUES (?, ?, ?, ?, ?, ?)"
            Dim cmd As New Command
            cmd.ActiveConnection = CNN
            cmd.CommandText = STRSQL
            cmd.CommandType = CommandTypeEnum.adCmdText

            cmd.Parameters.Append(cmd.CreateParameter("product_number", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , prodno))
            cmd.Parameters.Append(cmd.CreateParameter("product_name", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 100, productName))
            cmd.Parameters.Append(cmd.CreateParameter("price", DataTypeEnum.adCurrency, ParameterDirectionEnum.adParamInput, , priceval))
            cmd.Parameters.Append(cmd.CreateParameter("expiry_date", DataTypeEnum.adDate, ParameterDirectionEnum.adParamInput, , expiryDate))
            cmd.Parameters.Append(cmd.CreateParameter("quantity", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , quantityval))
            cmd.Parameters.Append(cmd.CreateParameter("status", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, statusVal))

            cmd.Execute()
            MessageBox.Show("Product saved successfully!")
            LoadProducts()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Save failed: " & ex.Message)
        End Try
    End Sub



    Private Sub Update_button_Click(sender As Object, e As EventArgs) Handles Update_button.Click
        ' Validate product number
        Dim prodno As Integer
        If Not Integer.TryParse(prodno_txt.Text, prodno) Then
            MessageBox.Show("Invalid product number.")
            Exit Sub
        End If

        ' Validate product name and group name
        Dim prodName As String = prodname_txt.Text.Trim()
        Dim groupName As String = prodgroup_txt.Text.Trim()

        If prodName = "" OrElse groupName = "" Then
            MessageBox.Show("Product name and group name cannot be empty.")
            Exit Sub
        End If

        ' Validate price
        Dim priceVal As Decimal
        If Not Decimal.TryParse(price_txt.Text, priceVal) Then
            MessageBox.Show("Invalid price.")
            Exit Sub
        End If
        If priceVal < 0 Then
            MessageBox.Show("Price cannot be negative.")
            Exit Sub
        End If

        ' Validate quantity
        Dim quantityVal As Integer
        If Not Integer.TryParse(quantity_txt.Text, quantityVal) Then
            MessageBox.Show("Invalid quantity.")
            Exit Sub
        End If
        If quantityVal < 0 Then
            MessageBox.Show("Quantity cannot be negative.")
            Exit Sub
        End If

        ' Validate expiry date
        Dim expiryDate As Date = expdate_txt.Value.Date
        If expiryDate < Date.Today.AddDays(7) Then
            MessageBox.Show("Expiry date must be at least 7 days from today.")
            Exit Sub
        End If

        ' Determine status
        Dim statusVal As String = If(quantityVal > 0, "Available", "Unavailable")

        Try
            ' Ensure ProductCatalog contains the product
            Dim rs As New ADODB.Recordset
            Dim checkSQL As String = "SELECT product_name FROM ProductCatalog WHERE LOWER(product_name) = LOWER(?)"
            Dim checkCmd As New ADODB.Command
            checkCmd.ActiveConnection = CNN
            checkCmd.CommandText = checkSQL
            checkCmd.CommandType = ADODB.CommandTypeEnum.adCmdText
            checkCmd.Parameters.Append(checkCmd.CreateParameter("product_name", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 100, prodName))
            rs = checkCmd.Execute()

            If rs.EOF Then
                ' Insert new product into ProductCatalog
                Dim insertCmd As New ADODB.Command
                insertCmd.ActiveConnection = CNN
                insertCmd.CommandText = "INSERT INTO ProductCatalog (product_name, group_name) VALUES (?, ?)"
                insertCmd.CommandType = ADODB.CommandTypeEnum.adCmdText
                insertCmd.Parameters.Append(insertCmd.CreateParameter("product_name", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 100, prodName))
                insertCmd.Parameters.Append(insertCmd.CreateParameter("group_name", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 100, groupName))
                insertCmd.Execute()
            End If
            rs.Close()

            ' Update ProductStock
            Dim updateCmd As New ADODB.Command
            updateCmd.ActiveConnection = CNN
            updateCmd.CommandText = "UPDATE ProductStock SET product_name = ?, price = ?, expiry_date = ?, quantity = ?, status = ? WHERE product_number = ?"
            updateCmd.CommandType = ADODB.CommandTypeEnum.adCmdText

            updateCmd.Parameters.Append(updateCmd.CreateParameter("product_name", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 100, prodName))
            updateCmd.Parameters.Append(updateCmd.CreateParameter("price", ADODB.DataTypeEnum.adCurrency, ADODB.ParameterDirectionEnum.adParamInput, , priceVal))
            updateCmd.Parameters.Append(updateCmd.CreateParameter("expiry_date", ADODB.DataTypeEnum.adDate, ADODB.ParameterDirectionEnum.adParamInput, , expiryDate))
            updateCmd.Parameters.Append(updateCmd.CreateParameter("quantity", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, , quantityVal))
            updateCmd.Parameters.Append(updateCmd.CreateParameter("status", ADODB.DataTypeEnum.adVarChar, ADODB.ParameterDirectionEnum.adParamInput, 20, statusVal))
            updateCmd.Parameters.Append(updateCmd.CreateParameter("product_number", ADODB.DataTypeEnum.adInteger, ADODB.ParameterDirectionEnum.adParamInput, , prodno))

            Dim affected As Integer
            updateCmd.Execute(affected)

            If affected > 0 Then
                MessageBox.Show("Product updated successfully.")
                LoadProducts()
                ClearFields()
            Else
                MessageBox.Show("No product found with that product number.")
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

            Dim confirmResult = MessageBox.Show("Are you sure you want to delete this product stock entry?", "Confirm Delete", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.Yes Then
                Dim STRSQL As String = "DELETE FROM ProductStock WHERE product_number = ?"
                Dim cmd As New Command
                cmd.ActiveConnection = CNN
                cmd.CommandText = STRSQL
                cmd.CommandType = CommandTypeEnum.adCmdText
                cmd.Parameters.Append(cmd.CreateParameter("product_number", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , productNumber))
                cmd.Execute()
                MessageBox.Show("Deleted successfully!")
                LoadProducts()
                ClearFields()
            End If
        Catch ex As Exception
            MessageBox.Show("Delete failed: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadProducts()
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

    Private Sub Btn_search_Click(sender As Object, e As EventArgs) Handles Btn_search.Click
        Dim searchText As String = txt_searchbox.Text.Trim()

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






    Private Sub ClearFields()
        prodno_txt.Clear()
        prodname_txt.Clear()
        price_txt.Clear()
        quantity_txt.Clear()
        expdate_txt.Value = Date.Today

    End Sub
    Private Sub Clear_button_Click(sender As Object, e As EventArgs) Handles Clear_button.Click
        ClearFields()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            prodno_txt.Text = If(row.Cells(0).Value IsNot Nothing, row.Cells(0).Value.ToString(), "")
            prodname_txt.Text = If(row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString(), "")
            prodgroup_txt.Text = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
            price_txt.Text = If(row.Cells(3).Value IsNot Nothing, row.Cells(3).Value.ToString(), "")

            ' Cell(4) = expiry_date
            If row.Cells(4).Value IsNot Nothing AndAlso IsDate(row.Cells(4).Value) Then
                expdate_txt.Value = Convert.ToDateTime(row.Cells(4).Value)
            Else
                expdate_txt.Value = Date.Today
            End If

            quantity_txt.Text = If(row.Cells(5).Value IsNot Nothing, row.Cells(5).Value.ToString(), "")
        End If

    End Sub

End Class
