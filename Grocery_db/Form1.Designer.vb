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
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(98, 181)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(290, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Btn_login
        ' 
        Btn_login.BackColor = Color.DarkOliveGreen
        Btn_login.FlatStyle = FlatStyle.Popup
        Btn_login.Font = New Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_login.ForeColor = Color.White
        Btn_login.Location = New Point(98, 341)
        Btn_login.Margin = New Padding(3, 4, 3, 4)
        Btn_login.Name = "Btn_login"
        Btn_login.Size = New Size(290, 73)
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
        Label1.Location = New Point(98, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 18)
        Label1.TabIndex = 2
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(98, 239)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 18)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(98, 272)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(290, 27)
        TextBox2.TabIndex = 3
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' BtnCreateAccount
        ' 
        BtnCreateAccount.BackColor = Color.Transparent
        BtnCreateAccount.FlatStyle = FlatStyle.Flat
        BtnCreateAccount.ForeColor = Color.Black
        BtnCreateAccount.ImageAlign = ContentAlignment.TopLeft
        BtnCreateAccount.Location = New Point(98, 443)
        BtnCreateAccount.Margin = New Padding(3, 4, 3, 4)
        BtnCreateAccount.Name = "BtnCreateAccount"
        BtnCreateAccount.Size = New Size(290, 51)
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
        Label3.Location = New Point(98, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 54)
        Label3.TabIndex = 6
        Label3.Text = "Login"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(513, 106)
        Label5.Name = "Label5"
        Label5.Size = New Size(389, 92)
        Label5.TabIndex = 8
        Label5.Text = "Grocery Inventory " & vbCrLf & "Management System" & vbCrLf
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveBorder
        BackgroundImage = My.Resources.Resources.green_watercolor_texture_background_free_vector
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(914, 599)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(BtnCreateAccount)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(Btn_login)
        Controls.Add(TextBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
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
    Friend WithEvents Label5 As Label

End Class
