﻿Create TABLE Siswa (
    SiswaId INT IDENTITY(1,1),
	NamaLengkap VARCHAR(50),
    NamaPanggil VARCHAR(20),
    Gender INT,
    TmpLahir VARCHAR(20),
    TglLahir DATETIME,
    Agama VARCHAR(15),
    Kewarganegaraan VARCHAR(10),
    NIK VARCHAR(20), 
    AnakKe INT,
    JmlhSdrKandung INT, 
    JmlhSdrTiri INT,
    JmlhSdrAngkat INT,
    YatimPiatu VARCHAR(20),
    Bahasa VARCHAR(30),
    Alamat VARCHAR(50),
    NoTelp VARCHAR(20),
    TngglDengan VARCHAR(20),
    JrkKeSekolah INT,
    TransportSekolah VARCHAR(30));