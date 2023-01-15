Imports System.IO

Public Class frmDIT
    Dim Dir As DirectoryInfo
    Dim File As FileInfo
    Dim a As Byte = 0
    Dim warna As Integer
#Region "Deklarasi"
    Dim item As ListViewItem
    Dim i As Integer
    Dim NOL As String
    Dim DITStatus As String = "normal"
    Dim PaketStatus As String = "normal"
    Dim TemuanStatus As String = "normal"
    Dim RekTLStatus As String = "normal"
    Dim OIDRekTL As Double
#End Region

#Region "FormMethode"
    Public Function ExportToListViewDIT(ByVal ListView As ListView, ByVal SQL As String) As Byte
        If dbRec.State() Then
            dbRec.Close()
        End If
        Try
            warna = 0
            ListView.Items.Clear()
            dbRec.Open(SQL)
            If dbRec.BOF Then
                dbRec.Close()
                Exit Function
            End If
            While Not dbRec.EOF

                For i = 0 To ListView.Columns.Count - 1
                    If i = 0 Then
                        item = ListView.Items.Add(dbRec.Fields.Item(i).Value)
                    Else
                        If IsDBNull(dbRec.Fields(i).Value) = True Then
                            item.SubItems.Add("")
                        Else
                            If dbRec.Fields(i).Type = ADODB.DataTypeEnum.adDate Then
                                item.SubItems.Add(CDate(dbRec.Fields(i).Value).ToString("dd-MM-yyyy"))
                            Else
                                item.SubItems.Add(dbRec.Fields(i).Value)
                            End If
                        End If
                    End If
                Next i
                GetRecordCount = dbRec.RecordCount
                warna += 1
                If warna Mod 2 = 0 Then
                    item.BackColor = Color.AliceBlue
                End If
                If dbRec.Fields("JMLHREKOM").Value = dbRec.Fields("TUNTAS").Value Then
                    item.ForeColor = Color.Blue
                ElseIf dbRec.Fields("TUNTAS").Value = 0 Then
                    item.ForeColor = Color.Red
                ElseIf dbRec.Fields("TUNTAS").Value > 0 And dbRec.Fields("TUNTAS").Value < dbRec.Fields("JMLHREKOM").Value Then
                    item.ForeColor = Color.Green
                End If
                dbRec.MoveNext()
            End While
            dbRec.Close()
            Return 1
        Catch ex As Exception
            Return 0
            MsgBox(ex.Message, MsgBoxStyle.Information, "error ExportToListview")
        End Try
    End Function

    Sub AturTab()
        If txtDITID.Text = "" Then
            Tab.TabPages.Remove(TabPaketPekerjaan)
            Tab.TabPages.Remove(TabTemuan)
            Tab.TabPages.Remove(TabRekTL)
        Else
            If Tab.TabCount = 1 Then
                Tab.TabPages.Add(TabPaketPekerjaan)
                PaketCmdStatus(True)
                PaketEnabled(True)
            End If
            PaketPekerjaanFresh()
        End If
        If txtPPID.Text = "" Then
            Tab.TabPages.Remove(TabTemuan)
            Tab.TabPages.Remove(TabRekTL)
        Else
            If Tab.TabCount = 2 Then
                Tab.TabPages.Add(TabTemuan)
                TemuanCmdStatus(True)
                TemuanEnabled(True)
            End If
            TemuanFresh()
        End If
        If txtUTID.Text = "" Then
            Tab.TabPages.Remove(TabRekTL)
        Else
            If Tab.TabCount = 3 Then
                Tab.TabPages.Add(TabRekTL)
                RekTLCmdStatus(True)
                RekTLEnabled(True)
            End If
            RekTLFresh()
        End If
    End Sub

    Sub ExtraReportList()
        Dir = New DirectoryInfo(ExtraReportPath)
        lvExtraReport.Items.Clear()
        For Each File In Dir.GetFiles
            lvExtraReport.Items.Add(File.Name, 0)
        Next
    End Sub

    Function CekStatus() As Boolean
        If DITStatus <> "normal" Or PaketStatus <> "normal" Or TemuanStatus <> "normal" Or RekTLStatus <> "normal" Then
            Return False
            Exit Function
        End If
        Return True
    End Function

    Sub DITFresh()
        SQL = "SELECT * FROM QDIT"
        If Not txtCari.Text = "" Then
            SQL += " WHERE DITID IN (SELECT DITID FROM (SELECT * FROM (" & My.Computer.FileSystem.ReadAllText(Path & "\ReportQuery\Lampiran.SQL") & ") WHERE "
            If cboCari.Text = "All" Then
                For i As Integer = 0 To cboCari.Items.Count - 2
                    SQL += cboCari.Items.Item(i).ToString & " LIKE '%" & txtCari.Text & "%' "
                    If Not i = cboCari.Items.Count - 2 Then
                        SQL += " OR "
                    End If
                Next
            Else
                SQL += cboCari.Text & " LIKE '%" & txtCari.Text & "%'"
                SQL += "))"
            End If
        End If
        ExportToListViewDIT(lvDIT, SQL)
        Statistik()
    End Sub

    Sub PaketPekerjaanFresh()
        SQL = "SELECT PPID, NAMAPAKET, NOKONTRAK, TGLKONTRAK, ATASNAMA, NILAI, TA FROM PAKETPEKERJAAN WHERE DITID='" & txtDITID.Text & "'"
        ExportToListView(lvPaketPekerjaan, SQL, False)
    End Sub

    Sub TemuanFresh()
        SQL = "SELECT * FROM URAIANTEMUAN WHERE PPID=" & txtPPID.Text
        ExportToListView(lvUraianTemuan, SQL, False)
        Statistik()
    End Sub

    Sub RekTLFresh()
        SQL = "SELECT * FROM REKTL Where UTID =" & txtUTID.Text
        ExportToListView(lvRekTL, SQL, False)
        Statistik()
    End Sub

    Sub DITKosong()
        txtDITID.Text = ""
        txtNoMemo.Text = ""
        txtTglMemo.Text = ""
        txtNoLHP.Text = ""
        txtTglLHP.Text = ""
        txtIDDeputi.Text = ""
        txtNamaDeputi.Text = ""
        txtIDSatker.Text = ""
        txtNamaSatker.Text = ""
    End Sub

    Sub PaketKosong()
        txtPPID.Text = ""
        txtNamaPaket.Text = ""
        txtNoKontrak.Text = ""
        txtTglKontrak.Text = ""
        txtAtasNama.Text = ""
        txtNilai.Text = ""
        txtTA.Text = ""
    End Sub

    Sub TemuanKosong()
        txtUTID.Text = ""
        txtIDTemuan.Text = ""
        txtUraianTemuan.Text = ""
        txtGroupTemuan.Text = ""
        txtUraianGroupTemuan.Text = ""
        txtUraianTm.Text = ""
        txtNilaiTemuan.Text = ""
    End Sub

    Sub RekTLKosong()
        OIDRekTL = 0
        txtIDRekomendasi.Text = ""
        txtUraianRekomendasi.Text = ""
        txtGroupRekomendasi.Text = ""
        txtUraianGroupRekomendasi.Text = ""
        txtUraianRek.Text = ""
        txtNilaiRekomendasi.Text = ""

        txtIDTindakLanjut.Text = ""
        txtUraianTindakLanjut.Text = ""
        txtgroupTindakLanjut.Text = ""
        txtUraianGroupTindakLanjut.Text = ""
        txtUraianTL.Text = ""
        txtNilaiTindakLanjut.Text = ""
    End Sub

    Sub DITEnabled(ByVal sts As Boolean)
        txtNoMemo.ReadOnly = sts
        txtTglMemo.ReadOnly = sts
        txtNoLHP.ReadOnly = sts
        txtTglLHP.ReadOnly = sts
        txtIDDeputi.ReadOnly = sts
        txtNamaDeputi.ReadOnly = sts
        txtIDSatker.ReadOnly = sts
        txtNamaSatker.ReadOnly = sts
    End Sub

    Sub PaketEnabled(ByVal sts As Boolean)
        txtNamaPaket.ReadOnly = sts
        txtNoKontrak.ReadOnly = sts
        txtTglKontrak.ReadOnly = sts
        txtAtasNama.ReadOnly = sts
        txtNilai.ReadOnly = sts
        txtTA.ReadOnly = sts
    End Sub

    Sub TemuanEnabled(ByVal sts As Boolean)
        txtIDTemuan.ReadOnly = sts
        txtUraianTm.ReadOnly = sts
        txtNilaiTemuan.ReadOnly = sts
    End Sub

    Sub RekTLEnabled(ByVal sts As Boolean)
        txtIDRekomendasi.ReadOnly = sts
        txtUraianRek.ReadOnly = sts
        txtNilaiRekomendasi.ReadOnly = sts
        txtIDTindakLanjut.ReadOnly = sts
        txtUraianTL.ReadOnly = sts
        txtNilaiTindakLanjut.ReadOnly = sts
    End Sub

    Sub DITCmdStatus(ByVal sts As Boolean)
        cmdTambah.Enabled = sts
        cmdEdit.Enabled = sts
        cmdSimpan.Enabled = Not sts
        cmdHapus.Enabled = sts
        cmdBatal.Enabled = Not sts
    End Sub

    Sub PaketCmdStatus(ByVal sts As Boolean)
        cmdTambahPaket.Enabled = sts
        cmdEditPaket.Enabled = sts
        cmdSimpanPaket.Enabled = Not sts
        cmdHapusPaket.Enabled = sts
        cmdBatalPaket.Enabled = Not sts
    End Sub

    Sub TemuanCmdStatus(ByVal sts As Boolean)
        cmdTambahTemuan.Enabled = sts
        cmdEditTemuan.Enabled = sts
        cmdSimpanTemuan.Enabled = Not sts
        cmdHapusTemuan.Enabled = sts
        cmdBatalTemuan.Enabled = Not sts
    End Sub

    Sub RekTLCmdStatus(ByVal sts As Boolean)
        cmdTambahRekTL.Enabled = sts
        cmdEditRekTL.Enabled = sts
        cmdSimpanRekTL.Enabled = Not sts
        cmdHapusRekTL.Enabled = sts
        cmdBatalRekTL.Enabled = Not sts
    End Sub

    Sub TAMPILDIT(ByVal sts As String)
        If sts <> "normal" Then Exit Sub
        txtDITID.Text = lvDIT.FocusedItem.Text
        txtNoMemo.Text = lvDIT.FocusedItem.SubItems(1).Text
        txtTglMemo.Text = lvDIT.FocusedItem.SubItems(2).Text
        txtNoLHP.Text = lvDIT.FocusedItem.SubItems(3).Text
        txtTglLHP.Text = lvDIT.FocusedItem.SubItems(4).Text
        txtIDSatker.Text = lvDIT.FocusedItem.SubItems(5).Text
        CariSatker()
        txtKasatker.Text = lvDIT.FocusedItem.SubItems(6).Text
        txtPPK.Text = lvDIT.FocusedItem.SubItems(7).Text
        AturTab()
    End Sub

    Sub TampilPaketPekerjaan(ByVal sts As String)
        If sts <> "normal" Then Exit Sub
        txtPPID.Text = lvPaketPekerjaan.FocusedItem.Text
        txtNamaPaket.Text = lvPaketPekerjaan.FocusedItem.SubItems(1).Text
        txtNoKontrak.Text = lvPaketPekerjaan.FocusedItem.SubItems(2).Text
        If Not lvPaketPekerjaan.FocusedItem.SubItems(3).Text = "" Then
            txtTglKontrak.Text = lvPaketPekerjaan.FocusedItem.SubItems(3).Text
        End If
        txtAtasNama.Text = lvPaketPekerjaan.FocusedItem.SubItems(4).Text
        txtNilai.Text = CDbl(lvPaketPekerjaan.FocusedItem.SubItems(5).Text)
        txtTA.Text = lvPaketPekerjaan.FocusedItem.SubItems(6).Text
    End Sub

    Sub TampilTemuan(ByVal sts As String)
        If sts <> "normal" Then Exit Sub
        txtUTID.Text = lvUraianTemuan.FocusedItem.Text
        txtIDTemuan.Text = lvUraianTemuan.FocusedItem.SubItems(2).Text
        txtUraianTm.Text = lvUraianTemuan.FocusedItem.SubItems(3).Text
        txtNilaiTemuan.Text = CDbl(lvUraianTemuan.FocusedItem.SubItems(4).Text)
        CariIDTemuan()
    End Sub

    Sub TampilRekTL(ByVal sts As String)
        If sts <> "normal" Then Exit Sub
        OIDRekTL = lvRekTL.FocusedItem.Text
        txtIDRekomendasi.Text = lvRekTL.FocusedItem.SubItems(2).Text
        CariIDRekom()
        txtUraianRek.Text = lvRekTL.FocusedItem.SubItems(3).Text
        txtNilaiRekomendasi.Text = CDbl(lvRekTL.FocusedItem.SubItems(4).Text)
        cboStatus.Text = lvRekTL.FocusedItem.SubItems(5).Text
        If Not lvRekTL.FocusedItem.SubItems(6).Text = "" Then
            txtIDTindakLanjut.Text = lvRekTL.FocusedItem.SubItems(6).Text
            CariIDTindakLanjut()
            txtUraianTL.Text = lvRekTL.FocusedItem.SubItems(7).Text
            txtNilaiTindakLanjut.Text = CDbl(lvRekTL.FocusedItem.SubItems(8).Text)
        Else
            txtIDTindakLanjut.Text = ""
            txtUraianTL.Text = ""
            txtNilaiTindakLanjut.Text = ""
        End If
    End Sub

    Sub CariSatker()
        SQL = "SELECT NAMASATKER, IDDEPUTI, NAMADEPUTI FROM QSATKER WHERE IDSATKER='" & txtIDSatker.Text & "'"
        If dbRec.State Then
            dbRec.Close()
        End If
        dbRec.Open(SQL)
        If dbRec.BOF Then
            If MsgBox("SATKER dengan ID = " & txtIDSatker.Text & ", tidak ditemukan, anda ingin menambah Data SATKER ?" _
            , MsgBoxStyle.Question + vbYesNo, "Question") = MsgBoxResult.Yes Then
                dbRec.Close()
                frmSatker.Show()
            Else
                dbRec.Close()
            End If
        Else
            txtNamaSatker.Text = dbRec.Fields("NAMASATKER").Value
            txtIDDeputi.Text = dbRec.Fields("IDDEPUTI").Value
            txtNamaDeputi.Text = dbRec.Fields("NAMADEPUTI").Value
            dbRec.Close()
        End If
    End Sub

    Sub CariIDTemuan()
        SQL = "SELECT * FROM QTEMUAN WHERE IDTEMUAN='" & txtIDTemuan.Text & "'"
        ClosedbRec()
        dbRec.Open(SQL)
        If dbRec.BOF Then
            dbRec.Close()
            If MsgBox("Kode Temuan " & txtIDTemuan.Text & " tidak ditemukan, klick Yes untuk Entry Temuan", vbQuestion + vbYesNo, "Informasi") = vbYes Then
                frmTemuan.Show()
            End If
            Exit Sub
        End If
        txtUraianTemuan.Text = dbRec.Fields("UraianTemuan").Value
        txtGroupTemuan.Text = dbRec.Fields("IDGroup").Value
        txtUraianGroupTemuan.Text = dbRec.Fields("UraianGroup").Value
        txtUraianTm.Focus()
        dbRec.Close()
    End Sub

    Sub CariIDRekom()
        SQL = "SELECT * FROM QREKOMENDASI WHERE IDREKOMENDASI='" & txtIDRekomendasi.Text & "'"
        ClosedbRec()
        dbRec.Open(SQL)
        If dbRec.BOF Then
            dbRec.Close()
            If MsgBox("Kode Rekomendasi " & txtIDRekomendasi.Text & " tidak ditemukan, klick Yes untuk Entry Temuan", vbQuestion + vbYesNo, "Informasi") = vbYes Then
                frmRekomendasi.Show()
            End If
            Exit Sub
        End If
        txtUraianRekomendasi.Text = dbRec.Fields("UraianRekomendasi").Value
        txtGroupRekomendasi.Text = dbRec.Fields("IDGroup").Value
        txtUraianGroupRekomendasi.Text = dbRec.Fields("UraianGroup").Value
        dbRec.Close()
    End Sub

    Sub CariIDTindakLanjut()
        SQL = "SELECT * FROM QTINDAKLANJUT WHERE IDTINDAKLANJUT='" & txtIDTindakLanjut.Text & "'"
        ClosedbRec()
        dbRec.Open(SQL)
        If dbRec.BOF Then
            dbRec.Close()
            If MsgBox("Kode Tindak Lanjut " & txtIDTindakLanjut.Text & " tidak ditemukan, klick Yes untuk Entry Temuan", vbQuestion + vbYesNo, "Informasi") = vbYes Then
                frmRekomendasi.Show()
            End If
            Exit Sub
        End If
        txtUraianTindakLanjut.Text = dbRec.Fields("UraianTindakLanjut").Value
        txtgroupTindakLanjut.Text = dbRec.Fields("IDGroup").Value
        txtUraianGroupTindakLanjut.Text = dbRec.Fields("UraianGroup").Value
        dbRec.Close()
    End Sub

    Function Temuan() As Double
        Try
            SQL = "SELECT SUM(NILAITEMUAN) AS NTEMUAN FROM URAIANTEMUAN"
            ClosedbRec()
            dbRec.Open(SQL)
            Return dbRec.Fields("NTEMUAN").Value
            dbRec.Close()
        Catch ex As Exception
            dbRec.Close()
            Return 0
        End Try
    End Function

    Function TL() As Double
        Try
            SQL = "SELECT SUM(NILAITINDAKLANJUT) AS NTL FROM REKTL"
            ClosedbRec()
            dbRec.Open(SQL)
            Return dbRec.Fields("NTL").Value
            dbRec.Close()
        Catch ex As Exception
            dbRec.Close()
            Return 0
        End Try
    End Function

    Sub Statistik()
        lblTemuan.Text = Temuan().ToString("0,0.00")
        lblTL.Text = TL().ToString("0,0.00")
        lblSaldo.Text = (lblTemuan.Text - lblTL.Text).ToString("0,0.00")
    End Sub

    Sub IsiCboCari()
        SQL = My.Computer.FileSystem.ReadAllText(Path & "\ReportQuery\Lampiran.SQL") & " WHERE DIT.DITID=''"
        IsiFieldCombo(cboCari, SQL)
        cboCari.Items.Add("All")
    End Sub
