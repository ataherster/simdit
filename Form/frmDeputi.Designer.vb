<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeputi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeputi))
        Me.lvDeputi = New System.Windows.Forms.ListView
        Me._lvDeputi_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvDeputi_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.txtNamaDeputi = New System.Windows.Forms.TextBox
        Me.txtIDDeputi = New System.Windows.Forms.TextBox
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.Line3 = New System.Windows.Forms.Label
        Me.Line4 = New System.Windows.Forms.Label
        Me.Line2 = New System.Windows.Forms.Label
        Me.Line1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdTambah = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdBatal = New System.Windows.Forms.Button
        Me.cmdHapus = New System.Windows.Forms.Button
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvDeputi
        '
        Me.lvDeputi.BackColor = System.Drawing.SystemColors.Window
        Me.lvDeputi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvDeputi_ColumnHeader_1, Me._lvDeputi_ColumnHeader_2})
        Me.lvDeputi.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvDeputi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvDeputi.FullRowSelect = True
        Me.lvDeputi.GridLines = True
        Me.lvDeputi.LabelEdit = True
        Me.lvDeputi.Location = New System.Drawing.Point(20, 194)
        Me.lvDeputi.Name = "lvDeputi"
        Me.lvDeputi.Size = New System.Drawing.Size(521, 190)
        Me.lvDeputi.TabIndex = 22
        Me.lvDeputi.UseCompatibleStateImageBehavior = False
        Me.lvDeputi.View = System.Windows.Forms.View.Details
        '
        '_lvDeputi_ColumnHeader_1
        '
        Me._lvDeputi_ColumnHeader_1.Text = "Kode Deputi"
        Me._lvDeputi_ColumnHeader_1.Width = 118
        '
        '_lvDeputi_ColumnHeader_2
        '
        Me._lvDeputi_ColumnHeader_2.Text = "Nama Deputi"
        Me._lvDeputi_ColumnHeader_2.Width = 765
        '
        'txtNamaDeputi
        '
        Me.txtNamaDeputi.AcceptsReturn = True
        Me.txtNamaDeputi.BackColor = System.Drawing.SystemColors.Window
        Me.txtNamaDeputi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaDeputi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaDeputi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNamaDeputi.Location = New System.Drawing.Point(125, 116)
        Me.txtNamaDeputi.MaxLength = 0
        Me.txtNamaDeputi.Multiline = True
        Me.txtNamaDeputi.Name = "txtNamaDeputi"
        Me.txtNamaDeputi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNamaDeputi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNamaDeputi.Size = New System.Drawing.Size(416, 53)
        Me.txtNamaDeputi.TabIndex = 17
        '
        'txtIDDeputi
        '
        Me.txtIDDeputi.AcceptsReturn = True
        Me.txtIDDeputi.BackColor = System.Drawing.SystemColors.Window
        Me.txtIDDeputi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDDeputi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDDeputi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDDeputi.Location = New System.Drawing.Point(125, 92)
        Me.txtIDDeputi.MaxLength = 20
        Me.txtIDDeputi.Name = "txtIDDeputi"
        Me.txtIDDeputi.ReadOnly = True
        Me.txtIDDeputi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIDDeputi.Size = New System.Drawing.Size(416, 21)
        Me.txtIDDeputi.TabIndex = 16
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(21, 12)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(520, 57)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 23
        Me.Image1.TabStop = False
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line3.Location = New System.Drawing.Point(21, 77)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(520, 1)
        Me.Line3.TabIndex = 24
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line4.Location = New System.Drawing.Point(21, 76)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(520, 1)
        Me.Line4.TabIndex = 25
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line2.Location = New System.Drawing.Point(21, 181)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(520, 1)
        Me.Line2.TabIndex = 26
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line1.Location = New System.Drawing.Point(21, 180)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(520, 1)
        Me.Line1.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(117, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(117, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(21, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nama Deputi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(21, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Kode Deputi"
        '
        'cmdTambah
        '
        Me.cmdTambah.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambah.Location = New System.Drawing.Point(20, 390)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(75, 23)
        Me.cmdTambah.TabIndex = 28
        Me.cmdTambah.Text = "Tambah"
        Me.cmdTambah.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Location = New System.Drawing.Point(182, 390)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 29
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(101, 390)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 30
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBatal.Location = New System.Drawing.Point(263, 390)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdBatal.TabIndex = 31
        Me.cmdBatal.Text = "Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'cmdHapus
        '
        Me.cmdHapus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHapus.Location = New System.Drawing.Point(466, 390)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.cmdHapus.TabIndex = 32
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'frmDeputi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 422)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdTambah)
        Me.Controls.Add(Me.lvDeputi)
        Me.Controls.Add(Me.txtNamaDeputi)
        Me.Controls.Add(Me.txtIDDeputi)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.Line4)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeputi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDeputi"
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lvDeputi As System.Windows.Forms.ListView
    Public WithEvents _lvDeputi_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
    Public WithEvents _lvDeputi_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
    Public WithEvents txtNamaDeputi As System.Windows.Forms.TextBox
    Public WithEvents txtIDDeputi As System.Windows.Forms.TextBox
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents Line3 As System.Windows.Forms.Label
    Public WithEvents Line4 As System.Windows.Forms.Label
    Public WithEvents Line2 As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdBatal As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
End Class
