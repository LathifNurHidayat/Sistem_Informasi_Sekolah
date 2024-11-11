CREATE TABLE Absensi
		(AbsensiId INT IDENTITY(1,1),
		Tanggal DATETIME NOT NULL DEFAULT('2024-01-01'),
		Jam VARCHAR(2) NOT NULL DEFAULT(''),
		KelasId INT NOT NULL DEFAULT(0),
		MapelId INT NOT NULL DEFAULT(0),
		GuruId INT NOT NULL DEFAULT(0),

		CONSTRAINT PK_Absensi PRIMARY KEY (AbsensiId)
		)
insert into Absensi (Tanggal, Jam, KelasId, MapelId, GuruId)
values ('2024-01-01', '2', 2, 6, 29)

SELECT 
            AbsensiId
        FROM 
            Absensi
        WHERE 
            KelasId = 2 AND Tanggal = '2024-01-01' AND
            Jam = '2' AND MapelId = 6 AND GuruId = 29
