IF DB_ID('HastaneDB') IS NULL
BEGIN
    CREATE DATABASE HastaneDB;
END
GO

USE HastaneDB;
GO

IF OBJECT_ID('Hastalar', 'U') IS NULL
BEGIN
     CREATE TABLE Hastalar (
        HastaID INT PRIMARY KEY IDENTITY(1,1),
        Ad NVARCHAR(50),
        Soyad NVARCHAR(50),
        TC NVARCHAR(11),
        Sifre NVARCHAR(50),
        Cinsiyet NVARCHAR(10),
        DogumTarihi DATE
     );
END

IF OBJECT_ID('Doktorlar', 'U') IS NULL
BEGIN
     CREATE TABLE Doktorlar (
        DoktorID INT PRIMARY KEY IDENTITY(1,1),
        Ad NVARCHAR(50),
        Soyad NVARCHAR(50),
        Brans NVARCHAR(50),
        Sifre NVARCHAR(50),
        SicilNo NVARCHAR(10),
        Cinsiyet NVARCHAR(10),
        DogumTarihi DATE,
        MezunOkul NVARCHAR(100),
        Fotograf NVARCHAR(255),
        BaslamaTarihi DATE,
        Durum NVARCHAR(20) DEFAULT 'Aktif'
     );
END

IF OBJECT_ID('Adminler', 'U') IS NULL
BEGIN
      CREATE TABLE Adminler (
         AdminID INT PRIMARY KEY IDENTITY(1,1),
         KullaniciAdi NVARCHAR(50),
         Sifre NVARCHAR(50)
      );
END

IF OBJECT_ID('Randevular', 'U') IS NULL
BEGIN
     CREATE TABLE Randevular (
        RandevuID INT PRIMARY KEY IDENTITY(1,1),
        HastaID INT,
        DoktorID INT,
        Tarih DATE,
        Saat TIME,
        Durum NVARCHAR(20) DEFAULT 'Aktif',
        OlusturmaTarihi DATETIME DEFAULT GETDATE(),
        RandevuZamani DATETIME,
        FOREIGN KEY (HastaID) REFERENCES Hastalar(HastaID),
        FOREIGN KEY (DoktorID) REFERENCES Doktorlar(DoktorID)
     );
END

IF OBJECT_ID('Yorumlar', 'U') IS NULL
BEGIN
     CREATE TABLE Yorumlar (
        YorumID INT PRIMARY KEY IDENTITY(1,1),
        DoktorID INT,
        HastaID INT,
        YorumMetni NVARCHAR(500),
        Puan INT,
        Tarih DATE,
        FOREIGN KEY (DoktorID) REFERENCES Doktorlar(DoktorID),
        FOREIGN KEY (HastaID) REFERENCES Hastalar(HastaID)
     );
END

IF NOT EXISTS (
    SELECT 1 
    FROM sys.key_constraints 
    WHERE name = 'UQ_Hastalar_TC'
)
BEGIN
    ALTER TABLE Hastalar
    ADD CONSTRAINT UQ_Hastalar_TC UNIQUE (TC);
END

IF NOT EXISTS (
    SELECT 1
    FROM sys.key_constraints
    WHERE name = 'UQ_Doktorlar_SicilNo'
)
BEGIN
    ALTER TABLE Doktorlar
    ADD CONSTRAINT UQ_Doktorlar_SicilNo UNIQUE (SicilNo);
END


