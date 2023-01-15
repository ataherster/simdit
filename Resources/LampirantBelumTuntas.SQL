SELECT DIT.DITID, Deputi.IDDeputi, Deputi.NamaDeputi, SATKER.IDSatker, SATKER.NamaSatker, SATKER.Kasatker, SATKER.PPK, DIT.NoMemo, DIT.TglMemo, DIT.NoLHP, DIT.TglLHP, DIT.Kasatker, DIT.PPK, PaketPekerjaan.NamaPaket, PaketPekerjaan.NoKontrak, PaketPekerjaan.TglKontrak, PaketPekerjaan.AtasNama, PaketPekerjaan.Nilai, PaketPekerjaan.TA, UraianTemuan.IDTemuan, UraianTemuan.UraianTemuan, UraianTemuan.NilaiTemuan, REKTL.IDRekomendasi, REKTL.UraianRekomendasi, REKTL.NilaiRekomendasi, REKTL.IDStatus, StatusTL.Status, REKTL.IDTindakLanjut, REKTL.UraianTindakLanjut, REKTL.NilaiTindakLanjut
FROM StatusTL RIGHT JOIN (((((Deputi INNER JOIN SATKER ON Deputi.IDDeputi = SATKER.IDDeputi) INNER JOIN DIT ON SATKER.IDSatker = DIT.IDSatker) INNER JOIN PaketPekerjaan ON DIT.DITID = PaketPekerjaan.DITID) LEFT JOIN UraianTemuan ON PaketPekerjaan.PPID = UraianTemuan.PPID) LEFT JOIN REKTL ON UraianTemuan.UTID = REKTL.UTID) ON StatusTL.IDStatus = REKTL.IDStatus
WHERE DIT.DITID IN 
(SELECT DITID FROM (SELECT JMLHDIT.DITID, JMLHREKOM, IIF(ISNULL(JMLHTL),0,JMLHTL) AS TUNTAS FROM (SELECT PaketPekerjaan.DITID, Count(REKTL.IDREKOMENDASI) AS JmlhRekom
FROM (PaketPekerjaan LEFT JOIN UraianTemuan ON PaketPekerjaan.PPID = UraianTemuan.PPID) LEFT JOIN REKTL ON UraianTemuan.UTID = REKTL.UTID
GROUP BY PaketPekerjaan.DITID) AS JmlhDIT LEFT JOIN (SELECT PaketPekerjaan.DITID, Count(REKTL.IDRekomendasi) AS JmlhTL
FROM (PaketPekerjaan LEFT JOIN UraianTemuan ON PaketPekerjaan.PPID = UraianTemuan.PPID) LEFT JOIN REKTL ON UraianTemuan.UTID = REKTL.UTID WHERE (((REKTL.IDStatus)='2'))
GROUP BY PaketPekerjaan.DITID) AS JmlhTL
ON JMLHDIT.DITID=JMLHTL.DITID)
WHERE JMLHREKOM<>TUNTAS)