
Imports System.Data.OleDb

Public Class Form1


    Private Sub Btn_createaccount_Click(sender As Object, e As EventArgs) Handles BtnCreateAccount.Click
        AddHandler Form2.FormClosed, AddressOf Form2_FormClosed
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Show()
        RemoveHandler Form2.FormClosed, AddressOf Form2_FormClosed
    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click


        Dim MSG As String = ""
        Dim isALLOK As Boolean = True

        If Trim(TextBox1.Text) = "" Then
            MSG &= "Enter Username" & vbCrLf
            isALLOK = False
        End If
        If Trim(TextBox2.Text) = "" Then
            MSG &= "Enter Password" & vbCrLf
            isALLOK = False
        End If

        If isALLOK Then
            Try
                ' Define the connection string directly here
                Dim connString As String = "Provider=SQLOLEDB.1;Data Source=GABRIEL;Initial Catalog=INVENTORY;Integrated Security=SSPI;Encrypt=yes;TrustServerCertificate=yes"

                Using conn As New OleDbConnection(connString)
                    conn.Open()

                    Dim query As String = "SELECT COUNT(*) FROM Admins WHERE Username = ? AND Password = ?"
                    Using cmd As New OleDbCommand(query, conn)
                        cmd.Parameters.AddWithValue("?", Trim(TextBox1.Text))
                        cmd.Parameters.AddWithValue("?", Trim(TextBox2.Text))

                        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                        If count > 0 Then
                            MsgBox("Login successful!")
                            Form3.Show()
                            Me.Hide()
                        Else
                            MsgBox("Invalid credentials")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Else
            MsgBox(MSG)
        End If



    End Sub
End Class
