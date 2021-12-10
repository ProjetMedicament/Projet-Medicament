-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 10 déc. 2021 à 08:19
-- Version du serveur :  5.7.31
-- Version de PHP : 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bddgestionvisiteur`
--

-- --------------------------------------------------------

--
-- Structure de la table `travailler`
--

DROP TABLE IF EXISTS `travailler`;
CREATE TABLE IF NOT EXISTS `travailler` (
  `matriculeVisiteur` int(10) NOT NULL,
  `date` datetime NOT NULL,
  `codeRegion` int(2) NOT NULL,
  `roleTravailler` char(25) NOT NULL,
  PRIMARY KEY (`matriculeVisiteur`,`date`,`codeRegion`),
  KEY `codeRegion` (`codeRegion`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `travailler`
--

INSERT INTO `travailler` (`matriculeVisiteur`, `date`, `codeRegion`, `roleTravailler`) VALUES
(1, '2021-06-10 09:13:35', 1, 'Safranier'),
(2, '2021-12-06 08:53:28', 1, 'Biologiste'),
(3, '2021-08-17 09:13:35', 3, 'Radiopharmacien'),
(4, '2021-12-07 09:07:18', 6, 'Technicien de Laboratoire'),
(5, '2021-09-02 09:12:26', 13, 'Microbiologiste'),
(6, '2020-10-15 09:14:52', 3, 'Ingénieur Biomédical'),
(7, '2020-07-16 09:14:52', 10, 'Biologiste moléculaire'),
(8, '2021-06-03 09:16:31', 5, 'Formulateur'),
(9, '2021-01-14 09:16:31', 1, 'Délégué Pharmaceutique'),
(10, '2021-11-17 09:07:18', 5, 'Chercheur'),
(11, '2021-04-22 09:12:26', 12, 'Péparateur'),
(12, '2020-03-27 09:18:21', 10, 'Directeur R&D');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `travailler`
--
ALTER TABLE `travailler`
  ADD CONSTRAINT `travailler_ibfk_1` FOREIGN KEY (`matriculeVisiteur`) REFERENCES `visiteur` (`matriculeVisiteur`),
  ADD CONSTRAINT `travailler_ibfk_2` FOREIGN KEY (`codeRegion`) REFERENCES `region` (`codeRegion`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
