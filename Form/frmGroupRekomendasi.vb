Public Class frmGroupRekomendasi
    Dim Item As System.Windows.Forms.ListViewItem
    Dim Status As String

    Private Sub cmdBatal_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBatal.Click
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        cmdTambah.Focus()
        Status = "normal"
    End Sub

    Private Sub cmdHapus_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHapus.Click
        If MsgBox("Data akan dihapus ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        SQL = "DELETE FROM GROUPREKOMENDASI WHERE IDGROUP='" & txtIDGroup.Text & "'"
        ExecuteQuery(SQL)
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        Fresh()
        Status = "normal"
    End Sub

    Private Sub cmdSimpan_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSimpan.Click
        If Status = "tambah" Then
            SQL = "INSERT INTO GROUPREKOMENDASI VALUES ('" & txtIDGroup.Text & "','" & txtUraian.Text & "')"
        ElseIf Status = "edit" Then
            SQL = "UPDATE GROUPREKOMENDASI SET URAIAN='" & txtUraian.Text & "' WHERE IDGROUP='" & txtIDGroup.Text & "'"
        End If
        If ExecuteQuery(SQL) = False Then Exit Sub
        Fresh()
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        Status = "normal"
    End Sub

    Private Sub cmdTambah_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTambah.Click
        Status = "tambah"
        txtStatus(False)
        CommandStatus(False)
        cmdHapus.Enabled = False
        txtIDGroup.Focus()
    End Sub

    Private Sub frmGroupREKOMENDASI_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Fresh()
    End Sub

    Private Sub frmGroupREKOMENDASI_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Fresh()
        txtStatus(True)
        CommandStatus(True)
    End Sub

    Sub Kosong()
        txtIDGroup.Text = ""
        txtUraian.Text = ""
    End Sub

    Sub txtStatus(ByRef A As Boolean)
        txtIDGroup.ReadOnly = A
        txtUraian.ReadOnly = A
    End Sub

    Sub Fresh()
        SQL = "SELECT * FROM GROUPREKOMENDASI ORDER BY IDGROUP"
        ExportToListView(lvGroupREKOMENDASI, SQL, False)
        SQL = "SELECT IDGROUP FROM GROUPREKOMENDASI"
        IsiDataCombo((frmRekomendasi.cboGroup), SQL)
    End Sub

    Function Tampil() As Boolean
        If lvGroupRekomendasi.Items.Count = 0 Then
            Tampil = False
            Exit Function
        End If
        txtIDGroup.Text = lvGroupRekomendasi.FocusedItem.Text
        txtUraian.Text = lvGroupRekomendasi.FocusedItem.SubItems(1).Text
        Tampil = True
    End Function

    Private Sub txtIDGroup_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIDGroup.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Private Sub txtIDGroup_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIDGroup.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtUraian_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUraian.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Sub CommandStatus(ByRef sts As Boolean)
        cmdTambah.Enabled = sts
        cmdEdit.Enabled = sts
        cmdSimpan.Enabled = Not sts
        cmdHapus.Enabled = sts
        cmdBatal.Enabled = Not sts
    End Sub

    Private Sub txtUraian_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUraian.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub lvGroupTemuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvGroupRekomendasi.SelectedIndexChanged
        If Tampil() = False Then Exit Sub
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Status = "edit"
        txtUraian.ReadOnly = False
        txtUraian.Focus()
        CommandStatus(False)
    End Sub
End Class