Public Class frmChangePassword

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If CekPassword(txtPassLama.Text, txtPassBaru.Text, txtKonfPass.Text) = False Then
            MsgBox("Gagal mengganti Password", MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub
        End If
        SQL = "UPDATE USER1 SET PASS='" & txtPassBaru.Text & "' WHERE USER='" & UserName & "'"
        dbConn.Execute(SQL)
        MsgBox("Password berhasil diganti", MsgBoxStyle.OkOnly, "Informasi")
    End Sub

    Private Sub cmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBatal.Click
        Me.Close()
    End Sub

    Function CekPassword(ByVal PassLama As String, ByVal Passbaru As String, ByVal konf As String) As Boolean
        If PassLama <> Password Then
            Return False
            Exit Function
        End If
        If Passbaru <> konf Then
            Return False
            Exit Function
        End If
        Return True
    End Function
End Class