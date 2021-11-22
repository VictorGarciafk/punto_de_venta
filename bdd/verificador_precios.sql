-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 22-11-2021 a las 19:26:39
-- Versión del servidor: 5.7.31
-- Versión de PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `verificador_precios`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

DROP TABLE IF EXISTS `productos`;
CREATE TABLE IF NOT EXISTS `productos` (
  `id_producto` int(11) NOT NULL,
  `nombre_producto` varchar(64) NOT NULL,
  `precio` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id_producto`, `nombre_producto`, `precio`) VALUES
(1, 'Suavitel', 25.00),
(2, 'Gansito', 15.50),
(999, 'Chicle', 0.50),
(998, 'coca cola', 12.00),
(0, 'Sabritas', 15.00),
(3, 'Sabritas', 15.00),
(4, 'Sal', 20.00),
(5, 'Cafe en frasco', 15.00),
(6, 'Pan', 20.00),
(7, 'Jugo de manzana', 12.00),
(8, 'Yogurth de fresa', 13.00),
(9, 'Pastel de zanahoria', 50.00),
(10, 'Sopa de coditos', 15.00);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `numero_empleado` int(11) NOT NULL,
  `nombre` varchar(60) DEFAULT NULL,
  `apellido_paterno` varchar(60) DEFAULT NULL,
  `apellido_materno` varchar(60) DEFAULT NULL,
  `pass` varchar(30) NOT NULL,
  `permisoUsuario` int(11) NOT NULL,
  PRIMARY KEY (`numero_empleado`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`numero_empleado`, `nombre`, `apellido_paterno`, `apellido_materno`, `pass`, `permisoUsuario`) VALUES
(2, 'victor hugo', 'Garcia', 'Mendez', '123tamarindo', 2),
(1, 'Yareli', 'Espinoza', 'Melendez', '123tamarindo', 1),
(14, 'Clarisa', 'Ruiz', 'salazar', '123tamarindo', 1),
(11, 'jose', 'sanchez', 'ramirez', '123tamarindo', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

DROP TABLE IF EXISTS `ventas`;
CREATE TABLE IF NOT EXISTS `ventas` (
  `idventa` int(11) NOT NULL AUTO_INCREMENT,
  `fechaventa` date NOT NULL,
  `horaventa` time NOT NULL,
  `operadorVenta` int(11) NOT NULL,
  UNIQUE KEY `idventa` (`idventa`),
  KEY `operadorVenta` (`operadorVenta`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`idventa`, `fechaventa`, `horaventa`, `operadorVenta`) VALUES
(1, '2021-11-04', '12:38:41', 1),
(2, '2021-11-04', '12:39:20', 1),
(3, '2021-11-04', '12:40:15', 14),
(5, '2021-11-09', '12:28:51', 1),
(6, '2021-11-09', '12:31:07', 1),
(7, '2021-11-11', '13:02:16', 1),
(8, '2021-11-11', '13:04:35', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas_detalle`
--

DROP TABLE IF EXISTS `ventas_detalle`;
CREATE TABLE IF NOT EXISTS `ventas_detalle` (
  `id_venta` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `precio_producto` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ventas_detalle`
--

INSERT INTO `ventas_detalle` (`id_venta`, `id_producto`, `cantidad`, `precio_producto`) VALUES
(5, 1, 1, 25),
(5, 2, 1, 15.5),
(6, 1, 3, 75),
(6, 2, 3, 46.5),
(6, 998, 1, 12),
(6, 999, 1, 0.5),
(7, 1, 1, 25),
(7, 2, 1, 15.5),
(7, 3, 1, 15),
(8, 4, 1, 20),
(8, 5, 1, 15),
(8, 6, 1, 20),
(9, 7, 1, 12),
(9, 8, 1, 13),
(9, 9, 1, 50),
(10, 10, 1, 15),
(10, 1, 1, 25),
(10, 2, 1, 15.5),
(11, 3, 1, 15),
(11, 4, 1, 20),
(11, 5, 1, 15),
(12, 6, 1, 20),
(12, 7, 1, 12),
(12, 8, 1, 13),
(13, 8, 1, 13),
(13, 9, 1, 50),
(13, 10, 1, 15),
(14, 1, 1, 25),
(14, 2, 1, 15.5),
(14, 3, 1, 15),
(15, 4, 1, 20),
(15, 5, 1, 15),
(15, 6, 1, 20),
(16, 7, 1, 12),
(16, 8, 1, 13),
(16, 9, 1, 50),
(17, 10, 1, 15),
(17, 1, 1, 25),
(17, 2, 1, 15.5),
(17, 3, 1, 15),
(18, 5, 1, 15),
(18, 6, 1, 20),
(18, 7, 1, 12),
(18, 8, 1, 13),
(18, 9, 1, 50),
(7, 2, 1, 15.5),
(8, 1, 1, 25);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
