-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 01/12/2023 às 00:41
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `prada`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `cadastro`
--

CREATE TABLE `cadastro` (
  `nome` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `telefone` varchar(255) NOT NULL,
  `data_nasc` varchar(255) NOT NULL,
  `PR` varchar(15) NOT NULL,
  `senha` varchar(255) NOT NULL,
  `genero` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `cadastro`
--

INSERT INTO `cadastro` (`nome`, `email`, `telefone`, `data_nasc`, `PR`, `senha`, `genero`) VALUES
('Michel', 'michel@gmail.com', '(11)99999-9999', '30/11/1990', 'pr123', '321', 'm'),
('luana', 'luana123@yahoo.com', '(12)98888-8888', '16/06/1998', 'pr157', '852', 'f'),
('joao', 'joao123@gmail.com', '(11)98855-8855', '20/06/2000', 'pr456', '52458', 'm'),
('Joaquim', 'joaq2@hotmail.com', '(11)95522-5522', '20/08/1996', 'pr852', 'fafdfd', 'o');

-- --------------------------------------------------------

--
-- Estrutura para tabela `periodo_manha`
--

CREATE TABLE `periodo_manha` (
  `registro` int(11) NOT NULL,
  `data` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `equipamento` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `horario` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `meta_unidades` int(11) NOT NULL,
  `acumulado_unidades` int(11) DEFAULT NULL,
  `parada_minutos` int(11) DEFAULT NULL,
  `observacao` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `periodo_manha`
--

INSERT INTO `periodo_manha` (`registro`, `data`, `equipamento`, `horario`, `meta_unidades`, `acumulado_unidades`, `parada_minutos`, `observacao`) VALUES
(1, '22/10/2023', 'LM 07', '05:50 as 06:00', 1500, 1500, 5, 'nd'),
(2, '22/10/2023', 'LM 07', '06:00 as 07:00', 10500, 1600, 0, ''),
(3, '22/10/2023', 'LM 07', '07:00 as 08:00', 19500, 1800, 0, ''),
(4, '22/10/2023', 'LM 07', '08:00 as 09:00', 28500, 1900, 0, ''),
(5, '22/10/2023', 'LM 07', '09:00 as 10:00', 37500, 2500, 4, ''),
(6, '22/10/2023', 'LM 07', '10:00 as 11:00', 46500, 3500, 0, ''),
(7, '22/10/2023', 'LM 07', '11:00 as 12:00', 55500, 4000, 6, ''),
(8, '22/10/2023', 'LM 07', '12:00 as 13:00', 64500, 4500, 0, ''),
(9, '22/10/2023', 'LM 07', '13:00 as 14:05', 74250, 5000, 5, ''),
(10, '22/02/2013', 'LM 53', '05:50 as 06:00', 2000, 200, 0, ''),
(11, '22/02/2013', 'LM 53', '06:00 as 07:00', 14000, 400, 0, ''),
(12, '22/02/2013', 'LM 53', '07:00 as 08:00', 26000, 600, 0, ''),
(13, '22/02/2013', 'LM 53', '08:00 as 09:00', 38000, 800, 0, ''),
(14, '22/02/2013', 'LM 53', '09:00 as 10:00', 50000, 900, 0, ''),
(15, '22/02/2013', 'LM 53', '10:00 as 11:00', 62000, 1300, 0, ''),
(16, '22/02/2013', 'LM 53', '11:00 as 12:00', 74000, 1500, 0, ''),
(17, '22/02/2013', 'LM 53', '12:00 as 13:00', 86000, 2000, 0, ''),
(18, '22/02/2013', 'LM 53', '13:00 as 14:05', 99000, 30000, 0, ''),
(19, '11/11/2011', 'LM 23', '05:50 as 06:00', 50, 5000, 0, ''),
(20, '11/11/2011', 'LM 23', '06:00 as 07:00', 350, 10000, 0, ''),
(21, '11/11/2011', 'LM 23', '07:00 as 08:00', 650, 15000, 2, 'pane'),
(22, '11/11/2011', 'LM 23', '08:00 as 09:00', 950, 20000, 0, ''),
(23, '11/11/2011', 'LM 23', '09:00 as 10:00', 1250, 25000, 0, ''),
(24, '11/11/2011', 'LM 23', '10:00 as 11:00', 1550, 27000, 0, ''),
(25, '11/11/2011', 'LM 23', '11:00 as 12:00', 1850, 28000, 0, ''),
(26, '11/11/2011', 'LM 23', '12:00 as 13:00', 2150, 29000, 0, ''),
(27, '11/11/2011', 'LM 23', ' as 14:05', 2475, 35000, 0, ''),
(28, '25/03/2018', 'LM 46', '05:50 as 06:00', 50, 10000, 0, ''),
(29, '25/03/2018', 'LM 46', '06:00 as 07:00', 350, 20000, 0, ''),
(30, '25/03/2018', 'LM 46', '07:00 as 08:00', 650, 30000, 0, ''),
(31, '25/03/2018', 'LM 46', '08:00 as 09:00', 950, 40000, 0, ''),
(32, '25/03/2018', 'LM 46', '09:00 as 10:00', 1250, 50000, 0, ''),
(33, '25/03/2018', 'LM 46', '10:00 as 11:00', 1550, 60000, 0, ''),
(34, '25/03/2018', 'LM 46', '11:00 as 12:00', 1850, 70000, 0, ''),
(35, '25/03/2018', 'LM 46', '12:00 as 13:00', 2150, 80000, 0, ''),
(36, '25/03/2018', 'LM 46', ' as 14:05', 2475, 90000, 0, ''),
(54, '24/11/2023', 'LM 55', '05:50 as 06:00', 0, 0, 0, ''),
(55, '24/11/2023', 'LM 55', '06:00 as 07:00', 8100, 9000, 0, ''),
(56, '24/11/2023', 'LM 55', '07:00 as 08:00', 16200, 18000, 0, ''),
(57, '24/11/2023', 'LM 55', '08:00 as 09:00', 24300, 27000, 0, ''),
(58, '24/11/2023', 'LM 55', '09:00 as 10:00', 32400, 33000, 0, ''),
(59, '24/11/2023', 'LM 55', '10:00 as 11:00', 40500, 42000, 0, ''),
(60, '24/11/2023', 'LM 55', '11:00 as 12:00', 48600, 51000, 0, ''),
(61, '24/11/2023', 'LM 55', '12:00 as 13:00', 56700, 60000, 0, ''),
(62, '16/04/2000', 'LM 20', '05:50 as 06:00', 0, 0, 0, ''),
(63, '16/04/2000', 'LM 20', '06:00 as 07:00', 8100, 9000, 0, ''),
(64, '16/04/2000', 'LM 20', '07:00 as 08:00', 16200, 18000, 0, ''),
(65, '16/04/2000', 'LM 20', '08:00 as 09:00', 24300, 27000, 0, ''),
(66, '16/04/2000', 'LM 20', '09:00 as 10:00', 32400, 33000, 20, 'pausa'),
(67, '16/04/2000', 'LM 20', '10:00 as 11:00', 40500, 42000, 0, ''),
(68, '16/04/2000', 'LM 20', '11:00 as 12:00', 48600, 51000, 0, ''),
(69, '16/04/2000', 'LM 20', '12:00 as 13:00', 56700, 60000, 0, ''),
(70, '16/04/2000', 'LM 20', '12:00 as 14:05', 65475, 70000, 0, ''),
(71, '15/12/2001', 'LM 48', '14:05 as 15:00', 6600, 8000, 0, ''),
(72, '15/12/2001', 'LM 48', '15:00 as 16:00', 13800, 16000, 0, ''),
(73, '15/12/2001', 'LM 48', '16:00 as 17:00', 21000, 32000, 0, ''),
(74, '15/12/2001', 'LM 48', '17:00 as 18:00', 28200, 40000, 0, ''),
(75, '15/12/2001', 'LM 48', '18:00 as 19:00', 35400, 48000, 0, ''),
(76, '15/12/2001', 'LM 48', '19:00 as 20:00', 35400, 0, 0, 'almoco'),
(77, '15/12/2001', 'LM 48', '20:00 as 21:00', 42600, 56000, 0, ''),
(78, '15/12/2001', 'LM 48', '21:00 as 22:25', 51000, 64000, 0, ''),
(79, '16/04/2011', 'LM 39', '22:25 as 23:00', 4725, 9000, 0, ''),
(80, '16/04/2011', 'LM 39', '23:00 as 00:00', 4725, 0, 0, ''),
(81, '16/04/2011', 'LM 39', '00:00 as 01:00', 12825, 18000, 0, ''),
(82, '16/04/2011', 'LM 39', '01:00 as 02:00', 20925, 27000, 0, ''),
(83, '16/04/2011', 'LM 39', '02:00 as 03:00', 29025, 36000, 0, ''),
(84, '16/04/2011', 'LM 39', '03:00 as 04:00', 37125, 42000, 0, ''),
(85, '16/04/2011', 'LM 39', '04:00 as 05:00', 45225, 48000, 0, ''),
(86, '16/04/2011', 'LM 39', '05:00 as 05:50', 51975, 60000, 0, '');

-- --------------------------------------------------------

--
-- Estrutura para tabela `periodo_noite`
--

CREATE TABLE `periodo_noite` (
  `registro` int(11) NOT NULL,
  `data` varchar(15) NOT NULL,
  `equipamento` varchar(10) NOT NULL,
  `horario` varchar(30) NOT NULL,
  `meta_unidades` int(11) NOT NULL,
  `acumulado_unidades` int(11) DEFAULT NULL,
  `parada_minutos` int(11) DEFAULT NULL,
  `observacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `periodo_noite`
--

INSERT INTO `periodo_noite` (`registro`, `data`, `equipamento`, `horario`, `meta_unidades`, `acumulado_unidades`, `parada_minutos`, `observacao`) VALUES
(1, '01/01/2001', 'LM 20', '22:25 as 23:00', 300, 200, 0, ''),
(2, '01/01/2001', 'LM 20', '23:00 as 00:00', 2100, 400, 0, ''),
(3, '01/01/2001', 'LM 20', '00:00 as 01:00', 2100, 0, 0, ''),
(4, '01/01/2001', 'LM 20', '01:00 as 02:00', 3900, 6000, 0, ''),
(5, '01/01/2001', 'LM 20', '02:00 as 03:00', 5700, 8000, 0, ''),
(6, '01/01/2001', 'LM 20', '03:00 as 04:00', 7500, 95000, 1, 'travou'),
(7, '01/01/2001', 'LM 20', '04:00 as 05:00', 9300, 150000, 0, ''),
(8, '01/01/2001', 'LM 20', '05:00 as 05:50', 11100, 40000, 0, '');

-- --------------------------------------------------------

--
-- Estrutura para tabela `periodo_tarde`
--

CREATE TABLE `periodo_tarde` (
  `registro` int(11) NOT NULL,
  `data` varchar(15) NOT NULL,
  `equipamento` varchar(10) NOT NULL,
  `horario` varchar(30) NOT NULL,
  `meta_unidades` int(11) NOT NULL,
  `acumulado_unidades` int(11) DEFAULT NULL,
  `parada_minutos` int(11) DEFAULT NULL,
  `observacao` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `periodo_tarde`
--

INSERT INTO `periodo_tarde` (`registro`, `data`, `equipamento`, `horario`, `meta_unidades`, `acumulado_unidades`, `parada_minutos`, `observacao`) VALUES
(1, '30/05/2022', 'LM 59', '14:05 as 15:00', 2000, 500, 0, ''),
(2, '21/09/200', 'LM 48', '14:05 as 15:00', 300, 500, 0, 'quebrou'),
(3, '21/09/200', 'LM 48', '15:00 as 16:00', 2100, 600, 0, ''),
(4, '21/09/200', 'LM 48', '16:00 as 17:00', 3900, 800, 0, ''),
(5, '21/09/200', 'LM 48', '17:00 as 18:00', 5700, 1500, 0, 'nada'),
(6, '21/09/200', 'LM 48', '18:00 as 19:00', 7500, 2000, 0, ''),
(7, '21/09/200', 'LM 48', '19:00 as 20:00', 9300, 3000, 0, ''),
(8, '21/09/200', 'LM 48', '20:00 as 21:00', 11100, 4000, 5, ''),
(9, '21/09/200', 'LM 48', '21:00 as 22:25', 12900, 5000, 0, '');

-- --------------------------------------------------------

--
-- Estrutura para tabela `relatorio_manha`
--

CREATE TABLE `relatorio_manha` (
  `data` varchar(20) NOT NULL,
  `equipamento` varchar(20) NOT NULL,
  `dispProd` float NOT NULL,
  `velocMediaPlan` int(11) NOT NULL,
  `prodReal` int(11) NOT NULL,
  `totalParada` int(11) NOT NULL,
  `velocMediaReal` float NOT NULL,
  `perdasQuali` int(11) NOT NULL,
  `percent1` float NOT NULL,
  `percent2` float NOT NULL,
  `percent3` float NOT NULL,
  `OEE` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `relatorio_manha`
--

INSERT INTO `relatorio_manha` (`data`, `equipamento`, `dispProd`, `velocMediaPlan`, `prodReal`, `totalParada`, `velocMediaReal`, `perdasQuali`, `percent1`, `percent2`, `percent3`, `OEE`) VALUES
('24/11/2023', 'LM 55', 8, 135, 70000, 0, 144, 740, 100, 106, 98, 105),
('16/04/2000', 'LM 20', 8, 135, 70000, 0, 150, 740, 95, 111, 98, 105);

-- --------------------------------------------------------

--
-- Estrutura para tabela `relatorio_noite`
--

CREATE TABLE `relatorio_noite` (
  `data` varchar(20) NOT NULL,
  `equipamento` varchar(20) NOT NULL,
  `dispProd` float NOT NULL,
  `velocMediaPlan` int(11) NOT NULL,
  `prodReal` int(11) NOT NULL,
  `totalParada` int(11) NOT NULL,
  `velocMediaReal` float NOT NULL,
  `perdasQuali` int(11) NOT NULL,
  `percent1` float NOT NULL,
  `percent2` float NOT NULL,
  `percent3` float NOT NULL,
  `OEE` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `relatorio_noite`
--

INSERT INTO `relatorio_noite` (`data`, `equipamento`, `dispProd`, `velocMediaPlan`, `prodReal`, `totalParada`, `velocMediaReal`, `perdasQuali`, `percent1`, `percent2`, `percent3`, `OEE`) VALUES
('16/04/2011', 'LM 39', 1, 135, 60000, 0, 526, 750, 100, 389, 98, 384);

-- --------------------------------------------------------

--
-- Estrutura para tabela `relatorio_tarde`
--

CREATE TABLE `relatorio_tarde` (
  `data` varchar(20) NOT NULL,
  `equipamento` varchar(20) NOT NULL,
  `dispProd` float NOT NULL,
  `velocMediaPlan` int(11) NOT NULL,
  `prodReal` int(11) NOT NULL,
  `totalParada` int(11) NOT NULL,
  `velocMediaReal` float NOT NULL,
  `perdasQuali` int(11) NOT NULL,
  `percent1` float NOT NULL,
  `percent2` float NOT NULL,
  `percent3` float NOT NULL,
  `OEE` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Despejando dados para a tabela `relatorio_tarde`
--

INSERT INTO `relatorio_tarde` (`data`, `equipamento`, `dispProd`, `velocMediaPlan`, `prodReal`, `totalParada`, `velocMediaReal`, `perdasQuali`, `percent1`, `percent2`, `percent3`, `OEE`) VALUES
('15/12/2001', 'LM 48', 1, 120, 64000, 0, 666, 500, 100, 555, 99, 551);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cadastro`
--
ALTER TABLE `cadastro`
  ADD PRIMARY KEY (`PR`);

--
-- Índices de tabela `periodo_manha`
--
ALTER TABLE `periodo_manha`
  ADD PRIMARY KEY (`registro`);

--
-- Índices de tabela `periodo_noite`
--
ALTER TABLE `periodo_noite`
  ADD PRIMARY KEY (`registro`);

--
-- Índices de tabela `periodo_tarde`
--
ALTER TABLE `periodo_tarde`
  ADD PRIMARY KEY (`registro`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `periodo_manha`
--
ALTER TABLE `periodo_manha`
  MODIFY `registro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=87;

--
-- AUTO_INCREMENT de tabela `periodo_noite`
--
ALTER TABLE `periodo_noite`
  MODIFY `registro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `periodo_tarde`
--
ALTER TABLE `periodo_tarde`
  MODIFY `registro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
