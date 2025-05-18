Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Btn_create_Click(sender As Object, e As EventArgs) Handles Btn_create.Click
        ' Double-check validation before proceeding



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

        Dim valid As Boolean = False

        If allTextFilled Then
            If emailValid Then
                If hasSpecialChar Then
                    If adminSelected Then
                        If is18OrOlder Then
                            valid = True
                        Else
                            MessageBox.Show("You're not legal to create an account", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Please check the radio box", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Else
                    MessageBox.Show("Please fill out your password with special characters", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please fill out your email with @gmail.com", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please fill out Username, firstname and lastname.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class