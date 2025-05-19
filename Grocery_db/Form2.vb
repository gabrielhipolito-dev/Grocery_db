Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Btn_create_Click(sender As Object, e As EventArgs) Handles Btn_create.Click
        ' Validate inputs
        Dim allTextFilled As Boolean = Not String.IsNullOrWhiteSpace(tb_username.Text) AndAlso
                                       Not String.IsNullOrWhiteSpace(tb_firstname.Text) AndAlso
                                       Not String.IsNullOrWhiteSpace(tb_lastname.Text) AndAlso
                                       Not String.IsNullOrWhiteSpace(tb_email.Text) AndAlso
                                       Not String.IsNullOrWhiteSpace(tb_password.Text)

        Dim emailValid As Boolean = tb_email.Text.ToLower().EndsWith("@gmail.com")
        Dim hasSpecialChar As Boolean = tb_password.Text.Any(Function(c) Not Char.IsLetterOrDigit(c))
        Dim roleSelected As Boolean = RbAdmin.Checked OrElse RbUser.Checked
        Dim birthday As Date = dtp_birthday.Value
        Dim age As Integer = Date.Today.Year - birthday.Year
        If birthday > Date.Today.AddYears(-age) Then age -= 1
        Dim is18OrOlder As Boolean = age >= 18

        If Not allTextFilled Then
            MessageBox.Show("Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Not emailValid Then
            MessageBox.Show("Email must end with @gmail.com", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Not hasSpecialChar Then
            MessageBox.Show("Password must contain at least one special character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Not roleSelected Then
            MessageBox.Show("Please select a role (Admin/User).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Not is18OrOlder Then
            MessageBox.Show("You must be at least 18 years old.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Proceed to insert into database
        Dim role As String = If(RbAdmin.Checked, "Admin", "User")

        Try
            Using conn As New OleDb.OleDbConnection("Provider=SQLOLEDB;Data Source=GABRIEL;Initial Catalog=INVENTORY;Integrated Security=SSPI;")
                conn.Open()

                ' Check if username or email already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM Accounts WHERE Username = ? OR Email = ?"
                Using checkCmd As New OleDb.OleDbCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("?", tb_username.Text.Trim())
                    checkCmd.Parameters.AddWithValue("?", tb_email.Text.Trim())
                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If exists > 0 Then
                        MessageBox.Show("Username or Email already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' Step 1: Insert into Accounts
                Dim insertAccountQuery As String = "INSERT INTO Accounts (Username, Email, Password, Role) VALUES (?, ?, ?, ?)"
                Using insertAccountCmd As New OleDb.OleDbCommand(insertAccountQuery, conn)
                    insertAccountCmd.Parameters.AddWithValue("?", tb_username.Text.Trim())
                    insertAccountCmd.Parameters.AddWithValue("?", tb_email.Text.Trim())
                    insertAccountCmd.Parameters.AddWithValue("?", tb_password.Text.Trim())
                    insertAccountCmd.Parameters.AddWithValue("?", role)
                    insertAccountCmd.ExecuteNonQuery()
                End Using

                ' Step 2: Get new AccountID
                Dim getIdQuery As String = "SELECT @@IDENTITY"
                Dim accountId As Integer
                Using getIdCmd As New OleDb.OleDbCommand(getIdQuery, conn)
                    accountId = Convert.ToInt32(getIdCmd.ExecuteScalar())
                End Using

                ' Step 3: Insert into Admins or Users
                If role = "Admin" Then
                    Dim insertAdminQuery As String = "INSERT INTO Admins (AccountID, FirstName, LastName, DateOfBirth) VALUES (?, ?, ?, ?)"
                    Using insertAdminCmd As New OleDb.OleDbCommand(insertAdminQuery, conn)
                        insertAdminCmd.Parameters.AddWithValue("?", accountId)
                        insertAdminCmd.Parameters.AddWithValue("?", tb_firstname.Text.Trim())
                        insertAdminCmd.Parameters.AddWithValue("?", tb_lastname.Text.Trim())
                        insertAdminCmd.Parameters.AddWithValue("?", birthday)
                        insertAdminCmd.ExecuteNonQuery()
                    End Using
                ElseIf role = "User" Then
                    Dim insertUserQuery As String = "INSERT INTO Users (AccountID, FirstName, LastName, DateOfBirth) VALUES (?, ?, ?, ?)"
                    Using insertUserCmd As New OleDb.OleDbCommand(insertUserQuery, conn)
                        insertUserCmd.Parameters.AddWithValue("?", accountId)
                        insertUserCmd.Parameters.AddWithValue("?", tb_firstname.Text.Trim())
                        insertUserCmd.Parameters.AddWithValue("?", tb_lastname.Text.Trim())
                        insertUserCmd.Parameters.AddWithValue("?", birthday)
                        insertUserCmd.ExecuteNonQuery()
                    End Using
                End If

                MessageBox.Show(role & " account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tb_lastname_TextChanged(sender As Object, e As EventArgs) Handles tb_lastname.TextChanged

    End Sub
End Class