<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        txt_prodno = New TextBox()
        txt_prodname = New TextBox()
        txt_price = New TextBox()
        combo_prodgroup = New ComboBox()
        datetimepk = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        check_avail = New CheckBox()
        button_clear = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewCheckBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewCheckBoxColumn()
        Label6 = New Label()
        txt_searchbox = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_prodno
        ' 
        txt_prodno.BackColor = Color.Ivory
        txt_prodno.Location = New Point(95, 98)
        txt_prodno.Margin = New Padding(3, 4, 3, 4)
        txt_prodno.Name = "txt_prodno"
        txt_prodno.Size = New Size(351, 31)
        txt_prodno.TabIndex = 0
        ' 
        ' txt_prodname
        ' 
        txt_prodname.BackColor = Color.Ivory
        txt_prodname.Location = New Point(95, 171)
        txt_prodname.Margin = New Padding(3, 4, 3, 4)
        txt_prodname.Name = "txt_prodname"
        txt_prodname.Size = New Size(351, 31)
        txt_prodname.TabIndex = 1
        ' 
        ' txt_price
        ' 
        txt_price.BackColor = Color.Ivory
        txt_price.Location = New Point(95, 250)
        txt_price.Margin = New Padding(3, 4, 3, 4)
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(351, 31)
        txt_price.TabIndex = 2
        ' 
        ' combo_prodgroup
        ' 
        combo_prodgroup.BackColor = Color.Ivory
        combo_prodgroup.FormattingEnabled = True
        combo_prodgroup.Location = New Point(95, 333)
        combo_prodgroup.Margin = New Padding(3, 4, 3, 4)
        combo_prodgroup.Name = "combo_prodgroup"
        combo_prodgroup.Size = New Size(351, 33)
        combo_prodgroup.TabIndex = 3
        ' 
        ' datetimepk
        ' 
        datetimepk.CalendarFont = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datetimepk.CalendarTitleBackColor = Color.Ivory
        datetimepk.Cursor = Cursors.Hand
        datetimepk.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datetimepk.Location = New Point(95, 411)
        datetimepk.Margin = New Padding(3, 4, 3, 4)
        datetimepk.Name = "datetimepk"
        datetimepk.Size = New Size(351, 28)
        datetimepk.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(95, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 21)
        Label1.TabIndex = 5
        Label1.Text = "Product No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(95, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 21)
        Label2.TabIndex = 6
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(95, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 21)
        Label3.TabIndex = 7
        Label3.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DarkSeaGreen
        Label4.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(95, 305)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 21)
        Label4.TabIndex = 8
        Label4.Text = "Product Group"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(95, 383)
        Label5.Name = "Label5"
        Label5.Size = New Size(112, 21)
        Label5.TabIndex = 9
        Label5.Text = "Expire Date"
        ' 
        ' check_avail
        ' 
        check_avail.AutoSize = True
        check_avail.BackColor = Color.Ivory
        check_avail.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        check_avail.Location = New Point(95, 476)
        check_avail.Margin = New Padding(3, 4, 3, 4)
        check_avail.Name = "check_avail"
        check_avail.Size = New Size(118, 25)
        check_avail.TabIndex = 10
        check_avail.Text = "Available"
        check_avail.UseVisualStyleBackColor = False
        ' 
        ' button_clear
        ' 
        button_clear.BackColor = SystemColors.Window
        button_clear.FlatAppearance.BorderColor = Color.Red
        button_clear.FlatAppearance.BorderSize = 2
        button_clear.FlatStyle = FlatStyle.Flat
        button_clear.Font = New Font("Arial Narrow", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        button_clear.ForeColor = Color.Red
        button_clear.Location = New Point(314, 472)
        button_clear.Margin = New Padding(3, 4, 3, 4)
        button_clear.Name = "button_clear"
        button_clear.Size = New Size(132, 31)
        button_clear.TabIndex = 11
        button_clear.Text = "Clear"
        button_clear.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.Ivory
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.GridColor = SystemColors.ActiveCaptionText
        DataGridView1.Location = New Point(496, 171)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(783, 444)
        DataGridView1.TabIndex = 12
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Product Number"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Resizable = DataGridViewTriState.True
        Column1.SortMode = DataGridViewColumnSortMode.Automatic
        Column1.Width = 180
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Product Name"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Price"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 85
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Group"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 98
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Expire Date"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 126
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Status"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 66
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(496, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 21)
        Label6.TabIndex = 14
        Label6.Text = "Search"
        ' 
        ' txt_searchbox
        ' 
        txt_searchbox.BackColor = Color.Ivory
        txt_searchbox.Location = New Point(496, 98)
        txt_searchbox.Margin = New Padding(3, 4, 3, 4)
        txt_searchbox.Name = "txt_searchbox"
        txt_searchbox.Size = New Size(467, 31)
        txt_searchbox.TabIndex = 13
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(1317, 665)
        Controls.Add(Label6)
        Controls.Add(txt_searchbox)
        Controls.Add(DataGridView1)
        Controls.Add(button_clear)
        Controls.Add(check_avail)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(datetimepk)
        Controls.Add(combo_prodgroup)
        Controls.Add(txt_price)
        Controls.Add(txt_prodname)
        Controls.Add(txt_prodno)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "My View"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_prodno As TextBox
    Friend WithEvents txt_prodname As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents combo_prodgroup As ComboBox
    Friend WithEvents datetimepk As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents check_avail As CheckBox
    Friend WithEvents button_clear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_searchbox As TextBox
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn
End Class
