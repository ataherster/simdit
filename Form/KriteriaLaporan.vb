Imports CrystalDecisions.CrystalReports.Engine

Public Class KriteriaLaporan
    Dim Laporan As String
    Private Sub chkNilai_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNilai.Click

        If chkNilai.Checked = True Then
            chkNilaiTemuan.Enabled = True
        Else
            chkNilaiTemuan.Enabled = False
        End If
    End Sub

    Private Sub KriteriaLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IsiCboDeputi()
        IsiCboRegional()
    End Sub

    Sub IsiCboDeputi()
        SQL = "SELECT IDDEPUTI FROM DEPUTI"
        IsiDataCombo(cboIDDeputi, SQL)
        IsiDataCombo(cboDeputi, SQL)
    End Sub

    Sub IsiCboSatker()
        SQL = "SELECT IDSATKER FROM SATKER WHERE IDDEPUTI='" & cboDeputi.Text & "'"
        IsiDataCombo(cboSatker, SQL)
    End Sub

    Sub IsiCboRegional()
        SQL = "SELECT ID FROM REGIONAL"
        IsiDataCombo(cboIDReg, SQL)
    End Sub

    Function IsiTextRegional(ByVal cbo As ComboBox) As String
        SQL = "SELECT REGIONAL FROM REGIONAL WHERE ID='" & cbo.Text & "'"
        ClosedbRec()
        dbRec.Open(SQL)
        Return dbRec.Fields("REGIONAL").Value
        dbRec.Close()
    End Function

    Function IsiTextDeputi(ByVal cbo As ComboBox) As String
        SQL = "SELECT NAMADEPUTI FROM DEPUTI WHERE IDDEPUTI='" & cbo.Text & "'"
        ClosedbRec()
        dbRec.Open(SQL)
        Return dbRec.Fields("NAMADEPUTI").Value
        dbRec.Close()
    End Function

    Function IsiTextSatker(ByVal cbo As ComboBox) As String
        SQL = "SELECT NAMASATKER FROM SATKER WHERE IDSATKER='" & cbo.Text & "'"
        ClosedbRec()
        dbRec.Open(SQL)
        Return dbRec.Fields("NAMASATKER").Value
        dbRec.Close()
    End Function
    Private Sub cboIDDeputi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIDDeputi.SelectedIndexChanged
        txtNamaDeputi.Text = IsiTextDeputi(cboIDDeputi)
    End Sub

    Function Kriteria() As String

        Return ""
    End Function

    Private Sub chkStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStatus.CheckedChanged
        If chkStatus.Checked = True Then
            chkTuntas.Enabled = True
        Else
            chkTuntas.Enabled = False
        End If
    End Sub

    Private Sub cboLaporan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLaporan.SelectedIndexChanged
        Select Case cboLaporan.Text
            Case "Rekapitulasi"
                chkStatus.Visible = False
                chkTuntas.Visible = False
                chkNilai.Visible = False
                chkNilaiTemuan.Visible = False
            Case "Lampiran"
                chkStatus.Visible = True
                chkTuntas.Visible = True
                chkNilai.Visible = True
                chkNilaiTemuan.Visible = True
        End Select
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        Laporan = "deputi"
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        Laporan = "satker"
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click
        Dim txtJudulLaporan As TextObject
        Dim txtDariTgl As TextObject
        Dim txtSampaiTgl As TextObject
        Dim frmLaporan As New frmLaporan

        Select Case Laporan
            Case "deputi"
                Select Case cboLaporan.Text
                    Case "Rekapitulasi"
                        Dim Rekap As New Laporan

                        Rekap.ResourceName = "Rekap.rpt"

                        txtJudulLaporan = Rekap.ReportDefinition.ReportObjects.Item("txtJudul")
                        txtDariTgl = Rekap.ReportDefinition.ReportObjects.Item("txtDariTgl")
                        txtSampaiTgl = Rekap.ReportDefinition.ReportObjects.Item("txtSampaiTgl")
                        txtJudulLaporan.Text = "REKAPITULASI TEMUAN PERDEPUTI"
                        txtDariTgl.Text = DariTanggal.Value
                        txtSampaiTgl.Text = SampaiTanggal.Value

                        SQL = My.Computer.FileSystem.ReadAllText(ReportQueryPath & "Rekap1.SQL")
                        SQL &= DariTanggal.Value
                        SQL &= My.Computer.FileSystem.ReadAllText(ReportQueryPath & "Rekap2.SQL")
                        SQL &= DariTanggal.Value
                        SQL &= My.Computer.FileSystem.ReadAllText(ReportQueryPath & "Rekap3.SQL")
                        SQL &= SampaiTanggal.Value
                        SQL &= My.Computer.FileSystem.ReadAllText(ReportQueryPath & "Rekap4.SQL")

                        If cboIDDeputi.Text <> "" Then
                            SQL &= " WHERE REKAPPL.IDDEPUTI='" & cboIDDeputi.Text & "'"
                        End If
                        ClosedbRec()
                        dbRec.Open(SQL)
                        Rekap.SetDataSource(dbRec)
                        frmLaporan.CR.ReportSource = Rekap
                        frmLaporan.Show()
                        dbRec.Close()
                        Rekap = Nothing
                        frmLaporan = Nothing
                    Case "Lampiran"
                        Dim Lampiran As New Laporan

                        Lampiran.ResourceName = "Lampiran.rpt"
                        txtJudulLaporan = Lampiran.ReportDefinition.ReportObjects.Item("txtJudul")
                        txtDariTgl = Lampiran.ReportDefinition.ReportObjects.Item("txtDariTgl")
                        txtSampaiTgl = Lampiran.ReportDefinition.ReportObjects.Item("txtSampaiTgl")
                        txtJudulLaporan.Text = "LAMPIAN TEMUAN "
                        txtDariTgl.Text = DariTanggal.Value
                        txtSampaiTgl.Text = SampaiTanggal.Value

                        SQL = My.Computer.FileSystem.ReadAllText(ReportQueryPath & "Lampiran.SQL") & " WHERE TGLMEMO BETWEEN "
                        SQL &= "#" & DariTanggal.Value & "#"
                        SQL &= " AND "
                        SQL &= "#" & SampaiTanggal.Value & "#"
                        If cboIDDeputi.Text <> "" Then
                            SQL &= " AND DEPUTI.IDDEPUTI='" & cboIDDeputi.Text & "'"
                        End If
                        If chkStatus.Checked = True Then
                            If chkTuntas.Checked = True Then
                                txtJudulLaporan.Text &= "YANG SUDAH DITINDAK LANJUTI"
                                SQL &= " AND DIT.DITID IN (" & My.Computer.FileSystem.ReadAllText(ReportQueryPath & "StatusTuntas.SQL") & ")"
                            ElseIf chkTuntas.Checked = False Then
                                txtJudulLaporan.Text &= "YANG BELUM DITINDAK LANJUTI"
                                SQL &= " AND DIT.DITID IN (" & My.Computer.FileSystem.ReadAllText(ReportQueryPath & "StatusBlmTuntas.SQL") & ")"
                            End If
                        End If
                        If chkNilai.Checked = True Then
                            If chkNilaiTemuan.Checked = True Then
                                SQL &= " AND NILAITEMUAN=0 "
                            ElseIf chkNilaiTemuan.Checked = False Then
                                SQL &= " AND NILAITEMUAN<>0 "
                            End If
                        End If
                        ClosedbRec()
                        dbRec.Open(SQL)
                        If dbRec.BOF Then
                            MsgBox("Tidak ada data yang dapat ditampilkan", MsgBoxStyle.OkOnly, "Informasi")
                            Exit Sub
                        Else
                            Lampiran.SetDataSource(dbRec)
                            frmLaporan.CR.ReportSource = Lampiran
                            frmLaporan.Show()
                            dbRec.Close()
                            Lampiran = Nothing
                            frmLaporan = Nothing
                        End If
                End Select
            Case "satker"
                Dim RekapSatker As New Laporan
                RekapSatker.ResourceName = "RekapPerSatker.rpt"
                SQL = My.Computer.FileSystem.ReadAllText(ReportQueryPath & "RekapSatker.SQL")
                If cboDeputi.Text <> "" Then
                    SQL &= " WHERE IDDEPUTI='" & cboDeputi.Text & "' "
                    If cboSatker.Text <> "" Then
                        SQL &= "AND SATKER.IDSATKER='" & cboSatker.Text & "'"
                    End If
                End If
                ClosedbRec()
                dbRec.Open(SQL)
                If dbRec.BOF Then
                    MsgBox("Tidak ada data yang dapat di tampilkan", MsgBoxStyle.Information, "Informasi")
                    dbRec.Close()
                    Exit Sub
                End If
                RekapSatker.SetDataSource(dbRec)
                dbRec.Close()
                frmLaporan.CR.ReportSource = RekapSatker
                frmLaporan.Show()
                RekapSatker = Nothing
                frmLaporan = Nothing
        End Select
    End Sub

    Private Sub cboDeputi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDeputi.SelectedIndexChanged
        txtDeputi.Text = IsiTextDeputi(cboDeputi)
        IsiCboSatker()
    End Sub

    Private Sub cboSatker_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSatker.SelectedIndexChanged
        txtSatker.Text = IsiTextSatker(cboSatker)
    End Sub

    Private Sub cboIDReg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIDReg.SelectedIndexChanged
        txtReg.Text = IsiTextRegional(cboIDReg)
    End Sub
End Class