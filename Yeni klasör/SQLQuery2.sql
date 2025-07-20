INSERT INTO Masalar (MasaAdi, Durum) VALUES
('Bahce1', 0), ('Bahce2', 0), ('Bahce3', 0), ('Bahce4', 0),
('Bahce5', 0), ('Bahce6', 0), ('Bahce7', 0), ('Bahce8', 0),
('Ana1', 0), ('Ana2', 0), ('Ana3', 0), ('Ana4', 0), ('Ana5', 0), ('Ana6', 0),
('Giris1', 0), ('Giris2', 0), ('Giris3', 0), ('Giris4', 0);

INSERT INTO Kullanicilar (AdSoyad, KullaniciAdi, Sifre) VALUES
('Admin', 'admin', 12345);

INSERT INTO Urunler (UrunAdi, Fiyat, KategoriID, Stok)
VALUES 
('Pizza', 120.00, 1, 100), -- 1 = Yemek
('Kola', 25.00, 2, 100),   -- 2 = Ýçecek
('Baklava', 45.00, 3, 50); -- 3 = Tatlý

INSERT INTO Kategoriler (KategoriAdi) VALUES 
('Yemek'), 
('Ýçecek'), 
('Tatlý');