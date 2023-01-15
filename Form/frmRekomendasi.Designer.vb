<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRekomendasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRekomendasi))
        Me.cmdGroup = New System.Windows.Forms.Button
        Me.cmdHapus = New System.Windows.Forms.Button
        Me.cmdBatal = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.cmdTambah = New System.Windows.Forms.Button
        Me.txtUraianRekomendasi = New System.Windows.Forms.TextBox
        Me.txtIDRekomendasi = New System.Windows.Forms.TextBox
        Me.cboGroup = New System.Windows.Forms.ComboBox
        Me.txtUraian = New System.Windows.Forms.TextBox
        Me.lvRekomendasi = New System.Windows.Forms.ListView
        Me._lvTindakLanjut_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvTindakLanjut_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.Line6 = New System.Windows.Forms.Label
        Me.Line5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Line4 = New System.Windows.Forms.Label
        Me.Line3 = New System.Windows.Forms.Label
        Me.Line1 = New System.Windows.Forms.Label
        Me.Line2 = New System.Windows.Forms.Label
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdGroup
        '
        Me.cmdGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGroup.Location = New System.Drawing.Point(474, 100)
        Me.cmdGroup.Name = "cmdGroup"
        Me.cmdGroup.Size = New System.Drawing.Size(60, 21)
        Me.cmdGroup.TabIndex = 81
        Me.cmdGroup.Text = "Group"
        Me.cmdGroup.UseVisualStyleBackColor = True
        '
        'cmdHapus
        '
        Me.cmdHapus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHapus.Location = New System.Drawing.Point(459, 469)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.cmdHapus.TabIndex = 80
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBatal.Location = New System.Drawing.Point(256, 469)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdBatal.TabIndex = 79
        Me.cmdBatal.Text = "Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(94, 469)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 78
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Location = New System.Drawing.Point(175, 469)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 77
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdTambah
        '
        Me.cmdTambah.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambah.Location = New System.Drawing.Point(13, 469)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(75, 23)
        Me.cmdTambah.TabIndex = 76
        Me.cmdTambah.Text = "Tambah"
        Me.cmdTambah.UseVisualStyleBackColor = True
        '
        'txtUraianRekomendasi
        '
        Me.txtUraianRekomendasi.AcceptsReturn = True
        Me.txtUraianRekomendasi.BackColor = System.Drawing.SystemColors.Window
        Me.txtUraianRekomendasi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUraianRekomendasi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUraianRekomendasi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUraianRekomendasi.Location = New System.Drawing.Point(149, 220)
        Me.txtUraianRekomendasi.MaxLength = 0
        Me.txtUraianRekomendasi.Multiline = True
        Me.txtUraianRekomendasi.Name = "txtUraianRekomendasi"
        Me.txtUraianRekomendasi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUraianRekomendasi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUraianRekomendasi.Size = New System.Drawing.Size(385, 69)
        Me.txtUraianRekomendasi.TabIndex = 59
        '
        'txtIDRekomendasi
        '
        Me.txtIDRekomendasi.AcceptsReturn = True
        Me.txtIDRekomendasi.BackColor = System.Drawing.SystemColors.Window
        Me.txtIDRekomendasi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDRekomendasi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDRekomendasi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDRekomendasi.Location = New System.Drawing.Point(149, 196)
        Me.txtIDRekomendasi.MaxLength = 4
        Me.txtIDRekomendasi.Name = "txtIDRekomendasi"
        Me.txtIDRekomendasi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIDRekomendasi.Size = New System.Drawing.Size(385, 21)
        Me.txtIDRekomendasi.TabIndex = 58
        '
        'cboGroup
        '
        Me.cboGroup.BackColor = System.Drawing.SystemColors.Window
        Me.cboGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGroup.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGroup.Location = New System.Drawing.Point(85, 100)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboGroup.Size = New System.Drawing.Size(383, 21)
        Me.cboGroup.TabIndex = 56
        '
        'txtUraian
        '
        Me.txtUraian.AcceptsReturn = True
        Me.txtUraian.BackColor = System.Drawing.SystemColors.Window
        Me.txtUraian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUraian.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUraian.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUraian.Location = New System.Drawing.Point(85, 124)
        Me.txtUraian.MaxLength = 0
        Me.txtUraian.Multiline = True
        Me.txtUraian.Name = "txtUraian"
        Me.txtUraian.ReadOnly = True
        Me.txtUraian.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUraian.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUraian.Size = New System.Drawing.Size(449, 53)
        Me.txtUraian.TabIndex = 57
        '
        'lvRekomendasi
        '
        Me.lvRekomendasi.BackColor = System.Drawing.SystemColors.Window
        Me.lvRekomendasi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvTindakLanjut_ColumnHeader_1, Me._lvTindakLanjut_ColumnHeader_2})
        Me.lvRekomendasi.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRekomendasi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvRekomendasi.FullRowSelect = True
        Me.lvRekomendasi.GridLines = True
        Me.lvRekomendasi.LabelEdit = True
        Me.lvRekomendasi.Location = New System.Drawing.Point(12, 316)
        Me.lvRekomendasi.Name = "lvRekomendasi"
        Me.lvRekomendasi.Size = New System.Drawing.Size(522, 146)
        Me.lvRekomendasi.TabIndex = 60
        Me.lvRekomendasi.UseCompatibleStateImageBehavior = False
        Me.lvRekomendasi.View = System.Windows.Forms.View.Details
        '
        '_lvTindakLanjut_ColumnHeader_1
        '
        Me._lvTindakLanjut_ColumnHeader_1.Text = "Kode Rekomendasi"
        Me._lvTindakLanjut_ColumnHeader_1.Width = 170
        '
        '_lvTindakLanjut_ColumnHeader_2
        '
        Me._lvTindakLanjut_ColumnHeader_2.Text = "Uraian"
        Me._lvTindakLanjut_ColumnHeader_2.Width = 706
        '
        'Line6
        '
        Me.Line6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line6.Location = New System.Drawing.Point(13, 301)
        Me.Line6.Name = "Line6"
        Me.Line6.Size = New System.Drawing.Size(519, 1)
        Me.Line6.TabIndex = 62
        '
        'Line5
        '
        Me.Line5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line5.Location = New System.Drawing.Point(13, 300)
        Me.Line5.Name = "Line5"
        Me.Line5.Size = New System.Drawing.Size(519, 1)
        Me.Line5.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(9, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Kode Rekomendasi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(10, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Uraian"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(141, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(141, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = ":"
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line4.Location = New System.Drawing.Point(13, 188)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(520, 1)
        Me.Line4.TabIndex = 71
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line3.Location = New System.Drawing.Point(13, 189)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(520, 1)
        Me.Line3.TabIndex = 72
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line1.Location = New System.Drawing.Point(13, 84)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(522, 1)
        Me.Line1.TabIndex = 73
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line2.Location = New System.Drawing.Point(13, 85)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(522, 1)
        Me.Line2.TabIndex = 74
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(13, 12)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(521, 57)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 75
        Me.Image1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(73, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(73, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(9, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Uraian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Group"
        '
        'frmRekomendasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 504)
        Me.Controls.Add(Me.cmdGroup)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdTambah)
        Me.Controls.Add(Me.txtUraianRekomendasi)
        Me.Controls.Add(Me.txtIDRekomendasi)
        Me.Controls.Add(Me.cboGroup)
        Me.Controls.Add(Me.txtUraian)
        Me.Controls.Add(Me.lvRekomendasi)
        Me.Controls.Add(Me.Line6)
        Me.Controls.Add(Me.Line5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Line4)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRekomendasi"
        Me.Text = "frmRekomendasi"
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdGroup As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents cmdBatal As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
    Public WithEvents txtUraianRekomendasi As System.Windows.Forms.TextBox
    Public WithEvents txtIDRekomendasi As System.Windows.Forms.TextBox
    Public WithEvents cboGroup As System.Windows.Forms.ComboBox
    Public WithEvents txtUraian As System.Windows.Forms.TextBox
    Public WithEvents lvRekomendasi As System.Windows.Forms.ListView
    Public WithEvents _lvTindakLanjut_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
    Public WithEvents _lvTindakLanjut_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
    Public WithEvents Line6 As System.Windows.Forms.Label
    Public WithEvents Line5 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Line4 As System.Windows.Forms.Label
    Public WithEvents Line3 As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents Line2 As System.Windows.Forms.Label
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
End Class
