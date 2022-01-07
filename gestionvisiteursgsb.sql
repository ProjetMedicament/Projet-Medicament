-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 07 jan. 2022 à 10:53
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestionvisiteursgsb`
--

-- --------------------------------------------------------

--
-- Structure de la table `labo`
--

DROP TABLE IF EXISTS `labo`;
CREATE TABLE IF NOT EXISTS `labo` (
  `LAB_CODE` int(2) NOT NULL AUTO_INCREMENT,
  `LAB_NOM` varchar(10) NOT NULL,
  `LAB_CHEFVENTE` varchar(20) NOT NULL,
  PRIMARY KEY (`LAB_CODE`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `labo`
--

INSERT INTO `labo` (`LAB_CODE`, `LAB_NOM`, `LAB_CHEFVENTE`) VALUES
(1, 'Sanofi', 'Guillaume Potin'),
(2, 'Vicks', 'Pierre Paitrault'),
(3, 'Pileje', 'Bruno Geffroy'),
(4, 'Parodontax', 'S.Chavigneaud'),
(5, 'Boiron', 'Stéphane Pennanguer'),
(6, 'Glaxo', 'Katia Nogueira'),
(7, 'Urgo', 'Edouard Mermet'),
(8, 'Merck', 'Jean-Charles Wirth'),
(9, 'Panpharma', 'Josiane Guyon'),
(10, 'Quies', 'Constance Montillot'),
(11, 'XLS', 'Marine Alberton'),
(12, 'Bayer', 'Sophie Mure'),
(13, 'Biogaran', 'Christophe Hequette'),
(14, 'Advil', 'Judith Benayoun'),
(15, 'Synthol', 'Nicolas Menissier');

-- --------------------------------------------------------

--
-- Structure de la table `region`
--

DROP TABLE IF EXISTS `region`;
CREATE TABLE IF NOT EXISTS `region` (
  `REG_CODE` int(2) NOT NULL AUTO_INCREMENT,
  `SEC_CODE` int(1) NOT NULL,
  `REG_NOM` varchar(50) NOT NULL,
  PRIMARY KEY (`REG_CODE`),
  KEY `SEC_CODE` (`SEC_CODE`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `region`
--

INSERT INTO `region` (`REG_CODE`, `SEC_CODE`, `REG_NOM`) VALUES
(16, 21, 'Bretagne'),
(17, 16, 'Corse'),
(18, 29, 'Île-de-France'),
(19, 17, 'Grand-Est'),
(20, 19, 'Nouvelle-Aquitaine'),
(21, 20, 'Auvergne-Rhône-Alpes'),
(22, 22, 'Bourgogne-Franche-Comté'),
(23, 23, 'Centre-Val de Loire'),
(24, 24, 'Occitanie'),
(25, 25, 'Normandie'),
(26, 26, 'Pays de la Loire'),
(27, 27, 'Provence-Alpes-Côte d\'Azur'),
(28, 20, 'Hauts-de-France');

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

DROP TABLE IF EXISTS `secteur`;
CREATE TABLE IF NOT EXISTS `secteur` (
  `SEC_CODE` int(1) NOT NULL AUTO_INCREMENT,
  `SEC_LIBELLE` varchar(15) NOT NULL,
  PRIMARY KEY (`SEC_CODE`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`SEC_CODE`, `SEC_LIBELLE`) VALUES
(16, 'Acupuncture'),
(17, 'Agent Thermal'),
(18, 'Soignants'),
(19, 'Allergies'),
(20, 'Ambulance'),
(21, 'Anesthésie'),
(22, 'Animalier'),
(23, 'Infirmerie'),
(24, 'Dentaire'),
(25, 'Audioprothèses'),
(26, 'Puériculture'),
(27, 'Brancardier'),
(28, 'Cardiologie'),
(29, 'Chirurgie'),
(30, 'Dermatologie');

-- --------------------------------------------------------

--
-- Structure de la table `travailler`
--

DROP TABLE IF EXISTS `travailler`;
CREATE TABLE IF NOT EXISTS `travailler` (
  `VIS_MATRICULE` int(10) NOT NULL,
  `JJMMAA` datetime NOT NULL,
  `REG_CODE` int(2) NOT NULL,
  `TRA_ROLE` varchar(50) NOT NULL,
  PRIMARY KEY (`JJMMAA`) USING BTREE,
  KEY `REG_CODE` (`REG_CODE`),
  KEY `VIS_MATRICULE` (`VIS_MATRICULE`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `travailler`
--

INSERT INTO `travailler` (`VIS_MATRICULE`, `JJMMAA`, `REG_CODE`, `TRA_ROLE`) VALUES
(14, '2020-03-27 09:18:21', 26, 'Directeur R&D'),
(7, '2020-07-16 09:14:52', 23, 'Biologiste moléculaire'),
(15, '2020-10-15 09:14:52', 25, 'Ingénieur Biomédical'),
(9, '2021-01-14 09:16:31', 18, 'Délégué Pharmaceutique'),
(8, '2021-04-22 09:12:26', 20, 'Péparateur'),
(6, '2021-06-03 09:16:31', 19, 'Formulateur'),
(1, '2021-06-10 09:13:35', 16, 'Safranier'),
(3, '2021-08-17 09:13:35', 21, 'Radiopharmacien'),
(5, '2021-09-02 09:12:26', 24, 'Microbiologiste'),
(12, '2021-11-17 09:07:18', 17, 'Chercheur'),
(2, '2021-12-06 08:53:28', 23, 'Biologiste'),
(4, '2021-12-07 09:07:18', 22, 'Technicien de Laboratoire');

-- --------------------------------------------------------

--
-- Structure de la table `visiteur`
--

DROP TABLE IF EXISTS `visiteur`;
CREATE TABLE IF NOT EXISTS `visiteur` (
  `VIS_MATRICULE` int(10) NOT NULL AUTO_INCREMENT,
  `VIS_NOM` varchar(25) NOT NULL,
  `VIS_PRENOM` varchar(50) NOT NULL,
  `VIS_ADRESSE` varchar(50) NOT NULL,
  `VIS_CP` varchar(5) NOT NULL,
  `VIS_VILLE` varchar(30) NOT NULL,
  `VIS_DATEEMBAUCHE` datetime NOT NULL,
  `SEC_CODE` int(1) DEFAULT NULL,
  `LAB_CODE` int(2) DEFAULT NULL,
  PRIMARY KEY (`VIS_MATRICULE`),
  KEY `LAB_CODE` (`LAB_CODE`),
  KEY `SEC_CODE` (`SEC_CODE`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `visiteur`
--

INSERT INTO `visiteur` (`VIS_MATRICULE`, `VIS_NOM`, `VIS_PRENOM`, `VIS_ADRESSE`, `VIS_CP`, `VIS_VILLE`, `VIS_DATEEMBAUCHE`, `SEC_CODE`, `LAB_CODE`) VALUES
(1, 'Girard', 'Arnaud', '30,Boulevard Auguste Blanqui', '75013', 'Paris', '2021-11-16 13:59:36', 27, 13),
(2, 'Bertrand', 'Coralie', '6,Rue du Berger', '75001', 'Paris', '2021-07-14 12:26:28', 19, 10),
(3, 'Morel', 'Etienne', '18,Avenue Aimé Martin', '06000', 'Nice', '2012-08-06 20:47:41', 23, 1),
(4, 'Huet', 'Frédéric', '121,Avenue Beausite.', '06000', 'Nice', '2005-02-19 11:52:47', 25, 10),
(5, 'Dupuis', 'Jérôme', '3,Rue Audran', '69001', 'Lyon', '2011-01-11 13:18:37', 18, 4),
(6, 'Adam', 'Lise', '29,Place d\'Albon', '69001', 'Lyon', '2018-01-15 10:18:16', 24, 5),
(7, 'Aubry', 'Martin', '98,Rue du 22 Novembre', '67000', 'Strasbourg', '2018-01-07 20:50:25', 16, 2),
(8, 'Dupont', 'Irène', '45,Avenue de Normandie', '67000', 'Strasbourg', '2017-08-19 11:22:12', 21, 6),
(9, 'Leroy', 'Romain', '11,Rue de l\'Egalité', '59000', 'Lille', '2020-12-05 20:18:14', 17, 9),
(10, 'David', 'Ursule', '3,Allée des Erables', '59000', 'Lille', '2014-10-13 14:44:35', 23, 15),
(11, 'Faure', 'Tanguy', '87,Rue Edgar Quinet', '21000', 'Dijon', '2011-07-08 10:23:18', 30, 3),
(12, 'Simon', 'Régis', '20,Allée Marcel Aymé', '21000', 'Dijon', '2016-09-23 16:38:47', 18, 1),
(13, 'Klein', 'Olivier', '57,Allée des Vosges', '37000', 'Tours', '2019-05-15 17:50:21', 22, 14),
(14, 'Fernandez', 'Pablo', '90,Avenue Mozart', '37000', 'Tours', '2019-07-12 00:00:00', 18, 7),
(15, 'Bouvier', 'Hugo', '45,Rue Marivaux', '87000', 'Limoges', '2008-06-09 12:38:47', NULL, NULL);

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
  ADD CONSTRAINT `travailler_ibfk_1` FOREIGN KEY (`REG_CODE`) REFERENCES `region` (`REG_CODE`),
  ADD CONSTRAINT `travailler_ibfk_2` FOREIGN KEY (`VIS_MATRICULE`) REFERENCES `visiteur` (`VIS_MATRICULE`);

--
-- Contraintes pour la table `visiteur`
--
ALTER TABLE `visiteur`
  ADD CONSTRAINT `visiteur_ibfk_1` FOREIGN KEY (`SEC_CODE`) REFERENCES `secteur` (`SEC_CODE`),
  ADD CONSTRAINT `visiteur_ibfk_2` FOREIGN KEY (`LAB_CODE`) REFERENCES `labo` (`LAB_CODE`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
