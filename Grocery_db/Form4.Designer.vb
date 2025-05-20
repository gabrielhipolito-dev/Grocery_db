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
        DataGridView1 = New DataGridView()
        Label6 = New Label()
        Btn_search1 = New Button()
        tb_search = New TextBox()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.Ivory
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.ActiveCaptionText
        DataGridView1.Location = New Point(97, 61)
        DataGridView1.Margin = New Padding(2, 3, 2, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(688, 459)
        DataGridView1.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(87, 16)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 20)
        Label6.TabIndex = 14
        Label6.Text = "Search:"
        ' 
        ' Btn_search1
        ' 
        Btn_search1.BackColor = Color.DarkOliveGreen
        Btn_search1.FlatStyle = FlatStyle.Popup
        Btn_search1.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_search1.ForeColor = SystemColors.Control
        Btn_search1.Location = New Point(466, 11)
        Btn_search1.Margin = New Padding(3, 4, 3, 4)
        Btn_search1.Name = "Btn_search1"
        Btn_search1.Size = New Size(86, 31)
        Btn_search1.TabIndex = 15
        Btn_search1.Text = "SEARCH"
        Btn_search1.UseVisualStyleBackColor = False
        ' 
        ' tb_search
        ' 
        tb_search.Location = New Point(158, 13)
        tb_search.Margin = New Padding(3, 4, 3, 4)
        tb_search.Name = "tb_search"
        tb_search.Size = New Size(293, 27)
        tb_search.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(31, 101)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 312)
        Label1.TabIndex = 18
        Label1.Text = "P" & vbCrLf & "R" & vbCrLf & "O" & vbCrLf & "D" & vbCrLf & "U" & vbCrLf & "C" & vbCrLf & "T" & vbCrLf & "S" & vbCrLf
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(893, 532)
        Controls.Add(Label1)
        Controls.Add(tb_search)
        Controls.Add(Btn_search1)
        Controls.Add(Label6)
        Controls.Add(DataGridView1)
        Margin = New Padding(2, 3, 2, 3)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Items"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_search1 As Button
    Friend WithEvents tb_search As TextBox
    Friend WithEvents Label1 As Label
End Class
