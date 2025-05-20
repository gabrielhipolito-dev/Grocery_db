<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        prodno_txt = New TextBox()
        prodname_txt = New TextBox()
        price_txt = New TextBox()
        prodgroup_txt = New ComboBox()
        expdate_txt = New DateTimePicker()
        Save_button = New Button()
        Update_button = New Button()
        Delete_button = New Button()
        Clear_button = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        txt_searchbox = New TextBox()
        Btn_search = New Button()
        Label7 = New Label()
        quantity_txt = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Georgia", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(26, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 39)
        Label1.TabIndex = 0
        Label1.Text = "Admin Form"
        ' 
        ' prodno_txt
        ' 
        prodno_txt.Location = New Point(93, 89)
        prodno_txt.Name = "prodno_txt"
        prodno_txt.Size = New Size(219, 25)
        prodno_txt.TabIndex = 1
        ' 
        ' prodname_txt
        ' 
        prodname_txt.Location = New Point(93, 151)
        prodname_txt.Name = "prodname_txt"
        prodname_txt.Size = New Size(219, 25)
        prodname_txt.TabIndex = 2
        ' 
        ' price_txt
        ' 
        price_txt.Location = New Point(93, 213)
        price_txt.Name = "price_txt"
        price_txt.Size = New Size(219, 25)
        price_txt.TabIndex = 3
        ' 
        ' prodgroup_txt
        ' 
        prodgroup_txt.FormattingEnabled = True
        prodgroup_txt.Items.AddRange(New Object() {"Beverage", "Snacks", "Cannes Goods", "Cleaning Materials"})
        prodgroup_txt.Location = New Point(93, 272)
        prodgroup_txt.Name = "prodgroup_txt"
        prodgroup_txt.Size = New Size(174, 26)
        prodgroup_txt.TabIndex = 4
        ' 
        ' expdate_txt
        ' 
        expdate_txt.Location = New Point(93, 332)
        expdate_txt.Name = "expdate_txt"
        expdate_txt.Size = New Size(250, 25)
        expdate_txt.TabIndex = 5
        ' 
        ' Save_button
        ' 
        Save_button.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Save_button.FlatStyle = FlatStyle.Popup
        Save_button.Location = New Point(89, 454)
        Save_button.Name = "Save_button"
        Save_button.Size = New Size(94, 29)
        Save_button.TabIndex = 7
        Save_button.Text = "Save"
        Save_button.UseVisualStyleBackColor = False
        ' 
        ' Update_button
        ' 
        Update_button.BackColor = Color.Gold
        Update_button.FlatStyle = FlatStyle.Popup
        Update_button.ForeColor = SystemColors.ActiveCaptionText
        Update_button.Location = New Point(218, 454)
        Update_button.Name = "Update_button"
        Update_button.Size = New Size(94, 29)
        Update_button.TabIndex = 8
        Update_button.Text = "Update"
        Update_button.UseVisualStyleBackColor = False
        ' 
        ' Delete_button
        ' 
        Delete_button.BackColor = Color.Red
        Delete_button.FlatStyle = FlatStyle.Popup
        Delete_button.Location = New Point(89, 499)
        Delete_button.Name = "Delete_button"
        Delete_button.Size = New Size(94, 29)
        Delete_button.TabIndex = 9
        Delete_button.Text = "Delete"
        Delete_button.UseVisualStyleBackColor = False
        ' 
        ' Clear_button
        ' 
        Clear_button.BackColor = SystemColors.ActiveBorder
        Clear_button.FlatStyle = FlatStyle.Popup
        Clear_button.Location = New Point(218, 499)
        Clear_button.Name = "Clear_button"
        Clear_button.Size = New Size(94, 29)
        Clear_button.TabIndex = 10
        Clear_button.Text = "Clear"
        Clear_button.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(93, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 18)
        Label2.TabIndex = 11
        Label2.Text = "Product No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(93, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 18)
        Label3.TabIndex = 12
        Label3.Text = "Product Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(93, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 18)
        Label4.TabIndex = 13
        Label4.Text = "Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(93, 251)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 18)
        Label5.TabIndex = 14
        Label5.Text = "Product Group"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(93, 311)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 18)
        Label6.TabIndex = 15
        Label6.Text = "Expiry Date"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(369, 115)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(630, 396)
        DataGridView1.TabIndex = 18
        ' 
        ' txt_searchbox
        ' 
        txt_searchbox.BackColor = Color.Ivory
        txt_searchbox.Location = New Point(369, 79)
        txt_searchbox.Margin = New Padding(2)
        txt_searchbox.Name = "txt_searchbox"
        txt_searchbox.Size = New Size(630, 25)
        txt_searchbox.TabIndex = 20
        ' 
        ' Btn_search
        ' 
        Btn_search.BackColor = Color.DarkOliveGreen
        Btn_search.FlatStyle = FlatStyle.Popup
        Btn_search.ForeColor = SystemColors.Control
        Btn_search.Location = New Point(369, 49)
        Btn_search.Name = "Btn_search"
        Btn_search.Size = New Size(75, 23)
        Btn_search.TabIndex = 22
        Btn_search.Text = "Search"
        Btn_search.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(93, 366)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 18)
        Label7.TabIndex = 23
        Label7.Text = "Quantity"
        ' 
        ' quantity_txt
        ' 
        quantity_txt.Location = New Point(93, 384)
        quantity_txt.Name = "quantity_txt"
        quantity_txt.Size = New Size(219, 25)
        quantity_txt.TabIndex = 24
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1028, 540)
        Controls.Add(quantity_txt)
        Controls.Add(Label7)
        Controls.Add(Btn_search)
        Controls.Add(txt_searchbox)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Clear_button)
        Controls.Add(Delete_button)
        Controls.Add(Update_button)
        Controls.Add(Save_button)
        Controls.Add(expdate_txt)
        Controls.Add(prodgroup_txt)
        Controls.Add(price_txt)
        Controls.Add(prodname_txt)
        Controls.Add(prodno_txt)
        Controls.Add(Label1)
        Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form3"
        Text = "Admin Form"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents prodno_txt As TextBox
    Friend WithEvents prodname_txt As TextBox
    Friend WithEvents price_txt As TextBox
    Friend WithEvents prodgroup_txt As ComboBox
    Friend WithEvents expdate_txt As DateTimePicker
    Friend WithEvents Save_button As Button
    Friend WithEvents Update_button As Button
    Friend WithEvents Delete_button As Button
    Friend WithEvents Clear_button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_searchbox As TextBox
    Friend WithEvents Btn_search As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents quantity_txt As TextBox
End Class
