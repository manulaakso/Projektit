-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 20.05.2022 klo 13:24
-- Palvelimen versio: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studypoint`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `opiskelija`
--

CREATE TABLE `opiskelija` (
  `Oid` int(11) NOT NULL,
  `etunimi` varchar(25) NOT NULL,
  `sukunimi` varchar(35) NOT NULL,
  `puhelin` varchar(15) NOT NULL,
  `sahkoposti` varchar(35) NOT NULL,
  `lahiosoite` varchar(40) NOT NULL,
  `postitoimipaikka` varchar(20) NOT NULL,
  `postinro` varchar(10) NOT NULL,
  `kayttaja` varchar(10) NOT NULL,
  `salasana` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Vedos taulusta `opiskelija`
--

INSERT INTO `opiskelija` (`Oid`, `etunimi`, `sukunimi`, `puhelin`, `sahkoposti`, `lahiosoite`, `postitoimipaikka`, `postinro`, `kayttaja`, `salasana`) VALUES
(2, 'Erkki', 'Peramerkki', '045567811', 'erkki.peramerkki@miuku.fi', 'suonmutka 2', 'suomies', '034566', 'erkpera', 'eXJjM5ZLFh'),
(3, 'Katri', 'Lepola', '0445000853', 'katri.lepola@edu.keuda.fi', 'kauppatie 2 ', 'tuusula', '04300', 'katlepo', 'abc123'),
(6, 'Jyrki', 'Mörönen', '0506778125', 'jyrki.mörönen@miuku.fi', 'kauratie 5', 'Järvenpää', '04400', 'jyrmörö', 'yffovQbxBo'),
(7, 'hannu', 'Hanhi', '1123773', 'hannu.hanhi@organisaatio.duc', 'vaakkutie 5', 'ankkalinna', '011884', 'hanhanh', 'vKZHXyUIDq'),
(8, 'user', 'user', '000', 'on', 'on', 'on', '000', 'useuser', 'user'),
(9, 'admin', 'admin', '-', '-', '-', '-', '000', 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `opiskelija`
--
ALTER TABLE `opiskelija`
  ADD PRIMARY KEY (`Oid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `opiskelija`
--
ALTER TABLE `opiskelija`
  MODIFY `Oid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
