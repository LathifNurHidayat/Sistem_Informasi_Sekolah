﻿CREATE TABLE AbsensiDetil
		(AbsensiId INT NOT NULL DEFAULT(0),
		NoUrut INT NOT NULL DEFAULT(0),
		SiswaId INT NOT NULL DEFAULT(0),
		StatusAbsen INT NOT NULL DEFAULT(0),
		Keterangan VARCHAR(30) NOT NULL DEFAULT('')
		)