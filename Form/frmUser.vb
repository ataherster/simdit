Public Class frmUser
    Dim Item As System.Windows.Forms.ListViewItem
    Dim Status As String

    Private Sub cmdBatal_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBatal.Click
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        Me.AcceptButton = cmdTambah
    End Sub

    Private Sub cmdHapus_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHapus.Click
        SQL = "DELETE FROM USER1 WHERE USER='" & txtUser.Text & "'"
        ExecuteQuery(SQL)
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        Fresh()
    End Sub

    Private Sub cmdSimpan_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSimpan.Click
        If CekData() = False Then Exit Sub
        If Status = "tambah" Then
            SQL = "INSERT INTO USER1 VALUES ('" & txtUser.Text & "','" & txtPassword.Text & "','" & cboOtoritas.Text & "')"
        ElseIf Status = "edit" Then
            SQL = "UPDATE USER1 SET PASS='" & txtPassword.Text & "', OTORITAS='" & cboOtoritas.Text & "' WHERE USER='" & txtUser.Text & "'"
        End If
        If ExecuteQuery(SQL) = False Then Exit Sub
        Fresh()
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        Me.AcceptButton = cmdTambah
        Status = ""
    End Sub

    Private Sub cmdTambah_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTambah.Click
        Status = "tambah"
        txtStatus(False)
        CommandStatus(False)
        cmdHapus.Enabled = False
        txtUser.Focus()
        Me.AcceptButton = cmdTambah
    End Sub

    Private Sub frmAdmUser_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Fresh()
        txtStatus(True)
        CommandStatus(True)
    End Sub

    Sub Kosong()
        txtUser.Text = ""
        txtPassword.Text = ""
        txtKonfPassword.Text = ""
        cboOtoritas.Text = ""
    End Sub

    Sub txtStatus(ByRef A As Boolean)
        txtUser.ReadOnly = A
        txtPassword.ReadOnly = A
        txtKonfPassword.ReadOnly = A
    End Sub

    Sub Fresh()
        SQL = "SELECT USER, OTORITAS FROM USER1 ORDER BY USER"
        ExportToListView(lvUser, SQL, False)
    End Sub
    Function Tampil() As Boolean
        If lvUser.Items.Count = 0 Then
            Tampil = False
            Exit Function
        End If
        txtUser.Text = lvUser.FocusedItem.Text
        cboOtoritas.Text = lvUser.FocusedItem.SubItems(1).Text
        Tampil = True
    End Function

    Private Sub txtUser_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUser.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Private Sub txtIDUser_KeyPress(ByRef KeyAscii As Short)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
    End Sub

    Private Sub txtPassword_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPassword.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Sub CommandStatus(ByRef sts As Boolean)
        cmdTambah.Enabled = sts
        cmdEdit.Enabled = sts
        cmdSimpan.Enabled = Not sts
        cmdHapus.Enabled = Not sts
        cmdBatal.Enabled = Not sts
    End Sub

    Private Sub txtPassword_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Function CekData() As Boolean
        If txtPassword.Text = "" Or txtKonfPassword.Text = "" Or cboOtoritas.Text = "" Or Not txtPassword.Text = txtKonfPassword.Text Then
            MsgBox("Periksa kembali data user anda, OK", MsgBoxStyle.Information, "Informasi")
            CekData = False
            Exit Function
        End If
        CekData = True
    End Function

    Private Sub lvUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvUser.SelectedIndexChanged
        If Tampil() = False Then Exit Sub
        Status = "edit"
        Tampil()
        Me.AcceptButton = cmdTambah
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        txtStatus(False)
        txtUser.ReadOnly = True
        cboOtoritas.Focus()
        CommandStatus(False)
    End Sub

    Private Sub cmdResetPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResetPass.Click
        frmResetPass.lblUserName.Text = txtUser.Text
        frmResetPass.Show()
        Me.Enabled = False
    End Sub
End Class