#End Region

#Region "DatabaseMethode"
    Function SimpanDIT() As Boolean
        If DITStatus = "tambah" Then
            SQL = "INSERT INTO DIT VALUES ('" & txtDITID.Text & "','" & txtNoMemo.Text _
            & "','" & Date.Parse(txtTglMemo.Text, New Globalization.CultureInfo("ID-id")) & "','" & txtNoLHP.Text & "','" & Date.Parse(txtTglLHP.Text, New Globalization.CultureInfo("ID-id")) _
            & "','" & txtIDSatker.Text & "', '" & txtKasatker.Text & "', '" & txtPPK.Text & "')"
        ElseIf DITStatus = "edit" Then
            SQL = "UPDATE DIT SET NOMEMO='" & txtNoMemo.Text & "', TGLMEMO='" & Date.Parse(txtTglMemo.Text, New Globalization.CultureInfo("ID-id")) _
            & "', NOLHP='" & txtNoLHP.Text & "', "
            SQL = SQL & "TGLLHP='" & Date.Parse(txtTglLHP.Text, New Globalization.CultureInfo("ID-id")) & "', IDSATKER='" & txtIDSatker.Text & "', KASATKER='" & txtKasatker.Text & "', PPK='" & txtPPK.Text & "' WHERE DITID='" & txtDITID.Text & "'"
        End If
        If ExecuteQuery(SQL) = False Then
            Return False
            Exit Function
        End If
        Return True
    End Function

    Function SimpanPaket() As Boolean
        If PaketStatus = "tambah" Then
            txtPPID.Text = MaxPPID()
            SQL = "INSERT INTO PAKETPEKERJAAN VALUES (" & txtPPID.Text & ",'" & txtDITID.Text & "','" _
                    & txtNamaPaket.Text & "','" & txtNoKontrak.Text & "',"
            If Len(txtTglKontrak.Text) = 10 Then
                SQL = SQL & "'" & Date.Parse(txtTglKontrak.Text, New Globalization.CultureInfo("ID-id")) & "',"
            ElseIf Len(txtTglKontrak.Text) < 2 Then
                SQL = SQL & "NULL,"
            End If
            SQL = SQL & "'" & txtAtasNama.Text & "'," & txtNilai.Text & ",'" & txtTA.Text & "')"
        ElseIf PaketStatus = "edit" Then
            SQL = "UPDATE PAKETPEKERJAAN SET NAMAPAKET='" & txtNamaPaket.Text & "', NOKONTRAK='" & txtNoKontrak.Text & "', "
            If Len(txtTglKontrak.Text) = 10 Then
                SQL = SQL & "TGLKONTRAK='" & Date.Parse(txtTglKontrak.Text, New Globalization.CultureInfo("ID-id")) & "', "
            ElseIf Len(txtTglKontrak.Text) <= 2 Then
                SQL = SQL & "TGLKONTRAK=NULL, "
            End If
            SQL = SQL & "ATASNAMA='" & txtAtasNama.Text _
            & "', NILAI=" & txtNilai.Text & ", TA='" & txtTA.Text & "' WHERE PPID=" & txtPPID.Text
        End If
        If ExecuteQuery(SQL) = False Then
            Return False
            Exit Function
        End If
        Return True
    End Function

    Function SimpanTemuan() As Boolean
        If TemuanStatus = "tambah" Then
            txtUTID.Text = MaxUTID()
            SQL = "INSERT INTO URAIANTEMUAN VALUES (" & txtUTID.Text & "," & txtPPID.Text & ",'" _
            & txtIDTemuan.Text & "','" & txtUraianTm.Text & "'," & txtNilaiTemuan.Text & ")"
        ElseIf TemuanStatus = "edit" Then
            SQL = "UPDATE URAIANTEMUAN SET IDTEMUAN='" & txtIDTemuan.Text & "', URAIANTEMUAN='" _
            & txtUraianTm.Text & "', NILAITEMUAN=" & txtNilaiTemuan.Text & " WHERE UTID=" _
            & txtUTID.Text
        End If
        If ExecuteQuery(SQL) = False Then
            Return False
        End If
        Return True
    End Function

    Function SimpanRekTL() As Boolean
        If RekTLStatus = "tambah" Then
            If Not txtIDTindakLanjut.Text = "" Then
                SQL = "INSERT INTO REKTL (UTID, IDREKOMENDASI, URAIANREKOMENDASI, NILAIREKOMENDASI, IDSTATUS, IDTINDAKLANJUT, URAIANTINDAKLANJUT, NILAITINDAKLANJUT) VALUES ('" & txtUTID.Text & "','" & txtIDRekomendasi.Text & "','" _
                & txtUraianRek.Text & "'," & txtNilaiRekomendasi.Text & ", '" & cboStatus.Text & "','" _
                & txtIDTindakLanjut.Text & "','" & txtUraianTL.Text & "'," & txtNilaiTindakLanjut.Text & ")"
            Else
                SQL = "INSERT INTO REKTL(UTID, IDREKOMENDASI, URAIANREKOMENDASI, NILAIREKOMENDASI, IDSTATUS) VALUES ('" & txtUTID.Text & "','" & txtIDRekomendasi.Text & "','" _
                & txtUraianRek.Text & "'," & txtNilaiRekomendasi.Text & ", '" & cboStatus.Text & "')"
            End If
        ElseIf RekTLStatus = "edit" Then
            If Not txtIDTindakLanjut.Text = "" Then
                SQL = "UPDATE REKTL SET IDREKOMENDASI='" & txtIDRekomendasi.Text & "', URAIANREKOMENDASI='" & txtUraianRek.Text & "', NILAIREKOMENDASI=" & txtNilaiRekomendasi.Text & ", IDSTATUS='" & cboStatus.Text & "', IDTINDAKLANJUT='" & txtIDTindakLanjut.Text & "', URAIANTINDAKLANJUT='" & txtUraianTL.Text & "', NILAITINDAKLANJUT=" & txtNilaiTindakLanjut.Text _
                & " WHERE OID=" & OIDRekTL
            Else
                SQL = "UPDATE REKTL SET IDREKOMENDASI='" & txtIDRekomendasi.Text & "', URAIANREKOMENDASI='" & txtUraianRek.Text & "', NILAIREKOMENDASI=" & txtNilaiRekomendasi.Text & ", IDSTATUS='" & cboStatus.Text & "', IDTINDAKLANJUT=NULL, URAIANTINDAKLANJUT=NULL, NILAITINDAKLANJUT=NULL " _
                & " WHERE OID=" & OIDRekTL
            End If
        End If
        If ExecuteQuery(SQL) = False Then
            Return False
            Exit Function
        End If
        Return True
    End Function

    Function HapusDIT() As Boolean
        SQL = "DELETE FROM DIT WHERE DITID='" & txtDITID.Text & "'"
        If ExecuteQuery(SQL) = False Then
            Return False
            Exit Function
        End If
        DITFresh()
        Return True
    End Function

    Function HapusPaket() As Boolean
        SQL = "DELETE FROM PAKETPEKERJAAN WHERE PPID=" & txtPPID.Text
        If ExecuteQuery(SQL) = False Then
            Return False
            Exit Function
        End If
        PaketPekerjaanFresh()
        Return True
    End Function

    Function HapusTemuan() As Boolean
        SQL = "DELETE FROM URAIANTEMUAN WHERE UTID=" & txtUTID.Text
        If ExecuteQuery(SQL) = False Then
            Return False
            Exit Function
        End If
        TemuanFresh()
        Return True
    End Function

    Function HapusRekTL() As Boolean
        SQL = "DELETE FROM REKTL WHERE OID=" & OIDRekTL
        If ExecuteQuery(SQL) = False Then
            Return False
            Exit Function
        End If
        RekTLFresh()
        Return True
    End Function

    Function MaxDITID() As String
        dbRec.Open("SELECT MAX(LEFT(DITID,4))+1 AS DITID FROM DIT", dbConn)
        For i = 1 To 4 - Len(dbRec.Fields(0).Value.ToString)
            NOL += "0"
        Next i
        MaxDITID = NOL & dbRec.Fields(0).Value & "/DIT/" & Year(Now)
        dbRec.Close()
    End Function

    Function MaxPPID() As Double
        SQL = "SELECT * FROM QPPID"
        dbRec.Open(SQL)
        If IsDBNull(dbRec.Fields("NO").Value) = True Then
            Return 1
            dbRec.Close()
            Exit Function
        End If
        Return dbRec.Fields("NO").Value
        dbRec.Close()
    End Function

    Function MaxUTID() As Double
        SQL = "SELECT * FROM QUTID"
        dbRec.Open(SQL)
        If IsDBNull(dbRec.Fields("NO").Value) = True Then
            Return 1
            dbRec.Close()
            Exit Function
        End If
        Return dbRec.Fields("NO").Value
        dbRec.Close()
    End Function

