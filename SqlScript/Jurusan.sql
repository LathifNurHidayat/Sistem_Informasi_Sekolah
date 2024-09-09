CREATE TABLE Jurusan 
	(
	JurusanId INT IDENTITY(0,1) PRIMARY KEY,
	JurusanName VARCHAR (30) NOT NULL DEFAULT ('')
	);

	INSERT INTO Jurusan (JurusanName)
VALUES ('');
