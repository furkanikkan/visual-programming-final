-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost
-- Üretim Zamanı: 03 Oca 2023, 01:09:20
-- Sunucu sürümü: 8.0.17
-- PHP Sürümü: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `siteyonetimi`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `calisanlar`
--

CREATE TABLE `calisanlar` (
  `calisanID` int(2) NOT NULL,
  `calisanAd` varchar(11) NOT NULL,
  `calisanSoyad` varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `calisanGorev` enum('Kapıcı','Temizlik Görevlisi','Güvenlik Görevlisi') CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `daireler`
--

CREATE TABLE `daireler` (
  `daireID` int(11) NOT NULL,
  `daireNo` int(11) NOT NULL,
  `aidatBorcu` float(9,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `daireler`
--

INSERT INTO `daireler` (`daireID`, `daireNo`, `aidatBorcu`) VALUES
(1, 1, 50.00),
(2, 2, 100.00),
(6, 3, 100.00),
(7, 4, 100.00);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `duyurular`
--

CREATE TABLE `duyurular` (
  `duyuruID` int(11) NOT NULL,
  `duyuruBaslik` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `duyuruIcerik` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `duyurular`
--

INSERT INTO `duyurular` (`duyuruID`, `duyuruBaslik`, `duyuruIcerik`) VALUES
(21, 'Hoşgeldiniz', 'hoşgeldiniz');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `iletisim`
--

CREATE TABLE `iletisim` (
  `iletisimID` int(11) NOT NULL,
  `iletisimNedeni` varchar(50) NOT NULL,
  `iletisimText` varchar(250) NOT NULL,
  `durum` enum('0','1') NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `Id` int(2) NOT NULL,
  `daireID` int(11) NOT NULL,
  `Ad` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Soyad` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `kullaniciAdi` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Sifre` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `aracPlaka` varchar(15) NOT NULL,
  `telefonNo` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`Id`, `daireID`, `Ad`, `Soyad`, `kullaniciAdi`, `Sifre`, `aracPlaka`, `telefonNo`) VALUES
(21, 1, 'Furkan', 'İkkan', 'furkan', '123', '16abc443', '555444444'),
(22, 2, 'Fatma', 'Turgut', 'fatma', '123', '16abc445', '555444444');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yoneticiler`
--

CREATE TABLE `yoneticiler` (
  `yoneticiID` int(11) NOT NULL,
  `kullaniciID` int(11) NOT NULL,
  `ad` varchar(50) NOT NULL,
  `soyad` varchar(50) NOT NULL,
  `kullaniciAd` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `sifre` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `yoneticiler`
--

INSERT INTO `yoneticiler` (`yoneticiID`, `kullaniciID`, `ad`, `soyad`, `kullaniciAd`, `sifre`) VALUES
(1, 25, 'Furkan', 'İkkan', 'furkan', '123');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `calisanlar`
--
ALTER TABLE `calisanlar`
  ADD PRIMARY KEY (`calisanID`);

--
-- Tablo için indeksler `daireler`
--
ALTER TABLE `daireler`
  ADD PRIMARY KEY (`daireID`);

--
-- Tablo için indeksler `duyurular`
--
ALTER TABLE `duyurular`
  ADD PRIMARY KEY (`duyuruID`);

--
-- Tablo için indeksler `iletisim`
--
ALTER TABLE `iletisim`
  ADD PRIMARY KEY (`iletisimID`);

--
-- Tablo için indeksler `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Id` (`Id`),
  ADD KEY `Id_2` (`Id`);

--
-- Tablo için indeksler `yoneticiler`
--
ALTER TABLE `yoneticiler`
  ADD PRIMARY KEY (`yoneticiID`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `calisanlar`
--
ALTER TABLE `calisanlar`
  MODIFY `calisanID` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Tablo için AUTO_INCREMENT değeri `daireler`
--
ALTER TABLE `daireler`
  MODIFY `daireID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Tablo için AUTO_INCREMENT değeri `duyurular`
--
ALTER TABLE `duyurular`
  MODIFY `duyuruID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Tablo için AUTO_INCREMENT değeri `iletisim`
--
ALTER TABLE `iletisim`
  MODIFY `iletisimID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Tablo için AUTO_INCREMENT değeri `kullanicilar`
--
ALTER TABLE `kullanicilar`
  MODIFY `Id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- Tablo için AUTO_INCREMENT değeri `yoneticiler`
--
ALTER TABLE `yoneticiler`
  MODIFY `yoneticiID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
