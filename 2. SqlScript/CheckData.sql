SELECT * FROM SiswaWali;
SELECT * FROM SiswaBeasiswa;
SELECT * FROM SiswaRiwayat;
SELECT * FROM Siswa;
SELECT * FROM SiswaLulus;
SELECT * FROM Guru;
SELECT * FROM GuruMapel;
SELECT * FROM JadwalPelajaran;






  INSERT INTO JadwalPelajaran
                    (KelasId, JenisJadwal,
                    Hari, JamMulai, JamSelesai, MapelId, GuruId)
                VALUES 
                    (2, 'Umum',
                    'Jumat', '09:09', '09:90', 3, 29)
                







                Delete from JadwalPelaj
                aran Where JadwalId = 5




                select aa.JadwalId, aa.Hari, aa.JamMulai, aa.JamSelesai,
                    ISNULL ( bb.MapelName , '') AS MapelName,
                    ISNULL ( cc.GuruName , '') AS GuruMapel
                FROM
                    JadwalPelajaran aa
                    LEFT JOIN MataPelajaran bb ON aa.MapelId = bb.MapelId
                    LEFT JOIN Guru cc ON aa.GuruId = aa.GuruId
                    where JadwalId = 1;




                    SELECT 
                    JadwalId,JenisJadwal, KelasId, Hari, JamMulai, JamSelesai,
                    MapelId, GuruId
                FROM
                    JadwalPelajaran



                  WITH RankedJadwal AS (
    SELECT 
        aa.JadwalId,
        aa.JenisJadwal, 
        aa.Hari, 
        aa.JamMulai, 
        aa.JamSelesai,
        ISNULL(bb.MapelName, '') AS MapelName,
        ISNULL(cc.GuruName, '') AS GuruName,
        ROW_NUMBER() OVER (PARTITION BY aa.Hari ORDER BY aa.JamMulai) AS rn
    FROM 
        JadwalPelajaran aa
        LEFT JOIN MataPelajaran bb ON aa.MapelId = bb.MapelId
        LEFT JOIN Guru cc ON aa.GuruId = cc.GuruId
    WHERE
        aa.KelasId = 2
)

SELECT 
    CASE 
        WHEN rn = 1 THEN Hari 
        ELSE '' 
    END AS Hari,
    JadwalId,
    JamMulai,
    MapelName,
    GuruName,
    rn
FROM 
    RankedJadwal
ORDER BY 
    CASE 
        WHEN Hari = 'Senin' THEN 1
        WHEN Hari = 'Selasa' THEN 2
        WHEN Hari = 'Rabu' THEN 3
        WHEN Hari = 'Kamis' THEN 4
        WHEN Hari = 'Jumat' THEN 5
        WHEN Hari = 'Sabtu' THEN 6
        ELSE 7
    END, JamMulai;



    WITH RankHari AS (
    SELECT aa.JadwalId, aa.JenisJadwal, aa.Hari, aa.JamMulai, aa.JamSelesai, 
    ISNULL ( bb.MapelName , '') AS MapelName,
    ISNULL (cc.GuruName , '') AS GuruName, 
    ROW_NUMBER() OVER (PARTITION BY aa.Hari ORDER BY aa.JamMulai) AS SetHari
    FROM JadwalPelajaran aa
    LEFT JOIN MataPelajaran bb ON aa.MapelId = bb.MapelId
    LEFT JOIN Guru cc ON aa.GuruId = cc.GuruId
    )



 SELECT 
 JadwalId,
    CASE 
        WHEN SetHari = 1 THEN Hari
        ELSE ''
    END AS Hari,
    JamMulai,
    JamSelesai,
    MapelName,
    GuruName,
    SetHari
FROM RankHari

