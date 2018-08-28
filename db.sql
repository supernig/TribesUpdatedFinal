-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 28, 2018 at 01:13 PM
-- Server version: 10.1.25-MariaDB
-- PHP Version: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `id` int(11) NOT NULL,
  `description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`id`, `description`) VALUES
(1, 'Staging'),
(2, 'Lights'),
(3, 'Speakers'),
(4, 'Misc.'),
(5, 'Video'),
(6, 'LED Wall'),
(7, 'LCD');

-- --------------------------------------------------------

--
-- Table structure for table `itemcontent`
--

CREATE TABLE `itemcontent` (
  `id` int(11) NOT NULL,
  `itemID` int(11) NOT NULL,
  `tagID` int(11) NOT NULL,
  `modelNumber` varchar(255) NOT NULL,
  `StockID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `itemcontent`
--

INSERT INTO `itemcontent` (`id`, `itemID`, `tagID`, `modelNumber`, `StockID`) VALUES
(1, 25, 1, '1', 25),
(3, 46, 1, '133e124rr12', 0),
(4, 46, 1, 'test', 0),
(5, 46, 1, 'test333', 0),
(6, 46, 1, 'test4', 0),
(7, 46, 1, 'tet', 0),
(8, 46, 3, 'test222224', 0),
(9, 46, 1, 'asd', 0),
(10, 46, 1, 'dsa', 0),
(11, 46, 1, 'tsdfsdg', 0),
(12, 46, 3, 'wewherh', 0),
(13, 46, 1, 'qwe23e', 0),
(14, 46, 1, 'wd32e2d', 0),
(15, 46, 1, 'twetswets', 0),
(16, 46, 1, 'twettt', 0);

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `categoryID` int(11) NOT NULL,
  `tagID` int(11) NOT NULL,
  `stocks` int(11) NOT NULL,
  `isDeployable` int(11) NOT NULL,
  `isDamaged` int(11) NOT NULL,
  `isOnrepair` int(11) NOT NULL,
  `isRented` int(11) NOT NULL,
  `isDeployed` int(11) NOT NULL,
  `isDamagedBeyondRepair` int(11) NOT NULL,
  `description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`id`, `name`, `categoryID`, `tagID`, `stocks`, `isDeployable`, `isDamaged`, `isOnrepair`, `isRented`, `isDeployed`, `isDamagedBeyondRepair`, `description`) VALUES
(37, '3', 2, 1, 0, 0, 0, 0, 0, 0, 0, 'test'),
(38, '5', 11, 1, 0, 0, 0, 0, 0, 0, 0, '1'),
(39, 'te', 21, 1, 0, 0, 0, 0, 0, 0, 0, '1'),
(40, 't', 11, 1, 0, 0, 0, 0, 0, 0, 0, '1'),
(46, 'test323', 1, 1, 0, 0, 0, 0, 0, 0, 0, '1');

-- --------------------------------------------------------

--
-- Table structure for table `repairlogs`
--

CREATE TABLE `repairlogs` (
  `id` int(11) NOT NULL,
  `itemID` int(11) NOT NULL,
  `daterepaired` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `repairlogs`
--

INSERT INTO `repairlogs` (`id`, `itemID`, `daterepaired`) VALUES
(5, 11, '8/28/2018 6:11:10 PM'),
(6, 7, '8/28/2018 6:14:10 PM'),
(7, 9, '8/28/2018 6:15:14 PM'),
(8, 11, '8/28/2018 6:18:16 PM'),
(9, 0, '8/28/2018 6:21:53 PM'),
(10, 0, '8/28/2018 6:22:16 PM');

-- --------------------------------------------------------

--
-- Table structure for table `tag`
--

CREATE TABLE `tag` (
  `id` int(11) NOT NULL,
  `description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tag`
--

INSERT INTO `tag` (`id`, `description`) VALUES
(1, 'Deployable'),
(2, 'Damaged'),
(3, 'On-repair'),
(4, 'Rented'),
(5, 'Damaged Beyond Repair'),
(6, 'Deployed');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `itemcontent`
--
ALTER TABLE `itemcontent`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `repairlogs`
--
ALTER TABLE `repairlogs`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tag`
--
ALTER TABLE `tag`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `itemcontent`
--
ALTER TABLE `itemcontent`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;
--
-- AUTO_INCREMENT for table `repairlogs`
--
ALTER TABLE `repairlogs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `tag`
--
ALTER TABLE `tag`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
