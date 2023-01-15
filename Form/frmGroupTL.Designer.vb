<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGroupTL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroupTL))
        Me.cmdHapus = New System.Windows.Forms.Button
        Me.cmdBatal = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.cmdTambah = New System.Windows.Forms.Button
        Me.txtUraian = New System.Windows.Forms.TextBox
        Me.txtIDGroup = New System.Windows.Forms.TextBox
        Me.lvGroupTindakLanjut = New System.Windows.Forms.ListView
        Me._lvGroupTemuan_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvGroupTemuan_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Line1 = New System.Windows.Forms.Label
        Me.Line2 = New System.Windows.Forms.Label
        Me.Image1 = New System.Windows.Forms.PictureBox
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdHapus
        '
        Me.cmdHapus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHapus.Location = New System.Drawing.Point(458, 388)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.cmdHapus.TabIndex = 69
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBatal.Location = New System.Drawing.Point(255, 388)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdBatal.TabIndex = 68
        Me.cmdBatal.Text = "Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(93, 388)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 67
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Location = New System.Drawing.Point(174, 388)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 66
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdTambah
        '
        Me.cmdTambah.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambah.Location = New System.Drawing.Point(12, 388)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(75, 23)
        Me.cmdTambah.TabIndex = 65
        Me.cmdTambah.Text = "Tambah"
        Me.cmdTambah.UseVisualStyleBackColor = True
        '
        'txtUraian
        '
        Me.txtUraian.AcceptsReturn = True
        Me.txtUraian.BackColor = System.Drawing.SystemColors.Window
        Me.txtUraian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUraian.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUraian.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUraian.Location = New System.Drawing.Point(116, 108)
        Me.txtUraian.MaxLength = 0
        Me.txtUraian.Multiline = True
        Me.txtUraian.Name = "txtUraian"
        Me.txtUraian.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUraian.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUraian.Size = New System.Drawing.Size(416, 77)
        Me.txtUraian.TabIndex = 56
        '
        'txtIDGroup
        '
        Me.txtIDGroup.AcceptsReturn = True
        Me.txtIDGroup.BackColor = System.Drawing.SystemColors.Window
        Me.txtIDGroup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDGroup.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDGroup.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDGroup.Location = New System.Drawing.Point(116, 84)
        Me.txtIDGroup.MaxLength = 4
        Me.txtIDGroup.Name = "txtIDGroup"
        Me.txtIDGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIDGroup.Size = New System.Drawing.Size(416, 22)
        Me.txtIDGroup.TabIndex = 55
        '
        'lvGroupTindakLanjut
        '
        Me.lvGroupTindakLanjut.BackColor = System.Drawing.SystemColors.Window
        Me.lvGroupTindakLanjut.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvGroupTemuan_ColumnHeader_1, Me._lvGroupTemuan_ColumnHeader_2})
        Me.lvGroupTindakLanjut.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvGroupTindakLanjut.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvGroupTindakLanjut.FullRowSelect = True
        Me.lvGroupTindakLanjut.GridLines = True
        Me.lvGroupTindakLanjut.LabelEdit = True
        Me.lvGroupTindakLanjut.Location = New System.Drawing.Point(12, 212)
        Me.lvGroupTindakLanjut.Name = "lvGroupTindakLanjut"
        Me.lvGroupTindakLanjut.Size = New System.Drawing.Size(521, 170)
        Me.lvGroupTindakLanjut.TabIndex = 57
        Me.lvGroupTindakLanjut.UseCompatibleStateImageBehavior = False
        Me.lvGroupTindakLanjut.View = System.Windows.Forms.View.Details
        '
        '_lvGroupTemuan_ColumnHeader_1
        '
        Me._lvGroupTemuan_ColumnHeader_1.Text = "Kode Group"
        Me._lvGroupTemuan_ColumnHeader_1.Width = 170
        '
        '_lvGroupTemuan_ColumnHeader_2
        '
        Me._lvGroupTemuan_ColumnHeader_2.Text = "Uraian"
        Me._lvGroupTemuan_ColumnHeader_2.Width = 706
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(108, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Kode Group"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(108, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Uraian"
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line1.Location = New System.Drawing.Point(12, 196)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(520, 1)
        Me.Line1.TabIndex = 62
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line2.Location = New System.Drawing.Point(12, 197)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(520, 1)
        Me.Line2.TabIndex = 63
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(12, 12)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(521, 57)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 64
        Me.Image1.TabStop = False
        '
        'frmGroupTL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 422)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdTambah)
        Me.Controls.Add(Me.txtUraian)
        Me.Controls.Add(Me.txtIDGroup)
        Me.Controls.Add(Me.lvGroupTindakLanjut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Image1)
        Me.Name = "frmGroupTL"
        Me.Text = "frmGroupTL"
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents cmdBatal As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
    Public WithEvents txtUraian As System.Windows.Forms.TextBox
    Public WithEvents txtIDGroup As System.Windows.Forms.TextBox
    Public WithEvents lvGroupTindakLanjut As System.Windows.Forms.ListView
    Public WithEvents _lvGroupTemuan_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
    Public WithEvents _lvGroupTemuan_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents Line2 As System.Windows.Forms.Label
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
End Class
