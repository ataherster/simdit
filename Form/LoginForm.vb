Public Class LoginForm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        UserName = txtUsername.Text
        Password = txtPassword.Text
        If OpenConnection(UserName, Password) = False Then
            MsgBox("Gagal Login", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        frmDIT.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

End Class

