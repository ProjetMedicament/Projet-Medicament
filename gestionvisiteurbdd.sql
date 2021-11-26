-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 26 nov. 2021 à 08:27
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
-- Base de données : `gestionvisiteurbdd`
--

-- --------------------------------------------------------

--
-- Structure de la table `labo`
--

DROP TABLE IF EXISTS `labo`;
CREATE TABLE IF NOT EXISTS `labo` (
  `LAB_CODE` char(2) NOT NULL,
  `LAB_NOM` char(10) NOT NULL,
  `LAB_CHEFVENTE` char(20) NOT NULL,
  PRIMARY KEY (`LAB_CODE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `region`
--

DROP TABLE IF EXISTS `region`;
CREATE TABLE IF NOT EXISTS `region` (
  `REG_CODE` char(2) NOT NULL,
  `SEC_CODE` char(1) NOT NULL,
  `REG_NOM` char(50) NOT NULL,
  PRIMARY KEY (`REG_CODE`),
  KEY `SEC_CODE` (`SEC_CODE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

DROP TABLE IF EXISTS `secteur`;
CREATE TABLE IF NOT EXISTS `secteur` (
  `SEC_CODE` char(1) NOT NULL,
  `SEC_LIBELLE` char(15) NOT NULL,
  PRIMARY KEY (`SEC_CODE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `travailler`
--

DROP TABLE IF EXISTS `travailler`;
CREATE TABLE IF NOT EXISTS `travailler` (
  `VIS_MATRICULE` char(10) NOT NULL,
  `JJMMAA` datetime NOT NULL,
  `REG_CODE` char(2) NOT NULL,
  `TRA_ROLE` char(11) NOT NULL,
  PRIMARY KEY (`VIS_MATRICULE`,`JJMMAA`,`REG_CODE`),
  KEY `REG_CODE` (`REG_CODE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `visiteur`
--

DROP TABLE IF EXISTS `visiteur`;
CREATE TABLE IF NOT EXISTS `visiteur` (
  `VIS_MATRICULE` char(10) NOT NULL,
  `VIS_NOM` char(25) NOT NULL,
  `VIS_PRENOM` char(50) NOT NULL,
  `VIS_ADRESSE` char(50) NOT NULL,
  `VIS_CP` char(5) NOT NULL,
  `VIS_VILLE` char(30) NOT NULL,
  `VIS_DATEEMBAUCHE` datetime NOT NULL,
  `SEC_CODE` char(1) NOT NULL,
  `LAB_CODE` char(2) NOT NULL,
  PRIMARY KEY (`VIS_MATRICULE`),
  KEY `LAB_CODE` (`LAB_CODE`),
  KEY `SEC_CODE` (`SEC_CODE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `region`
--
ALTER TABLE `region`
  ADD CONSTRAINT `region_ibfk_1` FOREIGN KEY (`SEC_CODE`) REFERENCES `secteur` (`SEC_CODE`);

--
-- Contraintes pour la table `travailler`
--
ALTER TABLE `travailler`
  ADD CONSTRAINT `travailler_ibfk_1` FOREIGN KEY (`REG_CODE`) REFERENCES `region` (`REG_CODE`);

--
-- Contraintes pour la table `visiteur`
--
ALTER TABLE `visiteur`
  ADD CONSTRAINT `visiteur_ibfk_1` FOREIGN KEY (`VIS_MATRICULE`) REFERENCES `travailler` (`VIS_MATRICULE`),
  ADD CONSTRAINT `visiteur_ibfk_2` FOREIGN KEY (`LAB_CODE`) REFERENCES `labo` (`LAB_CODE`),
  ADD CONSTRAINT `visiteur_ibfk_3` FOREIGN KEY (`SEC_CODE`) REFERENCES `secteur` (`SEC_CODE`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
