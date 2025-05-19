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
        status_checkbox = New CheckBox()
        save_button = New Button()
        update_button = New Button()
        delete_button = New Button()
        clear_button = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        search_txt = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewCheckBoxColumn()
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
        ' status_checkbox
        ' 
        status_checkbox.AutoSize = True
        status_checkbox.Location = New Point(93, 375)
        status_checkbox.Name = "status_checkbox"
        status_checkbox.Size = New Size(91, 22)
        status_checkbox.TabIndex = 6
        status_checkbox.Text = "Available"
        status_checkbox.UseVisualStyleBackColor = True
        ' 
        ' save_button
        ' 
        save_button.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        save_button.FlatStyle = FlatStyle.Popup
        save_button.Location = New Point(93, 412)
        save_button.Name = "save_button"
        save_button.Size = New Size(94, 29)
        save_button.TabIndex = 7
        save_button.Text = "Save"
        save_button.UseVisualStyleBackColor = False
        ' 
        ' update_button
        ' 
        update_button.BackColor = Color.Gold
        update_button.FlatStyle = FlatStyle.Popup
        update_button.ForeColor = SystemColors.ActiveCaptionText
        update_button.Location = New Point(218, 412)
        update_button.Name = "update_button"
        update_button.Size = New Size(94, 29)
        update_button.TabIndex = 8
        update_button.Text = "Update"
        update_button.UseVisualStyleBackColor = False
        ' 
        ' delete_button
        ' 
        delete_button.BackColor = Color.Red
        delete_button.FlatStyle = FlatStyle.Popup
        delete_button.Location = New Point(93, 464)
        delete_button.Name = "delete_button"
        delete_button.Size = New Size(94, 29)
        delete_button.TabIndex = 9
        delete_button.Text = "Delete"
        delete_button.UseVisualStyleBackColor = False
        ' 
        ' clear_button
        ' 
        clear_button.BackColor = SystemColors.ActiveBorder
        clear_button.FlatStyle = FlatStyle.Popup
        clear_button.Location = New Point(218, 464)
        clear_button.Name = "clear_button"
        clear_button.Size = New Size(94, 29)
        clear_button.TabIndex = 10
        clear_button.Text = "Clear"
        clear_button.UseVisualStyleBackColor = False
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(369, 46)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 18)
        Label7.TabIndex = 16
        Label7.Text = "Search"
        ' 
        ' search_txt
        ' 
        search_txt.Location = New Point(369, 67)
        search_txt.Name = "search_txt"
        search_txt.Size = New Size(630, 25)
        search_txt.TabIndex = 17
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(369, 115)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(630, 396)
        DataGridView1.TabIndex = 18
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Product Number"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 137
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Product Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Price"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Group"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 80
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Expiry Date"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 107
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Status"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Resizable = DataGridViewTriState.True
        Column6.SortMode = DataGridViewColumnSortMode.Automatic
        Column6.Width = 78
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1028, 540)
        Controls.Add(DataGridView1)
        Controls.Add(search_txt)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(clear_button)
        Controls.Add(delete_button)
        Controls.Add(update_button)
        Controls.Add(save_button)
        Controls.Add(status_checkbox)
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
    Friend WithEvents status_checkbox As CheckBox
    Friend WithEvents save_button As Button
    Friend WithEvents update_button As Button
    Friend WithEvents delete_button As Button
    Friend WithEvents clear_button As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents search_txt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn
End Class
