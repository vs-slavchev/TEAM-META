-- phpMyAdmin SQL Dump
-- version 4.2.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jun 10, 2016 at 11:26 AM
-- Server version: 5.5.11
-- PHP Version: 5.5.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbi345959`
--

-- --------------------------------------------------------

--
-- Table structure for table `camp`
--

CREATE TABLE IF NOT EXISTS `camp` (
  `camp_id` int(5) NOT NULL,
  `user_count` int(5) DEFAULT NULL,
  `organizer_code` char(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `material`
--

CREATE TABLE IF NOT EXISTS `material` (
  `material_id` int(5) NOT NULL,
  `type` varchar(32) NOT NULL,
  `rent_price` decimal(15,2) NOT NULL DEFAULT '0.00',
  `quantity` int(5) NOT NULL,
  `quantity_left` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `material_loan`
--

CREATE TABLE IF NOT EXISTS `material_loan` (
  `user_qr` char(40) NOT NULL,
  `material_id` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE IF NOT EXISTS `product` (
  `product_id` int(5) NOT NULL,
  `category` varchar(16) NOT NULL,
  `price` decimal(15,2) NOT NULL DEFAULT '0.00',
  `product_name` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `purchase`
--

CREATE TABLE IF NOT EXISTS `purchase` (
`purchase_id` int(20) NOT NULL,
  `user_qr` char(40) NOT NULL,
  `product_id` int(5) NOT NULL,
  `shop_id` int(5) NOT NULL,
  `quantity` int(5) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

-- --------------------------------------------------------

--
-- Table structure for table `reader_device`
--

CREATE TABLE IF NOT EXISTS `reader_device` (
`device_id` int(3) NOT NULL,
  `qr_value` char(64) DEFAULT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=100 ;

-- --------------------------------------------------------

--
-- Table structure for table `shop`
--

CREATE TABLE IF NOT EXISTS `shop` (
  `shop_id` int(5) NOT NULL,
  `shop_name` varchar(16) NOT NULL,
  `location` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `qr_code` char(40) NOT NULL,
  `email` varchar(64) NOT NULL,
  `first_name` varchar(64) DEFAULT NULL,
  `last_name` varchar(64) DEFAULT NULL,
  `paypal` varchar(32) DEFAULT NULL,
  `phone_number` varchar(32) DEFAULT NULL,
  `camp_id` int(8) DEFAULT NULL,
  `money` decimal(15,2) NOT NULL DEFAULT '0.00',
  `money_owed` decimal(15,2) NOT NULL DEFAULT '0.00',
  `total_money` decimal(15,2) NOT NULL DEFAULT '0.00',
  `has_entered` tinyint(1) NOT NULL DEFAULT '0',
  `has_left` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `camp`
--
ALTER TABLE `camp`
 ADD PRIMARY KEY (`camp_id`);

--
-- Indexes for table `material`
--
ALTER TABLE `material`
 ADD PRIMARY KEY (`material_id`);

--
-- Indexes for table `material_loan`
--
ALTER TABLE `material_loan`
 ADD PRIMARY KEY (`user_qr`,`material_id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
 ADD PRIMARY KEY (`product_id`);

--
-- Indexes for table `purchase`
--
ALTER TABLE `purchase`
 ADD PRIMARY KEY (`purchase_id`);

--
-- Indexes for table `reader_device`
--
ALTER TABLE `reader_device`
 ADD PRIMARY KEY (`device_id`);

--
-- Indexes for table `shop`
--
ALTER TABLE `shop`
 ADD PRIMARY KEY (`shop_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
 ADD PRIMARY KEY (`qr_code`), ADD UNIQUE KEY `email` (`email`), ADD UNIQUE KEY `paypal` (`paypal`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `purchase`
--
ALTER TABLE `purchase`
MODIFY `purchase_id` int(20) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `reader_device`
--
ALTER TABLE `reader_device`
MODIFY `device_id` int(3) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=100;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
