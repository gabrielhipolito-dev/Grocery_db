Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub save_button_Click(sender As Object, e As EventArgs) Handles save_button.Click
        Dim prodno As Integer
        If Not Integer.TryParse(prodno_txt.Text, prodno) Then
            MessageBox.Show("Product Number must be a whole number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim priceval As Decimal
        If Not Decimal.TryParse(price_txt.Text, priceval) Then
            MessageBox.Show("Price must be a valid decimal number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim STRSQL As String
        STRSQL = "INSERT INTO Products"
        STRSQL = STRSQL & vbCrLf & "(product_number, product_name, price, group_name, expiry_date, status)"
        STRSQL = STRSQL & vbCrLf & "VALUES ("
        STRSQL = STRSQL & vbCrLf & "'" & prodno & "',"
        STRSQL = STRSQL & vbCrLf & "'" & prodname_txt.Text & "',"
        STRSQL = STRSQL & vbCrLf & "'" & priceval & "',"
        STRSQL = STRSQL & vbCrLf & "'" & prodgroup_txt.Text & "',"
        STRSQL = STRSQL & vbCrLf & "'" & expdate_txt.Value.ToString("yyyy-MM-dd") & "',"
        STRSQL = STRSQL & vbCrLf & "'" & If(status_checkbox.Checked, "Available", "Unavailable") & "')"
        CNN.Execute(STRSQL)
        MessageBox.Show("Product saved successfully!")
        Call LoadProducts()
        Call ClearFields()
    End Sub

    Private Sub update_button_Click(sender As Object, e As EventArgs) Handles update_button.Click
        Dim prodno As Integer
        If Not Integer.TryParse(prodno_txt.Text, prodno) Then
            MessageBox.Show("Product Number must be a whole number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim priceval As Decimal
        If Not Decimal.TryParse(price_txt.Text, priceval) Then
            MessageBox.Show("Price must be a valid decimal number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim STRSQL As String
        STRSQL = "UPDATE Products SET"
        STRSQL = STRSQL & vbCrLf & "product_name = '" & prodname_txt.Text & "'"
        STRSQL = STRSQL & vbCrLf & ",price = '" & priceval & "'"
        STRSQL = STRSQL & vbCrLf & ",group_name = '" & prodgroup_txt.Text & "'"
        STRSQL = STRSQL & vbCrLf & ",expiry_date = '" & expdate_txt.Value.ToString("yyyy-MM-dd") & "'"
        STRSQL = STRSQL & vbCrLf & ",status = '" & If(status_checkbox.Checked, "Available", "Unavailable") & "'"
        STRSQL = STRSQL & vbCrLf & "WHERE product_number = '" & prodno & "'"
        CNN.Execute(STRSQL)
        MessageBox.Show("Product updated successfully!")
        Call LoadProducts()
        Call ClearFields()
    End Sub

    Private Sub clear_button_Click(sender As Object, e As EventArgs) Handles clear_button.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        prodno_txt.Clear()
        prodname_txt.Clear()
        price_txt.Clear()
        prodgroup_txt.Items.Clear()
        expdate_txt.Value = Date.Today()
        status_checkbox.Checked = False
    End Sub

    Private Sub delete_button_Click(sender As Object, e As EventArgs) Handles delete_button.Click
        Dim STRSQL As String
        STRSQL = "DELETE FROM Products"
        STRSQL = STRSQL & vbCrLf & "WHERE product_number = '" & prodno_txt.Text & "'"
        CNN.Execute(STRSQL)
        MessageBox.Show("Product deleted successfully!")
        Call LoadProducts()
        Call ClearFields()
    End Sub

    Private Sub LoadProducts()
        Dim RST As New ADODB.Recordset
        Dim STRSQL As String
        STRSQL = "SELECT * FROM Products"
        Try
            If CNN.State = 0 Then CNN.Open()
            RST.Open(STRSQL, CNN, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

            If Not RST.EOF Then
                Dim dt As New DataTable
                dt.Load(RST)
                DataGridView1.DataSource = dt
            Else
                DataGridView1.DataSource = Nothing
            End If
            RST.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub


End Class