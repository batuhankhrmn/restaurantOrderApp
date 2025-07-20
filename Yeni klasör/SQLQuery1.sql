--create database Restaurant;
--use Restaurant;
CREATE TABLE Kullanicilar (
    KullaniciID INT PRIMARY KEY IDENTITY,
    AdSoyad NVARCHAR(100),
    KullaniciAdi NVARCHAR(50) UNIQUE,
    Sifre NVARCHAR(100),
);
CREATE TABLE Masalar (
    MasaID INT PRIMARY KEY IDENTITY,
    MasaAdi NVARCHAR(50),
    Durum BIT -- 0 = Boþ, 1 = Dolu
);
CREATE TABLE Kategoriler (
    KategoriID INT PRIMARY KEY IDENTITY,
    KategoriAdi NVARCHAR(100)
);
CREATE TABLE Urunler (
    UrunID INT PRIMARY KEY IDENTITY,
    UrunAdi NVARCHAR(100),
    Fiyat DECIMAL(10,2),
    KategoriID INT FOREIGN KEY REFERENCES Kategoriler(KategoriID),
    Stok INT
);
CREATE TABLE Siparisler (
    SiparisID INT PRIMARY KEY IDENTITY,
    MasaID INT FOREIGN KEY REFERENCES Masalar(MasaID),
    KullaniciID INT FOREIGN KEY REFERENCES Kullanicilar(KullaniciID),
    TarihSaat DATETIME DEFAULT GETDATE(),
    Durum NVARCHAR(20) -- 'Açýk', 'Kapalý'
);
CREATE TABLE SiparisDetaylari (
    DetayID INT PRIMARY KEY IDENTITY,
    SiparisID INT FOREIGN KEY REFERENCES Siparisler(SiparisID),
    UrunID INT FOREIGN KEY REFERENCES Urunler(UrunID),
    Adet INT,
    ToplamTutar DECIMAL(10,2)
);
CREATE TABLE Odemeler (
    OdemeID INT PRIMARY KEY IDENTITY,
    SiparisID INT FOREIGN KEY REFERENCES Siparisler(SiparisID),
    OdemeTuru NVARCHAR(20), -- 'Nakit', 'Kredi Kartý' vs.
    Tutar DECIMAL(10,2),
    TarihSaat DATETIME DEFAULT GETDATE()
);



