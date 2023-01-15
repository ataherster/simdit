Imports System.IO
Imports System.Drawing

Public Class QueryBrowser
    Dim a As Shortcut
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If Not txtQuery.Text = "" Then
            If MsgBox("Query akan ditimpa ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Konfirmasi") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        txtQuery.Text = My.Computer.FileSystem.ReadAllText(App_Path() & "\ReportQuery\Lampiran.SQL")
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ExportToListView(lvQuery, txtQuery.Text, True)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        SaveFile.Filter = "Ms Excel File(*.xls)|*.xls"
        If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            SimpanKeExcel(txtQuery.Text, SaveFile.FileName)
        End If
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        If OpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Not txtQuery.Text = "" Then
                If MsgBox("Query akan ditimpa ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Konfirmasi") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            txtQuery.Text = My.Computer.FileSystem.ReadAllText(OpenFile.FileName)
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveFile.Filter = "SQL File(*.sql)|*.sql"
        If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFile.FileName, txtQuery.Text, False)
        End If
    End Sub

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Dim QueryBrowser As New QueryBrowser
        QueryBrowser.Show()
        QueryBrowser = Nothing
    End Sub

    Private Sub CutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripButton.Click
        SendKeys.Send("^X")
    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click
        SendKeys.Send("^C")
    End Sub

    Private Sub PasteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripButton.Click
        SendKeys.Send("^V")
    End Sub

    Private Sub PopulateTreeView()
        Dim rootNode As TreeNode

        Dim info As New DirectoryInfo(Path)

        If info.Exists Then
            rootNode = New TreeNode(info.Name)
            rootNode.Tag = info
            GetDirectories(info.GetDirectories(), rootNode)
            treeView1.Nodes.Add(rootNode)
        End If
    End Sub

    Private Sub GetDirectories(ByVal subDirs() As DirectoryInfo, _
        ByVal nodeToAddTo As TreeNode)

        Dim aNode As TreeNode
        Dim subSubDirs() As DirectoryInfo
        Dim subDir As DirectoryInfo

        For Each subDir In subDirs
            aNode = New TreeNode(subDir.Name, 0, 0)
            aNode.ImageKey = "folder"
            aNode.Tag = subDir
            subSubDirs = subDir.GetDirectories()
            If subSubDirs.Length <> 0 Then
                GetDirectories(subSubDirs, aNode)
            End If
            nodeToAddTo.Nodes.Add(aNode)
        Next subDir

    End Sub

    Private Sub QueryBrowser_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PopulateTreeView()
    End Sub

    Private Sub txtQuery_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuery.KeyDown
        If e.KeyCode = Keys.F5 Then
            ExportToListView(lvQuery, txtQuery.Text, True)
        End If
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        OpenFile.InitialDirectory = e.Node.Tag.ToString
        If OpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Not txtQuery.Text = "" Then
                If MsgBox("Query akan ditimpa ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Konfirmasi") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            txtQuery.Text = My.Computer.FileSystem.ReadAllText(OpenFile.FileName)
        End If
    End Sub

End Class