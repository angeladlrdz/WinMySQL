-- MySQL dump 10.13  Distrib 9.6.0, for Linux (x86_64)
--
-- Host: localhost    Database: escolar
-- ------------------------------------------------------
-- Server version	9.6.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
SET @MYSQLDUMP_TEMP_LOG_BIN = @@SESSION.SQL_LOG_BIN;
SET @@SESSION.SQL_LOG_BIN= 0;

--
-- GTID state at the beginning of the backup 
--

SET @@GLOBAL.GTID_PURGED=/*!80000 '+'*/ '11e8bd9c-1746-11f1-8309-ca0ba504f3c4:1-1930';

--
-- Table structure for table `Alumnos`
--

DROP TABLE IF EXISTS `Alumnos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Alumnos` (
  `nocontrol` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `paterno` varchar(45) DEFAULT NULL,
  `materno` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`nocontrol`)
) ENGINE=InnoDB AUTO_INCREMENT=26131181 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Alumnos`
--

LOCK TABLES `Alumnos` WRITE;
/*!40000 ALTER TABLE `Alumnos` DISABLE KEYS */;
INSERT INTO `Alumnos` VALUES (2413,'Angela','Lopez','Rodriguez'),(2414,'Luis','Perez','Garcia'),(2415,'Maria','Hernandez','Martinez'),(2416,'Carlos','Ramirez','Torres'),(2417,'Sofia','Gonzalez','Flores'),(2418,'Diego','Morales','Reyes'),(2419,'Valeria','Jimenez','Cruz'),(2420,'Andres','Vargas','Mendoza'),(2421,'Camila','Castillo','Ortega'),(2422,'Fernando','Ruiz','Salinas'),(12345,'qwertaaaaaaaa','qwer','werty'),(134567,'lalal','lolo','lolol');
/*!40000 ALTER TABLE `Alumnos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Asistencia`
--

DROP TABLE IF EXISTS `Asistencia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Asistencia` (
  `idAsistencia` int NOT NULL AUTO_INCREMENT,
  `fecha` date DEFAULT NULL,
  `asistencia` int DEFAULT NULL,
  `nocontrol` int DEFAULT NULL,
  PRIMARY KEY (`idAsistencia`),
  UNIQUE KEY `uq_fecha_control` (`nocontrol`,`fecha`),
  KEY `fk_numcontrol_idx` (`nocontrol`),
  CONSTRAINT `fk_numcontrol` FOREIGN KEY (`nocontrol`) REFERENCES `Alumnos` (`nocontrol`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=563 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Asistencia`
--

