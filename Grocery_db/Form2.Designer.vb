<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        tb_firstname = New TextBox()
        Label1 = New Label()
        Btn_create = New Button()
        Label2 = New Label()
        Label3 = New Label()
        tb_password = New TextBox()
        Label4 = New Label()
        tb_username = New TextBox()
        Label6 = New Label()
        dtp_birthday = New DateTimePicker()
        Label7 = New Label()
        RbAdmin = New RadioButton()
        tb_lastname = New TextBox()
        tb_email = New TextBox()
        Label5 = New Label()
        RbUser = New RadioButton()
        SuspendLayout()
        ' 
        ' tb_firstname
        ' 
        tb_firstname.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tb_firstname.Location = New Point(37, 173)
        tb_firstname.Margin = New Padding(3, 4, 3, 4)
        tb_firstname.Name = "tb_firstname"
        tb_firstname.Size = New Size(167, 25)
        tb_firstname.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(224, 239)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 18)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Btn_create
        ' 
        Btn_create.BackColor = Color.DarkOliveGreen
        Btn_create.FlatStyle = FlatStyle.Popup
        Btn_create.Font = New Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_create.ForeColor = SystemColors.ButtonHighlight
        Btn_create.Location = New Point(112, 435)
        Btn_create.Margin = New Padding(3, 4, 3, 4)
        Btn_create.Name = "Btn_create"
        Btn_create.Size = New Size(206, 59)
        Btn_create.TabIndex = 2
        Btn_create.Text = "Create Account"
        Btn_create.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(37, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 18)
        Label2.TabIndex = 4
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(37, 335)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 18)
        Label3.TabIndex = 8
        Label3.Text = "Password"
        ' 
        ' tb_password
        ' 
        tb_password.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tb_password.Location = New Point(37, 360)
        tb_password.Margin = New Padding(3, 4, 3, 4)
        tb_password.Name = "tb_password"
        tb_password.Size = New Size(167, 25)
        tb_password.TabIndex = 7
        tb_password.UseSystemPasswordChar = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(224, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 18)
        Label4.TabIndex = 6
        Label4.Text = "Last Name"
        ' 
        ' tb_username
        ' 
        tb_username.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tb_username.Location = New Point(224, 261)
        tb_username.Margin = New Padding(3, 4, 3, 4)
        tb_username.Name = "tb_username"
        tb_username.Size = New Size(167, 25)
        tb_username.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(37, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 18)
        Label6.TabIndex = 10
        Label6.Text = "Email"
        ' 
        ' dtp_birthday
        ' 
        dtp_birthday.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtp_birthday.Format = DateTimePickerFormat.Short
        dtp_birthday.Location = New Point(224, 357)
        dtp_birthday.Margin = New Padding(3, 4, 3, 4)
        dtp_birthday.Name = "dtp_birthday"
        dtp_birthday.Size = New Size(228, 25)
        dtp_birthday.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DimGray
        Label7.Location = New Point(224, 335)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 18)
        Label7.TabIndex = 16
        Label7.Text = "Date of Birth"
        ' 
        ' RbAdmin
        ' 
        RbAdmin.AutoSize = True
        RbAdmin.BackColor = Color.Transparent
        RbAdmin.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbAdmin.ForeColor = Color.DimGray
        RbAdmin.Location = New Point(37, 105)
        RbAdmin.Margin = New Padding(3, 4, 3, 4)
        RbAdmin.Name = "RbAdmin"
        RbAdmin.Size = New Size(74, 22)
        RbAdmin.TabIndex = 17
        RbAdmin.TabStop = True
        RbAdmin.Text = "Admin"
        RbAdmin.UseVisualStyleBackColor = False
        ' 
        ' tb_lastname
        ' 
        tb_lastname.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tb_lastname.Location = New Point(224, 173)
        tb_lastname.Margin = New Padding(3, 4, 3, 4)
        tb_lastname.Name = "tb_lastname"
        tb_lastname.Size = New Size(167, 25)
        tb_lastname.TabIndex = 19
        ' 
        ' tb_email
        ' 
        tb_email.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tb_email.Location = New Point(37, 261)
        tb_email.Margin = New Padding(3, 4, 3, 4)
        tb_email.Name = "tb_email"
        tb_email.Size = New Size(167, 25)
        tb_email.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(61, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(345, 46)
        Label5.TabIndex = 21
        Label5.Text = "Registration Form"
        ' 
        ' RbUser
        ' 
        RbUser.AutoSize = True
        RbUser.Location = New Point(207, 105)
        RbUser.Margin = New Padding(3, 4, 3, 4)
        RbUser.Name = "RbUser"
        RbUser.Size = New Size(59, 24)
        RbUser.TabIndex = 22
        RbUser.TabStop = True
        RbUser.Text = "User"
        RbUser.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.green_watercolor_texture_background_free_vector
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 600)
        Controls.Add(RbUser)
        Controls.Add(Label5)
        Controls.Add(tb_email)
        Controls.Add(tb_lastname)
        Controls.Add(RbAdmin)
        Controls.Add(Label7)
        Controls.Add(dtp_birthday)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(tb_password)
        Controls.Add(Label4)
        Controls.Add(tb_username)
        Controls.Add(Label2)
        Controls.Add(Btn_create)
        Controls.Add(Label1)
        Controls.Add(tb_firstname)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "Registration Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tb_firstname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_create As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_username As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtp_birthday As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents RbAdmin As RadioButton
    Friend WithEvents tb_lastname As TextBox
    Friend WithEvents tb_email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RbUser As RadioButton
End Class
