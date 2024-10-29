SELECT * FROM SiswaWali;
SELECT * FROM SiswaBeasiswa;
SELECT * FROM SiswaRiwayat;
SELECT * FROM Siswa;
SELECT * FROM SiswaLulus;
SELECT * FROM Guru;
SELECT * FROM GuruMapel;
SELECT * FROM KelasSiswa;
SELECT * FROM KelasSiswaDetil;


delete from KelasSiswaDetil


 SELECT 
                SiswaId, NamaLengkap
            FROM
                Siswa
            WHERE
                NamaLengkap LIKE '%L%'