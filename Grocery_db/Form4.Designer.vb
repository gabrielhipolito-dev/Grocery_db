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
        DataGridView1.BackgroundColor = Color.Silver
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.ActiveCaptionText
        DataGridView1.Location = New Point(68, 44)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(640, 344)
        DataGridView1.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(68, 13)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 14
        Label6.Text = "Search:"
        ' 
        ' Btn_search1
        ' 
        Btn_search1.BackColor = Color.DarkOliveGreen
        Btn_search1.FlatStyle = FlatStyle.Popup
        Btn_search1.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_search1.ForeColor = SystemColors.ButtonFace
        Btn_search1.Location = New Point(408, 8)
        Btn_search1.Name = "Btn_search1"
        Btn_search1.Size = New Size(75, 23)
        Btn_search1.TabIndex = 15
        Btn_search1.Text = "SEARCH"
        Btn_search1.UseVisualStyleBackColor = False
        ' 
        ' tb_search
        ' 
        tb_search.Location = New Point(129, 10)
        tb_search.Name = "tb_search"
        tb_search.Size = New Size(257, 23)
        tb_search.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(11, 75)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 248)
        Label1.TabIndex = 18
        Label1.Text = "P" & vbCrLf & "R" & vbCrLf & "O" & vbCrLf & "D" & vbCrLf & "U" & vbCrLf & "C" & vbCrLf & "T" & vbCrLf & "S"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.YellowGreen
        ClientSize = New Size(781, 399)
        Controls.Add(Label1)
        Controls.Add(tb_search)
        Controls.Add(Btn_search1)
        Controls.Add(Label6)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(2)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "My View"
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
