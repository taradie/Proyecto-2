-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-05-2016 a las 04:17:18
-- Versión del servidor: 10.1.9-MariaDB
-- Versión de PHP: 5.5.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `proyecto2`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `agendamovimientos`
--

CREATE TABLE `agendamovimientos` (
  `codigo_agenda` int(11) NOT NULL,
  `codigo_movimiento` int(11) DEFAULT NULL,
  `no_movimientos` int(11) NOT NULL,
  `periocidad` char(50) NOT NULL,
  `solicitado_por` char(50) NOT NULL,
  `prioridad` char(50) NOT NULL,
  `fecha_inicio` date NOT NULL,
  `estado` char(20) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `almacen`
--

CREATE TABLE `almacen` (
  `codalmacen` int(11) NOT NULL,
  `condicion` char(1) DEFAULT NULL,
  `codigo_empresa` int(11) NOT NULL,
  `nombre` char(100) NOT NULL,
  `tamano` char(10) NOT NULL,
  `disponibilidad` char(15) NOT NULL,
  `estado` char(15) NOT NULL,
  `ubicacion` char(70) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bancos`
--

CREATE TABLE `bancos` (
  `codigo_banco` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `nombre_cuenta` char(100) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `estado` char(20) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `basededatos`
--

CREATE TABLE `basededatos` (
  `codigo_bd` int(11) NOT NULL,
  `codigo_empresa` int(11) NOT NULL,
  `codigo_tipo_bd` int(11) NOT NULL,
  `nombre_conexion` char(50) NOT NULL,
  `conexion` varchar(100) NOT NULL,
  `driver_name` char(50) NOT NULL,
  `host` char(50) NOT NULL,
  `puerto` int(11) NOT NULL,
  `ubicacion` varchar(100) NOT NULL,
  `user_name` char(50) NOT NULL,
  `user_pw` varchar(100) NOT NULL,
  `nombre_bd` char(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE `bitacora` (
  `codigo_bitacora` int(11) NOT NULL,
  `condicion` varchar(10) DEFAULT NULL,
  `ip` varchar(20) DEFAULT NULL,
  `codigo_usuario` int(11) DEFAULT NULL,
  `accion` char(200) NOT NULL,
  `tabla` char(200) NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `equipo` char(50) NOT NULL,
  `observaciones` char(100) NOT NULL,
  `codigo_persona` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boleta`
--

CREATE TABLE `boleta` (
  `no_boleta` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `codTipoBoleta` int(11) NOT NULL,
  `codPrestamo` int(11) NOT NULL,
  `codTalonario` int(11) NOT NULL,
  `codigo_cuenta_interna` int(11) NOT NULL,
  `codigo_cuenta_externa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cheques`
--

CREATE TABLE `cheques` (
  `codigo_cheque` int(11) NOT NULL,
  `codigo_concepto` int(11) NOT NULL,
  `fecha_registro` date NOT NULL,
  `monto_total` float(8,0) NOT NULL,
  `no_cheque` int(11) NOT NULL,
  `fecha_aplicacion` date NOT NULL,
  `referencia_1` varchar(50) NOT NULL,
  `referencia_2` varchar(50) DEFAULT NULL,
  `observaciones` varchar(100) DEFAULT NULL,
  `estado` char(20) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clasificacionconceptosbancarios`
--

CREATE TABLE `clasificacionconceptosbancarios` (
  `codigo_clasificacion` int(11) NOT NULL,
  `clasificacion` char(50) NOT NULL,
  `descripcion` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `ncodcliente` int(11) NOT NULL,
  `estado` varchar(10) DEFAULT NULL,
  `condicion` tinyint(1) DEFAULT NULL,
  `nit` varchar(10) DEFAULT NULL,
  `codCobrador` int(11) NOT NULL,
  `codVendedor` int(11) NOT NULL,
  `cargo` varchar(30) DEFAULT NULL,
  `abono` varchar(30) DEFAULT NULL,
  `saldoactual` varchar(30) DEFAULT NULL,
  `saldoanterior` varchar(30) DEFAULT NULL,
  `nombrecliente` varchar(30) DEFAULT NULL,
  `apellidocliente` varchar(40) DEFAULT NULL,
  `direccion` varchar(10) DEFAULT NULL,
  `telefono` varchar(30) DEFAULT NULL,
  `correo` varchar(30) DEFAULT NULL,
  `icod` int(11) DEFAULT NULL,
  `cod_empleado` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`ncodcliente`, `estado`, `condicion`, `nit`, `codCobrador`, `codVendedor`, `cargo`, `abono`, `saldoactual`, `saldoanterior`, `nombrecliente`, `apellidocliente`, `direccion`, `telefono`, `correo`, `icod`, `cod_empleado`) VALUES
(1, 'ACTIVO', 1, '123456-4', 1, 1, 'Vendedor', '0', '0', '0', 'Josue', 'Revolorio', 'Guatemala', '24483027', 'josue@hotmail.com', 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cobrador`
--

CREATE TABLE `cobrador` (
  `codCobrador` int(11) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `condicion` tinyint(1) DEFAULT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `apellido` varchar(30) DEFAULT NULL,
  `genero` varchar(10) DEFAULT NULL,
  `correo` varchar(30) DEFAULT NULL,
  `direccion` varchar(40) DEFAULT NULL,
  `telefono` varchar(10) DEFAULT NULL,
  `comision` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cobrador`
--

INSERT INTO `cobrador` (`codCobrador`, `estado`, `condicion`, `nombre`, `apellido`, `genero`, `correo`, `direccion`, `telefono`, `comision`) VALUES
(1, 'ACTIVO', 1, 'Manuel', 'Chuquiej', 'Masculino', 'chuquiej@hotmail.com', 'Guatemala', '24483027', 'Por factura');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `comision`
--

CREATE TABLE `comision` (
  `codigocomision` int(11) NOT NULL,
  `estado` varchar(10) DEFAULT NULL,
  `condicion` tinyint(1) DEFAULT NULL,
  `vtotalventas` char(10) DEFAULT NULL,
  `monto` char(10) DEFAULT NULL,
  `codVendedor` int(11) NOT NULL,
  `codComision` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conceptos`
--

CREATE TABLE `conceptos` (
  `codigo_tipo_transaccion` int(11) NOT NULL,
  `tipo` char(50) DEFAULT NULL,
  `descripcion` char(50) DEFAULT NULL,
  `condicion` char(10) NOT NULL,
  `estado` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `conceptos`
--

INSERT INTO `conceptos` (`codigo_tipo_transaccion`, `tipo`, `descripcion`, `condicion`, `estado`) VALUES
(1, 'cargo', 'se pagan los prestamos y proveedores', 'ACTIVO', 'ACTIVO'),
(2, 'abono', 'pago clientes', 'ACTIVO', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conceptosbancarios`
--

CREATE TABLE `conceptosbancarios` (
  `codigo_concepto` int(11) NOT NULL,
  `concepto` char(50) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  `codigo_operacion` int(11) NOT NULL,
  `estado` char(30) NOT NULL,
  `condicion` char(20) DEFAULT NULL,
  `codigo_clasificacion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conciliacionbancaria`
--

CREATE TABLE `conciliacionbancaria` (
  `codigo_conciliacion` int(11) NOT NULL,
  `fecha_inicio` date NOT NULL,
  `fecha_salida` date NOT NULL,
  `total_cargos` float(8,0) NOT NULL,
  `total_abonos` float(8,0) NOT NULL,
  `monto` float(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion`
--

CREATE TABLE `cotizacion` (
  `ncodcotizacion` int(11) NOT NULL,
  `condicion` tinyint(1) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `vserie` varchar(10) NOT NULL,
  `codVendedor` int(11) NOT NULL,
  `dfechacotizacion` date DEFAULT NULL,
  `dfechavencimiento` date DEFAULT NULL,
  `ntotal` decimal(10,0) DEFAULT NULL,
  `vestadocotizacion` varchar(20) DEFAULT NULL,
  `ncodcliente` int(11) NOT NULL,
  `cod_empleado` int(11) DEFAULT NULL,
  `codCobrador` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentascorrientesclientes`
--

CREATE TABLE `cuentascorrientesclientes` (
  `codigo_cuentac` int(11) NOT NULL,
  `referencia` char(30) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `monto` char(50) DEFAULT NULL,
  `situacion` char(30) DEFAULT NULL,
  `ncodfactura` int(11) NOT NULL,
  `ncodcliente` int(11) DEFAULT NULL,
  `codMora` int(11) DEFAULT NULL,
  `codigo_tipo_transaccion` int(11) DEFAULT NULL,
  `vserie` varchar(10) NOT NULL,
  `codtipodocumento` int(11) NOT NULL,
  `condicion` char(30) DEFAULT NULL,
  `estado` char(20) DEFAULT NULL,
  `codVendedor` int(11) NOT NULL,
  `codCobrador` int(11) DEFAULT NULL,
  `codencabezado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentascorrientesempleados`
--

CREATE TABLE `cuentascorrientesempleados` (
  `codCEmpleados` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `monto` decimal(10,2) DEFAULT NULL,
  `situacion` char(30) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL,
  `estado` char(30) DEFAULT NULL,
  `codigo_tipo_transaccion` int(11) NOT NULL,
  `codtipodocumento` int(11) NOT NULL,
  `codTalonario` int(11) NOT NULL,
  `codMora` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentascorrientesproveedores`
--

CREATE TABLE `cuentascorrientesproveedores` (
  `codCProveedores` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `monto` decimal(10,2) DEFAULT NULL,
  `situacion` char(30) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL,
  `estado` char(30) DEFAULT NULL,
  `codproveedor` int(11) NOT NULL,
  `codigo_tipo_transaccion` int(11) NOT NULL,
  `codtipodocumento` int(11) NOT NULL,
  `codfacturaprov` int(11) NOT NULL,
  `codencabezado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentasexternas`
--

CREATE TABLE `cuentasexternas` (
  `codigo_cuenta_externa` int(11) NOT NULL,
  `codigo_persona` int(11) DEFAULT NULL,
  `codproveedor` int(11) DEFAULT NULL,
  `codigo_banco` int(11) NOT NULL,
  `no_cuenta` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuentasinternas`
--

CREATE TABLE `cuentasinternas` (
  `codigo_cuenta_interna` int(11) NOT NULL,
  `codigo_empresa` int(11) NOT NULL,
  `fecha_apertura` date NOT NULL,
  `no_cuenta` varchar(50) NOT NULL,
  `codigo_banco` int(11) NOT NULL,
  `codigo_moneda` int(11) NOT NULL,
  `siguiente_cheque` int(11) DEFAULT NULL,
  `estado` char(50) NOT NULL,
  `condicion` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallecotizacion`
--

CREATE TABLE `detallecotizacion` (
  `ncodcotizacion` int(11) NOT NULL,
  `codproducto` int(11) NOT NULL,
  `ncantidadcotizada` decimal(10,0) DEFAULT NULL,
  `npreciocotizado` decimal(10,0) DEFAULT NULL,
  `vserie` varchar(10) NOT NULL,
  `codVendedor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallefactura`
--

CREATE TABLE `detallefactura` (
  `ncodfactura` int(11) DEFAULT NULL,
  `codproducto` int(11) DEFAULT NULL,
  `ncantidadventa` decimal(10,0) DEFAULT NULL,
  `nprecioventa` decimal(10,0) DEFAULT NULL,
  `vserie` varchar(10) DEFAULT NULL,
  `codVendedor` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallepedido`
--

CREATE TABLE `detallepedido` (
  `ncodpedido` decimal(10,0) NOT NULL,
  `codproducto` int(11) NOT NULL,
  `ncantidadpedido` decimal(10,0) DEFAULT NULL,
  `npreciopedido` decimal(10,0) DEFAULT NULL,
  `vserie` varchar(10) NOT NULL,
  `codVendedor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `documento_compra`
--

CREATE TABLE `documento_compra` (
  `codoc` char(10) NOT NULL,
  `condicion` char(1) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `descuento` int(11) DEFAULT NULL,
  `codtipodocumento` int(11) NOT NULL,
  `codimpuesto` char(10) DEFAULT NULL,
  `codproveedor` int(11) NOT NULL,
  `codproducto` int(11) NOT NULL,
  `codencabezado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `domicilio_fiscal`
--

CREATE TABLE `domicilio_fiscal` (
  `codigo_domicilio` int(11) NOT NULL,
  `codigo_empresa` int(11) DEFAULT NULL,
  `calleoavenida` char(50) NOT NULL,
  `numero` varchar(25) NOT NULL,
  `colonia` varchar(50) NOT NULL,
  `referencia` varchar(100) NOT NULL,
  `ciudad` char(50) NOT NULL,
  `departamento` char(50) NOT NULL,
  `pais` char(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `cod_empleado` int(11) NOT NULL,
  `codigo_persona` int(11) NOT NULL,
  `vmetidoComision` varchar(20) DEFAULT NULL,
  `estado` char(30) DEFAULT NULL,
  `condicion` char(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`cod_empleado`, `codigo_persona`, `vmetidoComision`, `estado`, `condicion`) VALUES
(1, 2, '2', 'ACTIVO', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa`
--

CREATE TABLE `empresa` (
  `codigo_empresa` int(11) NOT NULL,
  `razon_social` char(100) NOT NULL,
  `direccion` char(100) NOT NULL,
  `ciudad` char(100) NOT NULL,
  `registro_tributario` char(50) NOT NULL,
  `pais` char(50) NOT NULL,
  `departamento` char(50) NOT NULL,
  `imagen` char(50) NOT NULL,
  `estado` char(30) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empresa`
--

INSERT INTO `empresa` (`codigo_empresa`, `razon_social`, `direccion`, `ciudad`, `registro_tributario`, `pais`, `departamento`, `imagen`, `estado`, `condicion`) VALUES
(1, 'Empresa 1', 'Guatemala', 'Guatemala', '123', 'Guatemala', 'Guatemala', 'C:\\Users\\DylanIsaac\\Pictures\\goku.png', 'ACTIVO', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezadodoc`
--

CREATE TABLE `encabezadodoc` (
  `codencabezado` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `estado` char(20) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `encabezado_doccompra`
--

CREATE TABLE `encabezado_doccompra` (
  `codencabezado` int(11) NOT NULL,
  `condicion` char(1) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `existencias`
--

CREATE TABLE `existencias` (
  `codexistencias` int(11) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `cantidad` int(10) DEFAULT NULL,
  `fechaingreso` date DEFAULT NULL,
  `fechaegreso` date DEFAULT NULL,
  `codalmacen` int(11) NOT NULL,
  `codproducto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `ncodfactura` int(11) NOT NULL,
  `vserie` varchar(10) NOT NULL,
  `codVendedor` int(11) NOT NULL,
  `moneda` varchar(30) DEFAULT NULL,
  `nombre` char(100) DEFAULT NULL,
  `nit` char(10) DEFAULT NULL,
  `fechafactura` date DEFAULT NULL,
  `fechavencimiento` date DEFAULT NULL,
  `condicion` tinyint(1) DEFAULT NULL,
  `total` decimal(10,0) DEFAULT NULL,
  `estado` varchar(20) DEFAULT NULL,
  `ncodcliente` int(11) DEFAULT NULL,
  `cod_empleado` int(11) DEFAULT NULL,
  `codCobrador` int(11) DEFAULT NULL,
  `movinventario` tinyint(1) NOT NULL,
  `saldo` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`ncodfactura`, `vserie`, `codVendedor`, `moneda`, `nombre`, `nit`, `fechafactura`, `fechavencimiento`, `condicion`, `total`, `estado`, `ncodcliente`, `cod_empleado`, `codCobrador`, `movinventario`, `saldo`) VALUES
(1, 'A', 1, 'Q.', 'Mario Velazquez', '3553228-4', '2016-05-19', '2016-05-31', 1, '500', 'ACTIVO', 1, 1, 1, 0, '0.00'),
(2, 'A', 1, 'Q', 'Empresa1', '98765-4', '2016-05-20', '2016-05-31', 1, '1000', 'ACTIVO', NULL, 1, 1, 0, '0.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturaproveedor`
--

CREATE TABLE `facturaproveedor` (
  `codfacturaprov` int(11) NOT NULL,
  `codproveedor` int(11) NOT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `codencabezado` int(11) DEFAULT NULL,
  `codimpuesto` char(10) DEFAULT NULL,
  `situacion` char(20) DEFAULT NULL,
  `estadomov` tinyint(1) NOT NULL,
  `saldo` decimal(10,2) DEFAULT NULL,
  `estado` char(20) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `facturaproveedor`
--

INSERT INTO `facturaproveedor` (`codfacturaprov`, `codproveedor`, `total`, `fecha`, `codencabezado`, `codimpuesto`, `situacion`, `estadomov`, `saldo`, `estado`, `condicion`) VALUES
(1, 1, '330.00', '2016-05-01', NULL, NULL, 'Pendiente', 1, '0.00', 'ACTIVO', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `formas_pago`
--

CREATE TABLE `formas_pago` (
  `codigo_forma` int(11) NOT NULL,
  `descripcion` char(50) NOT NULL,
  `codigo_tipo_forma` int(11) NOT NULL,
  `estado` char(20) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `formulario`
--

CREATE TABLE `formulario` (
  `codFormulario` int(11) NOT NULL,
  `condicion` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `formulario` char(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `idioma`
--

CREATE TABLE `idioma` (
  `codidioma` int(11) NOT NULL,
  `idioma` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `idioma`
--

INSERT INTO `idioma` (`codidioma`, `idioma`) VALUES
(1, 'Espanol');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `impuestos`
--

CREATE TABLE `impuestos` (
  `codimpuesto` char(10) NOT NULL,
  `condicion` char(1) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `nombre` char(15) NOT NULL,
  `porcentaje` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `linea`
--

CREATE TABLE `linea` (
  `codlinea` int(11) NOT NULL,
  `comision` varchar(20) DEFAULT NULL,
  `condicion` char(1) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `descripcion` char(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `linea`
--

INSERT INTO `linea` (`codlinea`, `comision`, `condicion`, `estado`, `descripcion`) VALUES
(1, '2', '1', 'ACTIVO', 'Electrodomesticos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `listaprecios`
--

CREATE TABLE `listaprecios` (
  `codListaProd` int(11) NOT NULL,
  `total` int(11) DEFAULT NULL,
  `descuento` int(11) DEFAULT NULL,
  `icod` int(11) NOT NULL,
  `codproducto` int(11) NOT NULL,
  `codmarca` int(11) NOT NULL,
  `codlinea` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `codmarca` int(11) NOT NULL,
  `comision` varchar(20) DEFAULT NULL,
  `condicion` char(1) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `descripcion` char(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`codmarca`, `comision`, `condicion`, `estado`, `descripcion`) VALUES
(1, '2', '1', 'ACTIVO', 'Toshiba');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matipocliente`
--

CREATE TABLE `matipocliente` (
  `icod` int(11) NOT NULL,
  `vtipo` varchar(10) DEFAULT NULL,
  `vdescripcion` varchar(18) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `matipocliente`
--

INSERT INTO `matipocliente` (`icod`, `vtipo`, `vdescripcion`) VALUES
(1, 'Individual', 'individual');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `monedas`
--

CREATE TABLE `monedas` (
  `codigo_moneda` int(11) NOT NULL,
  `nombre` char(50) NOT NULL,
  `abreviatura` varchar(25) NOT NULL,
  `fecha_registro` date NOT NULL,
  `estado` char(20) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mora`
--

CREATE TABLE `mora` (
  `codMora` int(11) NOT NULL,
  `porcentaje` decimal(10,2) DEFAULT NULL,
  `estado` char(50) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimientoinventario`
--

CREATE TABLE `movimientoinventario` (
  `codmov` char(10) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `descripcion` char(100) DEFAULT NULL,
  `concepto` char(10) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `codtipomovimiento` int(10) NOT NULL,
  `codproveedor` int(11) NOT NULL,
  `codproducto` int(11) NOT NULL,
  `ncodcliente` int(11) DEFAULT NULL,
  `codCobrador` int(11) DEFAULT NULL,
  `codVendedor` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimientosbancarios`
--

CREATE TABLE `movimientosbancarios` (
  `codigo_movimiento` int(11) NOT NULL,
  `codigo_cuenta_interna` int(11) NOT NULL,
  `codigo_concepto` int(11) NOT NULL,
  `codigo_forma` int(11) NOT NULL,
  `codigo_cuenta_externa` int(11) NOT NULL,
  `codigo_moneda` int(11) NOT NULL,
  `fecha_registro` date NOT NULL,
  `fecha_aplicacion` date NOT NULL,
  `referencia_1` varchar(50) NOT NULL,
  `referencia_2` varchar(50) DEFAULT NULL,
  `monto_total` float(8,0) NOT NULL,
  `observaciones` varchar(100) DEFAULT NULL,
  `estado` char(20) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimientosconciliados`
--

CREATE TABLE `movimientosconciliados` (
  `codigo_conciliacion` int(11) NOT NULL,
  `codigo_movimiento` int(11) NOT NULL,
  `estado_conciliacion` bit(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimientosrepetitivos`
--

CREATE TABLE `movimientosrepetitivos` (
  `no_movimiento` int(11) NOT NULL,
  `codigo_agenda` int(11) DEFAULT NULL,
  `fecha` date NOT NULL,
  `estado` char(20) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `multilenguaje`
--

CREATE TABLE `multilenguaje` (
  `codlenguaje` int(11) NOT NULL,
  `lenguaje` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `operacioncontable`
--

CREATE TABLE `operacioncontable` (
  `codigo_operacion` int(11) NOT NULL,
  `operacion` char(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `parametros`
--

CREATE TABLE `parametros` (
  `codigo_parametro` int(11) NOT NULL,
  `codigo_empresa` int(11) NOT NULL,
  `codigo_sistema` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `valor` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE `pedido` (
  `ncodpedido` decimal(10,0) NOT NULL,
  `vserie` varchar(10) NOT NULL,
  `codVendedor` int(11) NOT NULL,
  `dfechapedido` date DEFAULT NULL,
  `dfechavencimiento` date DEFAULT NULL,
  `ntotal` decimal(10,0) DEFAULT NULL,
  `vestadopedido` varchar(20) DEFAULT NULL,
  `ncodcliente` int(11) NOT NULL,
  `cod_empleado` int(11) NOT NULL,
  `codCobrador` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `permiso`
--

CREATE TABLE `permiso` (
  `codigo_permisos` int(11) NOT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `validacion` varchar(20) DEFAULT NULL,
  `estado` varchar(20) DEFAULT NULL,
  `condicion` varchar(20) DEFAULT NULL,
  `codigo_privilegios` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personas`
--

CREATE TABLE `personas` (
  `codigo_persona` int(11) NOT NULL,
  `codigo_empresa` int(11) NOT NULL,
  `dpi` char(50) NOT NULL,
  `nombres` varchar(50) NOT NULL,
  `apellidos` varchar(50) NOT NULL,
  `sexo` varchar(50) NOT NULL,
  `fechaNacimiento` date NOT NULL,
  `direccion` varchar(100) NOT NULL,
  `telefono` varchar(50) NOT NULL,
  `nit` char(50) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `estado` char(50) NOT NULL,
  `condicion` char(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `personas`
--

INSERT INTO `personas` (`codigo_persona`, `codigo_empresa`, `dpi`, `nombres`, `apellidos`, `sexo`, `fechaNacimiento`, `direccion`, `telefono`, `nit`, `correo`, `estado`, `condicion`) VALUES
(1, 1, '123456', 'Dylan ', 'Corado', 'Masculino', '2016-05-16', 'Guatemala', '24483027', '123445-6', 'nos_196@hotmail.com', 'ACTIVO', 'ACTIVO'),
(2, 1, '44444', 'Kevin', 'Cajbon', 'Masculino', '2016-05-10', 'Guatemala', '44444444', '2112121-9', 'kevin@hotmail.com', 'ACTIVO', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prestamo`
--

CREATE TABLE `prestamo` (
  `codPrestamo` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `pagos` char(50) DEFAULT NULL,
  `interes` decimal(10,0) DEFAULT NULL,
  `estado` char(50) DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL,
  `cod_empleado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `prestamo`
--

INSERT INTO `prestamo` (`codPrestamo`, `fecha`, `total`, `pagos`, `interes`, `estado`, `condicion`, `cod_empleado`) VALUES
(1, '2016-05-19', '100.00', '2', '2', 'ACTIVO', 'ACTIVO', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `privilegios`
--

CREATE TABLE `privilegios` (
  `codigo_privilegios` int(11) NOT NULL,
  `formulario` varchar(40) DEFAULT NULL,
  `condicion` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `permiso` char(20) DEFAULT NULL,
  `codigo_rol` int(11) NOT NULL,
  `codFormulario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `codproducto` int(11) NOT NULL,
  `comision` char(10) DEFAULT NULL,
  `imagen` char(100) NOT NULL,
  `condicion` char(1) NOT NULL,
  `fechacreacion` date DEFAULT NULL,
  `fechacompra` date DEFAULT NULL,
  `fechaventa` date DEFAULT NULL,
  `exstmin` int(11) DEFAULT NULL,
  `tipoproducto` char(10) DEFAULT NULL,
  `tamano` char(10) DEFAULT NULL,
  `costeo` char(20) DEFAULT NULL,
  `exstmax` int(11) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `costo` decimal(10,2) DEFAULT NULL,
  `nombreproducto` varchar(50) DEFAULT NULL,
  `descripcion` varchar(50) DEFAULT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `existencia` int(11) DEFAULT NULL,
  `codmarca` int(11) NOT NULL,
  `codlinea` int(11) NOT NULL,
  `codproveedor` int(11) NOT NULL,
  `codTipoProducto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `codproveedor` int(11) NOT NULL,
  `condicion` char(1) DEFAULT NULL,
  `nombre` char(50) DEFAULT NULL,
  `direccion` char(50) DEFAULT NULL,
  `nit` char(30) DEFAULT NULL,
  `telefono` char(50) DEFAULT NULL,
  `descripcion` char(50) DEFAULT NULL,
  `cuenta` char(50) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`codproveedor`, `condicion`, `nombre`, `direccion`, `nit`, `telefono`, `descripcion`, `cuenta`, `estado`) VALUES
(1, '1', 'Emotion', 'Guatemala', '98765-4', '23630547', 'Venta de llantas', '1112223', 'ACTIVO'),
(2, '1', 'Toshiba', 'Guatemala', '99999', '12345678', 'Toshiba', '123123123', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporte`
--

CREATE TABLE `reporte` (
  `ncodreporte` int(11) NOT NULL,
  `codigo_sistema` int(11) NOT NULL,
  `nombre_reporte` varchar(50) NOT NULL,
  `directorio` varchar(100) NOT NULL,
  `fecha` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rol`
--

CREATE TABLE `rol` (
  `codigo_rol` int(11) NOT NULL,
  `condicion` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL,
  `tipo` char(100) DEFAULT NULL,
  `descripcion` char(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sistema`
--

CREATE TABLE `sistema` (
  `codigo_sistema` int(11) NOT NULL,
  `sistema` char(50) NOT NULL,
  `descripcion` char(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `talonario`
--

CREATE TABLE `talonario` (
  `codTalonario` int(11) NOT NULL,
  `monto` decimal(10,2) DEFAULT NULL,
  `fechaPago` date DEFAULT NULL,
  `condicion` char(30) DEFAULT NULL,
  `estado` char(50) DEFAULT NULL,
  `codPrestamo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `talonario`
--

INSERT INTO `talonario` (`codTalonario`, `monto`, `fechaPago`, `condicion`, `estado`, `codPrestamo`) VALUES
(1, '50.00', '2016-06-18', 'ACTIVO', 'ACTIVO', 1),
(2, '50.00', '2016-07-18', 'ACTIVO', 'ACTIVO', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipobd`
--

CREATE TABLE `tipobd` (
  `codigo_tipo_bd` int(11) NOT NULL,
  `tipo` char(50) NOT NULL,
  `descripcion` char(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipoboleta`
--

CREATE TABLE `tipoboleta` (
  `codTipoBoleta` int(11) NOT NULL,
  `nombre` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipocambiomoneda`
--

CREATE TABLE `tipocambiomoneda` (
  `codigo_tipo_cambio` int(11) NOT NULL,
  `codigo_moneda` int(11) NOT NULL,
  `tipo_cambio` float(8,0) NOT NULL,
  `fecha_registro` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipocomision`
--

CREATE TABLE `tipocomision` (
  `codComision` int(11) NOT NULL,
  `porcentaje` varchar(30) DEFAULT NULL,
  `tipoComision` varchar(100) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipodocumento`
--

CREATE TABLE `tipodocumento` (
  `codtipodocumento` int(11) NOT NULL,
  `tipo` char(30) DEFAULT NULL,
  `descripcion` char(200) DEFAULT NULL,
  `condicion` char(10) DEFAULT NULL,
  `estado` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipodocumento`
--

INSERT INTO `tipodocumento` (`codtipodocumento`, `tipo`, `descripcion`, `condicion`, `estado`) VALUES
(1, 'cheque', 'cheque de cualquier banco', 'ACTIVO', 'ACTIVO'),
(2, 'Efectivo', 'Billete en quetzales', 'ACTIVO', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipofactura`
--

CREATE TABLE `tipofactura` (
  `codTipoFactura` int(11) NOT NULL,
  `tipo` char(50) DEFAULT NULL,
  `estado` char(50) DEFAULT NULL,
  `condicion` char(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipofactura`
--

INSERT INTO `tipofactura` (`codTipoFactura`, `tipo`, `estado`, `condicion`) VALUES
(1, 'Cliente', 'ACTIVO', 'ACTIVO'),
(2, 'Proveedor', 'ACTIVO', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipoformapago`
--

CREATE TABLE `tipoformapago` (
  `codigo_tipo_forma` int(11) NOT NULL,
  `tipo_forma` char(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipoformapago`
--

INSERT INTO `tipoformapago` (`codigo_tipo_forma`, `tipo_forma`) VALUES
(1, 'Efectivo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipomovimientoinventario`
--

CREATE TABLE `tipomovimientoinventario` (
  `codtipomovimiento` int(11) NOT NULL,
  `estado` char(10) DEFAULT NULL,
  `descripcion` char(70) NOT NULL,
  `movimiento` char(20) NOT NULL,
  `condicion` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `codigo_usuario` int(11) NOT NULL,
  `condicion` varchar(10) DEFAULT NULL,
  `nombre_usuario` char(100) DEFAULT NULL,
  `password_usuario` char(100) DEFAULT NULL,
  `codigo_rol` int(11) NOT NULL,
  `estado` char(50) NOT NULL,
  `cod_empleado` int(11) NOT NULL,
  `codigo_persona` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vendedor`
--

CREATE TABLE `vendedor` (
  `codVendedor` int(11) NOT NULL,
  `condicion` varchar(20) DEFAULT NULL,
  `comision` varchar(20) DEFAULT NULL,
  `nombrevendedor` varchar(30) DEFAULT NULL,
  `apellidovendedor` varchar(30) DEFAULT NULL,
  `direccion` varchar(20) DEFAULT NULL,
  `telefono` varchar(10) DEFAULT NULL,
  `correo` varchar(50) DEFAULT NULL,
  `estado` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `vendedor`
--

INSERT INTO `vendedor` (`codVendedor`, `condicion`, `comision`, `nombrevendedor`, `apellidovendedor`, `direccion`, `telefono`, `correo`, `estado`) VALUES
(1, 'ACTIVO', 'por factura', 'Diego ', 'Taracena', 'Guatemala', '28909090', 'diego@hot', 'ACTIVO');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `viewexistencias`
--
CREATE TABLE `viewexistencias` (
`Existencias` int(10)
,`Almacen` char(100)
,`Codigo_Producto` int(11)
,`Nombre` varchar(50)
,`Marca` char(100)
,`Linea` char(100)
,`Ultimo_Ingreso` date
,`Ultimo_Egreso` date
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `viewproducto`
--
CREATE TABLE `viewproducto` (
`Codigo` int(11)
,`Nombre` varchar(50)
,`Descripcion` varchar(50)
,`Marca` char(100)
,`Proveedor` char(50)
,`Linea` char(100)
,`Tamano` char(10)
,`Costo` decimal(10,2)
,`Precio` decimal(10,2)
,`Existencia` int(11)
,`ExisMin` int(11)
,`ExisMax` int(11)
,`Costeo` char(20)
,`Tipo_Producto` char(10)
,`Fecha_Creacion` date
,`Ultima_Venta` date
,`Ultima_Compra` date
,`Comision` char(10)
,`Estado` char(10)
);

-- --------------------------------------------------------

--
-- Estructura para la vista `viewexistencias`
--
DROP TABLE IF EXISTS `viewexistencias`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewexistencias`  AS  select `existencias`.`cantidad` AS `Existencias`,`almacen`.`nombre` AS `Almacen`,`producto`.`codproducto` AS `Codigo_Producto`,`producto`.`nombreproducto` AS `Nombre`,`marca`.`descripcion` AS `Marca`,`linea`.`descripcion` AS `Linea`,`existencias`.`fechaingreso` AS `Ultimo_Ingreso`,`existencias`.`fechaegreso` AS `Ultimo_Egreso` from ((((`producto` join `marca`) join `linea`) join `existencias`) join `almacen`) where ((`marca`.`codmarca` = `producto`.`codmarca`) and (`linea`.`codlinea` = `producto`.`codlinea`) and (`existencias`.`codalmacen` = `almacen`.`codalmacen`) and (`producto`.`codproducto` = `existencias`.`codproducto`)) ;

-- --------------------------------------------------------

--
-- Estructura para la vista `viewproducto`
--
DROP TABLE IF EXISTS `viewproducto`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `viewproducto`  AS  select `producto`.`codproducto` AS `Codigo`,`producto`.`nombreproducto` AS `Nombre`,`producto`.`descripcion` AS `Descripcion`,`marca`.`descripcion` AS `Marca`,`proveedor`.`nombre` AS `Proveedor`,`linea`.`descripcion` AS `Linea`,`producto`.`tamano` AS `Tamano`,`producto`.`costo` AS `Costo`,`producto`.`precio` AS `Precio`,`producto`.`existencia` AS `Existencia`,`producto`.`exstmin` AS `ExisMin`,`producto`.`exstmax` AS `ExisMax`,`producto`.`costeo` AS `Costeo`,`producto`.`tipoproducto` AS `Tipo_Producto`,`producto`.`fechacreacion` AS `Fecha_Creacion`,`producto`.`fechaventa` AS `Ultima_Venta`,`producto`.`fechacompra` AS `Ultima_Compra`,`producto`.`comision` AS `Comision`,`producto`.`estado` AS `Estado` from (((`producto` join `marca`) join `linea`) join `proveedor`) where ((`marca`.`codmarca` = `producto`.`codmarca`) and (`linea`.`codlinea` = `producto`.`codlinea`) and (`proveedor`.`codproveedor` = `producto`.`codproveedor`) and (`producto`.`condicion` = 1)) ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `agendamovimientos`
--
ALTER TABLE `agendamovimientos`
  ADD PRIMARY KEY (`codigo_agenda`),
  ADD KEY `RefMOVIMIENTOSBANCARIOS71` (`codigo_movimiento`);

--
-- Indices de la tabla `almacen`
--
ALTER TABLE `almacen`
  ADD PRIMARY KEY (`codalmacen`),
  ADD KEY `RefEMPRESA114` (`codigo_empresa`);

--
-- Indices de la tabla `bancos`
--
ALTER TABLE `bancos`
  ADD PRIMARY KEY (`codigo_banco`);

--
-- Indices de la tabla `basededatos`
--
ALTER TABLE `basededatos`
  ADD PRIMARY KEY (`codigo_bd`),
  ADD KEY `RefTIPOBD10` (`codigo_tipo_bd`),
  ADD KEY `RefEMPRESA11` (`codigo_empresa`);

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`codigo_bitacora`),
  ADD KEY `RefUSUARIO5` (`codigo_usuario`,`codigo_persona`);

--
-- Indices de la tabla `boleta`
--
ALTER TABLE `boleta`
  ADD PRIMARY KEY (`no_boleta`),
  ADD KEY `RefCUENTASEXTERNAS116` (`codigo_cuenta_externa`),
  ADD KEY `RefTIPOBOLETA46` (`codTipoBoleta`),
  ADD KEY `RefPRESTAMO48` (`codPrestamo`),
  ADD KEY `RefTALONARIO49` (`codTalonario`),
  ADD KEY `RefCUENTASINTERNAS84` (`codigo_cuenta_interna`);

--
-- Indices de la tabla `cheques`
--
ALTER TABLE `cheques`
  ADD PRIMARY KEY (`codigo_cheque`),
  ADD KEY `RefCONCEPTOSBANCARIOS73` (`codigo_concepto`);

--
-- Indices de la tabla `clasificacionconceptosbancarios`
--
ALTER TABLE `clasificacionconceptosbancarios`
  ADD PRIMARY KEY (`codigo_clasificacion`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`ncodcliente`,`codCobrador`,`codVendedor`),
  ADD KEY `RefEMPLEADO103` (`cod_empleado`),
  ADD KEY `RefCOBRADOR152` (`codCobrador`),
  ADD KEY `RefVENDEDOR153` (`codVendedor`),
  ADD KEY `RefMATIPOCLIENTE35` (`icod`);

--
-- Indices de la tabla `cobrador`
--
ALTER TABLE `cobrador`
  ADD PRIMARY KEY (`codCobrador`);

--
-- Indices de la tabla `comision`
--
ALTER TABLE `comision`
  ADD PRIMARY KEY (`codigocomision`,`codVendedor`),
  ADD KEY `RefVENDEDOR160` (`codVendedor`),
  ADD KEY `RefTIPOCOMISION162` (`codComision`);

--
-- Indices de la tabla `conceptos`
--
ALTER TABLE `conceptos`
  ADD PRIMARY KEY (`codigo_tipo_transaccion`);

--
-- Indices de la tabla `conceptosbancarios`
--
ALTER TABLE `conceptosbancarios`
  ADD PRIMARY KEY (`codigo_concepto`),
  ADD KEY `RefOPERACIONCONTABLE74` (`codigo_operacion`),
  ADD KEY `RefCLASIFICACIONCONCEPTOSBANCARIOS75` (`codigo_clasificacion`);

--
-- Indices de la tabla `conciliacionbancaria`
--
ALTER TABLE `conciliacionbancaria`
  ADD PRIMARY KEY (`codigo_conciliacion`);

--
-- Indices de la tabla `cotizacion`
--
ALTER TABLE `cotizacion`
  ADD PRIMARY KEY (`ncodcotizacion`,`vserie`,`codVendedor`),
  ADD KEY `RefEMPLEADO100` (`cod_empleado`),
  ADD KEY `RefCLIENTE27` (`codVendedor`,`ncodcliente`,`codCobrador`);

--
-- Indices de la tabla `cuentascorrientesclientes`
--
ALTER TABLE `cuentascorrientesclientes`
  ADD PRIMARY KEY (`codigo_cuentac`),
  ADD KEY `RefFACTURA117` (`ncodfactura`,`vserie`,`codVendedor`),
  ADD KEY `RefCLIENTE119` (`ncodcliente`,`codVendedor`,`codCobrador`),
  ADD KEY `RefMORA124` (`codMora`),
  ADD KEY `RefCONCEPTOS126` (`codigo_tipo_transaccion`),
  ADD KEY `relacionclientes_Tipo` (`codtipodocumento`),
  ADD KEY `relacioncuentascorrientesclientes_encabezado` (`codencabezado`);

--
-- Indices de la tabla `cuentascorrientesempleados`
--
ALTER TABLE `cuentascorrientesempleados`
  ADD PRIMARY KEY (`codCEmpleados`),
  ADD KEY `RefCONCEPTOS144` (`codigo_tipo_transaccion`),
  ADD KEY `RefTALONARIO146` (`codTalonario`),
  ADD KEY `RefMORA147` (`codMora`),
  ADD KEY `relacionempleados_Tipo` (`codtipodocumento`);

--
-- Indices de la tabla `cuentascorrientesproveedores`
--
ALTER TABLE `cuentascorrientesproveedores`
  ADD PRIMARY KEY (`codCProveedores`),
  ADD KEY `RefPROVEEDOR140` (`codproveedor`),
  ADD KEY `RefCONCEPTOS141` (`codigo_tipo_transaccion`),
  ADD KEY `relacionproveedores_Tipo` (`codtipodocumento`),
  ADD KEY `relaciontipofacturaproveedor_cuentascorrientesproveedor` (`codfacturaprov`),
  ADD KEY `relacioncuentascorrientesprov_encabezado` (`codencabezado`);

--
-- Indices de la tabla `cuentasexternas`
--
ALTER TABLE `cuentasexternas`
  ADD PRIMARY KEY (`codigo_cuenta_externa`),
  ADD KEY `RefBANCOS104` (`codigo_banco`),
  ADD KEY `RefPERSONAS106` (`codigo_persona`),
  ADD KEY `RefPROVEEDOR130` (`codproveedor`);

--
-- Indices de la tabla `cuentasinternas`
--
ALTER TABLE `cuentasinternas`
  ADD PRIMARY KEY (`codigo_cuenta_interna`),
  ADD KEY `RefEMPRESA105` (`codigo_empresa`),
  ADD KEY `RefBANCOS68` (`codigo_banco`),
  ADD KEY `RefMONEDAS79` (`codigo_moneda`);

--
-- Indices de la tabla `detallecotizacion`
--
ALTER TABLE `detallecotizacion`
  ADD KEY `RefCOTIZACION28` (`ncodcotizacion`,`vserie`,`codVendedor`),
  ADD KEY `RefPRODUCTO29` (`codproducto`);

--
-- Indices de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD KEY `RefFACTURA24` (`ncodfactura`,`vserie`,`codVendedor`),
  ADD KEY `RefPRODUCTO25` (`codproducto`);

--
-- Indices de la tabla `detallepedido`
--
ALTER TABLE `detallepedido`
  ADD KEY `RefPEDIDO30` (`ncodpedido`,`vserie`,`codVendedor`),
  ADD KEY `RefPRODUCTO31` (`codproducto`);

--
-- Indices de la tabla `documento_compra`
--
ALTER TABLE `documento_compra`
  ADD PRIMARY KEY (`codoc`),
  ADD KEY `RefENCABEZADO_DOCCOMPRA128` (`codencabezado`),
  ADD KEY `RefIMPUESTOS18` (`codimpuesto`),
  ADD KEY `RefPROVEEDOR21` (`codproveedor`),
  ADD KEY `RefPRODUCTO43` (`codproducto`),
  ADD KEY `documentocompra_Tipo` (`codtipodocumento`);

--
-- Indices de la tabla `domicilio_fiscal`
--
ALTER TABLE `domicilio_fiscal`
  ADD PRIMARY KEY (`codigo_domicilio`),
  ADD KEY `RefEMPRESA8` (`codigo_empresa`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`cod_empleado`),
  ADD KEY `RefPERSONAS107` (`codigo_persona`);

--
-- Indices de la tabla `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`codigo_empresa`);

--
-- Indices de la tabla `encabezadodoc`
--
ALTER TABLE `encabezadodoc`
  ADD PRIMARY KEY (`codencabezado`);

--
-- Indices de la tabla `encabezado_doccompra`
--
ALTER TABLE `encabezado_doccompra`
  ADD PRIMARY KEY (`codencabezado`);

--
-- Indices de la tabla `existencias`
--
ALTER TABLE `existencias`
  ADD PRIMARY KEY (`codexistencias`),
  ADD KEY `RefALMACEN134` (`codalmacen`),
  ADD KEY `RefPRODUCTO135` (`codproducto`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`ncodfactura`,`vserie`,`codVendedor`),
  ADD KEY `RefEMPLEADO101` (`cod_empleado`),
  ADD KEY `RefCLIENTE23` (`codVendedor`,`ncodcliente`,`codCobrador`);

--
-- Indices de la tabla `facturaproveedor`
--
ALTER TABLE `facturaproveedor`
  ADD PRIMARY KEY (`codfacturaprov`),
  ADD KEY `RefIMPUESTOS_fact18` (`codimpuesto`),
  ADD KEY `RefPROVEEDOR_fact21` (`codproveedor`),
  ADD KEY `RefENCABFACT18` (`codencabezado`);

--
-- Indices de la tabla `formas_pago`
--
ALTER TABLE `formas_pago`
  ADD PRIMARY KEY (`codigo_forma`),
  ADD KEY `RefTIPOFORMAPAGO76` (`codigo_tipo_forma`);

--
-- Indices de la tabla `formulario`
--
ALTER TABLE `formulario`
  ADD PRIMARY KEY (`codFormulario`);

--
-- Indices de la tabla `idioma`
--
ALTER TABLE `idioma`
  ADD PRIMARY KEY (`codidioma`);

--
-- Indices de la tabla `impuestos`
--
ALTER TABLE `impuestos`
  ADD PRIMARY KEY (`codimpuesto`);

--
-- Indices de la tabla `linea`
--
ALTER TABLE `linea`
  ADD PRIMARY KEY (`codlinea`);

--
-- Indices de la tabla `listaprecios`
--
ALTER TABLE `listaprecios`
  ADD PRIMARY KEY (`codListaProd`),
  ADD KEY `RefMATIPOCLIENTE164` (`icod`),
  ADD KEY `RefPRODUCTO166` (`codproducto`),
  ADD KEY `RefMARCA167` (`codmarca`),
  ADD KEY `RefLINEA168` (`codlinea`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`codmarca`);

--
-- Indices de la tabla `matipocliente`
--
ALTER TABLE `matipocliente`
  ADD PRIMARY KEY (`icod`);

--
-- Indices de la tabla `monedas`
--
ALTER TABLE `monedas`
  ADD PRIMARY KEY (`codigo_moneda`);

--
-- Indices de la tabla `mora`
--
ALTER TABLE `mora`
  ADD PRIMARY KEY (`codMora`);

--
-- Indices de la tabla `movimientoinventario`
--
ALTER TABLE `movimientoinventario`
  ADD PRIMARY KEY (`codmov`),
  ADD KEY `RefPROVEEDOR20` (`codproveedor`),
  ADD KEY `RefPRODUCTO42` (`codproducto`),
  ADD KEY `RefCLIENTE45` (`ncodcliente`,`codCobrador`,`codVendedor`),
  ADD KEY `RefTipoMovInv` (`codtipomovimiento`);

--
-- Indices de la tabla `movimientosbancarios`
--
ALTER TABLE `movimientosbancarios`
  ADD PRIMARY KEY (`codigo_movimiento`),
  ADD KEY `RefCUENTASEXTERNAS131` (`codigo_cuenta_externa`),
  ADD KEY `RefMONEDAS155` (`codigo_moneda`),
  ADD KEY `RefCONCEPTOSBANCARIOS69` (`codigo_concepto`),
  ADD KEY `RefFORMAS_PAGO70` (`codigo_forma`),
  ADD KEY `RefCUENTASINTERNAS81` (`codigo_cuenta_interna`);

--
-- Indices de la tabla `movimientosconciliados`
--
ALTER TABLE `movimientosconciliados`
  ADD PRIMARY KEY (`codigo_conciliacion`),
  ADD KEY `RefMOVIMIENTOSBANCARIOS80` (`codigo_movimiento`);

--
-- Indices de la tabla `movimientosrepetitivos`
--
ALTER TABLE `movimientosrepetitivos`
  ADD PRIMARY KEY (`no_movimiento`),
  ADD KEY `RefAGENDAMOVIMIENTOS72` (`codigo_agenda`);

--
-- Indices de la tabla `multilenguaje`
--
ALTER TABLE `multilenguaje`
  ADD PRIMARY KEY (`codlenguaje`);

--
-- Indices de la tabla `operacioncontable`
--
ALTER TABLE `operacioncontable`
  ADD PRIMARY KEY (`codigo_operacion`);

--
-- Indices de la tabla `parametros`
--
ALTER TABLE `parametros`
  ADD PRIMARY KEY (`codigo_parametro`),
  ADD KEY `RefSISTEMA9` (`codigo_sistema`),
  ADD KEY `RefEMPRESA12` (`codigo_empresa`);

--
-- Indices de la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`ncodpedido`,`vserie`,`codVendedor`),
  ADD KEY `RefEMPLEADO99` (`cod_empleado`),
  ADD KEY `RefCLIENTE26` (`codVendedor`,`ncodcliente`,`codCobrador`);

--
-- Indices de la tabla `permiso`
--
ALTER TABLE `permiso`
  ADD PRIMARY KEY (`codigo_permisos`,`codigo_privilegios`),
  ADD KEY `RefPRIVILEGIOS158` (`codigo_privilegios`);

--
-- Indices de la tabla `personas`
--
ALTER TABLE `personas`
  ADD PRIMARY KEY (`codigo_persona`),
  ADD KEY `RefEMPRESA113` (`codigo_empresa`);

--
-- Indices de la tabla `prestamo`
--
ALTER TABLE `prestamo`
  ADD PRIMARY KEY (`codPrestamo`),
  ADD KEY `RefEMPLEADO55` (`cod_empleado`);

--
-- Indices de la tabla `privilegios`
--
ALTER TABLE `privilegios`
  ADD PRIMARY KEY (`codigo_privilegios`),
  ADD KEY `RefROL2` (`codigo_rol`),
  ADD KEY `RefFORMULARIO86` (`codFormulario`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`codproducto`),
  ADD KEY `RefLINEA129` (`codlinea`),
  ADD KEY `RefPROVEEDOR133` (`codproveedor`),
  ADD KEY `RefTIPOPRODUCTO163` (`codTipoProducto`),
  ADD KEY `RefMARCA41` (`codmarca`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`codproveedor`);

--
-- Indices de la tabla `reporte`
--
ALTER TABLE `reporte`
  ADD PRIMARY KEY (`ncodreporte`),
  ADD KEY `RefSISTEMA85` (`codigo_sistema`);

--
-- Indices de la tabla `rol`
--
ALTER TABLE `rol`
  ADD PRIMARY KEY (`codigo_rol`);

--
-- Indices de la tabla `sistema`
--
ALTER TABLE `sistema`
  ADD PRIMARY KEY (`codigo_sistema`);

--
-- Indices de la tabla `talonario`
--
ALTER TABLE `talonario`
  ADD PRIMARY KEY (`codTalonario`),
  ADD KEY `RefPRESTAMO56` (`codPrestamo`);

--
-- Indices de la tabla `tipobd`
--
ALTER TABLE `tipobd`
  ADD PRIMARY KEY (`codigo_tipo_bd`);

--
-- Indices de la tabla `tipoboleta`
--
ALTER TABLE `tipoboleta`
  ADD PRIMARY KEY (`codTipoBoleta`);

--
-- Indices de la tabla `tipocambiomoneda`
--
ALTER TABLE `tipocambiomoneda`
  ADD PRIMARY KEY (`codigo_tipo_cambio`),
  ADD KEY `RefMONEDAS77` (`codigo_moneda`);

--
-- Indices de la tabla `tipocomision`
--
ALTER TABLE `tipocomision`
  ADD PRIMARY KEY (`codComision`);

--
-- Indices de la tabla `tipodocumento`
--
ALTER TABLE `tipodocumento`
  ADD PRIMARY KEY (`codtipodocumento`);

--
-- Indices de la tabla `tipofactura`
--
ALTER TABLE `tipofactura`
  ADD PRIMARY KEY (`codTipoFactura`);

--
-- Indices de la tabla `tipoformapago`
--
ALTER TABLE `tipoformapago`
  ADD PRIMARY KEY (`codigo_tipo_forma`);

--
-- Indices de la tabla `tipomovimientoinventario`
--
ALTER TABLE `tipomovimientoinventario`
  ADD PRIMARY KEY (`codtipomovimiento`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`codigo_usuario`,`codigo_persona`),
  ADD KEY `RefEMPLEADO92` (`cod_empleado`),
  ADD KEY `RefPERSONAS157` (`codigo_persona`),
  ADD KEY `RefROL1` (`codigo_rol`);

--
-- Indices de la tabla `vendedor`
--
ALTER TABLE `vendedor`
  ADD PRIMARY KEY (`codVendedor`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `agendamovimientos`
--
ALTER TABLE `agendamovimientos`
  MODIFY `codigo_agenda` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `almacen`
--
ALTER TABLE `almacen`
  MODIFY `codalmacen` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `bancos`
--
ALTER TABLE `bancos`
  MODIFY `codigo_banco` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `basededatos`
--
ALTER TABLE `basededatos`
  MODIFY `codigo_bd` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `codigo_bitacora` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `boleta`
--
ALTER TABLE `boleta`
  MODIFY `no_boleta` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cheques`
--
ALTER TABLE `cheques`
  MODIFY `codigo_cheque` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `clasificacionconceptosbancarios`
--
ALTER TABLE `clasificacionconceptosbancarios`
  MODIFY `codigo_clasificacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `ncodcliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `cobrador`
--
ALTER TABLE `cobrador`
  MODIFY `codCobrador` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `comision`
--
ALTER TABLE `comision`
  MODIFY `codigocomision` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `conceptos`
--
ALTER TABLE `conceptos`
  MODIFY `codigo_tipo_transaccion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `conceptosbancarios`
--
ALTER TABLE `conceptosbancarios`
  MODIFY `codigo_concepto` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `conciliacionbancaria`
--
ALTER TABLE `conciliacionbancaria`
  MODIFY `codigo_conciliacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cotizacion`
--
ALTER TABLE `cotizacion`
  MODIFY `ncodcotizacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cuentascorrientesclientes`
--
ALTER TABLE `cuentascorrientesclientes`
  MODIFY `codigo_cuentac` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cuentascorrientesempleados`
--
ALTER TABLE `cuentascorrientesempleados`
  MODIFY `codCEmpleados` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cuentascorrientesproveedores`
--
ALTER TABLE `cuentascorrientesproveedores`
  MODIFY `codCProveedores` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cuentasexternas`
--
ALTER TABLE `cuentasexternas`
  MODIFY `codigo_cuenta_externa` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cuentasinternas`
--
ALTER TABLE `cuentasinternas`
  MODIFY `codigo_cuenta_interna` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `domicilio_fiscal`
--
ALTER TABLE `domicilio_fiscal`
  MODIFY `codigo_domicilio` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `empleado`
--
ALTER TABLE `empleado`
  MODIFY `cod_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `empresa`
--
ALTER TABLE `empresa`
  MODIFY `codigo_empresa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `encabezadodoc`
--
ALTER TABLE `encabezadodoc`
  MODIFY `codencabezado` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `encabezado_doccompra`
--
ALTER TABLE `encabezado_doccompra`
  MODIFY `codencabezado` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `existencias`
--
ALTER TABLE `existencias`
  MODIFY `codexistencias` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `ncodfactura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `facturaproveedor`
--
ALTER TABLE `facturaproveedor`
  MODIFY `codfacturaprov` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `formas_pago`
--
ALTER TABLE `formas_pago`
  MODIFY `codigo_forma` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `formulario`
--
ALTER TABLE `formulario`
  MODIFY `codFormulario` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `idioma`
--
ALTER TABLE `idioma`
  MODIFY `codidioma` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `linea`
--
ALTER TABLE `linea`
  MODIFY `codlinea` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `listaprecios`
--
ALTER TABLE `listaprecios`
  MODIFY `codListaProd` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `codmarca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `matipocliente`
--
ALTER TABLE `matipocliente`
  MODIFY `icod` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `monedas`
--
ALTER TABLE `monedas`
  MODIFY `codigo_moneda` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `mora`
--
ALTER TABLE `mora`
  MODIFY `codMora` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `movimientosbancarios`
--
ALTER TABLE `movimientosbancarios`
  MODIFY `codigo_movimiento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `movimientosrepetitivos`
--
ALTER TABLE `movimientosrepetitivos`
  MODIFY `no_movimiento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `multilenguaje`
--
ALTER TABLE `multilenguaje`
  MODIFY `codlenguaje` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `operacioncontable`
--
ALTER TABLE `operacioncontable`
  MODIFY `codigo_operacion` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `parametros`
--
ALTER TABLE `parametros`
  MODIFY `codigo_parametro` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `permiso`
--
ALTER TABLE `permiso`
  MODIFY `codigo_permisos` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `personas`
--
ALTER TABLE `personas`
  MODIFY `codigo_persona` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `prestamo`
--
ALTER TABLE `prestamo`
  MODIFY `codPrestamo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `privilegios`
--
ALTER TABLE `privilegios`
  MODIFY `codigo_privilegios` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `codproducto` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `codproveedor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `reporte`
--
ALTER TABLE `reporte`
  MODIFY `ncodreporte` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `rol`
--
ALTER TABLE `rol`
  MODIFY `codigo_rol` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `sistema`
--
ALTER TABLE `sistema`
  MODIFY `codigo_sistema` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `talonario`
--
ALTER TABLE `talonario`
  MODIFY `codTalonario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `tipoboleta`
--
ALTER TABLE `tipoboleta`
  MODIFY `codTipoBoleta` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tipocambiomoneda`
--
ALTER TABLE `tipocambiomoneda`
  MODIFY `codigo_tipo_cambio` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tipocomision`
--
ALTER TABLE `tipocomision`
  MODIFY `codComision` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `tipodocumento`
--
ALTER TABLE `tipodocumento`
  MODIFY `codtipodocumento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `tipofactura`
--
ALTER TABLE `tipofactura`
  MODIFY `codTipoFactura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT de la tabla `tipoformapago`
--
ALTER TABLE `tipoformapago`
  MODIFY `codigo_tipo_forma` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `tipomovimientoinventario`
--
ALTER TABLE `tipomovimientoinventario`
  MODIFY `codtipomovimiento` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `codigo_usuario` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `vendedor`
--
ALTER TABLE `vendedor`
  MODIFY `codVendedor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `agendamovimientos`
--
ALTER TABLE `agendamovimientos`
  ADD CONSTRAINT `RefMOVIMIENTOSBANCARIOS71` FOREIGN KEY (`codigo_movimiento`) REFERENCES `movimientosbancarios` (`codigo_movimiento`);

--
-- Filtros para la tabla `almacen`
--
ALTER TABLE `almacen`
  ADD CONSTRAINT `RefEMPRESA114` FOREIGN KEY (`codigo_empresa`) REFERENCES `empresa` (`codigo_empresa`);

--
-- Filtros para la tabla `basededatos`
--
ALTER TABLE `basededatos`
  ADD CONSTRAINT `RefEMPRESA11` FOREIGN KEY (`codigo_empresa`) REFERENCES `empresa` (`codigo_empresa`),
  ADD CONSTRAINT `RefTIPOBD10` FOREIGN KEY (`codigo_tipo_bd`) REFERENCES `tipobd` (`codigo_tipo_bd`);

--
-- Filtros para la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD CONSTRAINT `RefUSUARIO5` FOREIGN KEY (`codigo_usuario`,`codigo_persona`) REFERENCES `usuario` (`codigo_usuario`, `codigo_persona`);

--
-- Filtros para la tabla `boleta`
--
ALTER TABLE `boleta`
  ADD CONSTRAINT `RefCUENTASEXTERNAS116` FOREIGN KEY (`codigo_cuenta_externa`) REFERENCES `cuentasexternas` (`codigo_cuenta_externa`),
  ADD CONSTRAINT `RefCUENTASINTERNAS84` FOREIGN KEY (`codigo_cuenta_interna`) REFERENCES `cuentasinternas` (`codigo_cuenta_interna`),
  ADD CONSTRAINT `RefPRESTAMO48` FOREIGN KEY (`codPrestamo`) REFERENCES `prestamo` (`codPrestamo`),
  ADD CONSTRAINT `RefTALONARIO49` FOREIGN KEY (`codTalonario`) REFERENCES `talonario` (`codTalonario`),
  ADD CONSTRAINT `RefTIPOBOLETA46` FOREIGN KEY (`codTipoBoleta`) REFERENCES `tipoboleta` (`codTipoBoleta`);

--
-- Filtros para la tabla `cheques`
--
ALTER TABLE `cheques`
  ADD CONSTRAINT `RefCONCEPTOSBANCARIOS73` FOREIGN KEY (`codigo_concepto`) REFERENCES `conceptosbancarios` (`codigo_concepto`);

--
-- Filtros para la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD CONSTRAINT `RefCOBRADOR152` FOREIGN KEY (`codCobrador`) REFERENCES `cobrador` (`codCobrador`),
  ADD CONSTRAINT `RefEMPLEADO103` FOREIGN KEY (`cod_empleado`) REFERENCES `empleado` (`cod_empleado`),
  ADD CONSTRAINT `RefMATIPOCLIENTE35` FOREIGN KEY (`icod`) REFERENCES `matipocliente` (`icod`),
  ADD CONSTRAINT `RefVENDEDOR153` FOREIGN KEY (`codVendedor`) REFERENCES `vendedor` (`codVendedor`);

--
-- Filtros para la tabla `comision`
--
ALTER TABLE `comision`
  ADD CONSTRAINT `RefTIPOCOMISION162` FOREIGN KEY (`codComision`) REFERENCES `tipocomision` (`codComision`),
  ADD CONSTRAINT `RefVENDEDOR160` FOREIGN KEY (`codVendedor`) REFERENCES `vendedor` (`codVendedor`);

--
-- Filtros para la tabla `conceptosbancarios`
--
ALTER TABLE `conceptosbancarios`
  ADD CONSTRAINT `RefCLASIFICACIONCONCEPTOSBANCARIOS75` FOREIGN KEY (`codigo_clasificacion`) REFERENCES `clasificacionconceptosbancarios` (`codigo_clasificacion`),
  ADD CONSTRAINT `RefOPERACIONCONTABLE74` FOREIGN KEY (`codigo_operacion`) REFERENCES `operacioncontable` (`codigo_operacion`);

--
-- Filtros para la tabla `cotizacion`
--
ALTER TABLE `cotizacion`
  ADD CONSTRAINT `RefCLIENTE27` FOREIGN KEY (`codVendedor`,`ncodcliente`,`codCobrador`) REFERENCES `cliente` (`ncodcliente`, `codCobrador`, `codVendedor`),
  ADD CONSTRAINT `RefEMPLEADO100` FOREIGN KEY (`cod_empleado`) REFERENCES `empleado` (`cod_empleado`),
  ADD CONSTRAINT `RefVENDEDOR150` FOREIGN KEY (`codVendedor`) REFERENCES `vendedor` (`codVendedor`);

--
-- Filtros para la tabla `cuentascorrientesclientes`
--
ALTER TABLE `cuentascorrientesclientes`
  ADD CONSTRAINT `RefCLIENTE119` FOREIGN KEY (`ncodcliente`,`codVendedor`,`codCobrador`) REFERENCES `cliente` (`ncodcliente`, `codCobrador`, `codVendedor`),
  ADD CONSTRAINT `RefCONCEPTOS126` FOREIGN KEY (`codigo_tipo_transaccion`) REFERENCES `conceptos` (`codigo_tipo_transaccion`),
  ADD CONSTRAINT `RefFACTURA117` FOREIGN KEY (`ncodfactura`,`vserie`,`codVendedor`) REFERENCES `factura` (`ncodfactura`, `vserie`, `codVendedor`),
  ADD CONSTRAINT `RefMORA124` FOREIGN KEY (`codMora`) REFERENCES `mora` (`codMora`),
  ADD CONSTRAINT `relacionclientes_Tipo` FOREIGN KEY (`codtipodocumento`) REFERENCES `tipodocumento` (`codtipodocumento`),
  ADD CONSTRAINT `relacioncuentascorrientesclientes_encabezado` FOREIGN KEY (`codencabezado`) REFERENCES `encabezadodoc` (`codencabezado`);

--
-- Filtros para la tabla `cuentascorrientesempleados`
--
ALTER TABLE `cuentascorrientesempleados`
  ADD CONSTRAINT `RefCONCEPTOS144` FOREIGN KEY (`codigo_tipo_transaccion`) REFERENCES `conceptos` (`codigo_tipo_transaccion`),
  ADD CONSTRAINT `RefMORA147` FOREIGN KEY (`codMora`) REFERENCES `mora` (`codMora`),
  ADD CONSTRAINT `RefTALONARIO146` FOREIGN KEY (`codTalonario`) REFERENCES `talonario` (`codTalonario`),
  ADD CONSTRAINT `relacionempleados_Tipo` FOREIGN KEY (`codtipodocumento`) REFERENCES `tipodocumento` (`codtipodocumento`);

--
-- Filtros para la tabla `cuentascorrientesproveedores`
--
ALTER TABLE `cuentascorrientesproveedores`
  ADD CONSTRAINT `RefCONCEPTOS141` FOREIGN KEY (`codigo_tipo_transaccion`) REFERENCES `conceptos` (`codigo_tipo_transaccion`),
  ADD CONSTRAINT `RefPROVEEDOR140` FOREIGN KEY (`codproveedor`) REFERENCES `proveedor` (`codproveedor`),
  ADD CONSTRAINT `relacioncuentascorrientesprov_encabezado` FOREIGN KEY (`codencabezado`) REFERENCES `encabezadodoc` (`codencabezado`),
  ADD CONSTRAINT `relacionproveedores_Tipo` FOREIGN KEY (`codtipodocumento`) REFERENCES `tipodocumento` (`codtipodocumento`),
  ADD CONSTRAINT `relaciontipofacturaproveedor_cuentascorrientesproveedor` FOREIGN KEY (`codfacturaprov`) REFERENCES `facturaproveedor` (`codfacturaprov`);

--
-- Filtros para la tabla `cuentasexternas`
--
ALTER TABLE `cuentasexternas`
  ADD CONSTRAINT `RefBANCOS104` FOREIGN KEY (`codigo_banco`) REFERENCES `bancos` (`codigo_banco`),
  ADD CONSTRAINT `RefPERSONAS106` FOREIGN KEY (`codigo_persona`) REFERENCES `personas` (`codigo_persona`),
  ADD CONSTRAINT `RefPROVEEDOR130` FOREIGN KEY (`codproveedor`) REFERENCES `proveedor` (`codproveedor`);

--
-- Filtros para la tabla `cuentasinternas`
--
ALTER TABLE `cuentasinternas`
  ADD CONSTRAINT `RefBANCOS68` FOREIGN KEY (`codigo_banco`) REFERENCES `bancos` (`codigo_banco`),
  ADD CONSTRAINT `RefEMPRESA105` FOREIGN KEY (`codigo_empresa`) REFERENCES `empresa` (`codigo_empresa`),
  ADD CONSTRAINT `RefMONEDAS79` FOREIGN KEY (`codigo_moneda`) REFERENCES `monedas` (`codigo_moneda`);

--
-- Filtros para la tabla `detallecotizacion`
--
ALTER TABLE `detallecotizacion`
  ADD CONSTRAINT `RefCOTIZACION28` FOREIGN KEY (`ncodcotizacion`,`vserie`,`codVendedor`) REFERENCES `cotizacion` (`ncodcotizacion`, `vserie`, `codVendedor`),
  ADD CONSTRAINT `RefPRODUCTO29` FOREIGN KEY (`codproducto`) REFERENCES `producto` (`codproducto`);

--
-- Filtros para la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD CONSTRAINT `RefFACTURA24` FOREIGN KEY (`ncodfactura`,`vserie`,`codVendedor`) REFERENCES `factura` (`ncodfactura`, `vserie`, `codVendedor`),
  ADD CONSTRAINT `RefPRODUCTO25` FOREIGN KEY (`codproducto`) REFERENCES `producto` (`codproducto`);

--
-- Filtros para la tabla `detallepedido`
--
ALTER TABLE `detallepedido`
  ADD CONSTRAINT `RefPEDIDO30` FOREIGN KEY (`ncodpedido`,`vserie`,`codVendedor`) REFERENCES `pedido` (`ncodpedido`, `vserie`, `codVendedor`),
  ADD CONSTRAINT `RefPRODUCTO31` FOREIGN KEY (`codproducto`) REFERENCES `producto` (`codproducto`);

--
-- Filtros para la tabla `documento_compra`
--
ALTER TABLE `documento_compra`
  ADD CONSTRAINT `RefENCABEZADO_DOCCOMPRA128` FOREIGN KEY (`codencabezado`) REFERENCES `encabezado_doccompra` (`codencabezado`),
  ADD CONSTRAINT `RefIMPUESTOS18` FOREIGN KEY (`codimpuesto`) REFERENCES `impuestos` (`codimpuesto`),
  ADD CONSTRAINT `RefPRODUCTO43` FOREIGN KEY (`codproducto`) REFERENCES `producto` (`codproducto`),
  ADD CONSTRAINT `RefPROVEEDOR21` FOREIGN KEY (`codproveedor`) REFERENCES `proveedor` (`codproveedor`),
  ADD CONSTRAINT `documentocompra_Tipo` FOREIGN KEY (`codtipodocumento`) REFERENCES `tipodocumento` (`codtipodocumento`);

--
-- Filtros para la tabla `domicilio_fiscal`
--
ALTER TABLE `domicilio_fiscal`
  ADD CONSTRAINT `RefEMPRESA8` FOREIGN KEY (`codigo_empresa`) REFERENCES `empresa` (`codigo_empresa`);

--
-- Filtros para la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD CONSTRAINT `RefPERSONAS107` FOREIGN KEY (`codigo_persona`) REFERENCES `personas` (`codigo_persona`);

--
-- Filtros para la tabla `existencias`
--
ALTER TABLE `existencias`
  ADD CONSTRAINT `RefALMACEN134` FOREIGN KEY (`codalmacen`) REFERENCES `almacen` (`codalmacen`),
  ADD CONSTRAINT `RefPRODUCTO135` FOREIGN KEY (`codproducto`) REFERENCES `producto` (`codproducto`);

--
-- Filtros para la tabla `factura`
--
ALTER TABLE `factura`
  ADD CONSTRAINT `RefCLIENTE23` FOREIGN KEY (`codVendedor`,`ncodcliente`,`codCobrador`) REFERENCES `cliente` (`ncodcliente`, `codCobrador`, `codVendedor`),
  ADD CONSTRAINT `RefEMPLEADO101` FOREIGN KEY (`cod_empleado`) REFERENCES `empleado` (`cod_empleado`),
  ADD CONSTRAINT `RefVENDEDOR149` FOREIGN KEY (`codVendedor`) REFERENCES `vendedor` (`codVendedor`);

--
-- Filtros para la tabla `facturaproveedor`
--
ALTER TABLE `facturaproveedor`
  ADD CONSTRAINT `RefENCABFACT18` FOREIGN KEY (`codencabezado`) REFERENCES `encabezado_doccompra` (`codencabezado`),
  ADD CONSTRAINT `RefIMPUESTOS_fact18` FOREIGN KEY (`codimpuesto`) REFERENCES `impuestos` (`codimpuesto`),
  ADD CONSTRAINT `RefPROVEEDOR_fact21` FOREIGN KEY (`codproveedor`) REFERENCES `proveedor` (`codproveedor`);

--
-- Filtros para la tabla `formas_pago`
--
ALTER TABLE `formas_pago`
  ADD CONSTRAINT `RefTIPOFORMAPAGO76` FOREIGN KEY (`codigo_tipo_forma`) REFERENCES `tipoformapago` (`codigo_tipo_forma`);

--
-- Filtros para la tabla `listaprecios`
--
ALTER TABLE `listaprecios`
  ADD CONSTRAINT `RefLINEA168` FOREIGN KEY (`codlinea`) REFERENCES `linea` (`codlinea`),
  ADD CONSTRAINT `RefMARCA167` FOREIGN KEY (`codmarca`) REFERENCES `marca` (`codmarca`),
  ADD CONSTRAINT `RefMATIPOCLIENTE164` FOREIGN KEY (`icod`) REFERENCES `matipocliente` (`icod`),
  ADD CONSTRAINT `RefPRODUCTO166` FOREIGN KEY (`codproducto`) REFERENCES `producto` (`codproducto`);

--
-- Filtros para la tabla `movimientoinventario`
--
ALTER TABLE `movimientoinventario`
  ADD CONSTRAINT `RefCLIENTE45` FOREIGN KEY (`ncodcliente`,`codCobrador`,`codVendedor`) REFERENCES `cliente` (`ncodcliente`, `codCobrador`, `codVendedor`),
  ADD CONSTRAINT `RefPRODUCTO42` FOREIGN KEY (`codproducto`) REFERENCES `producto` (`codproducto`),
  ADD CONSTRAINT `RefPROVEEDOR20` FOREIGN KEY (`codproveedor`) REFERENCES `proveedor` (`codproveedor`),
  ADD CONSTRAINT `RefTipoMovInv` FOREIGN KEY (`codtipomovimiento`) REFERENCES `tipomovimientoinventario` (`codtipomovimiento`);

--
-- Filtros para la tabla `movimientosbancarios`
--
ALTER TABLE `movimientosbancarios`
  ADD CONSTRAINT `RefCONCEPTOSBANCARIOS69` FOREIGN KEY (`codigo_concepto`) REFERENCES `conceptosbancarios` (`codigo_concepto`),
  ADD CONSTRAINT `RefCUENTASEXTERNAS131` FOREIGN KEY (`codigo_cuenta_externa`) REFERENCES `cuentasexternas` (`codigo_cuenta_externa`),
  ADD CONSTRAINT `RefCUENTASINTERNAS81` FOREIGN KEY (`codigo_cuenta_interna`) REFERENCES `cuentasinternas` (`codigo_cuenta_interna`),
  ADD CONSTRAINT `RefFORMAS_PAGO70` FOREIGN KEY (`codigo_forma`) REFERENCES `formas_pago` (`codigo_forma`),
  ADD CONSTRAINT `RefMONEDAS155` FOREIGN KEY (`codigo_moneda`) REFERENCES `monedas` (`codigo_moneda`);

--
-- Filtros para la tabla `movimientosconciliados`
--
ALTER TABLE `movimientosconciliados`
  ADD CONSTRAINT `RefCONCILIACIONBANCARIA78` FOREIGN KEY (`codigo_conciliacion`) REFERENCES `conciliacionbancaria` (`codigo_conciliacion`),
  ADD CONSTRAINT `RefMOVIMIENTOSBANCARIOS80` FOREIGN KEY (`codigo_movimiento`) REFERENCES `movimientosbancarios` (`codigo_movimiento`);

--
-- Filtros para la tabla `movimientosrepetitivos`
--
ALTER TABLE `movimientosrepetitivos`
  ADD CONSTRAINT `RefAGENDAMOVIMIENTOS72` FOREIGN KEY (`codigo_agenda`) REFERENCES `agendamovimientos` (`codigo_agenda`);

--
-- Filtros para la tabla `parametros`
--
ALTER TABLE `parametros`
  ADD CONSTRAINT `RefEMPRESA12` FOREIGN KEY (`codigo_empresa`) REFERENCES `empresa` (`codigo_empresa`),
  ADD CONSTRAINT `RefSISTEMA9` FOREIGN KEY (`codigo_sistema`) REFERENCES `sistema` (`codigo_sistema`);

--
-- Filtros para la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD CONSTRAINT `RefCLIENTE26` FOREIGN KEY (`codVendedor`,`ncodcliente`,`codCobrador`) REFERENCES `cliente` (`ncodcliente`, `codCobrador`, `codVendedor`),
  ADD CONSTRAINT `RefEMPLEADO99` FOREIGN KEY (`cod_empleado`) REFERENCES `empleado` (`cod_empleado`),
  ADD CONSTRAINT `RefVENDEDOR151` FOREIGN KEY (`codVendedor`) REFERENCES `vendedor` (`codVendedor`);

--
-- Filtros para la tabla `permiso`
--
ALTER TABLE `permiso`
  ADD CONSTRAINT `RefPRIVILEGIOS158` FOREIGN KEY (`codigo_privilegios`) REFERENCES `privilegios` (`codigo_privilegios`);

--
-- Filtros para la tabla `personas`
--
ALTER TABLE `personas`
  ADD CONSTRAINT `RefEMPRESA113` FOREIGN KEY (`codigo_empresa`) REFERENCES `empresa` (`codigo_empresa`);

--
-- Filtros para la tabla `prestamo`
--
ALTER TABLE `prestamo`
  ADD CONSTRAINT `RefEMPLEADO55` FOREIGN KEY (`cod_empleado`) REFERENCES `empleado` (`cod_empleado`);

--
-- Filtros para la tabla `privilegios`
--
ALTER TABLE `privilegios`
  ADD CONSTRAINT `RefFORMULARIO86` FOREIGN KEY (`codFormulario`) REFERENCES `formulario` (`codFormulario`),
  ADD CONSTRAINT `RefROL2` FOREIGN KEY (`codigo_rol`) REFERENCES `rol` (`codigo_rol`);

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `RefLINEA129` FOREIGN KEY (`codlinea`) REFERENCES `linea` (`codlinea`),
  ADD CONSTRAINT `RefMARCA41` FOREIGN KEY (`codmarca`) REFERENCES `marca` (`codmarca`),
  ADD CONSTRAINT `RefPROVEEDOR133` FOREIGN KEY (`codproveedor`) REFERENCES `proveedor` (`codproveedor`);

--
-- Filtros para la tabla `reporte`
--
ALTER TABLE `reporte`
  ADD CONSTRAINT `RefSISTEMA85` FOREIGN KEY (`codigo_sistema`) REFERENCES `sistema` (`codigo_sistema`);

--
-- Filtros para la tabla `talonario`
--
ALTER TABLE `talonario`
  ADD CONSTRAINT `RefPRESTAMO56` FOREIGN KEY (`codPrestamo`) REFERENCES `prestamo` (`codPrestamo`);

--
-- Filtros para la tabla `tipocambiomoneda`
--
ALTER TABLE `tipocambiomoneda`
  ADD CONSTRAINT `RefMONEDAS77` FOREIGN KEY (`codigo_moneda`) REFERENCES `monedas` (`codigo_moneda`);

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `RefEMPLEADO92` FOREIGN KEY (`cod_empleado`) REFERENCES `empleado` (`cod_empleado`),
  ADD CONSTRAINT `RefPERSONAS157` FOREIGN KEY (`codigo_persona`) REFERENCES `personas` (`codigo_persona`),
  ADD CONSTRAINT `RefROL1` FOREIGN KEY (`codigo_rol`) REFERENCES `rol` (`codigo_rol`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
