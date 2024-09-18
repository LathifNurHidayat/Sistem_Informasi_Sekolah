
CREATE TABLE Guru
	   (GuruId INT IDENTITY(1,1),
		GuruName VARCHAR(50),
		TglLahir DATETIME,
		JurusanPendidikan VARCHAR(30),
		TingkatPendidikan VARCHAR(10),
		TahunLulus VARCHAR(10),
		InstansiPendidikan VARCHAR(30),
		KotaPendidikan VARCHAR(20),

		CONSTRAINT PK_Guru PRIMARY KEY CLUSTERED (GuruId));