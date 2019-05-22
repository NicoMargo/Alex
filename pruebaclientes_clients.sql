-- MySQL dump 10.13  Distrib 5.7.24, for Win64 (x86_64)
--
-- Host: localhost    Database: pruebaclientes
-- ------------------------------------------------------
-- Server version	5.7.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clients` (
  `idClients` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) DEFAULT NULL,
  `Surname` varchar(25) DEFAULT NULL,
  `Dni` int(11) DEFAULT NULL,
  `Email` varchar(65) DEFAULT NULL,
  `Telephone` int(11) DEFAULT NULL,
  `Cellphone` int(11) DEFAULT NULL,
  `Town` varchar(45) DEFAULT NULL,
  `address` varchar(60) DEFAULT NULL,
  `Province` varchar(15) DEFAULT NULL,
  `Leter` char(1) DEFAULT NULL,
  `Number` int(11) DEFAULT NULL,
  `Floor` int(11) DEFAULT NULL,
  PRIMARY KEY (`idClients`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES (1,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(2,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(3,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(4,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(5,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(6,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(7,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(8,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(9,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(10,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(11,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(12,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(13,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14),(14,'Nicolas','Margossian',43994080,'nicolasmargossian@gmail.com',1563748576,44384657,'Caballito','Av rivadavia','Buenos Aires','C',6837,14);
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-05-22 19:29:38
