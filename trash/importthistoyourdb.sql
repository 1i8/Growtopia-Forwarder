-- Adminer 4.7.5 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';

SET NAMES utf8mb4;

CREATE DATABASE `accdbase` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `accdbase`;

DROP TABLE IF EXISTS `accounts`;
CREATE TABLE `accounts` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `namehash` text COLLATE utf8_unicode_ci DEFAULT NULL,
  `passhash` text COLLATE utf8_unicode_ci DEFAULT NULL,
  `identifier` text COLLATE utf8_unicode_ci DEFAULT NULL,
  `expiry` datetime DEFAULT NULL,
  `ip` text COLLATE utf8_unicode_ci DEFAULT NULL,
  `blacklist` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- 2020-06-08 13:10:40