-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mar. 06 mars 2018 à 09:30
-- Version du serveur :  5.7.19
-- Version de PHP :  7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `world_x`
--

-- --------------------------------------------------------

--
-- Structure de la table `meteodata`
--

DROP TABLE IF EXISTS `meteodata`;
CREATE TABLE IF NOT EXISTS `meteodata` (
  `id` int(11) NOT NULL,
  `date` datetime NOT NULL,
  `temp` double NOT NULL,
  `humidity` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `meteodata`
--

INSERT INTO `meteodata` (`id`, `date`, `temp`, `humidity`) VALUES
(1, '2018-03-06 03:14:00', 33, 56),
(2, '2017-05-24 12:37:35', 31, 52),
(3, '2017-05-24 12:42:35', 29, 53),
(4, '2017-05-24 12:47:35', 29.6, 50),
(5, '2017-05-24 12:52:35', 28.6, 51),
(6, '2017-05-24 12:57:35', 28.6, 49),
(7, '2017-05-24 13:02:35', 28.4, 48),
(8, '2017-05-24 13:07:35', 28.1, 48),
(9, '2017-05-24 13:12:35', 28.5, 49),
(10, '2017-05-24 13:17:35', 29.5, 44),
(11, '2017-05-24 13:22:35', 28.6, 47),
(12, '2017-05-24 13:27:35', 28.3, 48),
(13, '2017-05-24 13:32:35', 28.8, 48),
(14, '2017-05-24 13:37:35', 28.3, 48),
(15, '2017-05-24 13:42:35', 28.2, 49),
(16, '2017-05-24 13:47:35', 28.9, 48),
(17, '2017-05-24 13:52:35', 29.1, 48),
(18, '2017-05-24 13:57:35', 28.7, 48);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