--DOKTOR KAYITLARI
INSERT INTO Doktorlar
(Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
VALUES
('Afþin', 'Uysal', 'Anesteziyoloji ve Reanimasyon',
 '111', '1001', 'Erkek', '1995-05-24',
 'Selçuk Üniversitesi', 'afsin_uysal.jpeg',
 '2019-01-07', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Ahmet', 'Yýlmaz', 'Kardiyoloji',
 '123', '1004', 'Erkek', '1980-05-10',
 'Ýstanbul Üniversitesi', 'ahmet_yilmaz.jpeg',
 '2004-04-07', 'Pasif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Ayþe', 'Demir', 'Ýç Hastalýklarý(Dahiliye)',
 '123', '1005', 'Kadýn', '1985-08-20',
 'Ankara Üniversitesi', 'ayse_demir.jpeg',
 '2009-02-01', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Zahide', 'Taþdemir', 'Çocuk Saðlýðý ve Hastalýklarý',
 '112', '1006', 'Kadýn', '1998-03-11',
 'Ýstanbul - Cerrahpaþa', 'zahide_tasdemir.jpeg',
 '2022-02-07', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Þeyma', 'Yýlmaz', 'Deri ve Zührevi Hastalýklar',
 '113', '1007', 'Kadýn', '1997-06-03',
 'Hacettepe Üniversitesi', 'seyma_yilmaz.jpeg',
 '2021-03-08', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Fatih', 'Balcý', 'Aðýz ve Diþ Saðlýðý',
 '114', '1008', 'Erkek', '1990-10-29',
 'Ankara Üniversitesi', 'fatih_balci.jpeg',
 '2014-04-21', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Meltem', 'Gemi', 'Fizik Tedavi ve Rehabilitasyon',
 '115', '1009', 'Kadýn', '1991-05-04',
 'Gazi Üniversitesi', 'meltem_gemi.jpeg',
 '2016-01-26', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Turgut', 'Koç', 'Genel Cerrahi',
 '116', '1010', 'Erkek', '1976-09-15',
 'Ýstanbul Üniversitesi', 'turgut_koc.jpeg',
 '2001-10-08', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Þule', 'Yenigün', 'Ýç Hastalýklarý(Dahiliye)',
 '117', '1011', 'Kadýn', '1989-06-12',
 'Gazi Üniversitesi', 'sule_yenigun.jpeg',
 '2013-07-22', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Kamil', 'Poyraz', 'Fizik Tedavi ve Rehabilitasyon',
 '118', '1002', 'Erkek', '1992-04-10',
 'Çukurova Üniversitesi', 'kamil_poyraz.jpeg',
 '2016-11-14', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Murat', 'Yusuf', 'Göz Hastalýklarý',
 '119', '1012', 'Erkek', '1983-02-18',
 'Ondokuz Mayýs Üniversitesi', 'murat_yusuf.jpeg',
 '2007-11-19', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Muhammet', 'Türkyýlmaz', 'Nöroloji',
 '120', '1013', 'Erkek', '1979-08-21',
 'Ýstanbul Üniversitesi', 'muhammet_turkyilmaz.jpeg',
 '2004-03-29', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Esma', 'Kökver', 'Kardiyoloji',
 '121', '1014', 'Kadýn', '1992-05-22',
 'Necmettin Erbakan Üniversitesi', 'esma_kokver.jpeg',
 '2015-08-24', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Þemmi', 'Koyuncu', 'Ortopedi ve Travmatoloji',
 '123', '1015', 'Erkek', '2000-07-18',
 'Ýnönü Üniversitesi', 'semmi_koyuncu.jpeg',
 '2024-01-15', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Furkan', 'Bülbül', 'Ortopedi ve Travmatoloji',
 '123', '1016', 'Erkek', '1985-07-17',
 'Hacettepe Üniversitesi', 'furkan_bulbul.jpeg',
 '2009-02-18', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Feyza', 'Erdemir', 'Aðýz ve Diþ Saðlýðý',
 '124', '1017', 'Kadýn', '1995-03-30',
 'Gazi Üniversitesi', 'feyza_erdemir.jpeg',
 '2019-07-15', 'Aktif');

 INSERT INTO Doktorlar
 (Ad, Soyad, Brans, Sifre, SicilNo, Cinsiyet, DogumTarihi,
 MezunOkul, Fotograf, BaslamaTarihi, Durum)
 VALUES
 ('Merve', 'Çolak', 'Psikiyatri',
 '125', '1018', 'Kadýn', '1987-06-24',
 'Selçuk Üniversitesi', 'merve_colak.jpeg',
 '2011-06-20', 'Aktif');


 --HASTA KAYITLARI
 INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Ayþe', 'Yýlmaz', '12345678912', '111', 'Kadýn', '1978-10-04');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Ali', 'Kaya', '11111111112', '123', 'Erkek', '1970-01-07');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Melike', 'Ulusoy', '45645645645', '654', 'Kadýn', '1991-02-07');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Semra', 'Keten', '98765432112', '222', 'Kadýn', '1981-04-23');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Ýrem', 'Bostan', '12312312312', '123', 'Kadýn', '2014-11-03');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Eren', 'Kara', '78978978978', '333', 'Erkek', '2010-02-16');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Kayra', 'Topal', '12121212121', '121', 'Erkek', '2000-12-19');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Alperen', 'Teke', '12012012012', '120', 'Erkek', '1998-05-26');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Fatma', 'Gezgin', '67676767676', '113', 'Kadýn', '1980-10-31');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Buse', 'Caymaz', '89898989898', '888', 'Kadýn', '2010-12-02');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Cemil', 'Öztürk', '56789567895', '555', 'Erkek', '1958-05-14');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Serkan', 'Kurt', '10101010101', '101', 'Erkek', '1995-07-06');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Ömer', 'Polat', '45454545454', '456', 'Erkek', '2003-01-08');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Melisa', 'Þahin', '78787878787', '777', 'Kadýn', '1989-10-25');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Hasan', 'Koç', '96969696969', '888', 'Erkek', '1978-07-24');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Burak', 'Aksoy', '23232323232', '222', 'Erkek', '2019-07-17');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Neslihan', 'Taþ', '25252525252', '555', 'Kadýn', '1981-09-05');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Ceren', 'Aydýn', '99999999998', '999', 'Kadýn', '2008-11-16');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Ýsmail', 'Yýldýz', '34343434343', '444', 'Erkek', '1982-11-12');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Veysel', 'Aydoðdu', '35353535353', '333', 'Erkek', '1951-11-17');

