-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 30, 2023 at 05:29 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `boardgame`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

CREATE TABLE `admins` (
  `ID` int(11) NOT NULL,
  `UserName` varchar(100) DEFAULT NULL,
  `HOTEN` varchar(100) NOT NULL,
  `PassWord` varchar(255) NOT NULL,
  `sdt` varchar(12) NOT NULL,
  `email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admins`
--

INSERT INTO `admins` (`ID`, `UserName`, `HOTEN`, `PassWord`, `sdt`, `email`) VALUES
(1, '21522106', 'Hoàng Ngọc Hồng', 'hong0608', '0366928921', 'hoangngochong03@gmail.com'),
(2, '21522159', 'Nguyễn Thành Huy', 'huy1234', '0123456789', 'thanhhuy@gmail.com'),
(3, '21522592', 'Nguyễn Trần Hội Thắng', 'thang1234', '098712245', 'thang@gmail.com'),
(4, '21522109', 'Từ Thì Huệ', 'hue1234', '023658558', 'hue@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `boardgame`
--

CREATE TABLE `boardgame` (
  `MASP` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `TENSP` varchar(100) DEFAULT NULL,
  `GIA` int(11) DEFAULT NULL,
  `THELOAI` varchar(100) DEFAULT NULL,
  `SOLUONG` int(11) DEFAULT NULL,
  `MOTA` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `USERNAME` varchar(100) NOT NULL,
  `HOTEN` varchar(100) NOT NULL,
  `PassWord` varchar(255) NOT NULL,
  `sdt` varchar(12) NOT NULL,
  `email` varchar(100) NOT NULL,
  `ngaytao` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`USERNAME`, `HOTEN`, `PassWord`, `sdt`, `email`, `ngaytao`) VALUES
('hoangngochong', 'Hoàng Ngọc Hồng', 'hong122606', '0366928921', 'hoangngochong@gmail.com', '2023-06-27');

-- --------------------------------------------------------

--
-- Table structure for table `order_game`
--

CREATE TABLE `order_game` (
  `order_id` bigint(20) UNSIGNED NOT NULL,
  `customer_id` bigint(20) UNSIGNED NOT NULL,
  `date_created` date DEFAULT NULL,
  `tongtien` double DEFAULT NULL,
  `soluong` bigint(21) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `thue`
--

CREATE TABLE `thue` (
  `USERNAME` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci DEFAULT NULL,
  `NGAYTHUE` date DEFAULT NULL,
  `TONGTIEN` int(11) DEFAULT NULL,
  `ID_THUE` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `thue`
--

INSERT INTO `thue` (`USERNAME`, `NGAYTHUE`, `TONGTIEN`, `ID_THUE`) VALUES
('21522106', '2023-06-29', 65, 1429),
('21522106', '2023-06-28', 65, 2567),
('HOÀNG NGỌC HỒNG', '2023-06-26', 65, 4824),
('21522106', '2023-06-29', 65, 6039),
('21522106', '2023-06-28', 65, 6271),
('HOÀNG NGỌC HỒNG', '2023-06-28', 65, 6466),
('HOÀNG NGỌC HỒNG', '2023-06-27', 65, 6492),
('Red', '2023-06-27', 65, 7276),
('HOÀNG NGỌC HỒNG', '2023-06-28', 65, 9431);

-- --------------------------------------------------------

--
-- Table structure for table `thuegame`
--

CREATE TABLE `thuegame` (
  `ID_THUE` varchar(100) NOT NULL,
  `MASP` varchar(100) NOT NULL,
  `TENSP` varchar(255) DEFAULT NULL,
  `SOLUONG` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `thuegame`
--

INSERT INTO `thuegame` (`ID_THUE`, `MASP`, `TENSP`, `SOLUONG`) VALUES
('4824', 'BGOO1', 'Chess: Luxury Version', 1),
('7276', 'BGOO1', 'Chess: Luxury Version', 1),
('6492', 'BGOO1', 'Chess: Luxury Version', 1),
('2567', 'BGOO1', 'Chess: Luxury Version', 1),
('9431', 'BGOO1', 'Chess: Luxury Version', 1),
('6466', 'BGOO1', 'Chess: Luxury Version', 1),
('6271', 'BGOO1', 'Chess: Luxury Version', 1),
('1429', 'BGOO1', 'Chess: Luxury Version', 1),
('6039', 'BGOO1', 'Chess: Luxury Version', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tragame`
--

CREATE TABLE `tragame` (
  `ID_TRA` int(100) NOT NULL,
  `ID_THUE` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  `NGAYTRA` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`USERNAME`);

--
-- Indexes for table `thue`
--
ALTER TABLE `thue`
  ADD PRIMARY KEY (`ID_THUE`),
  ADD UNIQUE KEY `ID_THUE` (`ID_THUE`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
