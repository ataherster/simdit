Public Class frmDeputi

#Region "Deklarasi"
    Dim Status As String
#End Region

#Region "Form Methode"
    Private Sub cmdBatal_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBatal.Click
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        cmdTambah.Focus()
    End Sub

    Private Sub cmdHapus_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHapus.Click
        If MsgBox("Data akan dihapus", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Question") = MsgBoxResult.No Then
            Exit Sub
        End If
        SQL = "DELETE FROM DEPUTI WHERE IDDEPUTI='" & txtIDDeputi.Text & "'"
        ExecuteQuery(SQL)
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        Fresh()
    End Sub

    Private Sub cmdSimpan_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSimpan.Click
        If Status = "tambah" Then
            SQL = "INSERT INTO DEPUTI VALUES ('" & txtIDDeputi.Text & "','" & txtNamaDeputi.Text & "')"
        ElseIf Status = "edit" Then
            SQL = "UPDATE DEPUTI SET NAMADEPUTI='" & txtNamaDeputi.Text & "' WHERE IDDEPUTI='" & txtIDDeputi.Text & "'"
        End If
        If ExecuteQuery(SQL) = False Then Exit Sub
        Fresh()
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        Status = ""
    End Sub

    Private Sub cmdTambah_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTambah.Click
        Status = "tambah"
        txtStatus(False)
        CommandStatus(False)
        cmdHapus.Enabled = False
        txtIDDeputi.Focus()
    End Sub

    Private Sub frmDeputi_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Fresh()
        txtStatus(True)
        CommandStatus(True)
    End Sub

#End Region

    Sub Kosong()
        txtIDDeputi.Text = ""
        txtNamaDeputi.Text = ""
    End Sub

    Sub txtStatus(ByRef A As Boolean)
        txtNamaDeputi.ReadOnly = A
    End Sub

    Sub Fresh()
        SQL = "SELECT * FROM DEPUTI ORDER BY IDDEPUTI"
        ExportToListView(lvDeputi, SQL, False)
    End Sub
    Function Tampil() As Boolean
        If lvDeputi.Items.Count = 0 Then
            Return False
            Exit Function
        End If
        txtIDDeputi.Text = lvDeputi.FocusedItem.Text
        txtNamaDeputi.Text = lvDeputi.FocusedItem.SubItems(1).Text
        Return True
    End Function

    Private Sub txtIDDeputi_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIDDeputi.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Private Sub txtIDDeputi_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIDDeputi.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtNamaDeputi_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNamaDeputi.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Sub CommandStatus(ByRef sts As Boolean)
        cmdTambah.Enabled = sts
        cmdEdit.Enabled = sts
        cmdSimpan.Enabled = Not sts
        cmdHapus.Enabled = sts
        cmdBatal.Enabled = Not sts
    End Sub

    Private Sub txtNamaDeputi_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNamaDeputi.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        CommandStatus(False)
        txtNamaDeputi.ReadOnly = False
    End Sub

    Private Sub lvDeputi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvDeputi.SelectedIndexChanged
        If Tampil() = False Then Exit Sub
    End Sub
End Class