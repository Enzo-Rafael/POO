-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 20-Ago-2021 às 20:11
-- Versão do servidor: 5.7.31
-- versão do PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `3a2enzo10`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `pc_enzo`
--

DROP TABLE IF EXISTS `pc_enzo`;
CREATE TABLE IF NOT EXISTS `pc_enzo` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(70) NOT NULL,
  `memoria` varchar(45) NOT NULL,
  `processador` varchar(70) NOT NULL,
  `hd` varchar(45) NOT NULL,
  `marca` varchar(70) NOT NULL,
  `placamae` varchar(70) NOT NULL,
  `ano` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  `defeito` varchar(200) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `pc_enzo`
--

INSERT INTO `pc_enzo` (`codigo`, `nome`, `memoria`, `processador`, `hd`, `marca`, `placamae`, `ano`, `status`, `defeito`) VALUES
(1, '1', '1', '1', '1', '1', '1', '1', 'Funciona', '1');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
