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

/*Table structure for table `dtrans_beverage` */

DROP TABLE IF EXISTS `dtrans_beverage`;

CREATE TABLE `dtrans_beverage` (
  `DT_ID` int(6) DEFAULT NULL,
  `ID_HT` int(6) DEFAULT NULL,
  `DT_ID_PRODUK` int(6) DEFAULT NULL,
  `DT_JUMLAH` int(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `dtrans_beverage` */

insert  into `dtrans_beverage`(`DT_ID`,`ID_HT`,`DT_ID_PRODUK`,`DT_JUMLAH`) values 
(1,1,14,3),
(2,2,1,3),
(3,3,15,5),
(4,3,4,2),
(5,3,3,2),
(6,4,15,1),
(7,4,2,2),
(8,5,15,3),
(9,5,1,2),
(10,5,10,1),
(11,5,7,4),
(12,5,6,2),
(13,6,15,2),
(14,6,1,2),
(15,7,6,2),
(16,7,1,2),
(17,7,6,4),
(18,7,7,2),
(19,8,15,2),
(20,8,6,2),
(21,8,9,1),
(22,9,14,2),
(23,9,3,1),
(24,9,6,4);

/*Table structure for table `dtrans_movie` */

DROP TABLE IF EXISTS `dtrans_movie`;

CREATE TABLE `dtrans_movie` (
  `DT_ID` int(6) NOT NULL AUTO_INCREMENT,
  `DT_HT_ID` int(6) NOT NULL,
  `DT_ID_MOVIE` int(6) NOT NULL,
  `DT_JUMLAH` int(6) DEFAULT NULL,
  PRIMARY KEY (`DT_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=65 DEFAULT CHARSET=utf8mb4;

/*Data for the table `dtrans_movie` */

insert  into `dtrans_movie`(`DT_ID`,`DT_HT_ID`,`DT_ID_MOVIE`,`DT_JUMLAH`) values 
(1,1,1,1),
(2,1,1,1),
(3,1,1,1),
(4,2,2,2),
(5,2,3,2),
(6,2,5,2),
(7,2,5,3),
(8,2,8,2),
(9,2,9,2),
(10,3,5,3),
(11,3,6,4),
(12,4,7,5),
(13,4,7,5),
(14,4,7,5),
(15,4,5,4),
(16,4,5,4),
(17,5,4,4),
(18,5,3,3),
(19,5,3,3),
(20,6,1,3),
(21,6,1,3),
(22,6,2,2),
(23,7,3,1),
(24,7,4,1),
(25,7,5,2),
(26,7,6,2),
(27,7,7,2),
(28,8,8,1),
(29,8,9,1),
(30,8,5,2),
(31,8,1,2),
(32,8,2,2),
(33,9,3,3),
(34,9,4,4),
(35,10,5,3),
(36,10,6,3),
(37,10,7,3),
(38,11,4,3),
(39,11,1,3),
(40,11,4,4),
(41,11,5,5),
(42,12,2,6),
(43,12,1,6),
(44,12,2,5),
(45,12,4,4),
(46,13,2,4),
(47,13,3,4),
(48,13,1,4),
(49,13,4,3),
(50,14,5,3),
(51,14,6,3),
(52,14,6,3),
(53,14,7,3),
(54,14,7,2),
(55,14,7,2),
(56,14,7,2),
(57,14,5,1),
(58,15,1,1),
(59,16,1,3),
(60,16,1,4),
(61,16,1,5),
(62,17,2,6),
(63,17,2,5),
(64,17,2,1);

/*Table structure for table `furniture` */

DROP TABLE IF EXISTS `furniture`;

CREATE TABLE `furniture` (
  `FUR_ID` int(3) NOT NULL AUTO_INCREMENT,
  `FUR_NAME` varchar(255) NOT NULL,
  `fUR_JUMLAH` varchar(255) NOT NULL,
  `FUR_MASUK` date NOT NULL,
  `FUR_STATUS` int(1) NOT NULL,
  `FUR_PRICE` int(10) NOT NULL,
  PRIMARY KEY (`FUR_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

/*Data for the table `furniture` */

insert  into `furniture`(`FUR_ID`,`FUR_NAME`,`fUR_JUMLAH`,`FUR_MASUK`,`FUR_STATUS`,`FUR_PRICE`) values 
(1,'Meja Resepsionis','3','2022-02-04',1,10000000),
(2,'Tiket Printer','3','2022-02-04',1,6000000),
(3,'Mesin Pembuat Popcorn','1','2022-02-04',1,5000000),
(4,'Mesin Dispenser Minuman','2','2022-02-04',1,600000),
(5,'Monitor','3','2022-02-04',1,700000),
(6,'PC','3','2022-02-04',1,9000000),
(7,'Mouse & Keyboard','3','2022-02-04',1,800000),
(8,'Kursi Tunggu','20','2022-02-04',1,1000000);

/*Table structure for table `htrans_beverage` */

DROP TABLE IF EXISTS `htrans_beverage`;

CREATE TABLE `htrans_beverage` (
  `HT_ID_HT` int(6) DEFAULT NULL,
  `HT_NO_NOTA` int(6) DEFAULT NULL,
  `HT_TANGGAL` date DEFAULT NULL,
  `HT_ID_KASIR` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `htrans_beverage` */

/*Table structure for table `htrans_movie` */

DROP TABLE IF EXISTS `htrans_movie`;

CREATE TABLE `htrans_movie` (
  `HT_ID_HT` int(6) NOT NULL,
  `HT_NO_NOTA` int(6) NOT NULL,
  `HT_TANGGAL` date NOT NULL,
  `HT_ID_KASIR` int(3) NOT NULL,
  PRIMARY KEY (`HT_ID_HT`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `htrans_movie` */

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

/*Table structure for table `status` */

DROP TABLE IF EXISTS `status`;

CREATE TABLE `status` (
  `STA_ID` int(3) NOT NULL AUTO_INCREMENT,
  `STA_NAME` varchar(255) NOT NULL,
  PRIMARY KEY (`STA_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `status` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