INSERT INTO Hastalar
(Ad, Soyad, TC, Sifre, Cinsiyet, DogumTarihi)
VALUES
('Kerem', 'Soydan', '28282828282', '282', 'Erkek', '2003-10-26');


--ADMÝN KAYDI
INSERT INTO Adminler
(KullaniciAdi, Sifre)
VALUES
('hasanyilmaz', '123');


--RANDEVU KAYITLARI
INSERT INTO Randevular
(HastaID, DoktorID, Tarih, Saat, Durum, OlusturmaTarihi, RandevuZamani)
VALUES
(
 (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '12345678912'),
 (SELECT TOP 1 DoktorID FROM Doktorlar WHERE SicilNo = '1001'),
 '2026-05-27',
 '13:50:00',
 'Ýptal',
 GETDATE(),
 '2026-05-27 13:50:00'
);

INSERT INTO Randevular
(HastaID, DoktorID, Tarih, Saat, Durum, OlusturmaTarihi, RandevuZamani)
VALUES
(
 (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '11111111112'),
 (SELECT TOP 1 DoktorID FROM Doktorlar WHERE SicilNo = '1004'),
 '2026-05-27',
 '13:30:00',
 'Tamamlandý',
 GETDATE(),
 '2026-05-27 13:30:00'
);

INSERT INTO Randevular
(HastaID, DoktorID, Tarih, Saat, Durum, OlusturmaTarihi, RandevuZamani)
VALUES
(
 (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '12121212121'),
 (SELECT TOP 1 DoktorID FROM Doktorlar WHERE SicilNo = '1009'),
 '2026-05-27',
 '11:10:00',
 'Tamamlandý',
 GETDATE(),
 '2026-05-27 11:10:00'
);

INSERT INTO Randevular
(HastaID, DoktorID, Tarih, Saat, Durum, OlusturmaTarihi, RandevuZamani)
VALUES
(
 (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '45645645645'),
 (SELECT TOP 1 DoktorID FROM Doktorlar WHERE SicilNo = '1007'),
 '2026-05-26',
 '14:30:00',
 'Tamamlandý',
 GETDATE(),
 '2026-05-26 14:30:00'
);

INSERT INTO Randevular
(HastaID, DoktorID, Tarih, Saat, Durum, OlusturmaTarihi, RandevuZamani)
VALUES
(
 (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '34343434343'),
 (SELECT TOP 1 DoktorID FROM Doktorlar WHERE SicilNo = '1015'),
 '2026-05-26',
 '11:50:00',
 'Ýptal',
 GETDATE(),
 '2026-05-26 11:50:00'
);

