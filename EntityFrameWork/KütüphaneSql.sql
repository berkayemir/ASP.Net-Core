CREATE DATABASE KutuphaneSabah
GO

USE KutuphaneSabah
CREATE TABLE Turler
	(
		ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
		TurAd VARCHAR(30) UNIQUE
	)
GO

USE KutuphaneSabah
INSERT INTO Turler VALUES
('Ba?vuru'),('Bilgisayar'),('Edebiyat'),('Ders Kitab?')
GO

USE KutuphaneSabah
CREATE TABLE Yazarlar
	(
		ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
		AdSoyad VARCHAR(30),
		Cinsiyet VARCHAR(1),
		DogumTarihi DATE,
		Tel VARCHAR(11),
		Mail VARCHAR(40),
		TurID INT FOREIGN KEY REFERENCES Turler(ID) ON DELETE CASCADE
	)
GO
USE KutuphaneSabah
INSERT INTO Yazarlar VALUES
('Orhan Pamuk','E','1950-1-1','55555','opamuk1@gmail.com',1),
('Orhan Yamuk','E','1970-1-1','44444','opamuk3@gmail.com',2),
('Osman Pamuk','K','1960-1-1','22222','opamuk4@gmail.com',3),
('Orhan Tanuk','E','1970-1-1','99999','opamuk2@gmail.com',4)

USE KutuphaneSabah
CREATE TABLE Yayinevleri
	(
		ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
		Ad VARCHAR(50) UNIQUE,
		Adres VARCHAR(50),
		Tel VARCHAR(11)
	)
GO

USE KutuphaneSabah
INSERT INTO Yayinevleri VALUES
('K?rm?z? ?nek Yay?nevi','Beyo?lu','55555'),
('Mavi Portakal Bas?m Da??t?m','Bak?rköy','11111'),
('Turuncu Gökyüzü Yay?nlar?','Kad?köy','898989')

USE KutuphaneSabah
CREATE TABLE Uyeler
	(
		ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
		AdSoyad VARCHAR(30),
		Cinsiyet VARCHAR(1),
		DogumTarihi DATE,
		Tel VARCHAR(11),
		Mail VARCHAR(40),
		UyelikTarihi DATE,
		UyelikTipi INT,
		TcNo VARCHAR(11),
		Meslek VARCHAR(30),
		EgitimDurumu INT,
		CezaDurumu BIT
	)
GO

Use KutuphaneSabah
INSERT INTO Uyeler (AdSoyad, Cinsiyet, UyelikTipi, EgitimDurumu, CezaDurumu)
VALUES
--Üyelik Tipi: 1 ya da 2
--E?itim Durumu: 1-5 aras?nda
--Ceza Durumu: 0 ya da 1
('Ferhat Ald?verdi','E',1,3,0),
('Canan Günaçmaz','K',2,1,0),
('Ferdi Tayfur','E',2,4,0),
('Sezen Aksu','K',1,2,0),
('Tarkan Teveto?lu','E',2,4,0)
GO

USE KutuphaneSabah
CREATE TABLE Kitaplar
	(
		ISBN VARCHAR(13) NOT NULL PRIMARY KEY,
		Ad VARCHAR(100),
		SayfaSayisi INT,
		Stok INT,
		TurID INT FOREIGN KEY REFERENCES Turler(ID) ON DELETE CASCADE,
		YazarID INT FOREIGN KEY REFERENCES Yazarlar(ID),
		YayinEviID INT FOREIGN KEY REFERENCES Yayinevleri(ID) ON DELETE CASCADE
	)
GO

USE KutuphaneSabah
INSERT INTO Kitaplar (ISBN, Ad, TurID, YazarID, YayinEviID)
--TurID: 1-4
--YazarID: 1-4
--YayinEviID: 1-3
VALUES
('44444','C# Programlamaya Giri?',2,3,2),
('55555','Kara Kitap',3,1,1),
('88888','Vegan Olma Rehberi',4,2,1),
('99999','Gö?e Bakal?m',1,2,3),
('77777','E-Ticaretin Kap?lar?',2,4,1)
GO

USE KutuphaneSabah
CREATE TABLE Odunc
	(
		ID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
		UyeID INT FOREIGN KEY REFERENCES Uyeler(ID) ON DELETE CASCADE, 
		KitapISBN VARCHAR(13) FOREIGN KEY REFERENCES Kitaplar(ISBN) ON DELETE CASCADE,
		VerilisTarihi DATE,
		TeslimTarihi DATE,
		Iptal BIT
	)
GO