#End Region

#Region "Event"
    Private Sub frmDIT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If a = 0 Then
            DITFresh()
            AturTab()
            DITCmdStatus(True)
            DITEnabled(True)
            logo.Image = My.Resources.brr_logo
            IsiCboCari()
            a += 1
        End If
        StatusUserName.Text = "User Active : " & UserName
        ExtraReportList()
    End Sub

    Private Sub lvDIT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvDIT.SelectedIndexChanged
        TAMPILDIT(DITStatus)
        PaketKosong()
        AturTab()
    End Sub

    Private Sub lvPaketPekerjaan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvPaketPekerjaan.SelectedIndexChanged
        TampilPaketPekerjaan(PaketStatus)
        TemuanKosong()
        AturTab()
    End Sub

    Private Sub lvUraianTemuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvUraianTemuan.SelectedIndexChanged
        TampilTemuan(TemuanStatus)
        RekTLKosong()
        AturTab()
    End Sub

    Private Sub lvRekTL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRekTL.SelectedIndexChanged
        TampilRekTL(RekTLStatus)
    End Sub

    Private Sub cmdCariSatker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCariSatker.Click
        CariSatker()
    End Sub

    Private Sub cmdTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTambah.Click
        DITStatus = "tambah"
        DITKosong()
        DITEnabled(False)
        DITCmdStatus(False)
        AturTab()
        txtDITID.Text = MaxDITID()
    End Sub

    Private Sub cmdTambahPaket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTambahPaket.Click
        PaketStatus = "tambah"
        PaketKosong()
        PaketEnabled(False)
        PaketCmdStatus(False)
        AturTab()
    End Sub

    Private Sub cmdTambahTemuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTambahTemuan.Click
        TemuanStatus = "tambah"
        TemuanKosong()
        TemuanEnabled(False)
        TemuanCmdStatus(False)
        AturTab()
    End Sub

    Private Sub cmdTambahRekTL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTambahRekTL.Click
        RekTLStatus = "tambah"
        RekTLKosong()
        RekTLEnabled(False)
        RekTLCmdStatus(False)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtDITID.Text = "" Then
            MsgBox("Silahkan pilih data dahulu!", MsgBoxStyle.Information, "Informasi")
            Exit Sub
        End If
        DITStatus = "edit"
        DITEnabled(False)
        DITCmdStatus(False)
        AturTab()
    End Sub

    Private Sub cmdEditPaket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditPaket.Click
        If txtPPID.Text = "" Then
            MsgBox("Silahkan pilih data dahulu!", MsgBoxStyle.Information, "Informasi")
            Exit Sub
        End If
        PaketStatus = "edit"
        PaketEnabled(False)
        PaketCmdStatus(False)
        AturTab()
    End Sub

    Private Sub cmdEditTemuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditTemuan.Click
        If txtUTID.Text = "" Then
            MsgBox("Silahkan pilih data dahulu!", MsgBoxStyle.Information, "Informasi")
            Exit Sub
        End If
        TemuanStatus = "edit"
        TemuanEnabled(False)
        TemuanCmdStatus(False)
        AturTab()
    End Sub

    Private Sub cmdEditRekTL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditRekTL.Click
        If OIDRekTL = 0 Then
            MsgBox("Silahkan pilih data dahulu!", MsgBoxStyle.Information, "Informasi")
            Exit Sub
        End If
        RekTLStatus = "edit"
        RekTLEnabled(False)
        RekTLCmdStatus(False)
        AturTab()
    End Sub

    Private Sub cmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBatal.Click
        DITStatus = "normal"
        DITKosong()
        DITEnabled(True)
        DITCmdStatus(True)
        AturTab()
    End Sub

    Private Sub cmdBatalPaket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBatalPaket.Click
        PaketStatus = "normal"
        PaketKosong()
        PaketEnabled(True)
        PaketCmdStatus(True)
        AturTab()
    End Sub

    Private Sub cmdBatalTemuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBatalTemuan.Click
        TemuanStatus = "normal"
        TemuanKosong()
        TemuanEnabled(True)
        TemuanCmdStatus(True)
        AturTab()
    End Sub
    Private Sub cmdBatalRekTL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBatalRekTL.Click
        RekTLStatus = "normal"
        RekTLKosong()
        RekTLEnabled(True)
        RekTLCmdStatus(True)
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If SimpanDIT() = False Then Exit Sub
        AturTab()
        If DITStatus = "tambah" Then
            Tab.SelectTab(1)
        End If
        DITStatus = "normal"
        DITEnabled(True)
        DITCmdStatus(True)
        DITFresh()
    End Sub

    Private Sub cmdSimpanPaket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpanPaket.Click
        If SimpanPaket() = False Then Exit Sub
        AturTab()
        If PaketStatus = "tambah" Then
            Tab.SelectTab(2)
        End If
        PaketStatus = "normal"
        PaketEnabled(True)
        PaketCmdStatus(True)
    End Sub

    Private Sub cmdSimpanTemuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpanTemuan.Click
        If SimpanTemuan() = False Then Exit Sub
        AturTab()
        If TemuanStatus = "tambah" Then
            Tab.SelectTab(3)
        End If
        TemuanStatus = "normal"
        TemuanEnabled(True)
        TemuanCmdStatus(True)
    End Sub

    Private Sub cmdSimpanRekTL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpanRekTL.Click
        If SimpanRekTL() = False Then Exit Sub
        AturTab()
        RekTLStatus = "normal"
        RekTLEnabled(True)
        RekTLCmdStatus(True)
    End Sub

    Private Sub cmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapus.Click
        If txtDITID.Text = "" Then Exit Sub
        If MsgBox("Data akan dihapus ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Konfirmasi") = MsgBoxResult.Yes Then
            If HapusDIT() = False Then Exit Sub
            AturTab()
        End If
    End Sub

    Private Sub cmdHapusPaket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapusPaket.Click
        If txtPPID.Text = "" Then Exit Sub
        If MsgBox("Data akan dihapus ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Konfirmasi") = MsgBoxResult.Yes Then
            If HapusPaket() = False Then Exit Sub
            AturTab()
        End If
    End Sub

    Private Sub cmdHapusTemuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapusTemuan.Click
        If txtUTID.Text = "" Then Exit Sub
        If MsgBox("Data akan dihapus ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Konfirmasi") = MsgBoxResult.Yes Then
            If HapusTemuan() = False Then Exit Sub
            AturTab()
        End If
    End Sub

    Private Sub cmdHapusRekTL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapusRekTL.Click
        If OIDRekTL = 0 Then Exit Sub
        If MsgBox("Data akan dihapus ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Konfirmasi") = MsgBoxResult.Yes Then
            If HapusRekTL() = False Then Exit Sub
            AturTab()
        End If
    End Sub