INSERT INTO Randevular
(HastaID, DoktorID, Tarih, Saat, Durum, OlusturmaTarihi, RandevuZamani)
VALUES
(
 (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '12012012012'),
 (SELECT TOP 1 DoktorID FROM Doktorlar WHERE SicilNo = '1012'),
 '2026-05-27',
 '14:00:00',
 'Tamamlandý',
 GETDATE(),
 '2026-05-27 14:00:00'
);

INSERT INTO Randevular
(HastaID, DoktorID, Tarih, Saat, Durum, OlusturmaTarihi, RandevuZamani)
VALUES
(
 (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '78978978978'),
 (SELECT TOP 1 DoktorID FROM Doktorlar WHERE SicilNo = '1017'),
 '2026-05-26',
 '14:20:00',
 'Tamamlandý',
 GETDATE(),
 '2026-05-26 14:20:00'
);

INSERT INTO Randevular
(HastaID, DoktorID, Tarih, Saat, Durum, OlusturmaTarihi, RandevuZamani)
VALUES
(
 (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '25252525252'),
 (SELECT TOP 1 DoktorID FROM Doktorlar WHERE SicilNo = '1013'),
 '2026-05-27',
 '14:40:00',
 'Tamamlandý',
 GETDATE(),
 '2026-05-27 14:40:00'
);


--YORUM KAYITLARI
IF EXISTS (
    SELECT 1
    FROM Randevular
    WHERE HastaID = (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '11111111112')
      AND DoktorID = (SELECT TOP 1 DoktorID FROM Doktorlar WHERE SicilNo = '1004')
      AND Durum = 'Tamamlandý'
)
BEGIN
    INSERT INTO Yorumlar (DoktorID, HastaID, YorumMetni, Puan, Tarih)
    VALUES
   (
     (SELECT TOP 1 DoktorID FROM Doktorlar WHERE  SicilNo = '1004'),
     (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '11111111112'),
     N'Ýlgisiz bir doktordu, memnun kalmadým, tavsiye etmem.',
     2,
     '2026-05-27'
   );
END

IF EXISTS (
    SELECT 1
    FROM Randevular
    WHERE HastaID = (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '12121212121')
      AND DoktorID = (SELECT TOP 1 DoktorID FROM Doktorlar WHERE SicilNo = '1009')
      AND Durum = 'Tamamlandý'
)
BEGIN
    INSERT INTO Yorumlar (DoktorID, HastaID, YorumMetni, Puan, Tarih)
    VALUES
   (
     (SELECT TOP 1 DoktorID FROM Doktorlar WHERE  SicilNo = '1009'),
     (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '12121212121'),
     N'Ýletiþim konusunda eðitime ihtiyacý var, hiç memnun kalmadým.',
     2,
     '2026-05-27'
   );
END

IF EXISTS (
    SELECT 1
    FROM Randevular
    WHERE HastaID = (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '45645645645')
      AND DoktorID = (SELECT TOP 1 DoktorID FROM Doktorlar WHERE SicilNo = '1007')
      AND Durum = 'Tamamlandý'
)
BEGIN
    INSERT INTO Yorumlar (DoktorID, HastaID, YorumMetni, Puan, Tarih)
    VALUES
   (
     (SELECT TOP 1 DoktorID FROM Doktorlar WHERE  SicilNo = '1007'),
     (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '45645645645'),
     N'Muayene süreci gayet hýzlý ve rahattý, teþekkür ederim.',
     5,
     '2026-05-26'
   );
END

IF EXISTS (
    SELECT 1
    FROM Randevular
    WHERE HastaID = (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '12012012012')
      AND DoktorID = (SELECT TOP 1 DoktorID FROM Doktorlar WHERE SicilNo = '1012')
      AND Durum = 'Tamamlandý'
)
BEGIN
    INSERT INTO Yorumlar (DoktorID, HastaID, YorumMetni, Puan, Tarih)
    VALUES
   (
     (SELECT TOP 1 DoktorID FROM Doktorlar WHERE  SicilNo = '1012'),
     (SELECT TOP 1 HastaID FROM Hastalar WHERE TC = '12012012012'),
     N'Güler yüzlü bir doktordu, sorularýmý açýklayýcý bir þekilde cevapladý.',
     5,
     '2026-05-27'
   );
END