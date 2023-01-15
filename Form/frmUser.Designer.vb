<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.cboOtoritas = New System.Windows.Forms.ComboBox
        Me.txtKonfPassword = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.lvUser = New System.Windows.Forms.ListView
        Me._lvUser_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvUser_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Line1 = New System.Windows.Forms.Label
        Me.Line2 = New System.Windows.Forms.Label
        Me.Line4 = New System.Windows.Forms.Label
        Me.Line3 = New System.Windows.Forms.Label
        Me.cmdHapus = New System.Windows.Forms.Button
        Me.cmdBatal = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.cmdTambah = New System.Windows.Forms.Button
        Me.cmdResetPass = New System.Windows.Forms.Button
        Me.Image1 = New System.Windows.Forms.PictureBox
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboOtoritas
        '
        Me.cboOtoritas.BackColor = System.Drawing.SystemColors.Window
        Me.cboOtoritas.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboOtoritas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOtoritas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOtoritas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboOtoritas.Items.AddRange(New Object() {"Administrator", "OP"})
        Me.cboOtoritas.Location = New System.Drawing.Point(116, 164)
        Me.cboOtoritas.Name = "cboOtoritas"
        Me.cboOtoritas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboOtoritas.Size = New System.Drawing.Size(268, 21)
        Me.cboOtoritas.TabIndex = 25
        '
        'txtKonfPassword
        '
        Me.txtKonfPassword.AcceptsReturn = True
        Me.txtKonfPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtKonfPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKonfPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKonfPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtKonfPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtKonfPassword.Location = New System.Drawing.Point(116, 140)
        Me.txtKonfPassword.MaxLength = 0
        Me.txtKonfPassword.Name = "txtKonfPassword"
        Me.txtKonfPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKonfPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKonfPassword.Size = New System.Drawing.Size(268, 21)
        Me.txtKonfPassword.TabIndex = 24
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsReturn = True
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtPassword.Location = New System.Drawing.Point(116, 116)
        Me.txtPassword.MaxLength = 0
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPassword.Size = New System.Drawing.Size(268, 21)
        Me.txtPassword.TabIndex = 23
        '
        'txtUser
        '
        Me.txtUser.AcceptsReturn = True
        Me.txtUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUser.Location = New System.Drawing.Point(116, 92)
        Me.txtUser.MaxLength = 0
        Me.txtUser.Name = "txtUser"
        Me.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUser.Size = New System.Drawing.Size(268, 21)
        Me.txtUser.TabIndex = 22
        '
        'lvUser
        '
        Me.lvUser.BackColor = System.Drawing.SystemColors.Window
        Me.lvUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvUser_ColumnHeader_1, Me._lvUser_ColumnHeader_2})
        Me.lvUser.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvUser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvUser.FullRowSelect = True
        Me.lvUser.GridLines = True
        Me.lvUser.LabelEdit = True
        Me.lvUser.Location = New System.Drawing.Point(12, 212)
        Me.lvUser.Name = "lvUser"
        Me.lvUser.Size = New System.Drawing.Size(372, 113)
        Me.lvUser.TabIndex = 26
        Me.lvUser.UseCompatibleStateImageBehavior = False
        Me.lvUser.View = System.Windows.Forms.View.Details
        '
        '_lvUser_ColumnHeader_1
        '
        Me._lvUser_ColumnHeader_1.Text = "User Name"
        Me._lvUser_ColumnHeader_1.Width = 170
        '
        '_lvUser_ColumnHeader_2
        '
        Me._lvUser_ColumnHeader_2.Text = "Otoritas"
        Me._lvUser_ColumnHeader_2.Width = 202
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(108, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(12, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Otoritas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(108, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(12, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Konf Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(108, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(108, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = ":"
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line1.Location = New System.Drawing.Point(12, 196)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(371, 1)
        Me.Line1.TabIndex = 35
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line2.Location = New System.Drawing.Point(12, 197)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(371, 1)
        Me.Line2.TabIndex = 36
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Line4.Location = New System.Drawing.Point(12, 76)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(453, 1)
        Me.Line4.TabIndex = 37
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Line3.Location = New System.Drawing.Point(12, 77)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(453, 1)
        Me.Line3.TabIndex = 38
        '
        'cmdHapus
        '
        Me.cmdHapus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHapus.Location = New System.Drawing.Point(390, 302)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.cmdHapus.TabIndex = 44
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBatal.Location = New System.Drawing.Point(390, 163)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdBatal.TabIndex = 43
        Me.cmdBatal.Text = "Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(390, 115)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 42
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSimpan.Location = New System.Drawing.Point(390, 139)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 41
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdTambah
        '
        Me.cmdTambah.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambah.Location = New System.Drawing.Point(390, 92)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(75, 23)
        Me.cmdTambah.TabIndex = 40
        Me.cmdTambah.Text = "Tambah"
        Me.cmdTambah.UseVisualStyleBackColor = True
        '
        'cmdResetPass
        '
        Me.cmdResetPass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResetPass.Location = New System.Drawing.Point(390, 212)
        Me.cmdResetPass.Name = "cmdResetPass"
        Me.cmdResetPass.Size = New System.Drawing.Size(75, 34)
        Me.cmdResetPass.TabIndex = 45
        Me.cmdResetPass.Text = "Reset Password"
        Me.cmdResetPass.UseVisualStyleBackColor = True
        '
        'Image1
        '
        Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
        Me.Image1.Location = New System.Drawing.Point(12, 12)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(454, 57)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 39
        Me.Image1.TabStop = False
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 339)
        Me.Controls.Add(Me.cmdResetPass)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdTambah)
        Me.Controls.Add(Me.cboOtoritas)
        Me.Controls.Add(Me.txtKonfPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lvUser)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Line4)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.Image1)
        Me.MaximizeBox = False
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrasi User"
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cboOtoritas As System.Windows.Forms.ComboBox
    Public WithEvents txtKonfPassword As System.Windows.Forms.TextBox
    Public WithEvents txtPassword As System.Windows.Forms.TextBox
    Public WithEvents txtUser As System.Windows.Forms.TextBox
    Public WithEvents lvUser As System.Windows.Forms.ListView
    Public WithEvents _lvUser_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
    Public WithEvents _lvUser_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents Line2 As System.Windows.Forms.Label
    Public WithEvents Line4 As System.Windows.Forms.Label
    Public WithEvents Line3 As System.Windows.Forms.Label
    Public WithEvents Image1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents cmdBatal As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
    Friend WithEvents cmdResetPass As System.Windows.Forms.Button
End Class