ORDER BY 
    CASE 
        WHEN Hari = 'Senin' THEN 1
        WHEN Hari = 'Selasa' THEN 2
        WHEN Hari = 'Rabu' THEN 3
        WHEN Hari = 'Kamis' THEN 4
        WHEN Hari = 'Jumat' THEN 5 
        WHEN Hari = 'Sabtu' THEN 6
    ELSE 7
    END , JamMulai



    WITH RankHari  AS  (
    SELECT 
    aa.JadwalId , aa.JenisJadwal, aa.Hari, aa.JamMulai, aa.JamSelesai,
    ISNULL (bb.MapelName , '') AS MapelName,
    ISNULL (cc.GuruName , '') AS GuruName,
    ROW_NUMBER () OVER (PARTITION BY aa.Hari ORDER BY aa.JamMulai) AS SetHari

    FROM JadwalPelajaran aa
    LEFT JOIN MataPelajaran bb ON aa.MapelId = bb.MapelId
    LEFT JOIN Guru cc ON aa.GuruId = cc.GuruId

    )

   SELECT 
   JadwalId ,
   CASE 
        WHEN SetHari = 1 THEN Hari
        ELSE ''
    END AS Hari,
    JamMulai, JamSelesai, MapelName, GuruName
    FROM RankHari

        ORDER BY 
                CASE 
                    WHEN Hari = 'Senin' THEN 1
                    WHEN Hari = 'Selasa' THEN 2
                    WHEN Hari = 'Rabu' THEN 3
                    WHEN Hari = 'Kamis' THEN 4
                    WHEN Hari = 'Jumat' THEN 5
                    WHEN Hari = 'Sabtu' THEN 6
                    ELSE 7
                END , JamMulai







SELECT 
                    aa.JadwalId, aa.JenisJadwal, aa.Hari, aa.JamMulai, aa.JamSelesai,
                    ISNULL ( bb.MapelName , '') AS MapelName,
                    ISNULL ( cc.GuruName , '') AS GuruName
                FROM 
                    JadwalPelajaran aa
                    LEFT JOIN MataPelajaran bb ON aa.MapelId = bb.MapelId
                    LEFT JOIN Guru cc ON aa.GuruId = aa.GuruId
                WHERE
                    KelasId = 2                ORDER BY 
                    CASE 
                        WHEN Hari = 'Senin' THEN 1
                        WHEN Hari = 'Selasa' THEN 2
                        WHEN Hari = 'Rabu' THEN 3
                        WHEN Hari = 'Kamis' THEN 4
                        WHEN Hari = 'Jumat' THEN 5
                        WHEN Hari = 'Sabtu' THEN 6
                    ELSE 7
                END , JamMulai










   SELECT 
                    aa.JadwalId, aa.JenisJadwal, aa.Hari, aa.JamMulai, aa.JamSelesai,
                    ISNULL ( bb.MapelName , '') AS MapelName,
                    ISNULL ( cc.GuruName , '') AS GuruName
                FROM 
                    JadwalPelajaran aa
                    LEFT JOIN MataPelajaran bb ON aa.MapelId = bb.MapelId
                    LEFT JOIN Guru cc ON aa.GuruId = aa.GuruId
                WHERE
                    KelasId = 2
                ORDER BY 
                    CASE 
                        WHEN Hari = 'Senin' THEN 1
                        WHEN Hari = 'Selasa' THEN 2
                        WHEN Hari = 'Rabu' THEN 3
                        WHEN Hari = 'Kamis' THEN 4
                        WHEN Hari = 'Jumat' THEN 5
                        WHEN Hari = 'Sabtu' THEN 6
                    ELSE 7
                END ASC , JamMulai












                



    WITH Rank AS (
                    SELECT 
                        aa.JadwalId, aa.JenisJadwal, aa.Hari, aa.JamMulai, aa.JamSelesai, aa.Keterangan,
                        ISNULL (bb.MapelName , '') AS MapelName,
                        ISNULL (cc.GuruName , '') AS GuruName,
                        ROW_NUMBER() OVER (PARTITION BY aa.Hari ORDER BY aa.JamMulai) AS RK
                    FROM 
                        JadwalPelajaran aa 
                        LEFT JOIN MataPelajaran bb ON aa.MapelId = bb.MapelId
                        LEFT JOIN Guru cc ON aa.GuruId = cc.GuruId
                    WHERE 
                        KelasId = 2)

                SELECT 
                    JadwalId, JenisJadwal,Hari,

                        CASE 
                            WHEN RK = 1 THEN Hari
                        ELSE ''
                    END,
                    
                    JamMulai, JamSelesai, MapelName, GuruName, Keterangan
                FROM 
                    Rank
                ORDER BY 
                    CASE 
                        WHEN Hari = 'Senin' THEN 1
                        WHEN Hari = 'Selasa' THEN 2
                        WHEN Hari = 'Rabu' THEN 3
                        WHEN Hari = 'Kamis' THEN 4
                        WHEN Hari = 'Jumat' THEN 5
                        WHEN Hari = 'Sabtu' THEN 6
                    ELSE 7
                    END, JamMulai