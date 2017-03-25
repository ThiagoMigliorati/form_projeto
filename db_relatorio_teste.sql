-- phpMyAdmin SQL Dump
-- version 4.5.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 25-Mar-2017 às 17:37
-- Versão do servidor: 5.7.11
-- PHP Version: 5.6.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_relatorio_teste`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cuidador`
--

CREATE TABLE `tb_cuidador` (
  `id_cuidador` int(11) NOT NULL,
  `nome_cuidador` varchar(80) NOT NULL,
  `nascimento_cuidador` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_cuidador`
--

INSERT INTO `tb_cuidador` (`id_cuidador`, `nome_cuidador`, `nascimento_cuidador`) VALUES
(1, 'Robson Bailarino', '1980-01-01'),
(2, 'Carlos Aquino ', '1981-01-01');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_idoso`
--

CREATE TABLE `tb_idoso` (
  `id_idoso` int(11) NOT NULL,
  `nome_idoso` varchar(80) NOT NULL,
  `nascimento_idoso` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_idoso`
--

INSERT INTO `tb_idoso` (`id_idoso`, `nome_idoso`, `nascimento_idoso`) VALUES
(1, 'José Dantas Valdivia', '1980-06-11'),
(2, 'Juan Lemos Laminiosa', '1970-01-01'),
(3, 'Carlos Chavez Glamour Glads', '1920-01-01'),
(4, 'Marie Tchaca Bum', '1930-01-01'),
(5, 'Tomaz Turbando', '1930-02-02');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_relatorio`
--

CREATE TABLE `tb_relatorio` (
  `id_relatorio` int(11) NOT NULL,
  `data_relatorio` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `cafe_relatorio` varchar(50) NOT NULL,
  `colacao_relatorio` varchar(50) NOT NULL,
  `almoco_relatorio` varchar(50) NOT NULL,
  `lanche_relatorio` varchar(50) NOT NULL,
  `jantar_relatorio` varchar(50) NOT NULL,
  `ceia_relatorio` varchar(50) NOT NULL,
  `liquido_relatorio` varchar(50) NOT NULL,
  `urina_relatorio` varchar(50) NOT NULL,
  `evacuacao_relatorio` varchar(50) NOT NULL,
  `banho_relatorio` varchar(50) NOT NULL,
  `sono_relatorio` varchar(50) NOT NULL,
  `intensidade_dor_relatorio` int(11) NOT NULL,
  `obs_relatorio` text NOT NULL,
  `q1_relatorio` tinyint(1) NOT NULL,
  `q2_relatorio` tinyint(1) NOT NULL,
  `q3_relatorio` tinyint(1) NOT NULL,
  `q4_relatorio` tinyint(1) NOT NULL,
  `q5_relatorio` tinyint(1) NOT NULL,
  `q6_relatorio` tinyint(1) NOT NULL,
  `q7_relatorio` tinyint(1) NOT NULL,
  `q8_relatorio` tinyint(1) NOT NULL,
  `q9_relatorio` tinyint(1) NOT NULL,
  `q10_relatorio` tinyint(1) NOT NULL,
  `q11_relatorio` tinyint(1) NOT NULL,
  `fk_cuidador` int(11) NOT NULL,
  `fk_idoso` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_relatorio`
--

INSERT INTO `tb_relatorio` (`id_relatorio`, `data_relatorio`, `cafe_relatorio`, `colacao_relatorio`, `almoco_relatorio`, `lanche_relatorio`, `jantar_relatorio`, `ceia_relatorio`, `liquido_relatorio`, `urina_relatorio`, `evacuacao_relatorio`, `banho_relatorio`, `sono_relatorio`, `intensidade_dor_relatorio`, `obs_relatorio`, `q1_relatorio`, `q2_relatorio`, `q3_relatorio`, `q4_relatorio`, `q5_relatorio`, `q6_relatorio`, `q7_relatorio`, `q8_relatorio`, `q9_relatorio`, `q10_relatorio`, `q11_relatorio`, `fk_cuidador`, `fk_idoso`) VALUES
(1, '2017-03-25 14:06:24', '1 a 3', '1 a 3', '1 a 3', '1 a 3', '1 a 3', '1 a 3', '1 a 3', '1 a 3', '1 a 3', '1 a 3', '1 a 3', 20, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque at neque nibh. Mauris tincidunt quam dolor, a commodo est mattis eget. Donec consectetur consequat leo, vel finibus magna pretium vel. Nullam a hendrerit nibh. Suspendisse sed mi in turpis vulputate vestibulum eget at lacus. Curabitur ut nibh id arcu vestibulum consectetur eleifend ac nisl. Praesent at elementum tellus, non blandit augue. Suspendisse at mi vitae enim posuere faucibus non quis dui. Nam sit amet nunc id sem blandit tristique sed id mauris. Nulla eget mauris nisi. Sed ultricies dolor est, in placerat est efficitur sed. Suspendisse scelerisque, ipsum in suscipit placerat, sapien neque tincidunt tellus, at tristique felis leo ut nulla.', 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 4),
(2, '2017-03-25 14:19:23', 'Nada', 'Nada', 'Nada', 'Nada', 'Nada', 'Nada', 'Tudo', 'Tudo', 'Tudo', 'Tudo', 'Tudo', 24, '', 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1),
(3, '2017-03-25 14:19:26', 'Nada', 'Nada', 'Nada', 'Nada', 'Nada', 'Nada', 'Tudo', 'Tudo', 'Tudo', 'Tudo', 'Tudo', 24, '', 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1),
(4, '2017-03-25 14:19:27', 'Nada', 'Nada', 'Nada', 'Nada', 'Nada', 'Nada', 'Tudo', 'Tudo', 'Tudo', 'Tudo', 'Tudo', 24, '', 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1),
(5, '2017-03-25 14:35:50', 'Metade', 'Metade', 'Metade', 'Metade', 'Nada', 'Nada', 'Metade', 'Metade', 'Metade', 'Nada', 'Metade', 22, '', 1, 1, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_cuidador`
--
ALTER TABLE `tb_cuidador`
  ADD PRIMARY KEY (`id_cuidador`);

--
-- Indexes for table `tb_idoso`
--
ALTER TABLE `tb_idoso`
  ADD PRIMARY KEY (`id_idoso`);

--
-- Indexes for table `tb_relatorio`
--
ALTER TABLE `tb_relatorio`
  ADD PRIMARY KEY (`id_relatorio`),
  ADD KEY `fk_idoso` (`fk_idoso`),
  ADD KEY `fk_cuidador` (`fk_cuidador`) USING BTREE;

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_cuidador`
--
ALTER TABLE `tb_cuidador`
  MODIFY `id_cuidador` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tb_idoso`
--
ALTER TABLE `tb_idoso`
  MODIFY `id_idoso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `tb_relatorio`
--
ALTER TABLE `tb_relatorio`
  MODIFY `id_relatorio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_relatorio`
--
ALTER TABLE `tb_relatorio`
  ADD CONSTRAINT `tb_relatorio_ibfk_1` FOREIGN KEY (`fk_cuidador`) REFERENCES `tb_cuidador` (`id_cuidador`),
  ADD CONSTRAINT `tb_relatorio_ibfk_2` FOREIGN KEY (`fk_idoso`) REFERENCES `tb_idoso` (`id_idoso`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