LOCK TABLES `Asistencia` WRITE;
/*!40000 ALTER TABLE `Asistencia` DISABLE KEYS */;
INSERT INTO `Asistencia` VALUES (483,'2026-03-16',1,2413),(484,'2026-03-16',1,2414),(485,'2026-03-16',1,2415),(486,'2026-03-16',0,2416),(487,'2026-03-16',0,2417),(488,'2026-03-16',0,2418),(489,'2026-03-16',0,2419),(490,'2026-03-16',0,2420),(491,'2026-03-16',0,2421),(492,'2026-03-16',0,2422),(493,'2026-03-03',0,2413),(494,'2026-03-03',1,2414),(495,'2026-03-03',0,2415),(496,'2026-03-03',0,2416),(497,'2026-03-03',0,2417),(498,'2026-03-03',0,2418),(499,'2026-03-03',0,2419),(500,'2026-03-03',0,2420),(501,'2026-03-03',0,2421),(502,'2026-03-03',0,2422),(503,'2026-03-17',0,2413),(504,'2026-03-17',1,2414),(505,'2026-03-17',0,2415),(506,'2026-03-17',0,2416),(507,'2026-03-17',1,2417),(508,'2026-03-17',0,2418),(509,'2026-03-17',0,2419),(510,'2026-03-17',0,2420),(511,'2026-03-17',0,2421),(512,'2026-03-17',0,2422),(513,'2026-03-15',0,2413),(514,'2026-03-15',0,2414),(515,'2026-03-15',0,2415),(516,'2026-03-15',0,2416),(517,'2026-03-15',0,2417),(518,'2026-03-15',0,2418),(519,'2026-03-15',0,2419),(520,'2026-03-15',0,2420),(521,'2026-03-15',0,2421),(522,'2026-03-15',0,2422),(523,'2026-03-23',1,2413),(524,'2026-03-23',1,2414),(525,'2026-03-23',0,2415),(526,'2026-03-23',0,2416),(527,'2026-03-23',0,2417),(528,'2026-03-23',0,2418),(529,'2026-03-23',0,2419),(530,'2026-03-23',0,2420),(531,'2026-03-23',0,2421),(532,'2026-03-23',1,2422),(533,'2026-03-09',0,2413),(534,'2026-03-09',0,2414),(535,'2026-03-09',0,2415),(536,'2026-03-09',0,2416),(537,'2026-03-09',0,2417),(538,'2026-03-09',0,2418),(539,'2026-03-09',0,2419),(540,'2026-03-09',0,2420),(541,'2026-03-09',0,2421),(542,'2026-03-09',0,2422),(543,'2026-03-18',1,2413),(544,'2026-03-18',1,2414),(545,'2026-03-18',1,2415),(546,'2026-03-18',0,2416),(547,'2026-03-18',0,2417),(548,'2026-03-18',0,2418),(549,'2026-03-18',0,2419),(550,'2026-03-18',0,2420),(551,'2026-03-18',0,2421),(552,'2026-03-18',0,2422),(553,'2026-03-21',0,2413),(554,'2026-03-21',0,2414),(555,'2026-03-21',0,2415),(556,'2026-03-21',0,2416),(557,'2026-03-21',0,2417),(558,'2026-03-21',0,2418),(559,'2026-03-21',0,2419),(560,'2026-03-21',0,2420),(561,'2026-03-21',0,2421),(562,'2026-03-21',0,2422);
/*!40000 ALTER TABLE `Asistencia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Materias`
--

DROP TABLE IF EXISTS `Materias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Materias` (
  `idMaterias` int NOT NULL AUTO_INCREMENT,
  `Materia` varchar(70) DEFAULT NULL,
  `CVE` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idMaterias`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Materias`
--

LOCK TABLES `Materias` WRITE;
/*!40000 ALTER TABLE `Materias` DISABLE KEYS */;
INSERT INTO `Materias` VALUES (1,'Topicos Avanzados de Programacion','SCD-017'),(2,'Sistemas Programables','SCC-1023');
/*!40000 ALTER TABLE `Materias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Profesores`
--

DROP TABLE IF EXISTS `Profesores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Profesores` (
  `idProfesores` int NOT NULL AUTO_INCREMENT,
  `NumEmpleado` varchar(45) DEFAULT NULL,
  `PrimerNombre` varchar(45) DEFAULT NULL,
  `SegundoNombre` varchar(45) DEFAULT NULL,
  `ApellidoPaterno` varchar(45) DEFAULT NULL,
  `ApellidoMaterno` varchar(45) DEFAULT NULL,
  `RFC` varchar(45) DEFAULT NULL,
  `GradoAcademico` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idProfesores`),
  UNIQUE KEY `ApellidoMaterno_UNIQUE` (`ApellidoPaterno`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Profesores`
--

LOCK TABLES `Profesores` WRITE;
/*!40000 ALTER TABLE `Profesores` DISABLE KEYS */;
INSERT INTO `Profesores` VALUES (4,'5678','tyu','nm','tyu','tyu','tyu','ty');
/*!40000 ALTER TABLE `Profesores` ENABLE KEYS */;
UNLOCK TABLES;
SET @@SESSION.SQL_LOG_BIN = @MYSQLDUMP_TEMP_LOG_BIN;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-03-23 21:25:24
