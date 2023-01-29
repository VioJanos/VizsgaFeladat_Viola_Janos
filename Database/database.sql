-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Gép: mysql.omega:3306
-- Létrehozás ideje: 2023. Jan 29. 20:05
-- Kiszolgáló verziója: 5.7.39-log
-- PHP verzió: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `vizga`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `Location`
--

CREATE TABLE `Location` (
  `Location` int(10) NOT NULL,
  `Description` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `Location`
--

INSERT INTO `Location` (`Location`, `Description`) VALUES
(11, 'Beérkezés'),
(21, 'Raktár'),
(31, 'Eladótér'),
(41, 'Külső raktár');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `Material`
--

CREATE TABLE `Material` (
  `Materialname` varchar(45) DEFAULT NULL,
  `Packing` double DEFAULT NULL,
  `Measure` varchar(10) DEFAULT NULL,
  `PartNumber` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `Material`
--

INSERT INTO `Material` (`Materialname`, `Packing`, `Measure`, `PartNumber`) VALUES
('SZJFHJR', 10, 'DB', '345'),
('WSFDVS', 10, 'Kg', '543'),
('ASFDASF', 200, 'Kg', '666');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `Permissions`
--

CREATE TABLE `Permissions` (
  `Roles_ID` int(10) NOT NULL,
  `Permission` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `Permissions`
--

INSERT INTO `Permissions` (`Roles_ID`, `Permission`) VALUES
(1, 'Admin'),
(2, 'Leader'),
(3, 'Operator');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `personal_access_tokens`
--

CREATE TABLE `personal_access_tokens` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `tokenable_type` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tokenable_id` bigint(20) UNSIGNED NOT NULL,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `abilities` text COLLATE utf8mb4_unicode_ci,
  `last_used_at` timestamp NULL DEFAULT NULL,
  `expires_at` timestamp NULL DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `PriceList`
--

CREATE TABLE `PriceList` (
  `PartNumber` varchar(45) NOT NULL,
  `Price` double DEFAULT NULL,
  `Currency` varchar(45) NOT NULL,
  `Packaging` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `PriceList`
--

INSERT INTO `PriceList` (`PartNumber`, `Price`, `Currency`, `Packaging`) VALUES
('666', 5000, 'huf', '100');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `SuplierMaterials`
--

CREATE TABLE `SuplierMaterials` (
  `ID` int(11) NOT NULL,
  `SuplierId` int(11) NOT NULL,
  `MaterialName` varchar(45) NOT NULL,
  `Packaging` varchar(45) NOT NULL,
  `Part_Number` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `Suppliers`
--

CREATE TABLE `Suppliers` (
  `Suplier_Id` int(11) NOT NULL,
  `Suplier_Name` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `Suppliers`
--

INSERT INTO `Suppliers` (`Suplier_Id`, `Suplier_Name`) VALUES
(1, 'Tesco'),
(2, 'Lidl'),
(3, 'Aldi'),
(4, 'Auchan'),
(6, 'SAS'),
(7, 'SOS');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `User`
--

CREATE TABLE `User` (
  `Employee_id` int(11) NOT NULL,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `First_name` varchar(45) DEFAULT NULL,
  `Last_name` varchar(45) DEFAULT NULL,
  `E-mail` varchar(45) DEFAULT NULL,
  `Birth` date DEFAULT NULL,
  `Permission` int(10) NOT NULL,
  `Deleted` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `User`
--

INSERT INTO `User` (`Employee_id`, `Username`, `Password`, `First_name`, `Last_name`, `E-mail`, `Birth`, `Permission`, `Deleted`) VALUES
(10, 'ImrNag10', 'SGVsbG8xMjM0NQ==', 'Imre', 'Nagy', 'teszt1@proba', '1994-11-16', 1, 0),
(22, 'IboHor22', 'SGVsbG8xMjM0NQ==', 'Ibolya', 'Horváth', 'teszt@g', '2022-10-31', 1, 0),
(23, 'KinHor23', 'QXNkMTIzNDU=', 'Kinga', 'Horváth', 'teszt2@teszt', '2022-07-25', 1, 0),
(24, 'GizTes24', 'SGVsbG8xMjM0NQ==', 'Gizike', 'Horcsa', 'haha@aaa', '2022-10-31', 3, 1),
(25, 'DávRóz25', 'RGVmYXVsdDEyMzQ=', 'Dávid', 'Rózsa', 'admin@teszt', '2022-10-31', 1, 0),
(26, 'JánVio26', 'RGVmYXVsdDEyMzQ=', 'János', 'Viola', 'admin@teszt', '2022-10-31', 1, 0);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `WarehouseStock`
--

CREATE TABLE `WarehouseStock` (
  `PartNumber` varchar(45) NOT NULL,
  `Pcs` int(11) DEFAULT NULL,
  `Location` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `WarehouseStock`
--

INSERT INTO `WarehouseStock` (`PartNumber`, `Pcs`, `Location`) VALUES
('345', 100180, 11),
('345', 150, 21),
('345', 100, 31),
('345', 100, 41),
('543', 150, 11),
('543', 100, 21),
('543', 100, 31),
('543', 100, 41),
('666', 49, 11),
('666', 0, 21),
('666', -10, 31),
('666', 1, 41);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `Location`
--
ALTER TABLE `Location`
  ADD PRIMARY KEY (`Location`);

--
-- A tábla indexei `Material`
--
ALTER TABLE `Material`
  ADD PRIMARY KEY (`PartNumber`);

--
-- A tábla indexei `Permissions`
--
ALTER TABLE `Permissions`
  ADD PRIMARY KEY (`Roles_ID`);

--
-- A tábla indexei `personal_access_tokens`
--
ALTER TABLE `personal_access_tokens`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `personal_access_tokens_token_unique` (`token`),
  ADD KEY `personal_access_tokens_tokenable_type_tokenable_id_index` (`tokenable_type`,`tokenable_id`);

--
-- A tábla indexei `PriceList`
--
ALTER TABLE `PriceList`
  ADD PRIMARY KEY (`PartNumber`) USING BTREE,
  ADD UNIQUE KEY `PartNumber_UNIQUE` (`PartNumber`);

--
-- A tábla indexei `SuplierMaterials`
--
ALTER TABLE `SuplierMaterials`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `SuplierId` (`SuplierId`),
  ADD KEY `Part_Number` (`Part_Number`);

--
-- A tábla indexei `Suppliers`
--
ALTER TABLE `Suppliers`
  ADD PRIMARY KEY (`Suplier_Id`);

--
-- A tábla indexei `User`
--
ALTER TABLE `User`
  ADD PRIMARY KEY (`Employee_id`),
  ADD KEY `Title_idx` (`Permission`);

--
-- A tábla indexei `WarehouseStock`
--
ALTER TABLE `WarehouseStock`
  ADD KEY `Location` (`Location`) USING BTREE,
  ADD KEY `PartNumber` (`PartNumber`) USING BTREE;

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `Permissions`
--
ALTER TABLE `Permissions`
  MODIFY `Roles_ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `personal_access_tokens`
--
ALTER TABLE `personal_access_tokens`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `SuplierMaterials`
--
ALTER TABLE `SuplierMaterials`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `Suppliers`
--
ALTER TABLE `Suppliers`
  MODIFY `Suplier_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT a táblához `User`
--
ALTER TABLE `User`
  MODIFY `Employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `PriceList`
--
ALTER TABLE `PriceList`
  ADD CONSTRAINT `PriceList_ibfk_1` FOREIGN KEY (`PartNumber`) REFERENCES `Material` (`PartNumber`);

--
-- Megkötések a táblához `SuplierMaterials`
--
ALTER TABLE `SuplierMaterials`
  ADD CONSTRAINT `SuplierMaterials_ibfk_1` FOREIGN KEY (`Part_Number`) REFERENCES `Material` (`PartNumber`),
  ADD CONSTRAINT `Supliers` FOREIGN KEY (`SuplierId`) REFERENCES `Suppliers` (`Suplier_Id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Megkötések a táblához `User`
--
ALTER TABLE `User`
  ADD CONSTRAINT `User_ibfk_1` FOREIGN KEY (`Permission`) REFERENCES `Permissions` (`Roles_ID`);

--
-- Megkötések a táblához `WarehouseStock`
--
ALTER TABLE `WarehouseStock`
  ADD CONSTRAINT `WarehouseStock_ibfk_1` FOREIGN KEY (`Location`) REFERENCES `Location` (`Location`),
  ADD CONSTRAINT `WarehouseStock_ibfk_2` FOREIGN KEY (`PartNumber`) REFERENCES `Material` (`PartNumber`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
