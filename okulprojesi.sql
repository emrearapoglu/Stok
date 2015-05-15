-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 16 May 2015, 00:45:28
-- Sunucu sürümü: 5.6.20
-- PHP Sürümü: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Veritabanı: `okulprojesi`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `admins`
--

CREATE TABLE IF NOT EXISTS `admins` (
`id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `isim` varchar(50) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Tablo döküm verisi `admins`
--

INSERT INTO `admins` (`id`, `username`, `password`, `isim`) VALUES
(1, 'root', 'root', 'root');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ilac`
--

CREATE TABLE IF NOT EXISTS `ilac` (
`id` int(11) NOT NULL,
  `ad` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `barkod` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `tur` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `stok` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `aciklama` text CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `fiyat` double NOT NULL,
  `GeriOdemeKodu` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Tablo döküm verisi `ilac`
--

INSERT INTO `ilac` (`id`, `ad`, `barkod`, `tur`, `stok`, `aciklama`, `fiyat`, `GeriOdemeKodu`) VALUES
(1, 'APRANAX FORTE 550 mg', '8699514010258', 'Tablet', '120', 'Yerli ve Beseri bir ilaçdir.', 7, 'A00830'),
(2, 'asdasd', '222222222', 'Implant sistem', '22', 'asdasdasdasd', 332, 'aasda'),
(3, 'ccc', '213123', 'Sampuan', '1', '2323232323', 23, '3232323'),
(4, 'jhk', '123213213', 'Ampul', '2', '4444444', 4, '4444');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `admins`
--
ALTER TABLE `admins`
 ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `ilac`
--
ALTER TABLE `ilac`
 ADD PRIMARY KEY (`id`), ADD UNIQUE KEY `ad` (`ad`), ADD UNIQUE KEY `barkod` (`barkod`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `admins`
--
ALTER TABLE `admins`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- Tablo için AUTO_INCREMENT değeri `ilac`
--
ALTER TABLE `ilac`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
