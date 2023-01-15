<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSatker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSatker))
        Me.txtKasatker = New System.Windows.Forms.TextBox
        Me.txtIDSatker = New System.Windows.Forms.TextBox
        Me.txtNamaSatker = New System.Windows.Forms.TextBox
        Me.lvSatker = New System.Windows.Forms.ListView
        Me._lvSatker_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvSatker_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me._lvSatker_ColumnHeader_3 = New System.Windows.Forms.ColumnHeader
        Me._lvSatker_ColumnHeader_4 = New System.Windows.Forms.ColumnHeader
        Me._lvSatker_ColumnHeader_5 = New System.Windows.Forms.ColumnHeader
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Line3 = New System.Windows.Forms.Label
        Me.Line4 = New System.Windows.Forms.Label
        Me.Line1 = New System.Windows.Forms.Label
        Me.Line2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Image1 = New System.Windows.Forms.PictureBox
        Me.cmdHapus = New System.Windows.Forms.Button
        Me.cmdBatal = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.cmdTambah = New System.Windows.Forms.Button
        Me.txtPPK = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboDeputi = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.ID = New System.Windows.Forms.Label
        Me.cboRegional = New System.Windows.Forms.ComboBox
        Me.txtRegional = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtDeputi = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me._lvSatker_ColumnHeader_6 = New System.Windows.Forms.ColumnHeader
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKasatker
        '
        Me.txtKasatker.AcceptsReturn = True
        Me.txtKasatker.BackColor = System.Drawing.SystemColors.Window
        Me.txtKasatker.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKasatker.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKasatker.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtKasatker.Location = New System.Drawing.Point(122, 175)
        Me.txtKasatker.MaxLength = 50
        Me.txtKasatker.Name = "txtKasatker"
        Me.txtKasatker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKasatker.Size = New System.Drawing.Size(416, 21)
        Me.txtKasatker.TabIndex = 20
        '
        'txtIDSatker
        '
        Me.txtIDSatker.AcceptsReturn = True
        Me.txtIDSatker.BackColor = System.Drawing.SystemColors.Window
        Me.txtIDSatker.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIDSatker.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDSatker.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIDSatker.Location = New System.Drawing.Point(122, 95)
        Me.txtIDSatker.MaxLength = 20
        Me.txtIDSatker.Name = "txtIDSatker"
        Me.txtIDSatker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIDSatker.Size = New System.Drawing.Size(416, 21)
        Me.txtIDSatker.TabIndex = 18
        '
        'txtNamaSatker
        '
        Me.txtNamaSatker.AcceptsReturn = True
        Me.txtNamaSatker.BackColor = System.Drawing.SystemColors.Window
        Me.txtNamaSatker.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaSatker.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaSatker.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNamaSatker.Location = New System.Drawing.Point(122, 119)
        Me.txtNamaSatker.MaxLength = 0
        Me.txtNamaSatker.Multiline = True
        Me.txtNamaSatker.Name = "txtNamaSatker"
        Me.txtNamaSatker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNamaSatker.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNamaSatker.Size = New System.Drawing.Size(416, 53)
        Me.txtNamaSatker.TabIndex = 19
        '
        'lvSatker
        '
        Me.lvSatker.BackColor = System.Drawing.SystemColors.Window
        Me.lvSatker.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvSatker_ColumnHeader_1, Me._lvSatker_ColumnHeader_2, Me._lvSatker_ColumnHeader_3, Me._lvSatker_ColumnHeader_4, Me._lvSatker_ColumnHeader_5, Me._lvSatker_ColumnHeader_6})
        Me.lvSatker.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSatker.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvSatker.FullRowSelect = True
        Me.lvSatker.GridLines = True
        Me.lvSatker.LabelEdit = True
        Me.lvSatker.Location = New System.Drawing.Point(18, 333)
        Me.lvSatker.Name = "lvSatker"
        Me.lvSatker.Size = New System.Drawing.Size(521, 143)
        Me.lvSatker.TabIndex = 21
        Me.lvSatker.UseCompatibleStateImageBehavior = False
        Me.lvSatker.View = System.Windows.Forms.View.Details
        '
        '_lvSatker_ColumnHeader_1
        '
        Me._lvSatker_ColumnHeader_1.Text = "Kode Satker"
        Me._lvSatker_ColumnHeader_1.Width = 90
        '
        '_lvSatker_ColumnHeader_2
        '
        Me._lvSatker_ColumnHeader_2.Text = "Satker"
        Me._lvSatker_ColumnHeader_2.Width = 274
        '
        '_lvSatker_ColumnHeader_3
        '
        Me._lvSatker_ColumnHeader_3.Text = "Kode Deputi"
        Me._lvSatker_ColumnHeader_3.Width = 50
        '
        '_lvSatker_ColumnHeader_4
        '
        Me._lvSatker_ColumnHeader_4.Text = "Kasatker"
        '
        '_lvSatker_ColumnHeader_5
        '
        Me._lvSatker_ColumnHeader_5.Text = "PPK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(114, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(11, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(18, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kode Satker"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(18, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Satker"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(114, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(114, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = ":"
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line3.Location = New System.Drawing.Point(18, 80)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(520, 1)
        Me.Line3.TabIndex = 29
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line4.Location = New System.Drawing.Point(18, 79)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(520, 1)
        Me.Line4.TabIndex = 30
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line1.Location = New System.Drawing.Point(18, 324)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(520, 1)
        Me.Line1.TabIndex = 31
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line2.Location = New System.Drawing.Point(18, 325)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(520, 1)
        Me.Line2.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(18, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Kasatker"
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(18, 15)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(521, 57)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 28
        Me.Image1.TabStop = False
        '
        'cmdHapus
        '
        Me.cmdHapus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHapus.Location = New System.Drawing.Point(466, 482)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.cmdHapus.TabIndex = 37
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBatal.Location = New System.Drawing.Point(263, 482)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdBatal.TabIndex = 36
        Me.cmdBatal.Text = "Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(101, 482)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 35
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Location = New System.Drawing.Point(182, 482)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 34
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdTambah
        '
        Me.cmdTambah.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambah.Location = New System.Drawing.Point(20, 482)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(75, 23)
        Me.cmdTambah.TabIndex = 33
        Me.cmdTambah.Text = "Tambah"
        Me.cmdTambah.UseVisualStyleBackColor = True
        '
        'txtPPK
        '
        Me.txtPPK.AcceptsReturn = True
        Me.txtPPK.BackColor = System.Drawing.SystemColors.Window
        Me.txtPPK.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPPK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPK.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPPK.Location = New System.Drawing.Point(122, 200)
        Me.txtPPK.MaxLength = 50
        Me.txtPPK.Name = "txtPPK"
        Me.txtPPK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPPK.Size = New System.Drawing.Size(416, 21)
        Me.txtPPK.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(114, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(18, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "PPK"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(114, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(18, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Kode Deputi"
        '
        'cboDeputi
        '
        Me.cboDeputi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeputi.FormattingEnabled = True
        Me.cboDeputi.Location = New System.Drawing.Point(122, 225)
        Me.cboDeputi.Name = "cboDeputi"
        Me.cboDeputi.Size = New System.Drawing.Size(416, 21)
        Me.cboDeputi.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(114, 272)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = ":"
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.BackColor = System.Drawing.SystemColors.Control
        Me.ID.Cursor = System.Windows.Forms.Cursors.Default
        Me.ID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ID.Location = New System.Drawing.Point(18, 272)
        Me.ID.Name = "ID"
        Me.ID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ID.Size = New System.Drawing.Size(44, 13)
        Me.ID.TabIndex = 47
        Me.ID.Text = "Reg. ID"
        '
        'cboRegional
        '
        Me.cboRegional.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegional.FormattingEnabled = True
        Me.cboRegional.Location = New System.Drawing.Point(122, 272)
        Me.cboRegional.Name = "cboRegional"
        Me.cboRegional.Size = New System.Drawing.Size(416, 21)
        Me.cboRegional.TabIndex = 48
        '
        'txtRegional
        '
        Me.txtRegional.AcceptsReturn = True
        Me.txtRegional.BackColor = System.Drawing.SystemColors.Window
        Me.txtRegional.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegional.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegional.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRegional.Location = New System.Drawing.Point(122, 296)
        Me.txtRegional.MaxLength = 50
        Me.txtRegional.Name = "txtRegional"
        Me.txtRegional.ReadOnly = True
        Me.txtRegional.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRegional.Size = New System.Drawing.Size(416, 21)
        Me.txtRegional.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(114, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(18, 296)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Regional"
        '
        'txtDeputi
        '
        Me.txtDeputi.AcceptsReturn = True
        Me.txtDeputi.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeputi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeputi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeputi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDeputi.Location = New System.Drawing.Point(122, 249)
        Me.txtDeputi.MaxLength = 50
        Me.txtDeputi.Name = "txtDeputi"
        Me.txtDeputi.ReadOnly = True
        Me.txtDeputi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeputi.Size = New System.Drawing.Size(416, 21)
        Me.txtDeputi.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(114, 249)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(18, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Deputi"
        '
        '_lvSatker_ColumnHeader_6
        '
        Me._lvSatker_ColumnHeader_6.Text = "Regional"
        '
        'frmSatker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 512)
        Me.Controls.Add(Me.txtDeputi)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtRegional)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboRegional)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.cboDeputi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPPK)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdTambah)
        Me.Controls.Add(Me.txtKasatker)
        Me.Controls.Add(Me.txtIDSatker)
        Me.Controls.Add(Me.txtNamaSatker)
        Me.Controls.Add(Me.lvSatker)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.Line4)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmSatker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSatker"
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtKasatker As System.Windows.Forms.TextBox
    Public WithEvents txtIDSatker As System.Windows.Forms.TextBox
    Public WithEvents txtNamaSatker As System.Windows.Forms.TextBox
    Public WithEvents lvSatker As System.Windows.Forms.ListView
    Public WithEvents _lvSatker_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
    Public WithEvents _lvSatker_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
    Public WithEvents _lvSatker_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Public WithEvents Line3 As System.Windows.Forms.Label
    Public WithEvents Line4 As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents Line2 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents cmdBatal As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
    Public WithEvents txtPPK As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboDeputi As System.Windows.Forms.ComboBox
    Friend WithEvents _lvSatker_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents _lvSatker_ColumnHeader_5 As System.Windows.Forms.ColumnHeader
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents ID As System.Windows.Forms.Label
    Friend WithEvents cboRegional As System.Windows.Forms.ComboBox
    Public WithEvents txtRegional As System.Windows.Forms.TextBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents txtDeputi As System.Windows.Forms.TextBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents _lvSatker_ColumnHeader_6 As System.Windows.Forms.ColumnHeader
End Class
