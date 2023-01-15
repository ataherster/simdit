Public Class frmSatker

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
        SQL = "DELETE FROM SATKER WHERE IDSATKER='" & txtIDSatker.Text & "'"
        ExecuteQuery(SQL)
        Kosong()
        txtStatus(True)
        CommandStatus(True)
        Fresh()
    End Sub

    Private Sub cmdSimpan_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSimpan.Click
        If Status = "tambah" Then
            SQL = "INSERT INTO SATKER VALUES ('" & txtIDSatker.Text & "','" & txtNamaSatker.Text & "', '" & cboDeputi.Text & "', '" & txtKasatker.Text & "', '" & txtPPK.Text & "', '" & cboRegional.Text & "')"
        ElseIf Status = "edit" Then
            SQL = "UPDATE SATKER SET NAMASATKER='" & txtNamaSatker.Text & "', IDDEPUTI='" & cboDeputi.Text & "', KASATKER='" & txtKasatker.Text & "', PPK='" & txtPPK.Text & "', REGIONAL='" & cboRegional.Text & "' WHERE IDSATKER='" & txtIDSatker.Text & "'"
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
        Kosong()
        txtStatus(False)
        CommandStatus(False)
        cmdHapus.Enabled = False
        txtIDSatker.Focus()
    End Sub

    Private Sub frmDeputi_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Fresh()
        txtStatus(True)
        CommandStatus(True)
        SQL = "SELECT ID FROM REGIONAL"
        IsiDataCombo(cboRegional, SQL)
        SQL = "SELECT IDDEPUTI FROM DEPUTI"
        IsiDataCombo(cboDeputi, SQL)
    End Sub

#End Region

    Sub Kosong()
        txtIDSatker.Text = ""
        txtNamaSatker.Text = ""
        cboDeputi.Text = ""
        txtDeputi.Text = ""
        txtKasatker.Text = ""
        txtPPK.Text = ""
        cboRegional.Text = ""
        txtRegional.Text = ""
    End Sub

    Sub txtStatus(ByRef A As Boolean)
        txtIDSatker.ReadOnly = A
        txtNamaSatker.ReadOnly = A
        txtKasatker.ReadOnly = A
        txtPPK.ReadOnly = A
    End Sub

    Sub Fresh()
        SQL = "SELECT * FROM SATKER ORDER BY IDSATKER"
        ExportToListView(lvSatker, SQL, False)
    End Sub
    Function Tampil() As Boolean
        If lvSatker.Items.Count = 0 Then
            Return False
            Exit Function
        End If
        txtIDSatker.Text = lvSatker.FocusedItem.Text
        txtNamaSatker.Text = lvSatker.FocusedItem.SubItems(1).Text
        cboDeputi.Text = lvSatker.FocusedItem.SubItems(2).Text
        txtKasatker.Text = lvSatker.FocusedItem.SubItems(3).Text
        txtPPK.Text = lvSatker.FocusedItem.SubItems(4).Text
        cboRegional.Text = lvSatker.FocusedItem.SubItems(5).Text
        Return True
    End Function

    Private Sub txtIDSatker_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtIDSatker.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Private Sub txtIDSatker_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtIDSatker.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 27 Then
            cmdBatal_ClickEvent(cmdBatal, New System.EventArgs())
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtNamaSatker_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNamaSatker.Enter
        System.Windows.Forms.SendKeys.Send("{Home}+{End}")
    End Sub

    Sub CommandStatus(ByRef sts As Boolean)
        cmdTambah.Enabled = sts
        cmdEdit.Enabled = sts
        cmdSimpan.Enabled = Not sts
        cmdHapus.Enabled = sts
        cmdBatal.Enabled = Not sts
    End Sub

    Private Sub txtNamaSatker_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNamaSatker.KeyPress
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
        Status = "edit"
        CommandStatus(False)
        txtNamaSatker.ReadOnly = False
        txtKasatker.ReadOnly = False
        txtPPK.ReadOnly = False
    End Sub

    Private Sub lvSatker_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvSatker.SelectedIndexChanged
        If Tampil() = False Then Exit Sub
    End Sub

    Private Sub cboRegional_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegional.SelectedIndexChanged
        SQL = "SELECT REGIONAL FROM REGIONAL WHERE ID='" & cboRegional.Text & "'"
        ClosedbRec()
        dbRec.Open(SQL)
        txtRegional.Text = dbRec.Fields("REGIONAL").Value
        dbRec.Close()
    End Sub

    Private Sub cboDeputi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDeputi.SelectedIndexChanged
        SQL = "SELECT NAMADEPUTI FROM DEPUTI WHERE IDDEPUTI='" & cboDeputi.Text & "'"
        ClosedbRec()
        dbRec.Open(SQL)
        txtDeputi.Text = dbRec.Fields("NAMADEPUTI").Value
        dbRec.Close()
    End Sub
End Class