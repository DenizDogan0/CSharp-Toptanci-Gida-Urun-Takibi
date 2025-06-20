# Host: localhost  (Version 5.5.5-10.4.32-MariaDB)
# Date: 2025-03-02 00:27:13
# Generator: MySQL-Front 6.0  (Build 2.13)


#
# Structure for table "kategoriler"
#

DROP TABLE IF EXISTS `kategoriler`;
CREATE TABLE `kategoriler` (
  `kategori_id` int(11) NOT NULL AUTO_INCREMENT,
  `kategori_adi` varchar(50) NOT NULL,
  PRIMARY KEY (`kategori_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

#
# Data for table "kategoriler"
#

INSERT INTO `kategoriler` VALUES (1,'Temel Gıda Ürünleri'),(2,'Atıştırmalıklar'),(3,'İçecekler'),(4,'Kahvaltılık Ürünler'),(5,'Hazır Yemek Ve Konserveler'),(6,'Baharatlar Ve Çeşniler'),(7,'Unlu Mamüller'),(8,'Süt ve Süt Ürünleri'),(9,'Et ve Et Ürünleri'),(10,'Deniz Ürünleri'),(11,'Meyve ve Sebzeler'),(12,'Dondurulmuş Gıdalar');

#
# Structure for table "urunler"
#

DROP TABLE IF EXISTS `urunler`;
CREATE TABLE `urunler` (
  `urun_id` int(11) NOT NULL AUTO_INCREMENT,
  `urun_adi` varchar(100) NOT NULL,
  `kategori_id` int(11) DEFAULT NULL,
  `birim_fiyat` decimal(10,2) NOT NULL,
  `stok_miktari` int(11) NOT NULL,
  `birim` varchar(20) NOT NULL,
  `maliyet` decimal(10,2) NOT NULL DEFAULT 0.00,
  PRIMARY KEY (`urun_id`),
  KEY `kategori_id` (`kategori_id`),
  CONSTRAINT `urunler_ibfk_1` FOREIGN KEY (`kategori_id`) REFERENCES `kategoriler` (`kategori_id`)
) ENGINE=InnoDB AUTO_INCREMENT=94 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

#
# Data for table "urunler"
#

INSERT INTO `urunler` VALUES (1,'Nohut',1,30.00,4000,'Kilogram',9.60),(2,'Fasülye',1,24.00,1491,'Kilogram',19.20),(3,'Mercimek',1,6.00,196,'Adet',4.80),(4,'Süt',2,18.60,200,'Litre',14.88),(5,'Deterjan',3,54.90,80,'Adet',43.92),(6,'Çamaşır Suyu',3,24.00,120,'Litre',19.20),(9,'Pirinc Ve Bulgur',1,36.00,200,'Kilogram',28.80),(10,'Makarna Ve Şehriye',1,120.00,190,'Kilogram',96.00),(11,'Un Ve Unlu Mamüller',1,180.00,230,'Kilogram',144.00),(12,'Sıvı Yağlar',1,360.00,1100,'Litre',288.00),(13,'Şeker Ve Tatlandırıcılar',1,66.00,500,'Kilogram',52.80),(14,'Çikolata Ve Gofretler',2,60.00,2235,'Adet',48.00),(15,'Bisküvi Ve Krakerler',2,66.00,1240,'Adet',52.80),(16,'Cipsler',2,66.00,2500,'Adet',52.80),(17,'Kuruyemiş',2,180.00,747,'Kilogram',144.00),(18,'Şekerlemeler',2,42.00,1700,'Adet',33.60),(19,'Çay Ve Kahveler',3,204.00,465,'Kilogram',163.20),(20,'Meyve Suları',3,38.40,800,'Adet',30.72),(21,'Gazlı İçecekler',3,66.00,800,'Litre',52.80),(22,'Su Ve Maden Suları',3,48.00,17990,'Litre',38.40),(23,'Enerji İçecekleri',3,90.00,1500,'Adet',72.00),(24,'Peynir Çeşitleri',4,330.00,1800,'Kilogram',264.00),(25,'Zeytin',4,300.00,1030,'Kilogram',240.00),(26,'Reçel Ve Bal',4,480.00,544,'Kilogram',384.00),(27,'Yumurta',4,12.00,5400,'Adet',9.60),(28,'Şarküteri Üürnleri',4,144.00,400,'Adet',115.20),(29,'Hazır Çorbalar',5,60.00,12000,'Adet',48.00),(30,'Konserve Çorbalar',5,90.00,2990,'Adet',72.00),(31,'Konserve Meyveler',5,240.00,3000,'Adet',192.00),(32,'Hazır Yemekler',5,180.00,1600,'Adet',144.00),(33,'Salçaalar',5,420.00,1200,'Adet',336.00),(34,'Tuz Ve Karabiber',6,84.00,1870,'Kilogram',67.20),(35,'Kaışık Baharatlar',6,180.00,800,'Kilogram',144.00),(36,'Soslar ve Çeşnilier',6,240.00,800,'Kilogram',192.00),(37,'Sirke Ve Limon Suyu',6,240.00,1200,'Litre',192.00),(38,'Ekmek Çeşitleri',7,36.00,1200,'Adet',28.80),(39,'Simit Ve Poğacca',7,43.20,400,'Adet',34.56),(40,'Kek Ve Pasta',7,90.00,400,'Adet',72.00),(41,'Kurabiye',7,144.00,800,'Adet',115.20),(42,'Börek Çeşitleri',7,72.00,800,'Adet',57.60),(43,'Kraker Ve Galeta',7,60.00,1000,'Adet',48.00),(44,'Yufka Ve Lavaş',7,12.00,12324,'Adet',9.60),(45,'Tam Yağlı Süt',8,66.00,800,'Litre',52.80),(46,'Yarım Yağlı Süt',8,60.00,900,'Litre',48.00),(47,'Yağsız Süt',8,52.80,759,'Litre',42.24),(48,'Yoğurt',8,180.00,800,'Adet',144.00),(49,'Ayran',8,66.00,1200,'Litre',52.80),(50,'Beyaz Peynir',8,336.00,1200,'Adet',268.80),(51,'Kaşar Peyniri',8,300.00,1000,'Adet',192.00),(52,'Tulum Peyniri',8,420.00,400,'Kliogram',336.00),(53,'Tereyağı',8,720.00,1000,'Kilogram',576.00),(54,'Margarin',8,120.00,90,'Kilogram',96.00),(55,'Kaymak',8,360.00,760,'Kilogram',288.00),(56,'Dondurma',8,66.00,3000,'Kilogram',52.80),(57,'Kefir',8,120.00,430,'Litre',96.00),(58,'Dana Eti',9,960.00,480,'Kilogram',768.00),(59,'Kuzu Eti',9,840.00,900,'Kilogram',672.00),(60,'Koyun Eti',9,720.00,700,'Kilogram',576.00),(61,'Tavuk Eti',9,240.00,14000,'Kilogram',192.00),(62,'Hindi Eti',9,1680.00,600,'Kilogram',1344.00),(63,'Sucuk ',9,480.00,300,'Kilogram',384.00),(64,'Sosis',9,324.00,400,'Kilogram',259.20),(65,'Pastırm',9,1440.00,600,'Kilogram',1152.00),(66,'Salam',9,360.00,400,'Kilogram',288.00),(67,'Kavurma',9,960.00,1200,'Kilogram',768.00),(68,'Sakatat',9,600.00,400,'Kilogram',480.00),(69,'Hamsi',10,120.00,1190,'Kilogram',96.00),(70,'Çipura',10,240.00,500,'Kilogram',192.00),(71,'Karides',10,360.00,1200,'Kilogram',288.00),(72,'Kalamar',10,240.00,500,'Kilogram',192.00),(73,'Midye',10,120.00,3000,'Kilogram',96.00),(74,'Ahtapot',10,360.00,500,'Kilogram',288.00),(75,'İstiridye',10,360.00,2000,'Kilogram',288.00),(76,'Yengeç',10,600.00,1000,'Kilogram',480.00),(78,'Armut',11,120.00,1000,'Kilogram',96.00),(79,'Portakal',11,120.00,120,'Kiogram',96.00),(80,'Kurutulmuş Meyveler',11,360.00,1000,'Kilogram',288.00),(81,'Turunçgiller',11,240.00,1000,'Kilogram',192.00),(82,'Yeşil Yapraklı Sebzeler',11,120.00,390,'Kilogram',96.00),(83,'Kok Sebzeler',11,240.00,190,'Kilogram',192.00),(84,'Egzotik Meyveler',11,360.00,1000,'Kilogram',288.00),(85,'Mantar Çeşitleri',11,180.00,100,'Kilogram',144.00),(87,'Dondurulmuş Meyveler',12,240.00,1000,'Kilogram',192.00),(88,'Dondurulmuş Et Ürünleri',12,1080.00,980,'Kilogram',864.00),(89,'Dondurumuş Deniz Ürünleri',12,960.00,400,'Kilogram',768.00),(90,'Dondurulmuş Hazır Yemekler',12,360.00,100,'Adet',288.00),(91,'Dondurulmuş Hamur İşleri',12,480.00,200,'Adet',384.00),(92,'Mandalina',11,40.00,1500,'',32.00),(93,'elma',11,35.00,1200,'',0.00);

#
# Structure for table "stok_hareketleri"
#

DROP TABLE IF EXISTS `stok_hareketleri`;
CREATE TABLE `stok_hareketleri` (
  `hareket_id` int(11) NOT NULL AUTO_INCREMENT,
  `urun_id` int(11) DEFAULT NULL,
  `miktar` int(11) NOT NULL,
  `hareket_tipi` enum('Giriş','Çıkış') NOT NULL,
  `tarih` datetime DEFAULT current_timestamp(),
  `aciklama` text DEFAULT NULL,
  PRIMARY KEY (`hareket_id`),
  KEY `urun_id` (`urun_id`),
  CONSTRAINT `stok_hareketleri_ibfk_1` FOREIGN KEY (`urun_id`) REFERENCES `urunler` (`urun_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

#
# Data for table "stok_hareketleri"
#

INSERT INTO `stok_hareketleri` VALUES (1,1,1,'Çıkış','2025-03-01 05:52:19','Sipariş ID 1 için stok çıkışı'),(2,3,4,'Çıkış','2025-03-01 05:52:19','Sipariş ID 1 için stok çıkışı'),(3,2,1,'Çıkış','2025-03-01 05:52:19','Sipariş ID 2 için stok çıkışı'),(4,5,1,'Çıkış','2025-03-01 05:52:19','Sipariş ID 2 için stok çıkışı'),(5,4,50,'Giriş','2025-03-01 05:52:19','Yeni stok girişi'),(6,6,30,'Giriş','2025-03-01 05:52:19','Yeni stok girişi');

#
# Structure for table "uyeler"
#

DROP TABLE IF EXISTS `uyeler`;
CREATE TABLE `uyeler` (
  `uye_id` int(11) NOT NULL AUTO_INCREMENT,
  `kullanici_adi` varchar(50) NOT NULL,
  `sifre` varchar(255) NOT NULL,
  `ad` varchar(50) NOT NULL,
  `soyad` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `telefon` varchar(15) DEFAULT NULL,
  `adres` text DEFAULT NULL,
  `firma_adi` varchar(100) DEFAULT NULL,
  `vergi_no` varchar(20) DEFAULT NULL,
  `kayit_tarihi` datetime DEFAULT current_timestamp(),
  `onay_durumu` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`uye_id`),
  UNIQUE KEY `kullanici_adi` (`kullanici_adi`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

#
# Data for table "uyeler"
#

INSERT INTO `uyeler` VALUES (1,'ahmet123','18e8df240ddd4e8b778961056ae40b65a3417c0e806410a66c66775c7b7152a3','Ahmet','Yılmaz','ahmet@example.com','5551234567','İstanbul, Türkiye','Ahmet Ticaret','1234567890','2025-03-01 05:52:19',0),(2,'ayse456','ea6e826421b119e19506d554375c5632607377fffcfbe2f46459b9e94b75e728','Ayşe','Kara','ayse@example.com','5559876543','Ankara, Türkiye','Ayşe Ltd. Şti.','9876543210','2025-03-01 05:52:19',0),(4,'deniz','3344','deniz','dogan','denizdogan@gmail.com','05347330344','mersin mezitli\t','deniz toptancı','3344','2001-04-19 00:00:00',1),(5,'asya','3344','asya','varlıklı','asyavarlıklı@gmail.com','05347330345','mersin\t','asya aş','1234','2003-10-19 00:00:00',1);

#
# Structure for table "siparisler"
#

DROP TABLE IF EXISTS `siparisler`;
CREATE TABLE `siparisler` (
  `siparis_id` int(11) NOT NULL AUTO_INCREMENT,
  `uye_id` int(11) DEFAULT NULL,
  `siparis_tarihi` datetime DEFAULT current_timestamp(),
  `toplam_tutar` decimal(10,2) NOT NULL,
  `durum` varchar(20) DEFAULT 'Beklemede',
  PRIMARY KEY (`siparis_id`),
  KEY `uye_id` (`uye_id`),
  CONSTRAINT `siparisler_ibfk_1` FOREIGN KEY (`uye_id`) REFERENCES `uyeler` (`uye_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

#
# Data for table "siparisler"
#

INSERT INTO `siparisler` VALUES (1,1,'2025-03-01 05:52:19',5020.00,'Tamamlandı'),(2,2,'2025-03-01 05:52:19',3045.75,'Onaylandı'),(3,4,'2025-03-01 17:15:56',3900.00,'İptal Edildi'),(4,4,'2025-03-01 17:17:13',21450.00,'Kargoya Verildi'),(5,4,'2025-03-01 19:38:11',3720.00,'Beklemede'),(6,4,'2025-03-02 00:15:57',25200.00,'İptal Edildi'),(7,5,'2025-03-02 00:23:50',14880.00,'Onaylandı');

#
# Structure for table "siparis_detaylari"
#

DROP TABLE IF EXISTS `siparis_detaylari`;
CREATE TABLE `siparis_detaylari` (
  `siparis_detay_id` int(11) NOT NULL AUTO_INCREMENT,
  `siparis_id` int(11) DEFAULT NULL,
  `urun_id` int(11) DEFAULT NULL,
  `miktar` int(11) NOT NULL,
  `birim_fiyat` decimal(10,2) NOT NULL,
  PRIMARY KEY (`siparis_detay_id`),
  KEY `siparis_detaylari_ibfk_2` (`urun_id`),
  KEY `siparis_detaylari_ibfk_1` (`siparis_id`),
  CONSTRAINT `siparis_detaylari_ibfk_1` FOREIGN KEY (`siparis_id`) REFERENCES `siparisler` (`siparis_id`) ON DELETE CASCADE,
  CONSTRAINT `siparis_detaylari_ibfk_2` FOREIGN KEY (`urun_id`) REFERENCES `urunler` (`urun_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

#
# Data for table "siparis_detaylari"
#

INSERT INTO `siparis_detaylari` VALUES (1,1,1,1,5000.00),(2,1,3,4,5.00),(3,2,2,1,3000.00),(4,2,5,1,45.75),(5,3,1,10,10.00),(6,3,9,10,30.00),(7,3,11,10,150.00),(8,3,14,10,50.00),(9,3,32,10,150.00),(10,4,1,10,10.00),(11,4,6,30,20.00),(12,4,10,10,100.00),(13,4,30,10,75.00),(14,4,58,10,800.00),(15,4,83,10,200.00),(16,4,88,10,900.00),(17,5,19,10,204.00),(18,5,22,10,48.00),(19,5,15,10,66.00),(20,5,17,3,180.00),(21,6,1,12,12.00),(22,6,6,24,24.00),(23,6,35,12,180.00),(24,6,52,12,420.00),(25,6,84,12,360.00),(26,6,88,12,1080.00),(27,7,2,10,24.00),(28,7,44,20,12.00),(29,7,69,10,120.00),(30,7,82,10,120.00),(31,7,88,10,1080.00),(32,7,54,10,120.00);

#
# Structure for table "yoneticiler"
#

DROP TABLE IF EXISTS `yoneticiler`;
CREATE TABLE `yoneticiler` (
  `yonetici_id` int(11) NOT NULL AUTO_INCREMENT,
  `kullanici_adi` varchar(50) NOT NULL,
  `sifre` varchar(255) NOT NULL,
  `ad` varchar(50) NOT NULL,
  `soyad` varchar(50) NOT NULL,
  PRIMARY KEY (`yonetici_id`),
  UNIQUE KEY `kullanici_adi` (`kullanici_adi`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

#
# Data for table "yoneticiler"
#

INSERT INTO `yoneticiler` VALUES (1,'admin','admin','Deniz','Doğan'),(2,'moderator','moderator','Mehmet Deniz','Doğan'),(3,'deniz','deniz123','deniz','dogan');
