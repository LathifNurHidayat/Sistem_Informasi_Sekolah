    CREATE TABLE SiswaWali(
        SiswaId INT NOT NULL DEFAULT (0),
        JenisWali INT NOT NULL DEFAULT (0),
        Nama VARCHAR(50) NOT NULL DEFAULT (''),
        TmpLahir VARCHAR(30)NOT NULL DEFAULT (''),
        TglLahir DATETIME NOT NULL DEFAULT ('2000-01-01'),
        Agama VARCHAR(50) NOT NULL DEFAULT (''),
        Kewarga VARCHAR(30) NOT NULL DEFAULT (''),
        Pendidikan VARCHAR(50) NOT NULL DEFAULT (''),
        Pekerjaan VARCHAR(50) NOT NULL DEFAULT (''),
        Penghasilan DECIMAL (18,0) NOT NULL DEFAULT (0),
        Alamat VARCHAR(100) NOT NULL DEFAULT (''),
        NoKK VARCHAR (20) NOT NULL DEFAULT (''),
        NoTelp VARCHAR (15) NOT NULL DEFAULT (''),
        StatusHidup VARCHAR(30) NOT NULL DEFAULT (''),
        NIK VARCHAR (20)  NOT NULL DEFAULT ('')
    );