#End Region

    Private Sub PrintPreviewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripButton.Click
        If lvDIT.Focus = False Then Exit Sub
        Dim Lampiran As New Laporan
        Dim frmLaporan As New frmLaporan

        Lampiran.ResourceName = "Lampiran.rpt"
        SQL = My.Computer.FileSystem.ReadAllText(ReportQueryPath & "Lampiran.SQL") & " WHERE DIT.DITID='" & lvDIT.FocusedItem.Text & "'"

        ClosedbRec()
        dbRec.Open(SQL)
        If dbRec.BOF Then
            MsgBox("Tidak ada data yang bisa ditampilkan", MsgBoxStyle.OkOnly, "Informasi")
        Else
            Lampiran.SetDataSource(dbRec)
            frmLaporan.CR.ReportSource = Lampiran
            frmLaporan.Show()
        End If
        Lampiran = Nothing
        frmLaporan = Nothing
        dbRec.Close()
    End Sub


    Private Sub Jam_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Jam.Tick
        lblTanggal.Text = Now.ToString("dd-MM-yyyy")
        lblJam.Text = Now.ToString("hh:mm:ss")
    End Sub

    Private Sub ToolDeputi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolDeputi.Click
        frmDeputi.Show()
    End Sub

    Private Sub ToolSatker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolSatker.Click
        frmSatker.Show()
    End Sub

    Private Sub ToolTemuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolTemuan.Click
        frmTemuan.Show()
    End Sub

    Private Sub ToolTL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolTL.Click
        frmTindakLanjut.Show()
    End Sub

    Private Sub ToolRekomendasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolRekomendasi.Click
        frmRekomendasi.Show()
    End Sub

    Private Sub QueryBrowserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryBrowserToolStripMenuItem.Click
        Dim QueryBrowser As New QueryBrowser
        QueryBrowser.Show()
    End Sub

    Private Sub PerDeputiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerDeputiToolStripMenuItem.Click
        KriteriaLaporan.Show()
    End Sub

    Private Sub DeputiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeputiToolStripMenuItem1.Click
        Dim Deputi As New Laporan
        Dim frmLaporan As New frmLaporan

        Deputi.ResourceName = "Deputi.rpt"

        SQL = "SELECT * FROM DEPUTI"
        ClosedbRec()
        dbRec.Open(SQL)
        If dbRec.BOF Then
            MsgBox("Tidak ada data yang bisa ditampilkan", MsgBoxStyle.OkOnly, "Informasi")
        Else
            Deputi.SetDataSource(dbRec)
            frmLaporan.CR.ReportSource = Deputi
            frmLaporan.Show()
        End If
        Deputi = Nothing
        frmLaporan = Nothing
        dbRec.Close()
    End Sub

    Private Sub SatkerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SatkerToolStripMenuItem1.Click
        Dim Satker As New Laporan
        Dim frmLaporan As New frmLaporan

        Satker.ResourceName = "Satker.rpt"
        SQL = "SELECT * FROM SATKER INNER JOIN DEPUTI ON SATKER.IDDEPUTI=DEPUTI.IDDEPUTI"
        ClosedbRec()
        dbRec.Open(SQL)
        If dbRec.BOF Then
            MsgBox("Tidak ada data yang bisa ditampilkan", MsgBoxStyle.OkOnly, "Informasi")
        Else
            Satker.SetDataSource(dbRec)
            frmLaporan.CR.ReportSource = Satker
            frmLaporan.Show()
        End If
        Satker = Nothing
        frmLaporan = Nothing
        dbRec.Close()
    End Sub

    Private Sub JenisTemuanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JenisTemuanToolStripMenuItem.Click
        Dim JnsTemuan As New Laporan
        Dim frmLaporan As New frmLaporan

        JnsTemuan.ResourceName = "JenisTemuan.rpt"
        SQL = "SELECT * FROM TEMUAN INNER JOIN GROUPTEMUAN ON TEMUAN.IDGROUP=GROUPTEMUAN.IDGROUP"
        ClosedbRec()
        dbRec.Open(SQL)
        If dbRec.BOF Then
            MsgBox("Tidak ada data yang bisa ditampilkan", MsgBoxStyle.OkOnly, "Informasi")
        Else
            JnsTemuan.SetDataSource(dbRec)
            frmLaporan.CR.ReportSource = JnsTemuan
            frmLaporan.Show()
        End If
        JnsTemuan = Nothing
        frmLaporan = Nothing
        dbRec.Close()
    End Sub

    Private Sub JenisRekomendasiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JenisRekomendasiToolStripMenuItem.Click
        Dim JnsRekomendasi As New Laporan
        Dim frmLaporan As New frmLaporan

        JnsRekomendasi.ResourceName = "JenisRekomendasi.rpt"
        SQL = "SELECT * FROM REKOMENDASI INNER JOIN GROUPREKOMENDASI ON REKOMENDASI.IDGROUP=GROUPREKOMENDASI.IDGROUP"
        ClosedbRec()
        dbRec.Open(SQL)
        If dbRec.BOF Then
            MsgBox("Tidak ada data yang bisa ditampilkan", MsgBoxStyle.OkOnly, "Informasi")
        Else
            JnsRekomendasi.SetDataSource(dbRec)
            frmLaporan.CR.ReportSource = JnsRekomendasi
            frmLaporan.Show()
        End If
        JnsRekomendasi = Nothing
        frmLaporan = Nothing
        dbRec.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub JenisTindakLanjutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JenisTindakLanjutToolStripMenuItem.Click
        Dim JnsTindakLanjut As New Laporan
        Dim frmLaporan As New frmLaporan

        JnsTindakLanjut.ResourceName = "JenisTL.rpt"
        SQL = "SELECT * FROM tindaklanjut INNER JOIN GROUPTINDAKLANJUT ON TINDAKLANJUT.IDGROUP=GROUPTINDAKLANJUT.IDGROUP"
        ClosedbRec()
        dbRec.Open(SQL)
        If dbRec.BOF Then
            MsgBox("Tidak ada data yang bisa ditampilkan", MsgBoxStyle.OkOnly, "Informasi")
        Else
            JnsTindakLanjut.SetDataSource(dbRec)
            frmLaporan.CR.ReportSource = JnsTindakLanjut
            frmLaporan.Show()
        End If
        JnsTindakLanjut = Nothing
        frmLaporan = Nothing
        dbRec.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCari.Click
        DITFresh()
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        Me.AcceptButton = cmdCari
    End Sub

    Private Sub txtIDSatker_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDSatker.TextChanged
        Me.AcceptButton = cmdCariSatker
    End Sub

    Private Sub AdministrasiUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrasiUserToolStripMenuItem.Click
        frmUser.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmChangePassword.Show()
    End Sub

    Private Sub cmdCariRekomendasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCariRekomendasi.Click
        CariIDRekom()
    End Sub

    Private Sub cmdCariTindakLanjut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCariTindakLanjut.Click
        CariIDTindakLanjut()
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatus.SelectedIndexChanged
        SQL = "SELECT STATUS FROM STATUSTL WHERE IDSTATUS='" & cboStatus.Text & "'"
        ClosedbRec()
        dbRec.Open(SQL)
        txtStatusTL.Text = dbRec.Fields("STATUS").Value
        dbRec.Close()
    End Sub

    Private Sub lvExtraReport_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvExtraReport.DoubleClick
        Dim Lampiran As New Laporan
        Dim frmLaporan As New frmLaporan

        Lampiran.ResourceName = "Lampiran.rpt"

        SQL = My.Computer.FileSystem.ReadAllText(ExtraReportPath & lvExtraReport.FocusedItem.Text)
        ClosedbRec()
        dbRec.Open(SQL)
        If dbRec.BOF Then
            MsgBox("Tidak ada data yang bisa ditampilkan", MsgBoxStyle.OkOnly, "Informasi")
        Else
            Lampiran.SetDataSource(dbRec)
            frmLaporan.CR.ReportSource = Lampiran
            frmLaporan.Show()
        End If
        Lampiran = Nothing
        frmLaporan = Nothing
        dbRec.Close()
    End Sub

    Private Sub BackupDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupDataToolStripMenuItem.Click
        If FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.CopyFile(Path & "\DIT.mdb", FolderBrowserDialog.SelectedPath & "\" & Date.Today.ToString("dd-MM-yyyy"), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
        End If
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            If MsgBox("Anda yakin akan merestore data ?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Konfirmasi") = MsgBoxResult.Yes Then
                If MsgBox("Data akan direstore ...", MsgBoxStyle.OkCancel + MsgBoxStyle.DefaultButton2, "Restore Data") = MsgBoxResult.Ok Then
                    TerminateConnection()
                    My.Computer.FileSystem.CopyFile(OpenFileDialog.FileName, Path & "\DIT.mdb", True)
                    OpenConnection(UserName, Password)
                End If
            End If
        End If
    End Sub

    Private Sub ReconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconnectToolStripMenuItem.Click
        TerminateConnection()
        OpenConnection(UserName, Password)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

End Class