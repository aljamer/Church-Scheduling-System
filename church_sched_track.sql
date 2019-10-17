-- MySQL dump 10.13  Distrib 5.7.22, for Win64 (x86_64)
--
-- Host: localhost    Database: church_sched_track
-- ------------------------------------------------------
-- Server version	5.7.22-log

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
-- Table structure for table `tblaccount`
--

DROP TABLE IF EXISTS `tblaccount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblaccount` (
  `account_id` int(11) NOT NULL AUTO_INCREMENT,
  `staff_id` varchar(255) DEFAULT NULL,
  `type` varchar(255) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`account_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblaccount`
--

LOCK TABLES `tblaccount` WRITE;
/*!40000 ALTER TABLE `tblaccount` DISABLE KEYS */;
INSERT INTO `tblaccount` VALUES (1,'1','Admin','Admin','Admin'),(4,'2','Staff','Staff','Staff'),(17,'3','Staff','User','User'),(19,'4','Staff','meme','meme');
/*!40000 ALTER TABLE `tblaccount` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblapplicant`
--

DROP TABLE IF EXISTS `tblapplicant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblapplicant` (
  `app_id` int(11) NOT NULL,
  `lastname` varchar(255) DEFAULT NULL,
  `firstname` varchar(255) DEFAULT NULL,
  `mi` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `email_add` varchar(255) DEFAULT NULL,
  `mobile_num` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`app_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblapplicant`
--

LOCK TABLES `tblapplicant` WRITE;
/*!40000 ALTER TABLE `tblapplicant` DISABLE KEYS */;
INSERT INTO `tblapplicant` VALUES (1,'Sahidjuan','Aljamer','T.','Zamboanga','Alajzmkhy@gmail.com','09009301203'),(2,'adw','adw','daw','awd','wd','wd'),(3,'a','a','a','a','a','a'),(4,'d','d','d','d','d','d'),(5,'aw','aw','aw','aw','aw','aw'),(6,'Dumagay','Arvin','P.','Sanggali','wtf@wangbu.com','09944611391'),(7,'dawd','daw','awda','awdwad','wdawd','awd'),(8,'awda','awd','dawd','wadwa','wadad','awdw'),(9,'anak','anak','anak','anak','anak','anak'),(10,'awd','awdwad','awdwadaw','dawd','dawd','adwad'),(11,'aljamer','aljamer','aljamer','aljamer','aljamer','aljamer'),(12,'Olegario','Angeline','C','SAnta maria','Angelranmo.com','666666666666');
/*!40000 ALTER TABLE `tblapplicant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblevent`
--

DROP TABLE IF EXISTS `tblevent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblevent` (
  `event_id` int(11) NOT NULL,
  `event_name` varchar(255) DEFAULT NULL,
  `event_desc` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`event_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblevent`
--

LOCK TABLES `tblevent` WRITE;
/*!40000 ALTER TABLE `tblevent` DISABLE KEYS */;
INSERT INTO `tblevent` VALUES (3,'Wedding','This is wedding event'),(5,'Funeral','This is a funeral event'),(6,'Baptismal','baptismal'),(7,'Mock defense','this sample evemt');
/*!40000 ALTER TABLE `tblevent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblrequirement`
--

DROP TABLE IF EXISTS `tblrequirement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblrequirement` (
  `rec_id` int(11) NOT NULL AUTO_INCREMENT,
  `event_id` int(11) DEFAULT NULL,
  `rec_name` varchar(255) DEFAULT NULL,
  `rec_desc` varchar(255) DEFAULT NULL,
  `rec_type` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`rec_id`),
  KEY `event_id` (`event_id`),
  CONSTRAINT `tblrequirement_ibfk_1` FOREIGN KEY (`event_id`) REFERENCES `tblevent` (`event_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblrequirement`
--

LOCK TABLES `tblrequirement` WRITE;
/*!40000 ALTER TABLE `tblrequirement` DISABLE KEYS */;
INSERT INTO `tblrequirement` VALUES (6,3,'Birth Certificate','This is requirement for wedding','Required'),(7,3,'Baptismal Certificate','This is requirement for wedding','Required'),(8,3,'Marriage Banns','This is requirement for wedding','Required'),(9,3,'Confirmation','This is seminar requirement','Required'),(10,3,'Pre-Cana Seminar','This is seminar requirement','Required'),(11,3,'Cofession','This is requirement for wedding','Required'),(12,3,'Pre-Nuptial','Seminar','Required'),(13,5,'Death Certificate','Document','Required'),(14,5,'Burial permit','Document','Optional'),(15,6,'Child Birth Certificate','document','Required'),(16,6,'Parents Marriage Contract','document','Optional'),(22,7,'Complete memeber','this descr','Required');
/*!40000 ALTER TABLE `tblrequirement` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblstaff`
--

DROP TABLE IF EXISTS `tblstaff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblstaff` (
  `staff_id` int(11) NOT NULL,
  `lastname` varchar(255) DEFAULT NULL,
  `firstname` varchar(255) DEFAULT NULL,
  `mi` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `email_add` varchar(255) DEFAULT NULL,
  `contact_num` varchar(255) DEFAULT NULL,
  `role` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`staff_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblstaff`
--

LOCK TABLES `tblstaff` WRITE;
/*!40000 ALTER TABLE `tblstaff` DISABLE KEYS */;
INSERT INTO `tblstaff` VALUES (1,'Sahidjuan','Aljamer','T','Baliwasan','aljamzkhy@gmail.com','09654724484','Admin'),(2,'Arvin','Dumagay','P.','Baliwasan','aljam@gmail.com','09654724484','Staff'),(3,'Jhoey','Grimaldo','M.','Tetuan Zamboanga City','yahoo@gmail.com','09562147895','Staff'),(4,'aljamer','Sahodjuan','T','baliwasan','aljam@gmail.com','0926565652','Staff');
/*!40000 ALTER TABLE `tblstaff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblvenue`
--

DROP TABLE IF EXISTS `tblvenue`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblvenue` (
  `venue_id` int(11) NOT NULL,
  `venue_name` varchar(255) DEFAULT NULL,
  `location` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`venue_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblvenue`
--

LOCK TABLES `tblvenue` WRITE;
/*!40000 ALTER TABLE `tblvenue` DISABLE KEYS */;
INSERT INTO `tblvenue` VALUES (3,'St. Ignatius of Loyola Parish','Tetuan Zamboanga City');
/*!40000 ALTER TABLE `tblvenue` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-10-14 23:26:29
