-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 31-05-2019 a las 15:11:15
-- Versión del servidor: 5.7.21
-- Versión de PHP: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_agcs`
--

DELIMITER $$
--
-- Procedimientos
--
DROP PROCEDURE IF EXISTS `spDeleteClient`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `spDeleteClient` (IN `id` INT, IN `idBusiness` INT)  NO SQL
if(EXISTS(SELECT clients.idClients FROM clients WHERE clients.idClients = id and clients.Business_idBusiness = idBusiness))
THEN
	DELETE from clients WHERE clients.idClients = id and clients.Business_idBusiness = idBusiness;
end IF$$

DROP PROCEDURE IF EXISTS `spGetClients`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGetClients` (IN `idBusiness` INT)  NO SQL
SELECT clients.idClients, clients.Name, clients.Surname, clients.DNI_CUIT, clients.eMail, clients.Telephone FROM clients where clients.Business_idBusiness = idBusiness$$

DROP PROCEDURE IF EXISTS `spGetOneClient`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `spGetOneClient` (IN `id` INT, IN `idBusiness` INT)  NO SQL
SELECT * FROM clients WHERE clients.idClients = id and clients.Business_idBusiness = idBusiness$$

DROP PROCEDURE IF EXISTS `spInsertClient`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsertClient` (IN `idBusiness` INT, IN `Name` VARCHAR(45), IN `Surname` VARCHAR(45), IN `DNI_CUIT` INT, IN `eMail` VARCHAR(45), IN `Telephone` INT, IN `Address` VARCHAR(250), IN `Locality` VARCHAR(45), IN `idProvince` INT, IN `idDelivery` INT, IN `Comments` VARCHAR(200))  NO SQL
insert into clients(clients.Name,clients.Surname,clients.DNI_CUIT,clients.eMail,clients.Telephone,clients.Business_idBusiness) values(Name,Surname, DNI_CUIT, eMail, Telephone,idBusiness)$$

DROP PROCEDURE IF EXISTS `spUpdateClient`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `spUpdateClient` (IN `id` INT, IN `idBusiness` INT, IN `Name` VARCHAR(45), IN `Surname` VARCHAR(45), IN `DNI_Cuit` INT(20), IN `eMail` VARCHAR(45), IN `Telephone` INT)  NO SQL
if(EXISTS(SELECT clients.idClients from clients WHERE clients.idClients = id and clients.Business_idBusiness = idBusiness))
THEN
	
	if(Name is not null and Name != (SELECT clients.Name from clients where clients.idClients = id) ) 
    THEN
    	UPDATE clients set Name = Name WHERE clients.idClients = id and clients.Business_idBusiness = idBusiness ; 
    end if;
    
	if(Surname is not null and Surname != (SELECT clients.Surname from clients where clients.idClients = id)) 
    THEN
    	UPDATE clients set clients.Surname = Surname WHERE clients.idClients = id and clients.Business_idBusiness = idBusiness; 
    end if;
    
    if(DNI_CUIT is not null and DNI_CUIT != (SELECT clients.DNI_CUIT from clients where clients.idClients = id)) 
    THEN
    	UPDATE clients set clients.DNI_CUIT = DNI_CUIT WHERE clients.idClients = id and clients.Business_idBusiness = idBusiness; 
    end if;
    
    if(eMail is not null and eMail != (SELECT clients.eMail from clients where clients.idClients = id)) 
    THEN
    	UPDATE clients set clients.eMail = eMail WHERE clients.idClients = id and clients.Business_idBusiness = idBusiness; 
    end if;
    
    if(Telephone is not null and Telephone != (SELECT clients.Telephone from clients where clients.idClients = id)) 
    THEN
    	UPDATE clients set clients.Telephone = Telephone WHERE clients.idClients = id and clients.Business_idBusiness = idBusiness; 
    end if;
    

end if$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `address`
--

DROP TABLE IF EXISTS `address`;
CREATE TABLE IF NOT EXISTS `address` (
  `idAddress` int(11) NOT NULL AUTO_INCREMENT,
  `Locality` varchar(45) DEFAULT NULL,
  `Postal_Code` int(11) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Address_Number` int(11) DEFAULT NULL,
  `Floor` int(11) DEFAULT NULL,
  `Apartment` varchar(10) DEFAULT NULL,
  `Comments` varchar(200) DEFAULT NULL,
  `Delivery_idDelivery` int(11) NOT NULL,
  `Province_idProvince` int(11) NOT NULL,
  `Business_idBusiness` int(11) NOT NULL,
  `Clients_idClients` int(11) NOT NULL,
  PRIMARY KEY (`idAddress`,`Delivery_idDelivery`,`Province_idProvince`,`Business_idBusiness`),
  KEY `fk_Address_Delivery1_idx` (`Delivery_idDelivery`),
  KEY `fk_Address_Province1_idx` (`Province_idProvince`),
  KEY `fk_Address_Business1_idx` (`Business_idBusiness`),
  KEY `fk_Address_Client1` (`Clients_idClients`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `branches`
--

DROP TABLE IF EXISTS `branches`;
CREATE TABLE IF NOT EXISTS `branches` (
  `idBranch` int(11) NOT NULL AUTO_INCREMENT,
  `Address` varchar(100) DEFAULT NULL,
  `District` varchar(45) DEFAULT NULL,
  `Branch_Name` varchar(100) DEFAULT NULL,
  `Telephone` int(11) DEFAULT NULL,
  `Postal_Code` int(11) DEFAULT NULL,
  `Business_idBusiness` int(11) NOT NULL,
  `Province_idProvince` int(11) NOT NULL,
  PRIMARY KEY (`idBranch`,`Business_idBusiness`,`Province_idProvince`),
  KEY `fk_Branch_Business1_idx` (`Business_idBusiness`),
  KEY `fk_Branch_Province1_idx` (`Province_idProvince`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='	';

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `business`
--

DROP TABLE IF EXISTS `business`;
CREATE TABLE IF NOT EXISTS `business` (
  `idBusiness` int(11) NOT NULL AUTO_INCREMENT,
  `CUIT` int(11) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Gross_Income` int(11) DEFAULT NULL,
  `Beginning_of_Activities` date DEFAULT NULL,
  `Logo` varchar(100) DEFAULT NULL,
  `Signature` varchar(45) DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  `Telephone` int(11) DEFAULT NULL,
  PRIMARY KEY (`idBusiness`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `business`
--

INSERT INTO `business` (`idBusiness`, `CUIT`, `Name`, `Gross_Income`, `Beginning_of_Activities`, `Logo`, `Signature`, `Type`, `Telephone`) VALUES
(1, 1234, 'Prueba', 3000, '2019-05-01', 'xdd', 'xdd', 'Mayorista', 1121121),
(2, 1234, 'Prueba', 3000, '2019-05-01', 'xdd', 'xdd', 'Mayorista', 1121121);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clients`
--

DROP TABLE IF EXISTS `clients`;
CREATE TABLE IF NOT EXISTS `clients` (
  `idClients` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `Surname` varchar(45) DEFAULT NULL,
  `DNI_CUIT` int(11) DEFAULT NULL,
  `eMail` varchar(45) DEFAULT NULL,
  `Telephone` int(11) DEFAULT NULL,
  `Cellphone` int(11) NOT NULL,
  `Business_idBusiness` int(11) NOT NULL,
  PRIMARY KEY (`idClients`,`Business_idBusiness`),
  KEY `fk_Clients_Business1_idx` (`Business_idBusiness`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clients`
--

INSERT INTO `clients` (`idClients`, `Name`, `Surname`, `DNI_CUIT`, `eMail`, `Telephone`, `Cellphone`, `Business_idBusiness`) VALUES
(5, 'Carlitos', 'perez', 0, 'carlomagno@gmail.cim', 0, 0, 1),
(6, 'Don Juan', 'Equisde', 44444555, 'juan@mail.cim', 45678912, 0, 1),
(7, 'Robot de', 'Prueba', 17, 'c17@patrullaroja.com', NULL, 0, 1),
(8, 'Yare Yare', 'Dawa', 0, 'bot01@mail.com', 0, 0, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `delivery`
--

DROP TABLE IF EXISTS `delivery`;
CREATE TABLE IF NOT EXISTS `delivery` (
  `idDelivery` int(11) NOT NULL AUTO_INCREMENT,
  `Transportation_Company` varchar(45) DEFAULT NULL,
  `Telephone` int(11) DEFAULT NULL,
  `Business_idBusiness` int(11) NOT NULL,
  PRIMARY KEY (`idDelivery`,`Business_idBusiness`),
  KEY `fk_Delivery_Business1_idx` (`Business_idBusiness`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `macs`
--

DROP TABLE IF EXISTS `macs`;
CREATE TABLE IF NOT EXISTS `macs` (
  `idMacs` int(11) NOT NULL AUTO_INCREMENT,
  `Mac_Address` varchar(45) DEFAULT NULL,
  `Business_idBusiness` int(11) NOT NULL,
  PRIMARY KEY (`idMacs`,`Business_idBusiness`),
  KEY `fk_Macs_Business1_idx` (`Business_idBusiness`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `payment_methods`
--

DROP TABLE IF EXISTS `payment_methods`;
CREATE TABLE IF NOT EXISTS `payment_methods` (
  `idPayment_Methods` int(11) NOT NULL AUTO_INCREMENT,
  `Method` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idPayment_Methods`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `products`
--

DROP TABLE IF EXISTS `products`;
CREATE TABLE IF NOT EXISTS `products` (
  `idProducts` int(11) NOT NULL AUTO_INCREMENT,
  `Article_number` int(11) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Cost` int(11) DEFAULT NULL,
  `Age` bit(1) DEFAULT NULL,
  `Stock` int(11) DEFAULT NULL,
  `Code` int(11) DEFAULT NULL,
  `Suppliers_idSupplier` int(11) NOT NULL,
  `Business_idBusiness` int(11) NOT NULL,
  PRIMARY KEY (`idProducts`,`Suppliers_idSupplier`,`Business_idBusiness`),
  KEY `fk_Products_Suppliers1_idx` (`Suppliers_idSupplier`),
  KEY `fk_Products_Business1_idx` (`Business_idBusiness`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `provinces`
--

DROP TABLE IF EXISTS `provinces`;
CREATE TABLE IF NOT EXISTS `provinces` (
  `idProvince` int(11) NOT NULL AUTO_INCREMENT,
  `Province` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idProvince`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `purchases`
--

DROP TABLE IF EXISTS `purchases`;
CREATE TABLE IF NOT EXISTS `purchases` (
  `idPurchases` int(11) NOT NULL AUTO_INCREMENT,
  `Date` date DEFAULT NULL,
  `DNI/CUIT` int(11) DEFAULT NULL,
  `Employee_Code` int(11) DEFAULT NULL,
  `IVA_Condition` varchar(45) DEFAULT NULL,
  `Type` varchar(1) DEFAULT NULL,
  `Total` int(11) DEFAULT NULL,
  `Discount` int(11) DEFAULT NULL,
  `IVA_Recharge` int(11) DEFAULT NULL,
  `WholeSaler` bit(1) DEFAULT NULL,
  `Branches_idBranch` int(11) NOT NULL,
  `Payment_Methods_idPayment_Methods` int(11) NOT NULL,
  `Macs_idMacs` int(11) NOT NULL,
  `Business_idBusiness` int(11) NOT NULL,
  PRIMARY KEY (`idPurchases`,`Branches_idBranch`,`Payment_Methods_idPayment_Methods`,`Macs_idMacs`,`Business_idBusiness`),
  KEY `fk_Purchases_Branches1_idx` (`Branches_idBranch`),
  KEY `fk_Purchases_Payment_Methods1_idx` (`Payment_Methods_idPayment_Methods`),
  KEY `fk_Purchases_Macs1_idx` (`Macs_idMacs`),
  KEY `fk_Purchases_Business1_idx` (`Business_idBusiness`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `purchases_x_products`
--

DROP TABLE IF EXISTS `purchases_x_products`;
CREATE TABLE IF NOT EXISTS `purchases_x_products` (
  `idPurchases_X_Products` int(11) NOT NULL AUTO_INCREMENT,
  `Quantity` int(11) DEFAULT NULL,
  `Products_idProducts` int(11) NOT NULL,
  `Purchases_idPurchases` int(11) NOT NULL,
  PRIMARY KEY (`idPurchases_X_Products`,`Products_idProducts`,`Purchases_idPurchases`),
  KEY `fk_Purchases_X_Products_Products1_idx` (`Products_idProducts`),
  KEY `fk_Purchases_X_Products_Purchases1_idx` (`Purchases_idPurchases`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
CREATE TABLE IF NOT EXISTS `suppliers` (
  `idSupplier` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `Surname` varchar(45) DEFAULT NULL,
  `Telephone` int(11) DEFAULT NULL,
  `Cellphone` int(11) NOT NULL,
  `Factory_Plant` varchar(45) DEFAULT NULL,
  `Business_idBusiness` int(11) NOT NULL,
  `Address` varchar(200) NOT NULL,
  PRIMARY KEY (`idSupplier`,`Business_idBusiness`),
  KEY `fk_Supplier_Business1_idx` (`Business_idBusiness`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `idUser` int(11) NOT NULL AUTO_INCREMENT,
  `eMail` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `Code` int(11) DEFAULT NULL,
  `Admin` bit(1) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Surname` varchar(45) DEFAULT NULL,
  `Name_Second` varchar(45) DEFAULT NULL,
  `Business_idBusiness` int(11) NOT NULL,
  PRIMARY KEY (`idUser`,`Business_idBusiness`),
  KEY `fk_Users_Business1_idx` (`Business_idBusiness`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user_extrainfo`
--

DROP TABLE IF EXISTS `user_extrainfo`;
CREATE TABLE IF NOT EXISTS `user_extrainfo` (
  `idUser_ExtraInfo` int(11) NOT NULL AUTO_INCREMENT,
  `Address` varchar(100) DEFAULT NULL,
  `Tel_Father` int(11) DEFAULT NULL,
  `Tel_Mother` int(11) DEFAULT NULL,
  `Tel_User` int(11) DEFAULT NULL,
  `eMail` varchar(45) DEFAULT NULL,
  `District` varchar(45) DEFAULT NULL,
  `Healthcare_Company` varchar(45) DEFAULT NULL,
  `Sallary` int(11) DEFAULT NULL,
  `Employee_Code` int(11) DEFAULT NULL,
  `Users_idUsuarios` int(11) NOT NULL,
  `Province_idProvince` int(11) NOT NULL,
  `Payment_Methods_idPayment_Methods` int(11) NOT NULL,
  PRIMARY KEY (`idUser_ExtraInfo`,`Users_idUsuarios`,`Province_idProvince`,`Payment_Methods_idPayment_Methods`),
  KEY `fk_User_ExtraInfo_Users1_idx` (`Users_idUsuarios`),
  KEY `fk_User_ExtraInfo_Province1_idx` (`Province_idProvince`),
  KEY `fk_User_ExtraInfo_Payment_Methods1_idx` (`Payment_Methods_idPayment_Methods`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `address`
--
ALTER TABLE `address`
  ADD CONSTRAINT `fk_Address_Business1` FOREIGN KEY (`Business_idBusiness`) REFERENCES `business` (`idBusiness`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Address_Client1` FOREIGN KEY (`Clients_idClients`) REFERENCES `clients` (`idClients`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Address_Delivery1` FOREIGN KEY (`Delivery_idDelivery`) REFERENCES `delivery` (`idDelivery`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Address_Province1` FOREIGN KEY (`Province_idProvince`) REFERENCES `provinces` (`idProvince`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `branches`
--
ALTER TABLE `branches`
  ADD CONSTRAINT `fk_Branch_Business1` FOREIGN KEY (`Business_idBusiness`) REFERENCES `business` (`idBusiness`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Branch_Province1` FOREIGN KEY (`Province_idProvince`) REFERENCES `provinces` (`idProvince`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `clients`
--
ALTER TABLE `clients`
  ADD CONSTRAINT `fk_Clients_Business1` FOREIGN KEY (`Business_idBusiness`) REFERENCES `business` (`idBusiness`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `delivery`
--
ALTER TABLE `delivery`
  ADD CONSTRAINT `fk_Delivery_Business1` FOREIGN KEY (`Business_idBusiness`) REFERENCES `business` (`idBusiness`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `macs`
--
ALTER TABLE `macs`
  ADD CONSTRAINT `fk_Macs_Business1` FOREIGN KEY (`Business_idBusiness`) REFERENCES `business` (`idBusiness`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `fk_Products_Business1` FOREIGN KEY (`Business_idBusiness`) REFERENCES `business` (`idBusiness`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Products_Suppliers1` FOREIGN KEY (`Suppliers_idSupplier`) REFERENCES `suppliers` (`idSupplier`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `purchases`
--
ALTER TABLE `purchases`
  ADD CONSTRAINT `fk_Purchases_Branches1` FOREIGN KEY (`Branches_idBranch`) REFERENCES `branches` (`idBranch`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Purchases_Business1` FOREIGN KEY (`Business_idBusiness`) REFERENCES `business` (`idBusiness`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Purchases_Macs1` FOREIGN KEY (`Macs_idMacs`) REFERENCES `macs` (`idMacs`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Purchases_Payment_Methods1` FOREIGN KEY (`Payment_Methods_idPayment_Methods`) REFERENCES `payment_methods` (`idPayment_Methods`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `purchases_x_products`
--
ALTER TABLE `purchases_x_products`
  ADD CONSTRAINT `fk_Purchases_X_Products_Products1` FOREIGN KEY (`Products_idProducts`) REFERENCES `products` (`idProducts`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Purchases_X_Products_Purchases1` FOREIGN KEY (`Purchases_idPurchases`) REFERENCES `purchases` (`idPurchases`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `suppliers`
--
ALTER TABLE `suppliers`
  ADD CONSTRAINT `fk_Supplier_Business1` FOREIGN KEY (`Business_idBusiness`) REFERENCES `business` (`idBusiness`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `fk_Users_Business1` FOREIGN KEY (`Business_idBusiness`) REFERENCES `business` (`idBusiness`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `user_extrainfo`
--
ALTER TABLE `user_extrainfo`
  ADD CONSTRAINT `fk_User_ExtraInfo_Payment_Methods1` FOREIGN KEY (`Payment_Methods_idPayment_Methods`) REFERENCES `payment_methods` (`idPayment_Methods`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_User_ExtraInfo_Province1` FOREIGN KEY (`Province_idProvince`) REFERENCES `provinces` (`idProvince`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_User_ExtraInfo_Users1` FOREIGN KEY (`Users_idUsuarios`) REFERENCES `users` (`idUser`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
