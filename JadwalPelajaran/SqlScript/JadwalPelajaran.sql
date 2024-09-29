﻿CREATE TABLE JadwalPelajaran 
	(JadwalId INT IDENTITY(1,1),
	 KelasId INT NOT NULL DEFAULT(0),
	 JenisJadwal	INT NOT NULL DEFAULT(0),
	 Hari VARCHAR(10) NOT NULL DEFAULT (''),
	 JamMulai DATETIME NOT NULL DEFAULT(2024 - 01 - 01),
	 JamSelesai DATETIME NOT NULL DEFAULT(2024 - 01 - 01),
	 MapelId INT NOT NULL  DEFAULT(0),
	 GuruId INT NOT NULL DEFAULT(0)
	 )