Module Module1

    Public CNN As New ADODB.Connection

    Public Sub DBConnect()

        CNN.ConnectionString = "Provider=SQLOLEDB.1;Data Source=GABRIEL;Initial Catalog=INVENTORY;Integrated Security=SSPI;Encrypt=yes;TrustServerCertificate=yes"

        On Error GoTo ErrorHandler
        CNN.Open()
        Exit Sub

ErrorHandler:
        MsgBox("Connection failed: " & Err.Description, vbCritical, "Database Error")
    End Sub

    Friend Function ConnectionString() As String
        Throw New NotImplementedException()
    End Function
End Module