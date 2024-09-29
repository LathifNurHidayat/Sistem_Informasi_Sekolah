SELECT * FROM SiswaWali;
SELECT * FROM SiswaBeasiswa;
SELECT * FROM SiswaRiwayat;
SELECT * FROM Siswa;
SELECT * FROM SiswaLulus;
SELECT * FROM Guru;
SELECT * FROM GuruMapel;



SELECT 
                    aa.Hari , aa.JamMulai, aa.JamSelesai, bb.MapelName, cc.GuruName 
                FROM
                    JadwalPelajaran aa
                INNER JOIN 
                    MataPelajaran bb ON aa.JadwalId = bb.MapelId
                INNER JOIN
                    Guru cc ON  aa.JadwalId = cc.GuruId
                    
                    WHERE KelasId = @KelasId;