-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 17, 2021 at 11:18 PM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `verificador_precios`
--

-- --------------------------------------------------------

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
CREATE TABLE IF NOT EXISTS `productos` (
  `producto_codigo` bigint(13) UNSIGNED NOT NULL,
  `producto_nombre` varchar(255) NOT NULL,
  `producto_precio` double(10,2) NOT NULL,
  `producto_stock` int(3) NOT NULL,
  `producto_imagen` varchar(255) DEFAULT NULL,
  UNIQUE KEY `producto_codigo` (`producto_codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `productos`
--

INSERT INTO `productos` (`producto_codigo`, `producto_nombre`, `producto_precio`, `producto_stock`, `producto_imagen`) VALUES
(0, 'prueba', 1.00, 2, NULL),
(1, 'Agua Ciel 600ml', 10.00, 8, 'https://www.super-deli.com.mx/img/p/5/0/50-thickbox_default.jpg'),
(2, 'Dulce Bubulubu 35 gr', 5.00, 25, 'https://despensaurbana.mx/content/images/thumbs/5f0e60b31721854af7ff1e39_Bubulubu_35_g_M05AWIGEOF.png_400.png'),
(3, 'Salsa valentina roja 370 ml', 12.00, 5, 'https://tiendasneto.com.mx/media/catalog/product/cache/cb1e6b076f68ee0ac6e5e542f63310fa/1/0/1040000292-1_12.jpg'),
(4, 'Doritos Nachos Sabritas 155g', 30.24, 10, 'https://despensaurbana.mx/content/images/thumbs/5f0e608a1721854af7ff17d3_doritos-nachos-sabritas-155-g_400.png'),
(5, 'Chocolate de mesa Abuelita 540gr', 79.92, 4, 'https://despensaurbana.mx/content/images/thumbs/5fde63ef2c4d0179319346f9_chocolate-de-mesa-abuelita-540-gr_400.jpeg'),
(6, 'Palomitas de maiz extra mantequilla Act II 80gr', 11.00, 15, 'https://despensaurbana.mx/content/images/thumbs/5f0e5fda1721854af7ff0a79_palomitas-de-maz-extra-mantequilla-act-ii-80-g_400.png'),
(7, 'Palomitas de maiz queso jalapeño Act II 80gr', 14.00, 3, 'https://despensaurbana.mx/content/images/thumbs/5f0e5fd81721854af7ff0a21_palomitas-de-maz-queso-jalapeo-act-ii-80-g_400.png'),
(8, 'Papas Chips fuego 170gr', 42.12, 7, 'https://despensaurbana.mx/content/images/thumbs/5f0e60a11721854af7ff18f5_papas-chips-fuego-de-barcel-170-g_400.png'),
(9, 'Pringles Crema y cebolla 124gr', 41.58, 6, 'https://despensaurbana.mx/content/images/thumbs/5f0e5ff81721854af7ff0edb_pringles-crema-y-cebolla-124-g_400.png'),
(10, 'Jugo de tomate Clamato El Original con almeja 946ml', 40.00, 2, 'https://despensaurbana.mx/content/images/thumbs/60355248894b812405b917e8_clamato-946-ml_400.jpeg'),
(11, 'Electrolit suero rehidratante sabor mora azul 625ml', 20.00, 4, 'https://despensaurbana.mx/content/images/thumbs/5fd1333c2cea0931bf4449bb_electrolit-suero-rehidratante-sabor-mora-azul-625-ml_400.jpeg'),
(12, 'Jugo Boing de mango 250ml', 5.50, 23, 'https://despensaurbana.mx/content/images/thumbs/5f0e60491721854af7ff140a_jugo-boing-de-mango-250-ml_400.png'),
(13, 'Jugo Boing de manzana 1L', 19.50, 6, 'https://despensaurbana.mx/content/images/thumbs/5f0e60471721854af7ff13f8_jugo-boing-de-manzana-1-l_400.png'),
(14, 'Cafe soluble Nescafe clasico 42gr', 27.00, 12, 'https://despensaurbana.mx/content/images/thumbs/6064ac1b834fd8170988f941_caf-soluble-nescaf-clsico-42-g_400.webp'),
(15, 'Crema de avellanas Nutella 200gr', 43.20, 1, 'https://despensaurbana.mx/content/images/thumbs/60158f19894b812405967791_crema-de-avellanas-nutella-200-g_400.jpeg'),
(16, 'Aceite de Ajonjoli Tostado Ines 250ml', 75.00, 3, 'https://despensaurbana.mx/content/images/thumbs/608f4fec834fd81709e1f4a7_aceite-de-ajonjoli-tostado-ins-250-ml_400.png'),
(17, 'Azucar Zulka Refinada 1kg', 36.00, 8, 'https://despensaurbana.mx/content/images/thumbs/5f97259092ccc5311742f8a2_azcar-zulka-refinada-1kg_400.jpeg'),
(18, 'Catsup del Monte 320gr', 13.50, 19, 'https://despensaurbana.mx/content/images/thumbs/5f0e60af1721854af7ff1c77_catsup-del-monte-320-g_400.png'),
(19, 'Arroz Integral super extra SOS 1kg', 39.50, 26, 'https://despensaurbana.mx/content/images/thumbs/5f0e5fc41721854af7ff06d7_arroz-integral-super-extra-sos-1-kg_400.png'),
(20, 'Chicharos con Zanahoria Herdez 225gr', 9.50, 13, 'https://despensaurbana.mx/content/images/thumbs/5f0e5fc71721854af7ff077b_chcharos-con-zanahoria-herdez-225-g_400.png'),
(3990, 'taquitos de machaca', 30.00, 50, NULL);

--
-- Triggers `productos`
--
DROP TRIGGER IF EXISTS `actualizarPrecioProducto`;
DELIMITER $$
CREATE TRIGGER `actualizarPrecioProducto` BEFORE INSERT ON `productos` FOR EACH ROW BEGIN
  IF NEW.producto_precio <0
    THEN
      SET NEW.producto_precio = NEW.producto_precio * -1;
  END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `numero_empleado` int(11) NOT NULL,
  `nombre` varchar(60) DEFAULT NULL,
  `apellido_paterno` varchar(60) DEFAULT NULL,
  `apellido_materno` varchar(60) DEFAULT NULL,
  `numero_celular` varchar(16) DEFAULT NULL,
  `curp` varchar(22) NOT NULL,
  `rfc` varchar(22) NOT NULL,
  `nss` varchar(22) NOT NULL,
  `mail` varchar(255) NOT NULL,
  `direccion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`numero_empleado`),
  UNIQUE KEY `mail` (`mail`),
  UNIQUE KEY `mail_2` (`mail`),
  UNIQUE KEY `nss` (`nss`),
  UNIQUE KEY `nss_2` (`nss`),
  UNIQUE KEY `curp_2` (`curp`),
  UNIQUE KEY `curp_3` (`curp`),
  UNIQUE KEY `curp` (`curp`,`rfc`,`nss`),
  UNIQUE KEY `rfc` (`rfc`),
  UNIQUE KEY `rfc_2` (`rfc`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`numero_empleado`, `nombre`, `apellido_paterno`, `apellido_materno`, `numero_celular`, `curp`, `rfc`, `nss`, `mail`, `direccion`) VALUES
(1, 'victor hugo', 'Garcia', 'Mendez', '6312549852', 'GAMM2903KDK1223', 'GAM2SDOL1L2323W', 'H283NDMSW2', 'vicxstroll20ka@gmail.com', 'helouda calle numero 400'),
(2, 'Yareli', 'Espinoza', 'Melendez', '6624157826', 'ESME62HJSD7322S', 'ESMEHFNG2983SD2', 'HFNG7364GF', 'Yareli2sd@gmail.com', 'hidalgo #23'),
(3, 'Clarisa', 'Ruiz', 'salazar', '6622146725', 'RUSS1HGMN23HGM2', 'RUSSH276H3NGD23', 'KLDH25DTR0', 'ruisclarisa@gmail.com', 'ramos #32'),
(4, 'Saul', 'Lopez', 'gonzalez', '6622485320', 'LOGG2H2M0S25MLA', 'LOGGHNB274VD25', 'LSNCVHF785', 'salumss@gmail.com', 'periferico #82'),
(5, 'juan carlos', 'cruz', 'flores', '6622047832', 'CRFF2MH6OW20DSA', 'CRFF21S0Q5E3S0V', 'KWOSPFMVH2', 'juancrslold@gmail.com', 'bucareli #88'),
(6, 'jose', 'sanchez', 'ramirez', '662237853', 'SARR2W6E31EF6G1', 'SARR5S98LF02PS2', 'SDQWF2567D', 'Joseking@gmail.com', 'insurgentes #32'),
(7, 'Maria', 'hernandez', 'gomez', '6314752348', 'MAHH2KDO1MWU1KS', 'MAHHWS2OSL17SGD', 'SUQ72JSMAQ', 'mhhs@gmail.com', 'alvaro #51'),
(9, 'Francisco', 'acosta', NULL, NULL, 'ACCS4WQ531DXA24', 'ACCSD12DAS1S4Q5', 'SDQWE13SZC', 'f_usser@gmail.com', NULL),
(10, 'Jesus', 'aguirre', NULL, NULL, 'AGGS1S4FD2S5Q8W', 'AGGSD2W56Q71026', 'IQLWDN12ON', 'aguirrers@gmail.com', NULL),
(11, 'Alexandra', 'Varela', NULL, NULL, 'VAVVSW123S25WQQ', 'VAVVS2DVA513SV1', 'SD1XC1S8Q9', 'valexandravvl@gmail.com', NULL),
(12, 'erick', 'arauz', NULL, NULL, 'AREE25F69Q10S23', 'AREEI2MDSQSDQ23', 'HGM29RKSLA', 'extrmiin4te@gmail.com', NULL),
(13, 'alberto manuel', 'castellanos', NULL, NULL, 'CAMM23SHFNG5641', 'CAMM23HGJGN84NM', 'JF214SQW96', 'albermcaste@gmail.com', NULL),
(14, 'joaquin', 'rogelio', NULL, NULL, 'ROMNSHG82323SQA', 'ROMNSQW32GFMSA', 'HGNM2OSL1D', 'jojoturuturuturu@gmail.com', NULL),
(15, 'manuel', 'Guzman', NULL, NULL, 'GUSS3JGMWI1DLS2', 'GUSSDWQ2G3254S6', 'GHSQK1SHFN', 'gussmi@gmail.com', NULL),
(8, 'Carlos', 'Hernesto', NULL, NULL, 'HEMMD2YGF625MD3', 'HEMMDJFHEWYHFN3', 'HFNCH23DH4', 'hernestorr@gmail.com', NULL);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
