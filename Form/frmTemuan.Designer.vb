<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemuan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemuan))
        Me.txtUraian = New System.Windows.Forms.TextBox
        Me.cboGroup = New System.Windows.Forms.ComboBox
        Me.txtIDTemuan = New System.Windows.Forms.TextBox
        Me.txtUraianTemuan = New System.Windows.Forms.TextBox
        Me.lvTemuan = New System.Windows.Forms.ListView
        Me._lvTemuan_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvTemuan_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.Line2 = New System.Windows.Forms.Label
        Me.Line1 = New System.Windows.Forms.Label
        Me.Line3 = New System.Windows.Forms.Label
        Me.Line4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Line5 = New System.Windows.Forms.Label
        Me.Line6 = New System.Windows.Forms.Label
        Me.cmdHapus = New System.Windows.Forms.Button
        Me.cmdBatal = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.cmdTambah = New System.Windows.Forms.Button
        Me.cmdGroup = New System.Windows.Forms.Button
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUraian
        '
        Me.txtUraian.AcceptsReturn = True
        Me.txtUraian.BackColor = System.Drawing.SystemColors.Window
        Me.txtUraian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUraian.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUraian.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUraian.Location = New System.Drawing.Point(156, 128)
        Me.txtUraian.MaxLength = 0
        Me.txtUraian.Multiline = True
        Me.txtUraian.Name = "txtUraian"
        Me.txtUraian.ReadOnly = True
        Me.txtUraian.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUraian.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUraian.Size = New System.Drawing.Size(384, 53)
        Me.txtUraian.TabIndex = 26
        '
        'cboGroup
        '
        Me.cboGroup.BackColor = System.Drawing.SystemColors.Window
        Me.cboGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGroup.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboGroup.Location = New System.Drawing.Point(156, 104)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboGroup.Size = New System.Drawing.Size(314, 21)
        Me.cboGroup.TabIndex = 25
        '
        'txtIDTemuan
        '
        Me.txtIDTemuan.AcceptsReturn = True
        Me.txtIDTemuan.BackColor = System.Drawing.SystemColors.Window
        Me.txtIDTemuan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDTemuan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDTemuan.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDTemuan.Location = New System.Drawing.Point(156, 200)
        Me.txtIDTemuan.MaxLength = 4
        Me.txtIDTemuan.Name = "txtIDTemuan"
        Me.txtIDTemuan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIDTemuan.Size = New System.Drawing.Size(384, 21)
        Me.txtIDTemuan.TabIndex = 27
        '
        'txtUraianTemuan
        '
        Me.txtUraianTemuan.AcceptsReturn = True
        Me.txtUraianTemuan.BackColor = System.Drawing.SystemColors.Window
        Me.txtUraianTemuan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUraianTemuan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUraianTemuan.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUraianTemuan.Location = New System.Drawing.Point(156, 224)
        Me.txtUraianTemuan.MaxLength = 0
        Me.txtUraianTemuan.Multiline = True
        Me.txtUraianTemuan.Name = "txtUraianTemuan"
        Me.txtUraianTemuan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUraianTemuan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUraianTemuan.Size = New System.Drawing.Size(384, 69)
        Me.txtUraianTemuan.TabIndex = 28
        '
        'lvTemuan
        '
        Me.lvTemuan.BackColor = System.Drawing.SystemColors.Window
        Me.lvTemuan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvTemuan_ColumnHeader_1, Me._lvTemuan_ColumnHeader_2})
        Me.lvTemuan.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTemuan.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvTemuan.FullRowSelect = True
        Me.lvTemuan.GridLines = True
        Me.lvTemuan.LabelEdit = True
        Me.lvTemuan.Location = New System.Drawing.Point(19, 328)
        Me.lvTemuan.Name = "lvTemuan"
        Me.lvTemuan.Size = New System.Drawing.Size(521, 150)
        Me.lvTemuan.TabIndex = 29
        Me.lvTemuan.UseCompatibleStateImageBehavior = False
        Me.lvTemuan.View = System.Windows.Forms.View.Details
        '
        '_lvTemuan_ColumnHeader_1
        '
        Me._lvTemuan_ColumnHeader_1.Text = "Kode Temuan"
        Me._lvTemuan_ColumnHeader_1.Width = 170
        '
        '_lvTemuan_ColumnHeader_2
        '
        Me._lvTemuan_ColumnHeader_2.Text = "Uraian"
        Me._lvTemuan_ColumnHeader_2.Width = 706
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(20, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Group"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(20, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Uraian"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(148, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(148, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = ":"
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(20, 16)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(520, 57)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 38
        Me.Image1.TabStop = False
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line2.Location = New System.Drawing.Point(20, 89)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(517, 1)
        Me.Line2.TabIndex = 39
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line1.Location = New System.Drawing.Point(20, 88)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(517, 1)
        Me.Line1.TabIndex = 40
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line3.Location = New System.Drawing.Point(20, 193)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(517, 1)
        Me.Line3.TabIndex = 41
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line4.Location = New System.Drawing.Point(20, 192)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(518, 1)
        Me.Line4.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(148, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(148, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(20, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Uraian"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(20, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Kode Temuan"
        '
        'Line5
        '
        Me.Line5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line5.Location = New System.Drawing.Point(20, 312)
        Me.Line5.Name = "Line5"
        Me.Line5.Size = New System.Drawing.Size(519, 1)
        Me.Line5.TabIndex = 43
        '
        'Line6
        '
        Me.Line6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line6.Location = New System.Drawing.Point(20, 313)
        Me.Line6.Name = "Line6"
        Me.Line6.Size = New System.Drawing.Size(519, 1)
        Me.Line6.TabIndex = 44
        '
        'cmdHapus
        '
        Me.cmdHapus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHapus.Location = New System.Drawing.Point(465, 484)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.cmdHapus.TabIndex = 49
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBatal.Location = New System.Drawing.Point(262, 484)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdBatal.TabIndex = 48
        Me.cmdBatal.Text = "Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(100, 484)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 47
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Location = New System.Drawing.Point(181, 484)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 46
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdTambah
        '
        Me.cmdTambah.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambah.Location = New System.Drawing.Point(19, 484)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(75, 23)
        Me.cmdTambah.TabIndex = 45
        Me.cmdTambah.Text = "Tambah"
        Me.cmdTambah.UseVisualStyleBackColor = True
        '
        'cmdGroup
        '
        Me.cmdGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGroup.Location = New System.Drawing.Point(476, 104)
        Me.cmdGroup.Name = "cmdGroup"
        Me.cmdGroup.Size = New System.Drawing.Size(60, 21)
        Me.cmdGroup.TabIndex = 50
        Me.cmdGroup.Text = "Group"
        Me.cmdGroup.UseVisualStyleBackColor = True
        '
        'frmTemuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 520)
        Me.Controls.Add(Me.cmdGroup)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdTambah)
        Me.Controls.Add(Me.txtUraian)
        Me.Controls.Add(Me.cboGroup)
        Me.Controls.Add(Me.txtIDTemuan)
        Me.Controls.Add(Me.txtUraianTemuan)
        Me.Controls.Add(Me.lvTemuan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.Line4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Line5)
        Me.Controls.Add(Me.Line6)
        Me.MaximizeBox = False
        Me.Name = "frmTemuan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTemuan"
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtUraian As System.Windows.Forms.TextBox
    Public WithEvents cboGroup As System.Windows.Forms.ComboBox
    Public WithEvents txtIDTemuan As System.Windows.Forms.TextBox
    Public WithEvents txtUraianTemuan As System.Windows.Forms.TextBox
    Public WithEvents lvTemuan As System.Windows.Forms.ListView
    Public WithEvents _lvTemuan_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
    Public WithEvents _lvTemuan_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents Line2 As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents Line3 As System.Windows.Forms.Label
    Public WithEvents Line4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Line5 As System.Windows.Forms.Label
    Public WithEvents Line6 As System.Windows.Forms.Label
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents cmdBatal As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
    Friend WithEvents cmdGroup As System.Windows.Forms.Button
End Class
