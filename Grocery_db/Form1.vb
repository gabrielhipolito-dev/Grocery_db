
Imports System.Data.OleDb

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_createaccount_Click(sender As Object, e As EventArgs) Handles btn_createaccount.Click
        AddHandler Form2.FormClosed, AddressOf Form2_FormClosed
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Show()
        RemoveHandler Form2.FormClosed, AddressOf Form2_FormClosed
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
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
                ' Use OleDbCommand for parameterized query
                Using conn As New OleDbConnection(Module1.ConnectionString)
                    conn.Open()
                    Dim query As String = "SELECT fullname FROM users WHERE username = ? AND password = ?"
                    Using cmd As New OleDbCommand(query, conn)
                        cmd.Parameters.AddWithValue("?", Trim(TextBox1.Text))
                        cmd.Parameters.AddWithValue("?", Trim(TextBox2.Text))
                        Using reader As OleDbDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                MsgBox("Welcome " & reader("fullname").ToString())
                                MainForm.Show()
                                Me.Hide()
                            Else
                                MsgBox("Invalid Credentials")
                            End If
                        End Using
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
