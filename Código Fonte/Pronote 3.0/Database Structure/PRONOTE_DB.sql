-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Aug 15, 2022 at 08:49 PM
-- Server version: 5.7.36
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pronote`
--
CREATE DATABASE IF NOT EXISTS `pronote` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `pronote`;

-- --------------------------------------------------------

--
-- Table structure for table `adms`
--

DROP TABLE IF EXISTS `adms`;
CREATE TABLE IF NOT EXISTS `adms` (
  `code_adm` varchar(100) NOT NULL,
  `nome_completo` varchar(120) NOT NULL,
  `foto_perfil_adm` blob NOT NULL,
  `status` varchar(1) NOT NULL DEFAULT 'C',
  `email` varchar(200) DEFAULT NULL,
  UNIQUE KEY `code_adm` (`code_adm`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `adms`
--

INSERT INTO `adms` (`code_adm`, `nome_completo`, `foto_perfil_adm`, `status`, `email`) VALUES
('maria_db', 'Maria Santos', 0x65752e706e67, 'C', 'mikepascal.delta@gmail.com'),
('mike_973', 'Mike Pascal', 0x65752e706e67, 'C', 'mikepascaleleven@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `alunos`
--

DROP TABLE IF EXISTS `alunos`;
CREATE TABLE IF NOT EXISTS `alunos` (
  `code_escola` varchar(100) NOT NULL,
  `matricula` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `nome_completo` varchar(120) NOT NULL,
  `code_turma` varchar(100) NOT NULL,
  `foto_perfil_aluno` blob NOT NULL,
  `status` varchar(1) NOT NULL DEFAULT 'C',
  UNIQUE KEY `matricula` (`matricula`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `alunos`
--

INSERT INTO `alunos` (`code_escola`, `matricula`, `senha`, `nome_completo`, `code_turma`, `foto_perfil_aluno`, `status`) VALUES
('PB_007', '123581321', '', 'Priscilla Ferro', 'TPB_001', 0x616c756e6f2e706e67, 'C'),
('PB_007', '1501203005', '', 'Hope Morningstar Pascal', 'TPB_001', 0x616c756e6f2e706e67, 'C');

-- --------------------------------------------------------

--
-- Table structure for table `cargos_prof`
--

DROP TABLE IF EXISTS `cargos_prof`;
CREATE TABLE IF NOT EXISTS `cargos_prof` (
  `code_escola` varchar(100) NOT NULL,
  `code_turma` varchar(100) NOT NULL,
  `code_prof` varchar(100) NOT NULL,
  `code_disciplina` varchar(100) NOT NULL,
  `nome_disciplina` varchar(120) NOT NULL,
  `status` varchar(1) NOT NULL DEFAULT 'C',
  UNIQUE KEY `code_disciplina` (`code_disciplina`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `cargos_prof`
--

INSERT INTO `cargos_prof` (`code_escola`, `code_turma`, `code_prof`, `code_disciplina`, `nome_disciplina`, `status`) VALUES
('PB_007', 'TPB_001', 'PPB_001', 'DPB_001', 'Matemática', 'C');

-- --------------------------------------------------------

--
-- Table structure for table `escolas`
--

DROP TABLE IF EXISTS `escolas`;
CREATE TABLE IF NOT EXISTS `escolas` (
  `code_escola` varchar(100) NOT NULL,
  `nome_escola` varchar(120) NOT NULL,
  `tipo_periodo` varchar(120) NOT NULL DEFAULT 'Semestre',
  `qtd_periodo` int(11) NOT NULL DEFAULT '2',
  `foto_perfil_escola` blob NOT NULL,
  `code_adm_escola` varchar(100) NOT NULL,
  `status` varchar(1) NOT NULL DEFAULT 'C',
  UNIQUE KEY `code_escola` (`code_escola`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `escolas`
--

INSERT INTO `escolas` (`code_escola`, `nome_escola`, `tipo_periodo`, `qtd_periodo`, `foto_perfil_escola`, `code_adm_escola`, `status`) VALUES
('PB_007', 'Paulo Bauer', 'Bimestre', 4, 0x6573636f6c612e706e67, 'maria_db', 'C'),
('WH_007', 'Web Hacker', 'Trimestre', 4, 0x6573636f6c612e706e67, 'mike_973', 'C');

-- --------------------------------------------------------

--
-- Table structure for table `info_alunos`
--

DROP TABLE IF EXISTS `info_alunos`;
CREATE TABLE IF NOT EXISTS `info_alunos` (
  `code_escola` varchar(100) NOT NULL,
  `code_turma` varchar(100) NOT NULL,
  `matricula` varchar(100) NOT NULL,
  `code_disciplina` varchar(100) NOT NULL,
  `code_prof` varchar(100) NOT NULL,
  `periodo` varchar(120) NOT NULL,
  `code_media` int(11) NOT NULL AUTO_INCREMENT,
  `media` double NOT NULL,
  `status` varchar(1) NOT NULL DEFAULT 'C',
  PRIMARY KEY (`code_media`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `mensagens`
--

DROP TABLE IF EXISTS `mensagens`;
CREATE TABLE IF NOT EXISTS `mensagens` (
  `code_escola` varchar(100) NOT NULL,
  `code_msg` int(11) NOT NULL,
  `msg` text NOT NULL,
  `destinatario` varchar(100) NOT NULL,
  UNIQUE KEY `code_msg` (`code_msg`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `notas_alunos`
--

DROP TABLE IF EXISTS `notas_alunos`;
CREATE TABLE IF NOT EXISTS `notas_alunos` (
  `code_escola` varchar(100) NOT NULL,
  `code_turma` varchar(100) NOT NULL,
  `matricula` varchar(100) NOT NULL,
  `code_disciplina` varchar(100) NOT NULL,
  `code_prof` varchar(100) NOT NULL,
  `periodo` varchar(120) NOT NULL,
  `code_nota` int(11) NOT NULL AUTO_INCREMENT,
  `nota` double NOT NULL,
  `desc_nota` text,
  `status` varchar(1) NOT NULL DEFAULT 'C',
  PRIMARY KEY (`code_nota`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `notas_alunos`
--

INSERT INTO `notas_alunos` (`code_escola`, `code_turma`, `matricula`, `code_disciplina`, `code_prof`, `periodo`, `code_nota`, `nota`, `desc_nota`, `status`) VALUES
('PB_007', 'TPB_001', '123581321', 'DPB_001', 'PPB_001', '1° Bimestre', 1, 9.87, 'Nota da prova sobre as inequações do 2° grau.', 'C');

-- --------------------------------------------------------

--
-- Table structure for table `profs`
--

DROP TABLE IF EXISTS `profs`;
CREATE TABLE IF NOT EXISTS `profs` (
  `code_escola` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `code_prof` varchar(100) NOT NULL,
  `nome_completo` varchar(120) NOT NULL,
  `foto_perfil_prof` blob NOT NULL,
  `status` varchar(1) NOT NULL DEFAULT 'C',
  UNIQUE KEY `code_prof` (`code_prof`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `profs`
--

INSERT INTO `profs` (`code_escola`, `senha`, `code_prof`, `nome_completo`, `foto_perfil_prof`, `status`) VALUES
('PB_007', '', 'PPB_001', 'José da Silva Santos', 0x70726f662e706e67, 'C');

-- --------------------------------------------------------

--
-- Table structure for table `turmas`
--

DROP TABLE IF EXISTS `turmas`;
CREATE TABLE IF NOT EXISTS `turmas` (
  `code_escola` varchar(100) NOT NULL,
  `code_turma` varchar(100) NOT NULL,
  `nome_turma` varchar(120) NOT NULL,
  `foto_perfil_turma` blob NOT NULL,
  `status` varchar(1) NOT NULL DEFAULT 'C',
  UNIQUE KEY `code_turma` (`code_turma`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `turmas`
--

INSERT INTO `turmas` (`code_escola`, `code_turma`, `nome_turma`, `foto_perfil_turma`, `status`) VALUES
('PB_007', 'TPB_007', '5° Fromager', 0x7475726d612e706e67, 'C');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
