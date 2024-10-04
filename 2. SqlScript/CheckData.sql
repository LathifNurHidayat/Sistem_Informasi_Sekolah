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