-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 26, 2016 at 08:46 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 7.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pos`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `id` int(11) NOT NULL,
  `nama` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `alamat` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `no_hp` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  `jenis_kelamin` tinyint(2) NOT NULL,
  `waktu_buat` date NOT NULL,
  `waktu_ubah` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`id`, `nama`, `alamat`, `no_hp`, `jenis_kelamin`, `waktu_buat`, `waktu_ubah`) VALUES
(2, 'asd', 'asd', '123123', 1, '2016-12-26', '2016-12-26');

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

CREATE TABLE `item` (
  `id` int(11) NOT NULL,
  `kode_barang` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `nama_barang` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `jumlah_awal` int(11) NOT NULL,
  `harga_hpp` decimal(10,0) NOT NULL,
  `harga_jual` decimal(10,0) NOT NULL,
  `waktu_buat` date NOT NULL,
  `waktu_ubah` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`id`, `kode_barang`, `nama_barang`, `jumlah_awal`, `harga_hpp`, `harga_jual`, `waktu_buat`, `waktu_ubah`) VALUES
(1, 'asdasd', 'makan', 0, '10', '11', '2016-12-26', '2016-12-26'),
(2, 'a12', 'pepo', 0, '10000', '11000', '2016-12-26', '2016-12-26');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian`
--

CREATE TABLE `pembelian` (
  `id` int(11) NOT NULL,
  `id_item` int(11) NOT NULL,
  `id_supplier` int(11) NOT NULL,
  `jumlah_barang` int(11) NOT NULL,
  `waktu_buat` date NOT NULL,
  `waktu_ubah` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pembelian`
--

INSERT INTO `pembelian` (`id`, `id_item`, `id_supplier`, `jumlah_barang`, `waktu_buat`, `waktu_ubah`) VALUES
(1, 1, 1, 23, '2016-12-26', '2016-12-26'),
(2, 2, 1, 12, '2016-12-26', '2016-12-26'),
(3, 2, 1, 123, '2016-12-26', '2016-12-26'),
(4, 2, 1, 12, '2016-12-26', '2016-12-26'),
(5, 2, 1, 12, '2016-12-26', '2016-12-26'),
(6, 2, 1, 12, '2016-12-26', '2016-12-26');

-- --------------------------------------------------------

--
-- Table structure for table `penjualan`
--

CREATE TABLE `penjualan` (
  `id` int(11) NOT NULL,
  `id_item` int(11) NOT NULL,
  `id_customer` int(11) NOT NULL,
  `jumlah_barang` int(11) NOT NULL,
  `waktu_buat` date NOT NULL,
  `waktu_ubah` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penjualan`
--

INSERT INTO `penjualan` (`id`, `id_item`, `id_customer`, `jumlah_barang`, `waktu_buat`, `waktu_ubah`) VALUES
(1, 1, 2, 1, '2016-12-26', '2016-12-26'),
(2, 1, 2, 1, '2016-12-26', '2016-12-26'),
(3, 1, 2, 1, '2016-12-26', '2016-12-26'),
(4, 1, 2, 1, '2016-12-26', '2016-12-26'),
(5, 1, 2, 1, '2016-12-26', '2016-12-26'),
(6, 2, 2, 1, '2016-12-26', '2016-12-26'),
(7, 2, 2, 1, '2016-12-26', '2016-12-26'),
(8, 1, 2, 1, '2016-12-26', '2016-12-26'),
(9, 2, 2, 1, '2016-12-26', '2016-12-26'),
(10, 1, 2, 1, '2016-12-26', '2016-12-26'),
(11, 2, 2, 160, '2016-12-26', '2016-12-26');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `id` int(11) NOT NULL,
  `nama` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `alamat` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `no_hp` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `jenis_kelamin` tinyint(2) NOT NULL,
  `waktu_buat` date NOT NULL,
  `waktu_ubah` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`id`, `nama`, `alamat`, `no_hp`, `jenis_kelamin`, `waktu_buat`, `waktu_ubah`) VALUES
(1, 'asd', '123', '12312', 0, '2016-12-26', '2016-12-26');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `pembelian`
--
ALTER TABLE `pembelian`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `penjualan`
--
ALTER TABLE `penjualan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
