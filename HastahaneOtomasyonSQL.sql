USE HastaneOtomasyonDB

CREATE TABLE Kullanici (
KullaniciID int identity PRIMARY KEY NOT NULL,
KullaniciAdi varchar(25) NOT NULL,
KullaniciParola varchar(20) NOT NULL,
KullaniciTur char(3) NOT NULL
CONSTRAINT ck_KullaniciTur
CHECK (KullaniciTur in ('DOK','VEZ','LAB','ADM'))
)

CREATE TABLE Klinik (
KlinikID tinyint identity PRIMARY KEY NOT NULL,
KlinikAdi varchar(30) UNIQUE NOT NULL,
)

CREATE TABLE  Doktor (
DoktorID int identity PRIMARY KEY NOT NULL,
KlinikID tinyint 
CONSTRAINT fk_KlinikID_DoktorTB
FOREIGN KEY (KlinikID) references Klinik(KlinikID) ON DELETE CASCADE NOT NULL,

DoktorTC varchar(11) UNIQUE NOT NULL
CONSTRAINT ck_DoktorTC
CHECK(LEN(DoktorTC) = 11),

DoktorAd varchar(25) NOT NULL,
DoktorSoyad varchar(20) NOT NULL,
DoktorCinsiyet char(1) NOT NULL
CONSTRAINT ck_DoktorCinsiyet
CHECK(DoktorCinsiyet in ('E', 'K')),

DoktorDogumTarihi date 
CONSTRAINT ck_DoktorDogumTarihi
CHECK(DoktorDogumTarihi<=getdate()),
)

CREATE TABLE Hasta (
HastaID int identity(1,1) PRIMARY KEY,

HastaTC varchar(11) UNIQUE NOT NULL
CONSTRAINT ck_HastaTC
CHECK(LEN(HastaTC) = 11),

HastaAd varchar(25) NOT NULL ,
HastaSoyad varchar(20) NOT NULL ,
HastaBabaAdi varchar(20),
HastaAnneAdi varchar(20),

HastaCepTel varchar(10) NOT NULL
CONSTRAINT ck_HastaCepTel
CHECK(LEN(HastaCepTel) = 10),

HastaPosta varchar(50),
HastaAdres nvarchar(max),
HastaDogum date DEFAULT getdate(),

HastaCinsiyet char(1) NOT NULL
CONSTRAINT ck_HastaCinsiyet
CHECK (HastaCinsiyet in ('E','K')),

HastaKanGrup varchar(3) NOT NULL
CONSTRAINT ck_KanGrup 
CHECK(HastaKanGrup in ('A+','B+','A-','B-','0-','0+','AB-','AB+'))
)

CREATE TABLE Laboratuvar (
LabID tinyint identity(1,1) PRIMARY KEY,
LabAdi varchar(50) NOT NULL
)

CREATE TABLE Tani (
TaniID int identity(1,1) PRIMARY KEY,
HastaID int 
CONSTRAINT fk_HastaID_TaniTB
FOREIGN KEY (HastaID) references Hasta(HastaID) ON DELETE CASCADE NOT NULL,
TaniAdi varchar(50),
TaniAciklama nvarchar(max)
)

CREATE TABLE Test (
TestID int identity(1,1) PRIMARY KEY,

HastaID int
CONSTRAINT fk_HastaID_TestTB
FOREIGN KEY (HastaID) REFERENCES Hasta(HastaID) ON DELETE CASCADE NOT NULL,

LabID tinyint
CONSTRAINT fk_LabID_TestTB
FOREIGN KEY (LabID) REFERENCES Laboratuvar(LabID) ON DELETE CASCADE NOT NULL ,

TestSonuc nvarchar(max)
)

CREATE TABLE Recete (
ReceteID int identity(1,1) PRIMARY KEY,

HastaID int 
CONSTRAINT fk_HastaID_ReceteTB
FOREIGN KEY (HastaID) REFERENCES Hasta(HastaID) ON DELETE CASCADE ,

ReceteAciklama nvarchar(max)
)

