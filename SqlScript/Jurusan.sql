﻿CREATE TABLE Jurusan 
	(
	JurusanId INT IDENTITY(1,1) PRIMARY KEY,
	JurusanName VARCHAR (30) NOT NULL DEFAULT (''),
	JurusanKode INT NOT NULL DEFAULT (0)
	);

