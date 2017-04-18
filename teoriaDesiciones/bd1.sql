-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: teoria_desiciones
-- ------------------------------------------------------
-- Server version	5.6.34-log

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
-- Table structure for table `causa`
--

DROP TABLE IF EXISTS `causa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `causa` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `causa` varchar(999) NOT NULL DEFAULT '',
  `probabilidad` decimal(20,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `causa`
--

LOCK TABLES `causa` WRITE;
/*!40000 ALTER TABLE `causa` DISABLE KEYS */;
INSERT INTO `causa` VALUES (1,'falla energia electrica',10.00),(2,'falta de materia prima',15.00),(3,'operadores no disponibles',20.00),(4,'falla pieza de maquina',20.00),(5,'incapacitacion de empleado accidente maquina',15.00),(6,'materia prima llega tarde',20.00);
/*!40000 ALTER TABLE `causa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `maquina_tipo`
--

DROP TABLE IF EXISTS `maquina_tipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `maquina_tipo` (
  `id` int(11) NOT NULL DEFAULT '0',
  `tipo` varchar(999) NOT NULL DEFAULT '',
  `cantidad` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `maquina_tipo`
--

LOCK TABLES `maquina_tipo` WRITE;
/*!40000 ALTER TABLE `maquina_tipo` DISABLE KEYS */;
INSERT INTO `maquina_tipo` VALUES (1,'cutters',2),(2,'molinos',1),(3,'embutidoras',3),(4,'clipeadoras',3),(5,'tambores',3),(6,'inyectadoras',1),(7,'empacadoras',3),(8,'termoformadoras',1);
/*!40000 ALTER TABLE `maquina_tipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mes`
--

DROP TABLE IF EXISTS `mes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mes` (
  `mes` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`mes`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mes`
--

