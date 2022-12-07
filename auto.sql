-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Dec 07. 15:47
-- Kiszolgáló verziója: 10.4.22-MariaDB
-- PHP verzió: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `autok`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `auto`
--

CREATE TABLE `auto` (
  `id` int(11) NOT NULL,
  `rendszam` varchar(100) NOT NULL,
  `forgalomba` tinyint(1) NOT NULL DEFAULT 1,
  `tulajdonos` varchar(300) NOT NULL,
  `utolsomuszaki` date NOT NULL,
  `evjarat` date NOT NULL,
  `marka` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `auto`
--

INSERT INTO `auto` (`id`, `rendszam`, `forgalomba`, `tulajdonos`, `utolsomuszaki`, `evjarat`, `marka`) VALUES
(1, 'hsfd-hjkjl', 1, 'fghjhgj', '2022-02-18', '2009-06-12', 'Opel'),
(2, 'sdffdg', 0, 'uioukol', '2022-05-03', '2014-06-08', 'Honda'),
(3, 'dfgfgh', 0, 'zuijk', '2004-01-23', '2003-03-02', 'Suzuki');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `auto`
--
ALTER TABLE `auto`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `auto`
--
ALTER TABLE `auto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
