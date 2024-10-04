SELECT * FROM SiswaWali;
SELECT * FROM SiswaBeasiswa;
SELECT * FROM SiswaRiwayat;
SELECT * FROM Siswa;
SELECT * FROM SiswaLulus;
SELECT * FROM Guru;
SELECT * FROM GuruMapel;
SELECT * FROM JadwalPelajaran;

SELECT 
                    aa.JadwalId, aa.Hari, aa.JamMulai, aa.JamSelesai,
                    ISNULL ( bb.MapelName , '') AS MapelName,
                    ISNULL ( cc.GuruName , '') AS GuruMapel
                FROM 
                    JadwalPelajaran aa
                    LEFT JOIN MataPelajaran bb ON aa.MapelId = bb.MapelId
                    LEFT JOIN Guru cc ON aa.GuruId = aa.GuruId





                      SELECT 
                    aa.JadwalId,aa.JenisJadwal,  aa.KelasId, aa.GuruId, aa.Hari, aa.JamMulai, aa.JamSelesai,
                    ISNULL ( bb.MapelName , '') AS MapelName,
                    ISNULL ( cc.GuruName , '') AS GuruMapel,
                    ISNULL (dd.KelasName , '') AS KelasName
                FROM 
                    JadwalPelajaran aa
                    LEFT JOIN MataPelajaran bb ON aa.MapelId = bb.MapelId
                    LEFT JOIN Guru cc ON aa.GuruId = aa.GuruId
LEFT JOIN Kelas dd    ON aa.KelasId  = dd.KelasId 
                


                Delete from JadwalPelajaran Where JadwalId = 5




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
