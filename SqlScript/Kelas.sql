﻿CREATE TABLE Kelas 
	(
	KelasId INT IDENTITY(1,1) PRIMARY KEY,
	KelasName VARCHAR(30) NOT NULL DEFAULT(''),
	KelasTingkat INT NOT NULL DEFAULT(0),
	JurusanId INT NOT NULL DEFAULT (0),
	Flag  VARCHAR(5) NOT NULL DEFAULT ('')
	);


	INSERT INTO Kelas (KelasName, KelasTingkat, JurusanId, Flag)
	VALUES ('10 RPL-2',10,3,'2');
