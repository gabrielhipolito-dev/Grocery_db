Module Module1
    Public CNN As New ADODB.Connection

    Public Sub DBConnect()
        ' For Windows Authentication:
        CNN.ConnectionString = "Provider=SQLOLEDB.1;Data Source=GABRIEL;Initial Catalog=INVENTORY;Integrated Security=SSPI;Encrypt=yes;TrustServerCertificate=yes"

        ' Or for SQL Authentication (if you have username/password):
        ' CNN.ConnectionString = "Provider=SQLOLEDB.1;Data Source=SABRIEL;Initial Catalog=DBDD_TUE_ML;User ID=your_username;Password=your_password;Encrypt=yes;TrustServerCertificate=yes"

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