CREATE TABLE Randevu(
RandevuID int identity(1,1) PRIMARY KEY,

HastaID int 
CONSTRAINT fk_HastaID_RandevuTBS
FOREIGN KEY (HastaID) REFERENCES Hasta(HastaID) ON DELETE CASCADE  ,

RandevuDoktorID int 
CONSTRAINT fk_RandevuDoktorID_RandevuTB
FOREIGN KEY (RandevuDoktorID) REFERENCES Doktor(DoktorID) ON DELETE CASCADE ,

KlinikID tinyint
CONSTRAINT fk_KlinikID_RandevuTB
FOREIGN KEY (KlinikID) REFERENCES Klinik(KlinikID),

RandevuTarih date,
)

CREATE TABLE  SilinennDoktor (
DoktorID int PRIMARY KEY NOT NULL,
KlinikID tinyint 
CONSTRAINT fk_KlinikID_Silinenn
FOREIGN KEY (KlinikID) REFERENCES Klinik(KlinikID) NOT NULL,

DoktorTC varchar(11) UNIQUE NOT NULL
CONSTRAINT ck_DoktorTC_Silinenn
CHECK(LEN(DoktorTC) = 11),

DoktorAd varchar(25) NOT NULL,
DoktorSoyad varchar(20) NOT NULL,
DoktorCinsiyet char(1) NOT NULL
CONSTRAINT ck_DoktorCinsiyet_Silinenn
CHECK(DoktorCinsiyet in ('E', 'K')),

DoktorDogumTarihi date 
CONSTRAINT ck_DoktorDogumTarihi_Silinenn
CHECK(DoktorDogumTarihi<=getdate()),

silinmeTarihi as getdate()
)

GO
CREATE PROCEDURE sp_KullaniciGetir 
AS 
SELECT * FROM Kullanici

GO
CREATE PROCEDURE sp_KullaniciEkle (@KullaniciAdi varchar(25),@KullaniciParola varchar(20),@KullaniciTur char(3)) 
AS
INSERT INTO Kullanici VALUES (@KullaniciAdi,@KullaniciParola,@KullaniciTur)

GO
CREATE PROCEDURE sp_KullaniciSil (@KullaniciID int)
AS 
DELETE FROM Kullanici WHERE KullaniciID = @KullaniciID

GO
CREATE PROCEDURE sp_LaboratuvarGetir
AS
SELECT * FROM Laboratuvar

GO 
CREATE PROCEDURE sp_LaboratuvarSil(@LabID int)
AS 
DELETE FROM Laboratuvar WHERE LabID = @LabID

GO
CREATE PROCEDURE sp_LaboratuvarEkle (@LabAdi varchar(50))
AS 
INSERT INTO Laboratuvar VALUES(@LabAdi)

GO
CREATE PROCEDURE sp_LaboratuvarGuncelle (@LabID tinyint, @LabAdi varchar(50))
AS
UPDATE Laboratuvar SET LabAdi = @LabAdi WHERE LabID = @LabID

GO
CREATE PROCEDURE sp_KlinikGetir
AS
SELECT * FROM Klinik

GO
CREATE PROCEDURE sp_KlinikEkle (@KlinikAdi varchar(50))
AS 
INSERT INTO Klinik VALUES(@KlinikAdi)

GO 
CREATE PROCEDURE sp_KlinikSil(@KlinikID int)
AS 
DELETE FROM Klinik WHERE KlinikID = @KlinikID

GO
CREATE PROCEDURE sp_KlinikGuncelle (@KlinikID tinyint, @KlinikAdi varchar(50))
AS
UPDATE Klinik SET KlinikAdi = @KlinikAdi WHERE KlinikID = @KlinikID

GO
CREATE PROCEDURE sp_DoktorGetir(@ad nvarchar(25))
AS
SELECT * FROM Doktor

