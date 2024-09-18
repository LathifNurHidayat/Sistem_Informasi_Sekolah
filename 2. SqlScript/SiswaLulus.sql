
CREATE TABLE SiswaLulus (
    SiswaId int NOT NULL DEFAULT (0) , 
    LanjutDi VARCHAR(30) NOT NULL DEFAULT (''),
    TglMulaiKerja DATETIME NOT NULL DEFAULT ('2000-01-01'),
    NamaPerusahaan VARCHAR(30) NOT NULL DEFAULT (''),
    Penghasilan DECIMAL(18,0) NOT NULL DEFAULT (0));