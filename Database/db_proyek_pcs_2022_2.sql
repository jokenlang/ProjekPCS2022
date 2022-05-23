/*
SQLyog Community
MySQL - 10.4.21-MariaDB : Database - proyek_pcs_2022
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
/*Table structure for table `beverage` */

DROP TABLE IF EXISTS `beverage`;

CREATE TABLE `beverage` (
  `BEV_ID` int(3) NOT NULL AUTO_INCREMENT,
  `BEV_AMOUNT` int(3) NOT NULL DEFAULT 10,
  `BE_NAME` varchar(255) NOT NULL,
  `BE_PRICE` int(6) NOT NULL DEFAULT 50000,
  `BE_STATUS` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`BEV_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4;

/*Data for the table `beverage` */

insert  into `beverage`(`BEV_ID`,`BEV_AMOUNT`,`BE_NAME`,`BE_PRICE`,`BE_STATUS`) values 
(1,10,'Krabby Patty',35000,1),
(2,10,'Fried Rice ',42000,1),
(3,10,'Krabby Patty Wombo Combo',150000,1),
(4,10,'Krabby Patty Rendang',100000,1),
(5,10,'Krabby Patty Special',120000,1),
(6,10,'Coca Cola',10000,1),
(7,10,'French Fries with Chips',25000,1),
(8,10,'French Fries Family Pack',70000,1),
(9,10,'Hotdog with Chips',50000,1),
(10,10,'Hotdog Family Pack',60000,1),
(11,10,'Ice Tea',10000,1),
(12,10,'Lemon Tea',10000,1),
(13,10,'Hot Chocolate',10000,1),
(14,10,'Chocolate Ice Cream',15000,1),
(15,10,'Caramel Popcorn',50000,1),
(16,10,'Salted Popcorn',50000,1),
(17,10,'Plain Popcorn',45000,1);

/*Table structure for table `furniture` */

DROP TABLE IF EXISTS `furniture`;

CREATE TABLE `furniture` (
  `FUR_ID` int(3) NOT NULL AUTO_INCREMENT,
  `FUR_NAME` varchar(255) NOT NULL,
  `fUR_JUMLAH` varchar(255) NOT NULL,
  PRIMARY KEY (`FUR_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `furniture` */

/*Table structure for table `movie` */

DROP TABLE IF EXISTS `movie`;

CREATE TABLE `movie` (
  `MO_ID` int(3) NOT NULL AUTO_INCREMENT,
  `MO_TITLE` varchar(255) NOT NULL,
  `MO_DURATION` int(3) NOT NULL,
  `MO_STATUS` int(1) NOT NULL DEFAULT 1,
  `MO_GENRE` varchar(255) NOT NULL,
  PRIMARY KEY (`MO_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

/*Data for the table `movie` */

insert  into `movie`(`MO_ID`,`MO_TITLE`,`MO_DURATION`,`MO_STATUS`,`MO_GENRE`) values 
(1,'Angle Has Fallen',7260,1,'Comedy'),
(2,'The Imitation Game',6840,1,'Action'),
(3,'The Martian',8640,1,'Horror'),
(4,'Mortal Kombat',6600,1,'Action'),
(5,'Parasite',7920,1,'Drama'),
(6,'Split',7020,1,'Action'),
(7,'Warcraft',7380,1,'Science Fiction'),
(8,'Godzilla Kong',6780,1,'Thriller'),
(9,'KKN di Desa Multiverse',6969,1,'Drama');

/*Table structure for table `pegawai` */

DROP TABLE IF EXISTS `pegawai`;

CREATE TABLE `pegawai` (
  `ID` int(3) NOT NULL AUTO_INCREMENT,
  `NAMA` varchar(500) NOT NULL,
  `STATUS` int(1) NOT NULL,
  `USERNAME` varchar(255) NOT NULL,
  `PASSWORD` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `pegawai` */

insert  into `pegawai`(`ID`,`NAMA`,`STATUS`,`USERNAME`,`PASSWORD`) values 
(1,'Aaron Linggo Satrio',1,'aronbabi','babi'),
(2,'Jonathan Kenzie L',2,'zie','zie'),
(3,'Samuel Gunawan',3,'samgun','sam'),
(4,'John Louis Airlangga',2,'akutan','akutan');

/*Table structure for table `rekap` */

DROP TABLE IF EXISTS `rekap`;

CREATE TABLE `rekap` (
  `REK_ID` int(3) NOT NULL AUTO_INCREMENT,
  `REK_NAMA_BARANG` varchar(255) NOT NULL,
  `REK_JUMLAH` int(3) NOT NULL DEFAULT 0,
  `REK_DESKRIPSI` varchar(500) NOT NULL,
  PRIMARY KEY (`REK_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `rekap` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
