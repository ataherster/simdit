Public Class frmTindakLanjut
    Dim SQL As String
    Dim Item As System.Windows.Forms.ListViewItem
    Dim Status As String

    Private Sub cboGroup_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboGroup.SelectedIndexChanged
        SQL = "SELECT URAIAN FROM GROUPtindaklanjut WHERE IDGROUP='" & cboGroup.Text & "'"
        dbRec.Open(SQL, dbConn)
        txtUraian.Text = dbRec.Fields(0).Value
        dbRec.Close()
        Fresh()
    End Sub

    Private Sub cmdEditGroup_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGroup.Click
        frmGroupTL.Show()
    End Sub

    Private Sub frmTINDAKLANJUT_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Fresh()
    End Sub

    Sub Fresh()
        SQL = "SELECT IDTINDAKLANJUT,URAIAN FROM TINDAKLANJUT WHERE IDGROUP='" & cboGroup.Text & "' ORDER BY IDTINDAKLANJUT"
        ExportToListView(lvTindakLanjut, SQL, False)
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
        SQL = "DELETE FROM TINDAKLANJUT WHERE IDTINDAKLANJUT='" & txtIDTindakLanjut.Text & "'"
        ExecuteQuery(SQL)
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        Fresh()
        Status = "normal"
    End Sub

    Private Sub cmdSimpan_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSimpan.Click
        If Status = "tambah" Then
            SQL = "INSERT INTO TINDAKLANJUT VALUES ('" & cboGroup.Text & "','" & txtIDTindakLanjut.Text & "','" & txtUraianTindakLanjut.Text & "')"
        ElseIf Status = "edit" Then
            SQL = "UPDATE TINDAKLANJUT SET URAIAN='" & txtUraianTindakLanjut.Text & "' WHERE IDTINDAKLANJUT='" & txtIDTindakLanjut.Text & "'"
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
        txtIDTindakLanjut.Focus()
    End Sub

    Private Sub frmTINDAKLANJUT_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        SQL = "SELECT IDGROUP FROM GROUPTINDAKLANJUT"
        IsiDataCombo(cboGroup, SQL)
        Fresh()
        txtStatus(True)
        CommandStatus(True)
    End Sub

    Sub Kosong()
        txtIDTindakLanjut.Text = ""
        txtUraianTindakLanjut.Text = ""
    End Sub

    Sub txtStatus(ByRef A As Boolean)
        txtIDTindakLanjut.ReadOnly = A
        txtUraianTindakLanjut.ReadOnly = A
    End Sub

    Function Tampil() As Boolean
        If lvTindakLanjut.Items.Count = 0 Then
            Tampil = False
            Exit Function
        End If
        txtIDTindakLanjut.Text = lvTindakLanjut.FocusedItem.Text
        txtUraianTindakLanjut.Text = lvTindakLanjut.FocusedItem.SubItems(1).Text
        Tampil = True
    End Function

    Private Sub txtIDTINDAKLANJUT_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIDTindakLanjut.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Private Sub txtIDTINDAKLANJUT_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIDTindakLanjut.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtUraianTINDAKLANJUT_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUraianTindakLanjut.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Sub CommandStatus(ByRef sts As Boolean)
        cmdTambah.Enabled = sts
        cmdEdit.Enabled = sts
        cmdSimpan.Enabled = Not sts
        cmdHapus.Enabled = sts
        cmdBatal.Enabled = Not sts
    End Sub

    Private Sub txtUraianTINDAKLANJUT_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUraianTindakLanjut.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub lvTINDAKLANJUT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvTindakLanjut.SelectedIndexChanged
        If Status = "tambah" Or Status = "edit" Then Exit Sub
        If Tampil() = False Then Exit Sub
        Tampil()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Status = "edit"
        txtStatus(False)
        CommandStatus(False)
        cmdHapus.Enabled = False
        txtIDTindakLanjut.Focus()
    End Sub
End Class