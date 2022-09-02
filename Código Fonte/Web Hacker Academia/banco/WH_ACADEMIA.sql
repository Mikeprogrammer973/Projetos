-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 26-Maio-2022 às 03:22
-- Versão do servidor: 5.7.36
-- versão do PHP: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `wh_academia`
--
CREATE DATABASE IF NOT EXISTS `wh_academia` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `wh_academia`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `horaires`
--

DROP TABLE IF EXISTS `horaires`;
CREATE TABLE IF NOT EXISTS `horaires` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `desc_horaire` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `horaires`
--

INSERT INTO `horaires` (`id`, `desc_horaire`) VALUES
(1, '06:00 - 07:00'),
(2, '07:00 - 08:00'),
(3, '08:00 - 09:00'),
(4, '09:00 - 10:00'),
(5, '10:00 - 11:00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `profs`
--

DROP TABLE IF EXISTS `profs`;
CREATE TABLE IF NOT EXISTS `profs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(70) NOT NULL,
  `telefone` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `profs`
--

INSERT INTO `profs` (`id`, `nome`, `telefone`) VALUES
(1, 'Mike Pascal', '+55 (47) 99667-6941'),
(2, 'Maria Eduarda Santos', '+55 (11) 99887-6944'),
(3, 'Pedro Reis', '+55 (47) 97428-0783'),
(4, 'Priscilla Ferro', '+55 (42) 90876-2364'),
(5, 'Daniella Soares', '+55 (47) 99748-0964'),
(6, 'Peter Morningstar', '+55 (11) 94903-2894'),
(7, 'Evelyn Andréas Cortéz', '+52 (686) 912 6498');

-- --------------------------------------------------------

--
-- Estrutura da tabela `turmas`
--

DROP TABLE IF EXISTS `turmas`;
CREATE TABLE IF NOT EXISTS `turmas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `desc_turma` text NOT NULL,
  `prof` varchar(70) NOT NULL,
  `horaire` text NOT NULL,
  `max_alunos` int(11) NOT NULL DEFAULT '-1',
  `status` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `turmas`
--

INSERT INTO `turmas` (`id`, `desc_turma`, `prof`, `horaire`, `max_alunos`, `status`) VALUES
(1, 'Natação 1', '3', '2', 37, 'A'),
(2, 'Gimnástica', '7', '4', 20, 'A'),
(3, 'Natação 2', '6', '2', 19, 'A'),
(4, 'Karatê', '1', '5', 30, 'A'),
(5, 'Yoga', '5', '1', 60, 'A'),
(6, 'Judô', '4', '5', 40, 'A');

-- --------------------------------------------------------

--
-- Estrutura da tabela `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `level` int(11) NOT NULL,
  `status` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `users`
--

INSERT INTO `users` (`id`, `nome`, `username`, `senha`, `level`, `status`) VALUES
(1, 'Maria Eduarda Santos', 'Maria_duda', 'maria_duda', 2, 'A'),
(2, 'Priscilla Ferro', 'Prisc_Ferro', 'priscilla123', 3, 'A'),
(3, 'Karen Alundra', 'Karen_Al', 'karen_973', 3, 'A'),
(5, 'Daniella Soares', 'Dani_So', 'dani_soares', 3, 'A');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
