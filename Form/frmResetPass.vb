Public Class frmResetPass

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        frmUser.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub cmdTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTambah.Click
        If CekPass(txtPasswordBaru.Text, txtKonfirmasi.Text) = False Then
            MsgBox("Password tidak sesuai", MsgBoxStyle.OkOnly, "Informasi")
            txtPasswordBaru.Text = ""
            txtKonfirmasi.Text = ""
            txtPasswordBaru.Focus()
            Exit Sub
        End If

        SQL = "UPDATE USER1 SET PASS='" & txtPasswordBaru.Text & "' WHERE USER='" & lblUserName.Text & "'"
        dbConn.Execute(SQL)
        MsgBox("Password User=" & lblUserName.Text & ", telah direset", MsgBoxStyle.OkOnly, "Infromasi")
        Me.Dispose()
    End Sub

    Function CekPass(ByVal PassBaru As String, ByVal Konf As String) As Boolean
        If Not PassBaru = Konf Then
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub frmResetPass_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frmUser.Enabled = True
        frmUser.Activate()
    End Sub

    Private Sub frmResetPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = cmdTambah
    End Sub
End Class