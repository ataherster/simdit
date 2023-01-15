Module dbAct

#Region "Deklarasi"
    Public dbConn As ADODB.Connection
    Public dbRec As ADODB.Recordset
    Public Server As String
    Public Chassier As String
    Public GetRecordCount As Double
    Dim Item As ListViewItem
    Dim i As Integer
    Dim warna As Integer
#End Region

#Region "Fungsi"

    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function

    Public Function OpenConnection(ByVal UserName As String, ByVal Password As String) As Boolean
        Try
            dbConn = New ADODB.Connection
            dbRec = New ADODB.Recordset
            dbConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.AppDomain.CurrentDomain.BaseDirectory & "\DIT.mdb;"
            dbConn.Open()
            dbRec.ActiveConnection = dbConn

            SQL = "SELECT * FROM USER1 WHERE USER='" & UserName & "' AND PASS='" & Password & "'"
            dbRec.Open(SQL)
            If dbRec.BOF Then
                dbRec.Close()
                Return False
                Exit Function
            End If
            dbRec.Close()

            Return True
        Catch ex As Exception
            Return False
            MsgBox(Err.Description, vbExclamation, "Error OpenConnection")
        End Try
    End Function

    Public Function TerminateConnection() As Boolean
        dbConn.Close()
    End Function

    Public Sub ClosedbRec()
        If dbRec.State Then
            dbRec.Close()
        End If
    End Sub
    Public Function ExecuteQuery(ByVal SQL As String) As Boolean
        Try
            dbConn.Execute(SQL)
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message, vbExclamation, "Error ExecuteQuery")
        End Try
    End Function

    Function ListViewHeader(ByRef ListView As System.Windows.Forms.ListView, ByRef SQL As String) As Boolean
        Dim i As Integer
        ListView.View = System.Windows.Forms.View.Details
        ListView.Columns.Clear()
        Try
            ClosedbRec()
            dbRec.Open(SQL)
            For i = 0 To dbRec.Fields.Count - 1
                ListView.Columns.Add(dbRec.Fields(i).Name)
            Next i
            dbRec.Close()
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error ListViewHeader")
        End Try
    End Function

    Public Function ExportToListView(ByVal ListView As ListView, ByVal SQL As String, ByVal Header As Boolean) As Byte
        ClosedbRec()
        Try
            warna = 0
            ListView.Items.Clear()
            dbRec.Open(SQL)

            If Header = True Then
                Dim i As Integer
                ListView.View = System.Windows.Forms.View.Details
                ListView.Columns.Clear()
                For i = 0 To dbRec.Fields.Count - 1
                    ListView.Columns.Add(dbRec.Fields(i).Name)
                Next i
            End If

            If dbRec.BOF Then
                dbRec.Close()
                Exit Function
            End If
            While Not dbRec.EOF
                For i = 0 To ListView.Columns.Count - 1
                    If i = 0 Then
                        Item = ListView.Items.Add(dbRec.Fields.Item(i).Value)
                    Else
                        If IsDBNull(dbRec.Fields(i).Value) = True Then
                            Item.SubItems.Add("")
                        Else
                            If dbRec.Fields(i).Type = ADODB.DataTypeEnum.adDate Then
                                Item.SubItems.Add(CDate(dbRec.Fields(i).Value).ToString("dd-MM-yyyy"))
                            Else
                                Item.SubItems.Add(dbRec.Fields(i).Value)
                            End If
                        End If
                    End If
                Next i
                GetRecordCount = dbRec.RecordCount
                warna += 1
                If warna Mod 2 = 0 Then
                    Item.BackColor = Color.AliceBlue
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

    Public Function IsiDataCombo(ByVal Cbo As ComboBox, ByVal SQL As String) As Boolean
        Cbo.Items.Clear()
        ClosedbRec()
        Try
            dbRec.Open(SQL)
            While Not dbRec.BOF
                Cbo.Items.Add(dbRec.Fields(0).Value)
                dbRec.MoveNext()
            End While
            dbRec.Close()
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error IsiCombo")
        End Try
    End Function

    Public Function IsiFieldCombo(ByVal cbo As ComboBox, ByVal SQL As String) As Boolean
        cbo.Items.Clear()
        ClosedbRec()
        Try
            dbRec.Open(SQL)
            For i As Integer = 0 To dbRec.Fields.Count - 1
                cbo.Items.Add(dbRec.Fields(i).Name)
            Next
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message, MsgBoxStyle.Information, "Error IsiFieldCombo")
        End Try
    End Function

    Public Function SimpanKeExcel(ByRef SQL As String, ByRef PATH As String) As Boolean
        On Error GoTo ErrorSaveToExcel
        Dim appExcel As Excel.Application
        Dim ExcelWB As Excel.Workbook
        Dim ExcelWS As Excel.Worksheet
        ClosedbRec()
        dbRec.Open(SQL, dbConn)

        appExcel = New Excel.Application
        ExcelWB = appExcel.Workbooks.Add
        ExcelWS = appExcel.Worksheets.Add

        Dim JumlahField As Short
        Dim ColField As Collection
        ColField = New Collection

        For JumlahField = 0 To dbRec.Fields.Count - 1
            ExcelWS.Cells(1, JumlahField + 1) = dbRec.Fields(JumlahField).Name
        Next JumlahField

        Dim Record As Integer
        Record = 2
        dbRec.MoveFirst()
        While Not dbRec.EOF
            For JumlahField = 0 To dbRec.Fields.Count - 1
                ExcelWS.Cells(Record, JumlahField + 1) = dbRec.Fields(JumlahField).Value
            Next JumlahField
            dbRec.MoveNext()
            Record = Record + 1
            System.Windows.Forms.Application.DoEvents()
        End While

        ExcelWB.SaveAs(PATH)
        ExcelWB.Saved = True
        If MsgBox("Data telah di export, lihat laporan ??", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "informasion") = MsgBoxResult.Yes Then
            appExcel.Visible = True
        Else
            appExcel.Quit()
        End If
        dbRec.Close()
        Return True
ErrorSaveToExcel:
        Return False
        appExcel.Quit()
        MsgBox("Gagal mengexport data", MsgBoxStyle.Information, "Informasi")
    End Function

    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long
    Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Long

#End Region

End Module
