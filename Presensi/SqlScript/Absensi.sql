﻿CREATE TABLE Absensi
		(AbsensiId INT IDENTITY(1,1),
		Tgl DATETIME NOT NULL DEFAULT('2024-01-01'),
		Jam TIME NOT NULL DEFAULT('00:00'),
		KelasId INT NOT NULL DEFAULT(0),
		MapelId INT NOT NULL DEFAULT(0),
		GuruId INT NOT NULL DEFAULT(0),

		CONSTRAINT PK_Absensi PRIMARY KEY (AbsensiId)
		)
		