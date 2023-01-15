<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResetPass
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
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdTambah = New System.Windows.Forms.Button
        Me.txtKonfirmasi = New System.Windows.Forms.TextBox
        Me.txtPasswordBaru = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblUserName = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Location = New System.Drawing.Point(319, 100)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 50
        Me.cmdEdit.Text = "Batal"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdTambah
        '
        Me.cmdTambah.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTambah.Location = New System.Drawing.Point(237, 100)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(75, 23)
        Me.cmdTambah.TabIndex = 49
        Me.cmdTambah.Text = "OK"
        Me.cmdTambah.UseVisualStyleBackColor = True
        '
        'txtKonfirmasi
        '
        Me.txtKonfirmasi.AcceptsReturn = True
        Me.txtKonfirmasi.BackColor = System.Drawing.SystemColors.Window
        Me.txtKonfirmasi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKonfirmasi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKonfirmasi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtKonfirmasi.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtKonfirmasi.Location = New System.Drawing.Point(126, 69)
        Me.txtKonfirmasi.MaxLength = 0
        Me.txtKonfirmasi.Name = "txtKonfirmasi"
        Me.txtKonfirmasi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKonfirmasi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKonfirmasi.Size = New System.Drawing.Size(268, 21)
        Me.txtKonfirmasi.TabIndex = 44
        '
        'txtPasswordBaru
        '
        Me.txtPasswordBaru.AcceptsReturn = True
        Me.txtPasswordBaru.BackColor = System.Drawing.SystemColors.Window
        Me.txtPasswordBaru.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPasswordBaru.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordBaru.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPasswordBaru.Location = New System.Drawing.Point(126, 45)
        Me.txtPasswordBaru.MaxLength = 0
        Me.txtPasswordBaru.Name = "txtPasswordBaru"
        Me.txtPasswordBaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordBaru.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPasswordBaru.Size = New System.Drawing.Size(268, 21)
        Me.txtPasswordBaru.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(22, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Password Baru"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(22, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Konfirmasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(118, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(118, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(22, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "User Name"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.SystemColors.Control
        Me.lblUserName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUserName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUserName.Location = New System.Drawing.Point(126, 19)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUserName.Size = New System.Drawing.Size(90, 13)
        Me.lblUserName.TabIndex = 52
        Me.lblUserName.Text = "Password Baru"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(118, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = ":"
        '
        'frmResetPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 137)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdTambah)
        Me.Controls.Add(Me.txtKonfirmasi)
        Me.Controls.Add(Me.txtPasswordBaru)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.Name = "frmResetPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
    Public WithEvents txtKonfirmasi As System.Windows.Forms.TextBox
    Public WithEvents txtPasswordBaru As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents lblUserName As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
End Class