GO
CREATE PROCEDURE sp_DoktorEkle(@KlinikID tinyint, @DoktorTC varchar(11), @DoktorAD varchar(50), @DoktorSoyad varchar(20), @DoktorCinsiyet char(1), @DoktorDogumTarihi date)    
AS
INSERT Doktor VALUES(@KlinikID,@DoktorTC,@DoktorAD,@DoktorSoyad,@DoktorCinsiyet,@DoktorDogumTarihi)

GO
CREATE PROCEDURE sp_DoktorSil(@DoktorID int)
AS
DELETE FROM Doktor WHERE DoktorID = @DoktorID

GO
CREATE PROCEDURE sp_DoktorGuncelle(@DoktorID int, @KlinikID tinyint, @DoktorTC varchar(11), @DoktorAD varchar(50), @DoktorSoyad varchar(20), @DoktorCinsiyet char(1), @DoktorDogumTarihi date)
AS
UPDATE Doktor SET KlinikID = @KlinikID, DoktorTC = @DoktorTC, DoktorAD = @DoktorAD, DoktorSoyad = @DoktorSoyad, DoktorCinsiyet = @DoktorCinsiyet, DoktorDogumTarihi = @DoktorDogumTarihi  WHERE DoktorID = @DoktorID

GO
CREATE PROCEDURE sp_HastaGetir
AS
SELECT * FROM Hasta

GO
CREATE PROCEDURE sp_RandevuEkle (
@HastaID int,
@RandevuDoktorID int,
@KlinikID tinyint,
@RandevuTarih date
)
AS 
INSERT INTO Randevu VALUES(
@HastaID,
@RandevuDoktorID,
@KlinikID,
@RandevuTarih
)

GO
CREATE PROCEDURE sp_ReceteKaydet(
    @HastaID int,
    @ReceteAciklama nvarchar(max)
)
AS
INSERT Recete(HastaID, ReceteAciklama) VALUES(
    @HastaID,
    @ReceteAciklama
)

GO
CREATE PROCEDURE sp_KlinikDoktorGetir (@KlinikID int) 
AS
SELECT DoktorAd,DoktorSoyad,DoktorID FROM Doktor INNER JOIN Klinik ON Klinik.KlinikID = Doktor.KlinikID WHERE Doktor.KlinikID = @KlinikID

GO
CREATE PROCEDURE sp_RaporGetir
AS
SELECT * FROM Recete

GO
CREATE PROCEDURE sp_SilinennDoktorEkle(@DoktorID int,@KlinikID tinyint, @DoktorTC varchar(11), @DoktorAD varchar(50), @DoktorSoyad varchar(20), @DoktorCinsiyet char(1), @DoktorDogumTarihi date)
AS
INSERT SilinennDoktor VALUES(@DoktorID,@KlinikID,@DoktorTC,@DoktorAD,@DoktorSoyad,@DoktorCinsiyet,@DoktorDogumTarihi)

GO
CREATE PROCEDURE sp_HastaTCAra (@HastaTC varchar(11))
AS
SELECT * FROM Hasta WHERE HastaTC = @HastaTC

GO
CREATE PROCEDURE sp_DoktorAdAra (@DoktorAd varchar(25))
AS
BEGIN
DECLARE @DoktorAd2 varchar(25)
SET @DoktorAd2 = '%'+ @DoktorAd + '%'
SELECT * FROM Doktor WHERE DoktorAd LIKE @DoktorAd2
END

GO
CREATE TRIGGER tr_doktor_insert_cinse
ON Doktor
AFTER INSERT
AS
BEGIN
    UPDATE Doktor SET DoktorCinsiyet ='E' WHERE DoktorCinsiyet = 'e'
END

GO
CREATE TRIGGER tr_doktor_insert_cinsk
ON Doktor
AFTER INSERT
AS
BEGIN
   UPDATE Doktor SET DoktorCinsiyet ='K' WHERE DoktorCinsiyet = 'k' 
END

GO 
CREATE TRIGGER tr_tani_insert
ON Tani
AFTER INSERT
AS
BEGIN
    DECLARE @HastaID int
    SELECT  @HastaID = INSERTED.HastaID FROM INSERTED
    DELETE FROM Randevu WHERE HastaID = @HastaID
END