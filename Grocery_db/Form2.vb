Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Btn_create_Click(sender As Object, e As EventArgs) Handles Btn_create.Click
        ' Validation
        Dim allTextFilled As Boolean = Not String.IsNullOrWhiteSpace(tb_username.Text) AndAlso
                                       Not String.IsNullOrWhiteSpace(tb_firstname.Text) AndAlso
                                       Not String.IsNullOrWhiteSpace(tb_lastname.Text)

        Dim emailValid As Boolean = tb_email.Text.ToLower().EndsWith("@gmail.com")
        Dim hasSpecialChar As Boolean = tb_password.Text.Any(Function(c) Not Char.IsLetterOrDigit(c))
        Dim adminSelected As Boolean = admin_button.Checked

        Dim birthday As Date = dtp_birthday.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthday.Year
        If (birthday > today.AddYears(-age)) Then age -= 1
        Dim is18OrOlder As Boolean = age >= 18

        If Not allTextFilled Then
            MessageBox.Show("Please fill out Username, First Name, and Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not emailValid Then
            MessageBox.Show("Please provide a valid Gmail address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not hasSpecialChar Then
            MessageBox.Show("Password must contain at least one special character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not adminSelected Then
            MessageBox.Show("Please check the admin radio button.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not is18OrOlder Then
            MessageBox.Show("You must be at least 18 years old.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' INSERT INTO DATABASE
        Try
            Dim connString As String = "Provider=SQLOLEDB.1;Data Source=GABRIEL;Initial Catalog=INVENTORY;Integrated Security=SSPI;Encrypt=yes;TrustServerCertificate=yes"

            Using conn As New OleDb.OleDbConnection(connString)
                conn.Open()

                Dim query As String = "INSERT INTO Admins (Username, Email, FirstName, LastName, Password, DateOfBirth) " &
                                      "VALUES (?, ?, ?, ?, ?, ?)"

                Using cmd As New OleDb.OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("?", tb_username.Text.Trim())
                    cmd.Parameters.AddWithValue("?", tb_email.Text.Trim())
                    cmd.Parameters.AddWithValue("?", tb_firstname.Text.Trim())
                    cmd.Parameters.AddWithValue("?", tb_lastname.Text.Trim())
                    cmd.Parameters.AddWithValue("?", tb_password.Text.Trim()) ' consider hashing!
                    cmd.Parameters.AddWithValue("?", birthday)

                    Dim rowsInserted As Integer = cmd.ExecuteNonQuery()

                    If rowsInserted > 0 Then
                        MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to create account.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class