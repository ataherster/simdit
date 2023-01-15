<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KriteriaLaporan
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cboLaporan = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkTuntas = New System.Windows.Forms.CheckBox
        Me.chkStatus = New System.Windows.Forms.CheckBox
        Me.cboIDDeputi = New System.Windows.Forms.ComboBox
        Me.txtNamaDeputi = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkNilaiTemuan = New System.Windows.Forms.CheckBox
        Me.chkNilai = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.cboDeputi = New System.Windows.Forms.ComboBox
        Me.txtDeputi = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboSatker = New System.Windows.Forms.ComboBox
        Me.txtSatker = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.cboLapReg = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.chkTuntasReg = New System.Windows.Forms.CheckBox
        Me.chkStatusReg = New System.Windows.Forms.CheckBox
        Me.cboIDReg = New System.Windows.Forms.ComboBox
        Me.txtReg = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.chkNilaiTemuanReg = New System.Windows.Forms.CheckBox
        Me.chkNilaiReg = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SampaiTanggal = New System.Windows.Forms.DateTimePicker
        Me.DariTanggal = New System.Windows.Forms.DateTimePicker
        Me.cmdPreview = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 83)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(388, 285)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cboLaporan)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.chkTuntas)
        Me.TabPage1.Controls.Add(Me.chkStatus)
        Me.TabPage1.Controls.Add(Me.cboIDDeputi)
        Me.TabPage1.Controls.Add(Me.txtNamaDeputi)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.chkNilaiTemuan)
        Me.TabPage1.Controls.Add(Me.chkNilai)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(380, 259)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Per Deputi"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cboLaporan
        '
        Me.cboLaporan.FormattingEnabled = True
        Me.cboLaporan.Items.AddRange(New Object() {"Rekapitulasi", "Lampiran"})
        Me.cboLaporan.Location = New System.Drawing.Point(124, 16)
        Me.cboLaporan.Name = "cboLaporan"
        Me.cboLaporan.Size = New System.Drawing.Size(240, 21)
        Me.cboLaporan.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Laporan"
        '
        'chkTuntas
        '
        Me.chkTuntas.AutoSize = True
        Me.chkTuntas.Enabled = False
        Me.chkTuntas.Location = New System.Drawing.Point(22, 164)
        Me.chkTuntas.Name = "chkTuntas"
        Me.chkTuntas.Size = New System.Drawing.Size(59, 17)
        Me.chkTuntas.TabIndex = 15
        Me.chkTuntas.Text = "Tuntas"
        Me.chkTuntas.UseVisualStyleBackColor = True
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Location = New System.Drawing.Point(22, 141)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(57, 17)
        Me.chkStatus.TabIndex = 14
        Me.chkStatus.Text = "Status"
        Me.chkStatus.UseVisualStyleBackColor = True
        '
        'cboIDDeputi
        '
        Me.cboIDDeputi.FormattingEnabled = True
        Me.cboIDDeputi.Location = New System.Drawing.Point(124, 52)
        Me.cboIDDeputi.Name = "cboIDDeputi"
        Me.cboIDDeputi.Size = New System.Drawing.Size(240, 21)
        Me.cboIDDeputi.TabIndex = 13
        '
        'txtNamaDeputi
        '
        Me.txtNamaDeputi.Location = New System.Drawing.Point(124, 77)
        Me.txtNamaDeputi.Multiline = True
        Me.txtNamaDeputi.Name = "txtNamaDeputi"
        Me.txtNamaDeputi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNamaDeputi.Size = New System.Drawing.Size(240, 43)
        Me.txtNamaDeputi.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nama Deputi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Kode Deputi"
        '
        'chkNilaiTemuan
        '
        Me.chkNilaiTemuan.AutoSize = True
        Me.chkNilaiTemuan.Enabled = False
        Me.chkNilaiTemuan.Location = New System.Drawing.Point(22, 225)
        Me.chkNilaiTemuan.Name = "chkNilaiTemuan"
        Me.chkNilaiTemuan.Size = New System.Drawing.Size(121, 17)
        Me.chkNilaiTemuan.TabIndex = 8
        Me.chkNilaiTemuan.Text = "Nilai sama dengan 0"
        Me.chkNilaiTemuan.UseVisualStyleBackColor = True
        '
        'chkNilai
        '
        Me.chkNilai.AutoSize = True
        Me.chkNilai.Location = New System.Drawing.Point(22, 202)
        Me.chkNilai.Name = "chkNilai"
        Me.chkNilai.Size = New System.Drawing.Size(86, 17)
        Me.chkNilai.TabIndex = 7
        Me.chkNilai.Text = "Nilai Temuan"
        Me.chkNilai.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cboDeputi)
        Me.TabPage2.Controls.Add(Me.txtDeputi)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.cboSatker)
        Me.TabPage2.Controls.Add(Me.txtSatker)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(380, 259)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Per Satker"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cboDeputi
        '
        Me.cboDeputi.FormattingEnabled = True
        Me.cboDeputi.Location = New System.Drawing.Point(121, 19)
        Me.cboDeputi.Name = "cboDeputi"
        Me.cboDeputi.Size = New System.Drawing.Size(240, 21)
        Me.cboDeputi.TabIndex = 21
        '
        'txtDeputi
        '
        Me.txtDeputi.Location = New System.Drawing.Point(121, 44)
        Me.txtDeputi.Multiline = True
        Me.txtDeputi.Name = "txtDeputi"
        Me.txtDeputi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDeputi.Size = New System.Drawing.Size(240, 43)
        Me.txtDeputi.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Nama Deputi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Kode Deputi"
        '
        'cboSatker
        '
        Me.cboSatker.FormattingEnabled = True
        Me.cboSatker.Location = New System.Drawing.Point(121, 93)
        Me.cboSatker.Name = "cboSatker"
        Me.cboSatker.Size = New System.Drawing.Size(240, 21)
        Me.cboSatker.TabIndex = 17
        '
        'txtSatker
        '
        Me.txtSatker.Location = New System.Drawing.Point(121, 118)
        Me.txtSatker.Multiline = True
        Me.txtSatker.Name = "txtSatker"
        Me.txtSatker.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSatker.Size = New System.Drawing.Size(240, 43)
        Me.txtSatker.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Nama Satker"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Kode Satker"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cboLapReg)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.chkTuntasReg)
        Me.TabPage3.Controls.Add(Me.chkStatusReg)
        Me.TabPage3.Controls.Add(Me.cboIDReg)
        Me.TabPage3.Controls.Add(Me.txtReg)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.chkNilaiTemuanReg)
        Me.TabPage3.Controls.Add(Me.chkNilaiReg)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(380, 259)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Regional"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cboLapReg
        '
        Me.cboLapReg.FormattingEnabled = True
        Me.cboLapReg.Items.AddRange(New Object() {"Rekapitulasi", "Lampiran"})
        Me.cboLapReg.Location = New System.Drawing.Point(123, 16)
        Me.cboLapReg.Name = "cboLapReg"
        Me.cboLapReg.Size = New System.Drawing.Size(240, 21)
        Me.cboLapReg.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Laporan"
        '
        'chkTuntasReg
        '
        Me.chkTuntasReg.AutoSize = True
        Me.chkTuntasReg.Enabled = False
        Me.chkTuntasReg.Location = New System.Drawing.Point(21, 164)
        Me.chkTuntasReg.Name = "chkTuntasReg"
        Me.chkTuntasReg.Size = New System.Drawing.Size(59, 17)
        Me.chkTuntasReg.TabIndex = 25
        Me.chkTuntasReg.Text = "Tuntas"
        Me.chkTuntasReg.UseVisualStyleBackColor = True
        '
        'chkStatusReg
        '
        Me.chkStatusReg.AutoSize = True
        Me.chkStatusReg.Location = New System.Drawing.Point(21, 141)
        Me.chkStatusReg.Name = "chkStatusReg"
        Me.chkStatusReg.Size = New System.Drawing.Size(57, 17)
        Me.chkStatusReg.TabIndex = 24
        Me.chkStatusReg.Text = "Status"
        Me.chkStatusReg.UseVisualStyleBackColor = True
        '
        'cboIDReg
        '
        Me.cboIDReg.FormattingEnabled = True
        Me.cboIDReg.Location = New System.Drawing.Point(123, 52)
        Me.cboIDReg.Name = "cboIDReg"
        Me.cboIDReg.Size = New System.Drawing.Size(240, 21)
        Me.cboIDReg.TabIndex = 23
        '
        'txtReg
        '
        Me.txtReg.Location = New System.Drawing.Point(123, 77)
        Me.txtReg.Multiline = True
        Me.txtReg.Name = "txtReg"
        Me.txtReg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReg.Size = New System.Drawing.Size(240, 43)
        Me.txtReg.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Regional"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Kode Regional"
        '
        'chkNilaiTemuanReg
        '
        Me.chkNilaiTemuanReg.AutoSize = True
        Me.chkNilaiTemuanReg.Enabled = False
        Me.chkNilaiTemuanReg.Location = New System.Drawing.Point(21, 225)
        Me.chkNilaiTemuanReg.Name = "chkNilaiTemuanReg"
        Me.chkNilaiTemuanReg.Size = New System.Drawing.Size(121, 17)
        Me.chkNilaiTemuanReg.TabIndex = 19
        Me.chkNilaiTemuanReg.Text = "Nilai sama dengan 0"
        Me.chkNilaiTemuanReg.UseVisualStyleBackColor = True
        '
        'chkNilaiReg
        '
        Me.chkNilaiReg.AutoSize = True
        Me.chkNilaiReg.Location = New System.Drawing.Point(21, 202)
        Me.chkNilaiReg.Name = "chkNilaiReg"
        Me.chkNilaiReg.Size = New System.Drawing.Size(86, 17)
        Me.chkNilaiReg.TabIndex = 18
        Me.chkNilaiReg.Text = "Nilai Temuan"
        Me.chkNilaiReg.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sampai Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Dari Tanggal"
        '
        'SampaiTanggal
        '
        Me.SampaiTanggal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SampaiTanggal.Location = New System.Drawing.Point(114, 44)
        Me.SampaiTanggal.Name = "SampaiTanggal"
        Me.SampaiTanggal.Size = New System.Drawing.Size(286, 21)
        Me.SampaiTanggal.TabIndex = 7
        '
        'DariTanggal
        '
        Me.DariTanggal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DariTanggal.Location = New System.Drawing.Point(114, 17)
        Me.DariTanggal.Name = "DariTanggal"
        Me.DariTanggal.Size = New System.Drawing.Size(286, 21)
        Me.DariTanggal.TabIndex = 6
        '
        'cmdPreview
        '
        Me.cmdPreview.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPreview.Location = New System.Drawing.Point(298, 374)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(98, 28)
        Me.cmdPreview.TabIndex = 10
        Me.cmdPreview.Text = "Preview Report"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'KriteriaLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 414)
        Me.Controls.Add(Me.cmdPreview)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SampaiTanggal)
        Me.Controls.Add(Me.DariTanggal)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "KriteriaLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Per Deputi"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents chkNilaiTemuan As System.Windows.Forms.CheckBox
    Friend WithEvents chkNilai As System.Windows.Forms.CheckBox
    Friend WithEvents txtNamaDeputi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboIDDeputi As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SampaiTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DariTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkTuntas As System.Windows.Forms.CheckBox
    Friend WithEvents chkStatus As System.Windows.Forms.CheckBox
    Friend WithEvents cboLaporan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
    Friend WithEvents cboSatker As System.Windows.Forms.ComboBox
    Friend WithEvents txtSatker As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboDeputi As System.Windows.Forms.ComboBox
    Friend WithEvents txtDeputi As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cboLapReg As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkTuntasReg As System.Windows.Forms.CheckBox
    Friend WithEvents chkStatusReg As System.Windows.Forms.CheckBox
    Friend WithEvents cboIDReg As System.Windows.Forms.ComboBox
    Friend WithEvents txtReg As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkNilaiTemuanReg As System.Windows.Forms.CheckBox
    Friend WithEvents chkNilaiReg As System.Windows.Forms.CheckBox
End Class
