<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        Btn_login = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        BtnCreateAccount = New Button()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(86, 136)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(254, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Btn_login
        ' 
        Btn_login.BackColor = Color.DarkOliveGreen
        Btn_login.FlatStyle = FlatStyle.Popup
        Btn_login.Font = New Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_login.ForeColor = Color.White
        Btn_login.Location = New Point(86, 256)
        Btn_login.Name = "Btn_login"
        Btn_login.Size = New Size(254, 55)
        Btn_login.TabIndex = 1
        Btn_login.Text = "Login"
        Btn_login.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(86, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 15)
        Label1.TabIndex = 2
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(86, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(86, 204)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(254, 23)
        TextBox2.TabIndex = 3
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' BtnCreateAccount
        ' 
        BtnCreateAccount.BackColor = Color.Transparent
        BtnCreateAccount.FlatStyle = FlatStyle.Flat
        BtnCreateAccount.ForeColor = Color.Black
        BtnCreateAccount.ImageAlign = ContentAlignment.TopLeft
        BtnCreateAccount.Location = New Point(86, 332)
        BtnCreateAccount.Name = "BtnCreateAccount"
        BtnCreateAccount.Size = New Size(254, 38)
        BtnCreateAccount.TabIndex = 5
        BtnCreateAccount.Text = "Not yet registered? Create an account"
        BtnCreateAccount.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Georgia", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(86, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 43)
        Label3.TabIndex = 6
        Label3.Text = "Login"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(466, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(283, 76)
        Label4.TabIndex = 7
        Label4.Text = "Grocery Inventory " & vbCrLf & "Management"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveBorder
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(800, 449)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(BtnCreateAccount)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(Btn_login)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form1"
        ShowIcon = False
        Text = "Login Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btn_login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnCreateAccount As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
