Public Class frmTemuan
    Dim Item As System.Windows.Forms.ListViewItem
    Dim Status As String

    Private Sub cboGroup_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGroup.SelectedIndexChanged
        SQL = "SELECT URAIAN FROM GROUPTEMUAN WHERE IDGROUP='" & cboGroup.Text & "'"
        dbRec.Open(SQL, dbConn)
        txtUraian.Text = dbRec.Fields(0).Value
        dbRec.Close()
        Fresh()
    End Sub

    Private Sub cmdEditGroup_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGroup.Click
        frmGroupTemuan.Show()
    End Sub

    Private Sub frmTemuan_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Fresh()
    End Sub

    Sub Fresh()
        SQL = "SELECT IDTEMUAN,URAIAN FROM TEMUAN WHERE IDGROUP='" & cboGroup.Text & "' ORDER BY IDTEMUAN"
        ExportToListView(lvTemuan, SQL, False)
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
        SQL = "DELETE FROM TEMUAN WHERE IDTEMUAN='" & txtIDTemuan.Text & "'"
        ExecuteQuery(SQL)
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        Fresh()
        Status = "normal"
    End Sub

    Private Sub cmdSimpan_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSimpan.Click
        If Status = "tambah" Then
            SQL = "INSERT INTO TEMUAN VALUES ('" & cboGroup.Text & "','" & txtIDTemuan.Text & "','" & txtUraianTemuan.Text & "')"
        ElseIf Status = "edit" Then
            SQL = "UPDATE TEMUAN SET URAIAN='" & txtUraianTemuan.Text & "' WHERE IDTEMUAN='" & txtIDTemuan.Text & "'"
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
        txtIDTemuan.Focus()
    End Sub

    Private Sub frmTemuan_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SQL = "SELECT IDGROUP FROM GROUPTEMUAN"
        IsiDataCombo(cboGroup, SQL)
        Fresh()
        txtStatus(True)
        CommandStatus(True)
    End Sub

    Sub Kosong()
        txtIDTemuan.Text = ""
        txtUraianTemuan.Text = ""
    End Sub

    Sub txtStatus(ByRef A As Boolean)
        txtIDTemuan.ReadOnly = A
        txtUraianTemuan.ReadOnly = A
    End Sub

    Function Tampil() As Boolean
        If lvTemuan.Items.Count = 0 Then
            Tampil = False
            Exit Function
        End If
        txtIDTemuan.Text = lvTemuan.FocusedItem.Text
        txtUraianTemuan.Text = lvTemuan.FocusedItem.SubItems(1).Text
        Tampil = True
    End Function

    Private Sub txtIDTemuan_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIDTemuan.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Private Sub txtIDTemuan_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIDTemuan.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtUraianTemuan_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUraianTemuan.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Sub CommandStatus(ByRef sts As Boolean)
        cmdTambah.Enabled = sts
        cmdEdit.Enabled = sts
        cmdSimpan.Enabled = Not sts
        cmdHapus.Enabled = sts
        cmdBatal.Enabled = Not sts
    End Sub

    Private Sub txtUraianTemuan_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUraianTemuan.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub lvTemuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvTemuan.SelectedIndexChanged
        If Status = "tambah" Or Status = "edit" Then Exit Sub
        If Tampil() = False Then Exit Sub
        Tampil()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Status = "edit"
        txtStatus(False)
        CommandStatus(False)
        cmdHapus.Enabled = False
        txtIDTemuan.Focus()
    End Sub
End Class