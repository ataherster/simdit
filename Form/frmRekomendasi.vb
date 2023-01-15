Public Class frmRekomendasi
    Dim Item As System.Windows.Forms.ListViewItem
    Dim Status As String

    Private Sub cboGroup_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGroup.SelectedIndexChanged
        SQL = "SELECT URAIAN FROM GROUPREKOMENDASI WHERE IDGROUP='" & cboGroup.Text & "'"
        dbRec.Open(SQL, dbConn)
        txtUraian.Text = dbRec.Fields(0).Value
        dbRec.Close()
        Fresh()
    End Sub

    Private Sub cmdEditGroup_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGroup.Click
        frmGroupRekomendasi.Show()
    End Sub

    Private Sub frmREKOMENDASI_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Fresh()
    End Sub

    Sub Fresh()
        SQL = "SELECT IDREKOMENDASI,URAIAN FROM REKOMENDASI WHERE IDGROUP='" & cboGroup.Text & "' ORDER BY IDREKOMENDASI"
        ExportToListView(lvRekomendasi, SQL, False)
    End Sub

    Private Sub cmdBatal_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBatal.Click
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        cmdTambah.Focus()
        Status = "normal"
    End Sub

    Private Sub cmdHapus_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHapus.Click
        If MsgBox("Data akan dihapus ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        SQL = "DELETE FROM REKOMENDASI WHERE IDREKOMENDASI='" & txtIDRekomendasi.Text & "'"
        ExecuteQuery(SQL)
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        Fresh()
        Status = "normal"
    End Sub

    Private Sub cmdSimpan_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSimpan.Click
        If Status = "tambah" Then
            SQL = "INSERT INTO REKOMENDASI VALUES ('" & cboGroup.Text & "','" & txtIDRekomendasi.Text & "','" & txtUraianRekomendasi.Text & "')"
        ElseIf Status = "edit" Then
            SQL = "UPDATE REKOMENDASI SET URAIAN='" & txtUraianRekomendasi.Text & "' WHERE IDREKOMENDASI='" & txtIDRekomendasi.Text & "'"
        End If
        If ExecuteQuery(SQL) = False Then Exit Sub
        Fresh()
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        cmdTambah.Focus()
        Status = ""
    End Sub

    Private Sub cmdTambah_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTambah.Click
        If cboGroup.Text = "" Then
            MsgBox("Silahkan pilih group", MsgBoxStyle.Information, "Informasi")
            Exit Sub
        End If
        Status = "tambah"
        txtStatus(False)
        CommandStatus(False)
        cmdHapus.Enabled = False
        Kosong()
        txtIDRekomendasi.Focus()
    End Sub

    Private Sub frmREKOMENDASI_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SQL = "SELECT IDGROUP FROM GROUPREKOMENDASI"
        IsiDataCombo(cboGroup, SQL)
        Fresh()
        txtStatus(True)
        CommandStatus(True)
    End Sub

    Sub Kosong()
        txtIDRekomendasi.Text = ""
        txtUraianRekomendasi.Text = ""
    End Sub

    Sub txtStatus(ByRef A As Boolean)
        txtIDRekomendasi.ReadOnly = A
        txtUraianRekomendasi.ReadOnly = A
    End Sub

    Function Tampil() As Boolean
        If lvRekomendasi.Items.Count = 0 Then
            Tampil = False
            Exit Function
        End If
        txtIDRekomendasi.Text = lvRekomendasi.FocusedItem.Text
        txtUraianRekomendasi.Text = lvRekomendasi.FocusedItem.SubItems(1).Text
        Tampil = True
    End Function

    Private Sub txtIDREKOMENDASI_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIDRekomendasi.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Private Sub txtIDREKOMENDASI_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIDRekomendasi.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtUraianREKOMENDASI_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUraianRekomendasi.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Sub CommandStatus(ByRef sts As Boolean)
        cmdTambah.Enabled = sts
        cmdEdit.Enabled = sts
        cmdSimpan.Enabled = Not sts
        cmdHapus.Enabled = sts
        cmdBatal.Enabled = Not sts
    End Sub

    Private Sub txtUraianREKOMENDASI_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUraianRekomendasi.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub lvREKOMENDASI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRekomendasi.SelectedIndexChanged
        If Status = "tambah" Or Status = "edit" Then Exit Sub
        If Tampil() = False Then Exit Sub
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Status = "edit"
        txtStatus(False)
        CommandStatus(False)
        cmdHapus.Enabled = False
        txtIDRekomendasi.Focus()
    End Sub
End Class