LOCK TABLES `mes` WRITE;
/*!40000 ALTER TABLE `mes` DISABLE KEYS */;
INSERT INTO `mes` VALUES (1),(2),(3),(4),(5),(6),(7),(8),(9),(10),(11),(12);
/*!40000 ALTER TABLE `mes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parada`
--

DROP TABLE IF EXISTS `parada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `parada` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_causa` int(11) NOT NULL DEFAULT '0',
  `tiempo_horas` decimal(20,2) NOT NULL DEFAULT '0.00',
  `tiempo_minutos` decimal(20,2) NOT NULL DEFAULT '0.00',
  `id_maquina` int(11) NOT NULL DEFAULT '0',
  `id_periodo` int(11) NOT NULL DEFAULT '0',
  `mes` int(11) NOT NULL DEFAULT '0',
  `tiempo_trabajado` decimal(20,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`id`),
  KEY `FK_parada_3` (`id_maquina`),
  KEY `FK_parada_4` (`id_periodo`),
  KEY `FK_parada_5` (`mes`),
  KEY `FK_parada_1` (`id_causa`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=146 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parada`
--

LOCK TABLES `parada` WRITE;
/*!40000 ALTER TABLE `parada` DISABLE KEYS */;
INSERT INTO `parada` VALUES (1,4,0.65,39.00,3,2016,11,11310.00),(2,2,0.75,45.00,1,2015,2,13050.00),(3,2,0.70,42.00,2,2016,4,12180.00),(4,1,0.65,39.00,1,2016,8,11310.00),(5,2,0.75,45.00,4,2015,11,13050.00),(6,3,0.60,36.00,1,2015,11,10440.00),(7,2,0.77,46.00,1,2015,11,13340.00),(8,1,0.63,38.00,5,2016,2,11020.00),(9,3,0.82,49.00,1,2016,5,14210.00),(10,2,0.73,44.00,1,2015,3,12760.00),(11,3,0.77,46.00,3,2015,3,13340.00),(12,2,0.68,41.00,1,2016,1,11890.00),(13,1,0.63,38.00,1,2016,10,11020.00),(14,2,0.73,44.00,1,2016,2,12760.00),(15,2,0.77,46.00,1,2016,5,13340.00),(16,2,0.68,41.00,1,2016,6,11890.00),(17,1,0.63,38.00,2,2016,4,11020.00),(18,3,0.82,49.00,1,2016,4,14210.00),(19,4,0.73,44.00,1,2016,4,12760.00),(20,5,0.58,35.00,4,2016,4,10150.00),(21,2,0.68,41.00,1,2015,1,11890.00),(22,1,0.63,38.00,3,2016,10,11020.00),(23,3,0.82,49.00,1,2016,12,14210.00),(24,2,0.73,44.00,1,2016,3,12760.00),(25,4,0.77,46.00,5,2016,6,13340.00),(26,2,0.68,41.00,1,2015,3,11890.00),(27,1,0.63,38.00,1,2015,6,11020.00),(28,3,0.82,49.00,2,2015,7,14210.00),(29,2,0.73,44.00,1,2016,2,12760.00),(30,3,0.77,46.00,1,2016,2,13340.00),(31,2,0.68,41.00,1,2015,7,11890.00),(32,2,0.80,48.00,1,2015,12,13920.00),(33,3,0.85,51.00,1,2016,1,14790.00),(34,1,0.62,37.00,4,2016,6,10730.00),(35,2,0.72,43.00,1,2015,8,12470.00),(36,2,0.75,45.00,5,2015,9,13050.00),(37,1,0.67,40.00,1,2016,10,11600.00),(38,3,0.85,51.00,3,2016,11,14790.00),(39,1,0.62,37.00,1,2016,3,10730.00),(40,2,0.80,48.00,1,2016,3,13920.00),(41,2,0.72,43.00,1,2016,9,12470.00),(42,2,0.75,45.00,1,2016,11,13050.00),(43,4,0.67,40.00,2,2015,8,11600.00),(44,3,0.85,51.00,6,2015,12,14790.00),(45,1,0.62,37.00,1,2015,4,10730.00),(46,2,0.80,48.00,1,2015,4,13920.00),(47,2,0.72,43.00,5,2015,11,12470.00),(48,2,0.75,45.00,1,2016,1,13050.00),(49,1,0.67,40.00,1,2015,4,11600.00),(50,3,0.85,51.00,1,2015,5,14790.00),(51,2,0.80,48.00,4,2015,8,13920.00),(52,2,0.72,43.00,1,2016,6,12470.00),(53,2,0.73,44.00,4,2015,1,12760.00),(54,5,0.67,40.00,2,2015,10,11600.00),(55,3,0.83,50.00,6,2015,10,14500.00),(56,1,0.60,36.00,1,2016,12,10440.00),(57,2,0.78,47.00,1,2015,2,13630.00),(58,4,0.70,42.00,6,2015,4,12180.00),(59,2,0.73,44.00,7,2015,4,12760.00),(60,1,0.65,39.00,1,2015,11,11310.00),(61,3,0.83,50.00,7,2016,1,14500.00),(62,1,0.60,36.00,1,2015,6,10440.00),(63,2,0.78,47.00,1,2015,7,13630.00),(64,2,0.70,42.00,1,2016,8,12180.00),(65,2,0.73,44.00,7,2016,12,12760.00),(66,1,0.65,39.00,1,2015,7,11310.00),(67,3,0.83,50.00,1,2015,9,14500.00),(68,1,0.60,36.00,1,2015,3,10440.00),(69,2,0.78,47.00,3,2015,4,13630.00),(70,2,0.70,42.00,6,2016,3,12180.00),(71,2,0.73,44.00,1,2015,1,12760.00),(72,1,0.65,39.00,1,2015,9,11310.00),(73,1,0.60,36.00,1,2015,8,10440.00),(74,2,0.78,47.00,1,2015,8,13630.00),(75,2,0.70,42.00,8,2016,2,12180.00),(76,2,0.73,44.00,1,2016,3,12760.00),(77,5,0.65,39.00,4,2015,4,11310.00),(78,1,0.60,36.00,1,2016,9,10440.00),(79,2,0.78,47.00,1,2016,12,13630.00),(80,1,0.58,35.00,7,2015,4,10150.00),(81,2,0.70,42.00,1,2015,9,12180.00),(82,2,0.72,43.00,1,2016,2,12470.00),(83,1,0.63,38.00,1,2015,2,11020.00),(84,1,0.58,35.00,1,2016,12,10150.00),(85,2,0.77,46.00,1,2015,3,13340.00),(86,2,0.68,41.00,1,2016,1,11890.00),(87,2,0.72,43.00,3,2016,6,12470.00),(88,1,0.63,38.00,1,2015,8,11020.00),(89,3,0.82,49.00,1,2015,10,14210.00),(90,1,0.58,35.00,1,2016,7,10150.00),(91,2,0.77,46.00,8,2016,8,13340.00),(92,2,0.68,41.00,1,2015,11,11890.00),(93,2,0.72,43.00,8,2016,7,12470.00),(94,2,0.63,38.00,5,2015,9,11020.00),(95,3,0.82,49.00,1,2015,12,14210.00),(96,1,0.58,35.00,1,2015,6,10150.00),(97,2,0.68,41.00,1,2015,9,11890.00),(98,2,0.72,43.00,1,2015,11,12470.00),(99,4,0.63,38.00,7,2016,9,11020.00),(100,3,0.82,49.00,7,2016,9,14210.00),(101,3,0.58,35.00,4,2015,12,10150.00),(102,2,0.77,46.00,1,2016,1,13340.00),(103,2,0.68,41.00,1,2015,1,11890.00),(104,3,0.72,43.00,1,2015,1,12470.00),(105,3,0.63,38.00,3,2015,6,11020.00),(106,3,0.82,49.00,3,2015,6,14210.00),(107,1,0.58,35.00,1,2016,6,10150.00),(108,2,0.75,45.00,6,2016,8,13050.00),(109,2,0.68,41.00,1,2015,10,11890.00),(110,2,0.70,42.00,1,2016,3,12180.00),(111,1,0.62,37.00,1,2016,9,10730.00),(112,2,0.80,48.00,8,2016,9,13920.00),(113,2,0.75,45.00,1,2016,9,13050.00),(114,2,0.67,40.00,8,2015,8,11600.00),(115,2,0.70,42.00,1,2016,2,12180.00),(116,1,0.62,37.00,1,2015,2,10730.00),(117,2,0.80,48.00,4,2015,2,13920.00),(118,2,0.75,45.00,1,2015,8,13050.00),(119,3,0.67,40.00,8,2016,5,11600.00),(120,3,0.85,51.00,1,2016,9,14790.00),(121,4,0.70,42.00,8,2016,9,12180.00),(122,1,0.62,37.00,1,2015,1,10730.00),(123,2,0.80,48.00,1,2015,2,13920.00),(124,2,0.75,45.00,8,2015,8,13050.00),(125,1,0.67,40.00,1,2016,5,11600.00),(126,3,0.85,51.00,1,2016,5,14790.00),(127,1,0.62,37.00,2,2015,8,10730.00),(128,2,0.80,48.00,18,2015,8,13920.00),(129,2,0.75,45.00,1,2015,12,13050.00),(130,3,0.67,40.00,5,2016,7,11600.00),(131,3,0.85,51.00,1,2016,12,14790.00),(132,4,0.70,42.00,1,2016,12,12180.00),(133,5,0.62,37.00,2,2016,12,10730.00),(134,2,0.80,48.00,1,2015,1,13920.00),(135,2,0.75,45.00,1,2015,2,13050.00),(136,1,0.67,40.00,3,2016,3,11600.00),(137,2,0.68,41.00,1,2016,3,11890.00),(138,1,0.62,37.00,4,2016,10,10730.00),(139,2,0.78,47.00,1,2016,11,13630.00),(140,2,0.73,44.00,5,2016,11,12760.00),(141,1,0.65,39.00,1,2016,3,11310.00),(142,3,0.83,50.00,1,2016,3,14500.00),(143,5,0.60,36.00,8,2016,11,10440.00),(144,2,0.78,47.00,2,2016,12,13630.00),(145,2,0.73,44.00,1,2016,10,12760.00);
/*!40000 ALTER TABLE `parada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `periodo`
--

DROP TABLE IF EXISTS `periodo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `periodo` (
  `periodo` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`periodo`)
) ENGINE=InnoDB AUTO_INCREMENT=2021 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `periodo`
--

LOCK TABLES `periodo` WRITE;
/*!40000 ALTER TABLE `periodo` DISABLE KEYS */;
INSERT INTO `periodo` VALUES (2015),(2016),(2017),(2018),(2019),(2020);
/*!40000 ALTER TABLE `periodo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `problema`
--

DROP TABLE IF EXISTS `problema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `problema` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `problema` varchar(999) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `problema`
--

LOCK TABLES `problema` WRITE;
/*!40000 ALTER TABLE `problema` DISABLE KEYS */;
INSERT INTO `problema` VALUES (1,'maquina se detiene');
/*!40000 ALTER TABLE `problema` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `problema_vs_causa`
--

DROP TABLE IF EXISTS `problema_vs_causa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `problema_vs_causa` (
  `id_problema` int(11) NOT NULL DEFAULT '0',
  `id_causa` int(11) NOT NULL DEFAULT '0',
  KEY `FK_problema_vs_causa_2` (`id_causa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `problema_vs_causa`
--

LOCK TABLES `problema_vs_causa` WRITE;
/*!40000 ALTER TABLE `problema_vs_causa` DISABLE KEYS */;
INSERT INTO `problema_vs_causa` VALUES (1,1),(1,2),(1,3),(1,4),(1,5);
/*!40000 ALTER TABLE `problema_vs_causa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produccion`
--

DROP TABLE IF EXISTS `produccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produccion` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `periodo` int(11) NOT NULL DEFAULT '0',
  `mes` int(11) NOT NULL DEFAULT '0',
  `cantidad` decimal(20,2) NOT NULL DEFAULT '0.00',
  `nota` varchar(9999) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`),
  KEY `FK_produccion_1` (`mes`),
  KEY `FK_produccion_2` (`periodo`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produccion`
--

LOCK TABLES `produccion` WRITE;
/*!40000 ALTER TABLE `produccion` DISABLE KEYS */;
INSERT INTO `produccion` VALUES (1,2015,1,300000.00,'la venta fue buena porque hubo una buena demanda y un buen deseempeno de los trabajadores'),(2,2015,2,320000.00,''),(3,2015,3,280000.00,''),(4,2015,4,285000.00,'la venta bajo porque es mes abril por motivo a semana santa no se comio mucha carne'),(5,2015,5,270000.00,''),(6,2015,6,290000.00,''),(7,2015,7,260000.00,'la produccion bajo terriblemente porque se danaron varias maquinas'),(8,2015,8,273000.00,''),(9,2015,9,279000.00,''),(10,2015,10,290000.00,''),(11,2015,11,304000.00,''),(12,2015,12,320000.00,'hubo un aumento en la produccion por motivo de diciembre se vendio mas de lo esperado'),(13,2016,1,295000.00,''),(14,2016,2,290000.00,''),(15,2016,3,301000.00,''),(16,2016,4,286000.00,'la venta de carnes es afectada por la semana santna de comer carnes'),(17,2016,5,290000.00,'la venta subio debido con relacion al mes pasado debido a la salida de la semana santa'),(18,2016,6,285000.00,''),(19,2016,7,280000.00,'la venta bajo porque varias maquinas presentaron desperfecto'),(20,2016,8,287000.00,''),(21,2016,9,285000.00,'la venta bajo porque no hubo personal suficiente'),(22,2016,10,295000.00,''),(23,2016,11,290000.00,''),(24,2016,12,310000.00,'la venta subio por la temporada de diciembre');
/*!40000 ALTER TABLE `produccion` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-18 14:33:34
