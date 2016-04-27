--
-- ER/Studio 8.0 SQL Code Generation
-- Company :      Hewlett-Packard
-- Project :      Modelo ER Banco.DM1
-- Author :       Josué Enrique
--
-- Date Created : Tuesday, April 26, 2016 18:44:49
-- Target DBMS : MySQL 5.x
--

-- 
-- TABLE: AGENDAMOVIMIENTOS 
--

CREATE TABLE AGENDAMOVIMIENTOS(
    codigo_movimiento    INT         NOT NULL,
    no_movimientos       INT         NOT NULL,
    periocidad           CHAR(50)    NOT NULL,
    solicitado_por       CHAR(50)    NOT NULL,
    prioridad            CHAR(50)    NOT NULL,
    fecha_inicio         DATE        NOT NULL,
    PRIMARY KEY (codigo_movimiento)
)ENGINE=MYISAM
;



-- 
-- TABLE: ALMACEN 
--

CREATE TABLE ALMACEN(
    codalmacen        CHAR(10)     NOT NULL,
    codigo_empresa    INT          NOT NULL,
    nombre            CHAR(100)    NOT NULL,
    tamaño            CHAR(10)     NOT NULL,
    disponibilidad    CHAR(15)     NOT NULL,
    estado            CHAR(15)     NOT NULL,
    ubicacion         CHAR(70),
    PRIMARY KEY (codalmacen)
)ENGINE=MYISAM
;



-- 
-- TABLE: BANCOS 
--

CREATE TABLE BANCOS(
    codigo_banco     INT             AUTO_INCREMENT,
    nombre           VARCHAR(100)    NOT NULL,
    nombre_cuenta    CHAR(100)       NOT NULL,
    telefono         VARCHAR(20)     NOT NULL,
    sucursal         CHAR(50)        NOT NULL,
    PRIMARY KEY (codigo_banco)
)ENGINE=MYISAM
;



-- 
-- TABLE: BASE_DE_DATOS 
--

CREATE TABLE BASE_DE_DATOS(
    codigo_bd          INT             NOT NULL,
    codigo_empresa     INT             NOT NULL,
    codigo_tipo_bd     INT             NOT NULL,
    nombre_conexion    CHAR(50)        NOT NULL,
    conexion           VARCHAR(100)    NOT NULL,
    driver_name        CHAR(50)        NOT NULL,
    host               CHAR(50)        NOT NULL,
    puerto             INT             NOT NULL,
    ubicación          VARCHAR(100)    NOT NULL,
    user_name          CHAR(50)        NOT NULL,
    user_pw            VARCHAR(100)    NOT NULL,
    nombre_bd          CHAR(50)        NOT NULL,
    PRIMARY KEY (codigo_bd)
)ENGINE=MYISAM
;



-- 
-- TABLE: BITACORA 
--

CREATE TABLE BITACORA(
    codigo_bitacora    INT          NOT NULL,
    codigo_usuario     CHAR(50),
    accion             CHAR(200)    NOT NULL,
    tabla              CHAR(200)    NOT NULL,
    fecha              DATE         NOT NULL,
    hora               TIME         NOT NULL,
    equipo             CHAR(50)     NOT NULL,
    observaciones      CHAR(100)    NOT NULL,
    PRIMARY KEY (codigo_bitacora)
)ENGINE=MYISAM
;



-- 
-- TABLE: BOLETA 
--

CREATE TABLE BOLETA(
    no_boleta                INT     AUTO_INCREMENT,
    fecha                    DATE,
    codTipoBoleta            INT     NOT NULL,
    codPagoProveedor         INT     NOT NULL,
    codPrestamo              INT     NOT NULL,
    codTalonario             INT     NOT NULL,
    codPagoFactura           INT     NOT NULL,
    codigo_cuenta_interna    INT     NOT NULL,
    codigo_cuenta_externa    INT     NOT NULL,
    PRIMARY KEY (no_boleta)
)ENGINE=MYISAM
;



-- 
-- TABLE: CHEQUES 
--

CREATE TABLE CHEQUES(
    codigo_cheque       INT             AUTO_INCREMENT,
    codigo_concepto     INT             NOT NULL,
    fecha_registro      DATE            NOT NULL,
    monto_total         FLOAT(8, 0)     NOT NULL,
    no_cheque           INT             NOT NULL,
    fecha_aplicacion    DATE            NOT NULL,
    referencia_1        VARCHAR(50)     NOT NULL,
    referencia_2        VARCHAR(50),
    observaciones       VARCHAR(100),
    PRIMARY KEY (codigo_cheque)
)ENGINE=MYISAM
;



-- 
-- TABLE: CLASIFICACIONCONCEPTOSBANCARIOS 
--

CREATE TABLE CLASIFICACIONCONCEPTOSBANCARIOS(
    codigo_clasificacion    INT            AUTO_INCREMENT,
    clasificacion           CHAR(50)       NOT NULL,
    descripcion             VARCHAR(50)    NOT NULL,
    PRIMARY KEY (codigo_clasificacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: CLIENTE 
--

CREATE TABLE CLIENTE(
    ncodcliente       DECIMAL(10, 0)    NOT NULL,
    codigo_persona    INT               NOT NULL,
    icod              INT,
    cod_empleado      INT,
    vestado           VARCHAR(20),
    PRIMARY KEY (ncodcliente)
)ENGINE=MYISAM
;



-- 
-- TABLE: COMISION 
--

CREATE TABLE COMISION(
    ncodcomision    INT         NOT NULL,
    icodComision    INT         NOT NULL,
    cod_empleado    INT         NOT NULL,
    vtotalventas    CHAR(10),
    vcomision       CHAR(10),
    PRIMARY KEY (ncodcomision, icodComision, cod_empleado)
)ENGINE=MYISAM
;



-- 
-- TABLE: CONCEPTOSBANCARIOS 
--

CREATE TABLE CONCEPTOSBANCARIOS(
    codigo_concepto         INT            AUTO_INCREMENT,
    concepto                CHAR(50)       NOT NULL,
    descripcion             VARCHAR(50)    NOT NULL,
    codigo_operacion        INT            NOT NULL,
    estado                  CHAR(50)       NOT NULL,
    codigo_clasificacion    INT            NOT NULL,
    PRIMARY KEY (codigo_concepto)
)ENGINE=MYISAM
;



-- 
-- TABLE: CONCILIACIONBANCARIA 
--

CREATE TABLE CONCILIACIONBANCARIA(
    codigo_conciliacion    INT            AUTO_INCREMENT,
    fecha_inicio           DATE           NOT NULL,
    fecha_salida           DATE           NOT NULL,
    total_cargos           FLOAT(8, 0)    NOT NULL,
    total_abonos           FLOAT(8, 0)    NOT NULL,
    monto                  FLOAT(8, 0)    NOT NULL,
    PRIMARY KEY (codigo_conciliacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: COTIZACIÓN 
--

CREATE TABLE COTIZACIÓN(
    ncodcotizacion       DECIMAL(10, 0)    NOT NULL,
    vserie               VARCHAR(10),
    dfechacotizacion     DATE,
    dfechavencimiento    DATE,
    ntotal               DECIMAL(10, 0),
    vestadocotizacion    VARCHAR(20),
    ncodcliente          DECIMAL(10, 0)    NOT NULL,
    cod_empleado         INT,
    PRIMARY KEY (ncodcotizacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: CUENTASEXTERNAS 
--

CREATE TABLE CUENTASEXTERNAS(
    codigo_cuenta_externa    INT            AUTO_INCREMENT,
    codigo_persona           INT            NOT NULL,
    codigo_banco             INT            NOT NULL,
    no_cuenta                VARCHAR(50)    NOT NULL,
    PRIMARY KEY (codigo_cuenta_externa)
)ENGINE=MYISAM
;



-- 
-- TABLE: CUENTASINTERNAS 
--

CREATE TABLE CUENTASINTERNAS(
    codigo_cuenta_interna    INT            AUTO_INCREMENT,
    codigo_empresa           INT            NOT NULL,
    fecha_apertura           DATE           NOT NULL,
    no_cuenta                VARCHAR(50)    NOT NULL,
    codigo_banco             INT            NOT NULL,
    estado                   CHAR(50)       NOT NULL,
    siguiente_cheque         INT,
    dia_corte                INT            NOT NULL,
    codigo_moneda            INT            NOT NULL,
    PRIMARY KEY (codigo_cuenta_interna)
)ENGINE=MYISAM
;



-- 
-- TABLE: DETALLECOTIZACION 
--

CREATE TABLE DETALLECOTIZACION(
    codigo_detalle_cotizacion    INT               AUTO_INCREMENT,
    ncodcotizacion               DECIMAL(10, 0)    NOT NULL,
    codproducto                  DECIMAL(10, 0)    NOT NULL,
    ncantidadcotizada            DECIMAL(10, 0),
    npreciocotizado              DECIMAL(10, 0),
    PRIMARY KEY (codigo_detalle_cotizacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: DETALLEFACTURA 
--

CREATE TABLE DETALLEFACTURA(
    codigo_detalle_factura    INT               AUTO_INCREMENT,
    ncodfactura               DECIMAL(10, 0),
    codproducto               DECIMAL(10, 0),
    ncantidadventa            DECIMAL(10, 0),
    nprecioventa              DECIMAL(10, 0),
    PRIMARY KEY (codigo_detalle_factura)
)ENGINE=MYISAM
;



-- 
-- TABLE: DETALLEPEDIDO 
--

CREATE TABLE DETALLEPEDIDO(
    codigo_detalle_pedido    INT               AUTO_INCREMENT,
    ncodpedido               DECIMAL(10, 0)    NOT NULL,
    codproducto              DECIMAL(10, 0)    NOT NULL,
    ncantidadpedido          DECIMAL(10, 0),
    npreciopedido            DECIMAL(10, 0),
    PRIMARY KEY (codigo_detalle_pedido)
)ENGINE=MYISAM
;



-- 
-- TABLE: DOCUMENTO_COMPRA 
--

CREATE TABLE DOCUMENTO_COMPRA(
    codoc               CHAR(10)          NOT NULL,
    estado              CHAR(10),
    cantidad            INT,
    fecha               DATE,
    descuento           INT,
    codigo_prov         CHAR(10),
    codtipodocumento    CHAR(10),
    codimpuesto         CHAR(10),
    codproveedor        INT               NOT NULL,
    codproducto         DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (codoc)
)ENGINE=MYISAM
;



-- 
-- TABLE: DOMICILIO_FISCAL 
--

CREATE TABLE DOMICILIO_FISCAL(
    codigo_empresa         INT             NOT NULL,
    `calle/avenida`        CHAR(50)        NOT NULL,
    numero                 VARCHAR(25)     NOT NULL,
    colonia                VARCHAR(50)     NOT NULL,
    referencia             VARCHAR(100)    NOT NULL,
    `ciudad/poblacion`     CHAR(50)        NOT NULL,
    `estado/departamento`  CHAR(50)        NOT NULL,
    pais                   CHAR(50)        NOT NULL,
    PRIMARY KEY (codigo_empresa)
)ENGINE=MYISAM
;



-- 
-- TABLE: EMPLEADO 
--

CREATE TABLE EMPLEADO(
    cod_empleado       INT         AUTO_INCREMENT,
    codigo_persona     INT         NOT NULL,
    codTipoVendedor    INT,
    estado             CHAR(30),
    PRIMARY KEY (cod_empleado)
)ENGINE=MYISAM
;



-- 
-- TABLE: EMPRESA 
--

CREATE TABLE EMPRESA(
    codigo_empresa         INT          NOT NULL,
    razon_social           CHAR(100)    NOT NULL,
    direccion              CHAR(100)    NOT NULL,
    `ciudad/poblacion`     CHAR(100)    NOT NULL,
    registro_tributario    CHAR(50)     NOT NULL,
    pais                   CHAR(50)     NOT NULL,
    `estado/departamento`  CHAR(50)     NOT NULL,
    PRIMARY KEY (codigo_empresa)
)ENGINE=MYISAM
;



-- 
-- TABLE: FACTURA 
--

CREATE TABLE FACTURA(
    ncodfactura          DECIMAL(10, 0)    NOT NULL,
    nombre               CHAR(100),
    nit                  CHAR(10),
    vserie               VARCHAR(10),
    dfechafactura        DATE,
    dfechavencimiento    DATE,
    ntotal               DECIMAL(10, 0),
    vestadofactura       VARCHAR(20),
    ncodcliente          DECIMAL(10, 0),
    codTipoFactura       INT,
    cod_empleado         INT,
    PRIMARY KEY (ncodfactura)
)ENGINE=MYISAM
;



-- 
-- TABLE: FORMAS_PAGO 
--

CREATE TABLE FORMAS_PAGO(
    codigo_forma         INT         AUTO_INCREMENT,
    descripcion          CHAR(50)    NOT NULL,
    codigo_tipo_forma    INT         NOT NULL,
    PRIMARY KEY (codigo_forma)
)ENGINE=MYISAM
;



-- 
-- TABLE: FORMULARIO 
--

CREATE TABLE FORMULARIO(
    codFormulario    INT         AUTO_INCREMENT,
    estado           CHAR(10),
    formulario       CHAR(20),
    PRIMARY KEY (codFormulario)
)ENGINE=MYISAM
;



-- 
-- TABLE: IMPUESTOS 
--

CREATE TABLE IMPUESTOS(
    codimpuesto    CHAR(10)          NOT NULL,
    estado         CHAR(10),
    nombre         CHAR(15)          NOT NULL,
    porcentaje     DECIMAL(15, 2)    NOT NULL,
    PRIMARY KEY (codimpuesto)
)ENGINE=MYISAM
;



-- 
-- TABLE: MARCA 
--

CREATE TABLE MARCA(
    codmarca       INT          AUTO_INCREMENT,
    estado         CHAR(10),
    descripcion    CHAR(100),
    PRIMARY KEY (codmarca)
)ENGINE=MYISAM
;



-- 
-- TABLE: MaTipoCliente 
--

CREATE TABLE MaTipoCliente(
    icod            INT            AUTO_INCREMENT,
    vtipo           VARCHAR(10),
    vdescripcion    VARCHAR(18),
    PRIMARY KEY (icod)
)ENGINE=MYISAM
;



-- 
-- TABLE: MONEDAS 
--

CREATE TABLE MONEDAS(
    codigo_moneda     INT            AUTO_INCREMENT,
    nombre            CHAR(50)       NOT NULL,
    abreviatura       VARCHAR(25)    NOT NULL,
    fecha_registro    DATE           NOT NULL,
    PRIMARY KEY (codigo_moneda)
)ENGINE=MYISAM
;



-- 
-- TABLE: MORAFACTURA 
--

CREATE TABLE MORAFACTURA(
    codMora        INT               AUTO_INCREMENT,
    monto          DECIMAL(10, 2),
    mes            CHAR(10),
    ncodfactura    DECIMAL(10, 0)    NOT NULL,
    PRIMARY KEY (codMora)
)ENGINE=MYISAM
;



-- 
-- TABLE: MORAPRESTAMO 
--

CREATE TABLE MORAPRESTAMO(
    codMora        INT               AUTO_INCREMENT,
    monto          DECIMAL(10, 2),
    mes            CHAR(10),
    codPrestamo    INT               NOT NULL,
    PRIMARY KEY (codMora)
)ENGINE=MYISAM
;



-- 
-- TABLE: MOVIMIENTOINVENTARIO 
--

CREATE TABLE MOVIMIENTOINVENTARIO(
    codmov               CHAR(10)          NOT NULL,
    estado               CHAR(10),
    descripcion          CHAR(100),
    concepto             CHAR(10),
    costo                DECIMAL(10, 0),
    fecha                DATE,
    codigo_prov          CHAR(10),
    codtipomovimiento    CHAR(10),
    codproveedor         INT               NOT NULL,
    codproducto          DECIMAL(10, 0)    NOT NULL,
    ncodcliente          DECIMAL(10, 0),
    PRIMARY KEY (codmov)
)ENGINE=MYISAM
;



-- 
-- TABLE: MOVIMIENTOSBANCARIOS 
--

CREATE TABLE MOVIMIENTOSBANCARIOS(
    codigo_movimiento        INT             AUTO_INCREMENT,
    codigo_cuenta_interna    INT             NOT NULL,
    codigo_concepto          INT             NOT NULL,
    codigo_forma             INT             NOT NULL,
    fecha_registro           DATE            NOT NULL,
    fecha_aplicacion         DATE            NOT NULL,
    referencia_1             VARCHAR(50)     NOT NULL,
    referencia_2             VARCHAR(50),
    monto_total              FLOAT(8, 0)     NOT NULL,
    observaciones            VARCHAR(100),
    PRIMARY KEY (codigo_movimiento)
)ENGINE=MYISAM
;



-- 
-- TABLE: MOVIMIENTOSCONCILIADOS 
--

CREATE TABLE MOVIMIENTOSCONCILIADOS(
    codigo_conciliacion    INT       NOT NULL,
    codigo_movimiento      INT       NOT NULL,
    estado_conciliacion    CHAR(50),
    PRIMARY KEY (codigo_conciliacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: MOVIMIENTOSREPETITIVOS 
--

CREATE TABLE MOVIMIENTOSREPETITIVOS(
    codigo_movimiento    INT     NOT NULL,
    no_movimiento        INT     ,
    fecha                DATE    NOT NULL,
    PRIMARY KEY (codigo_movimiento)
)ENGINE=MYISAM
;



-- 
-- TABLE: OPERACIONCONTABLE 
--

CREATE TABLE OPERACIONCONTABLE(
    codigo_operacion    INT         AUTO_INCREMENT,
    operacion           CHAR(50)    NOT NULL,
    PRIMARY KEY (codigo_operacion)
)ENGINE=MYISAM
;



-- 
-- TABLE: PAGOFACTURA 
--

CREATE TABLE PAGOFACTURA(
    codPagoFactura    INT               AUTO_INCREMENT,
    fecha             DATE,
    monto             DECIMAL(10, 2),
    codMora           INT               NOT NULL,
    ncodfactura       DECIMAL(10, 0)    NOT NULL,
    ncodcliente       DECIMAL(10, 0)    NOT NULL,
    codigo_forma      INT               NOT NULL,
    PRIMARY KEY (codPagoFactura)
)ENGINE=MYISAM
;



-- 
-- TABLE: PAGOPROVEEDOR 
--

CREATE TABLE PAGOPROVEEDOR(
    codPagoProveedor    INT               AUTO_INCREMENT,
    fecha               DATE,
    monto               DECIMAL(10, 2),
    saldo               DECIMAL(10, 2),
    codproveedor        INT               NOT NULL,
    codigo_forma        INT               NOT NULL,
    ncodfactura         DECIMAL(10, 0),
    PRIMARY KEY (codPagoProveedor)
)ENGINE=MYISAM
;



-- 
-- TABLE: PARAMETROS 
--

CREATE TABLE PARAMETROS(
    codigo_parametro    INT             NOT NULL,
    codigo_empresa      INT             NOT NULL,
    codigo_sistema      INT             NOT NULL,
    nombre              VARCHAR(100)    NOT NULL,
    valor               VARCHAR(100)    NOT NULL,
    PRIMARY KEY (codigo_parametro)
)ENGINE=MYISAM
;



-- 
-- TABLE: PEDIDO 
--

CREATE TABLE PEDIDO(
    ncodpedido           DECIMAL(10, 0)    NOT NULL,
    vserie               VARCHAR(10),
    dfechapedido         DATE,
    dfechavencimiento    DATE,
    ntotal               DECIMAL(10, 0),
    vestadopedido        VARCHAR(20),
    ncodcliente          DECIMAL(10, 0)    NOT NULL,
    cod_empleado         INT               NOT NULL,
    PRIMARY KEY (ncodpedido)
)ENGINE=MYISAM
;



-- 
-- TABLE: PERSONAS 
--

CREATE TABLE PERSONAS(
    codigo_persona     INT             AUTO_INCREMENT,
    codigo_empresa     INT             NOT NULL,
    dpi                CHAR(50)        NOT NULL,
    nombres            VARCHAR(50)     NOT NULL,
    apellidos          VARCHAR(50)     NOT NULL,
    sexo               VARCHAR(50)     NOT NULL,
    fechaNacimiento    DATE            NOT NULL,
    direccion          VARCHAR(100)    NOT NULL,
    telefono           VARCHAR(50)     NOT NULL,
    nit                CHAR(50)        NOT NULL,
    correo             VARCHAR(50)     NOT NULL,
    estado             CHAR(50)        NOT NULL,
    PRIMARY KEY (codigo_persona)
)ENGINE=MYISAM
;



-- 
-- TABLE: PRESTAMO 
--

CREATE TABLE PRESTAMO(
    codPrestamo     INT               AUTO_INCREMENT,
    fecha           DATE,
    total           DECIMAL(10, 2),
    nombre          CHAR(50),
    cod_empleado    INT               NOT NULL,
    PRIMARY KEY (codPrestamo)
)ENGINE=MYISAM
;



-- 
-- TABLE: PRIVILEGIOS 
--

CREATE TABLE PRIVILEGIOS(
    codigo_privilegios    INT         NOT NULL,
    estado                CHAR(10),
    permiso               CHAR(20),
    codigo_rol            INT         NOT NULL,
    codFormulario         INT         NOT NULL,
    PRIMARY KEY (codigo_privilegios)
)ENGINE=MYISAM
;



-- 
-- TABLE: PRODUCTO 
--

CREATE TABLE PRODUCTO(
    codproducto        DECIMAL(10, 0)    NOT NULL,
    estado             CHAR(10),
    ncosto             DECIMAL(10, 0),
    vnombreproducto    VARCHAR(50),
    vdescripcion       VARCHAR(50),
    ncantidad          DECIMAL(10, 0),
    nprecio            DECIMAL(10, 0),
    existencia         INT,
    codtipoproducto    DECIMAL(10, 0),
    icod               INT               NOT NULL,
    codalmacen         CHAR(10)          NOT NULL,
    codmarca           INT               NOT NULL,
    PRIMARY KEY (codproducto)
)ENGINE=MYISAM
;



-- 
-- TABLE: PROVEEDOR 
--

CREATE TABLE PROVEEDOR(
    codproveedor      INT         AUTO_INCREMENT,
    codigo_persona    INT         NOT NULL,
    estado            CHAR(10),
    PRIMARY KEY (codproveedor)
)ENGINE=MYISAM
;



-- 
-- TABLE: REPORTE 
--

CREATE TABLE REPORTE(
    ncodreporte       INT             AUTO_INCREMENT,
    codigo_sistema    INT             NOT NULL,
    nombre_reporte    VARCHAR(50)     NOT NULL,
    directorio        VARCHAR(100)    NOT NULL,
    fecha             DATE            NOT NULL,
    PRIMARY KEY (ncodreporte)
)ENGINE=MYISAM
;



-- 
-- TABLE: ROL 
--

CREATE TABLE ROL(
    codigo_rol     INT          NOT NULL,
    estado         CHAR(10),
    tipo           CHAR(100),
    descripcion    CHAR(20),
    PRIMARY KEY (codigo_rol)
)ENGINE=MYISAM
;



-- 
-- TABLE: SISTEMA 
--

CREATE TABLE SISTEMA(
    codigo_sistema    INT         NOT NULL,
    sistema           CHAR(50)    NOT NULL,
    descripcion       CHAR(50)    NOT NULL,
    PRIMARY KEY (codigo_sistema)
)ENGINE=MYISAM
;



-- 
-- TABLE: TALONARIO 
--

CREATE TABLE TALONARIO(
    codTalonario    INT               AUTO_INCREMENT,
    monto           DECIMAL(10, 2),
    fechaPago       DATE,
    interes         DECIMAL(10, 0),
    codPrestamo     INT               NOT NULL,
    codMora         INT               NOT NULL,
    PRIMARY KEY (codTalonario)
)ENGINE=MYISAM
;



-- 
-- TABLE: TIPOBD 
--

CREATE TABLE TIPOBD(
    codigo_tipo_bd    INT         NOT NULL,
    tipo              CHAR(50)    NOT NULL,
    descripcion       CHAR(50)    NOT NULL,
    PRIMARY KEY (codigo_tipo_bd)
)ENGINE=MYISAM
;



-- 
-- TABLE: TIPOBOLETA 
--

CREATE TABLE TIPOBOLETA(
    codTipoBoleta    INT         AUTO_INCREMENT,
    nombre           CHAR(50),
    PRIMARY KEY (codTipoBoleta)
)ENGINE=MYISAM
;



-- 
-- TABLE: TIPOCAMBIOMONEDA 
--

CREATE TABLE TIPOCAMBIOMONEDA(
    codigo_tipo_cambio    INT            AUTO_INCREMENT,
    codigo_moneda         INT            NOT NULL,
    tipo_cambio           FLOAT(8, 0)    NOT NULL,
    fecha_registro        DATE,
    PRIMARY KEY (codigo_tipo_cambio)
)ENGINE=MYISAM
;



-- 
-- TABLE: TIPOCOMISION 
--

CREATE TABLE TIPOCOMISION(
    icodComision     INT             AUTO_INCREMENT,
    vtipoComision    VARCHAR(100),
    vdescripcion     VARCHAR(100),
    PRIMARY KEY (icodComision)
)ENGINE=MYISAM
;



-- 
-- TABLE: TIPODOCUMENTO 
--

CREATE TABLE TIPODOCUMENTO(
    codtipodocumento    CHAR(10)     NOT NULL,
    estado              CHAR(10),
    descripcion         CHAR(200),
    PRIMARY KEY (codtipodocumento)
)ENGINE=MYISAM
;



-- 
-- TABLE: TIPOFACTURA 
--

CREATE TABLE TIPOFACTURA(
    codTipoFactura    INT          AUTO_INCREMENT,
    tipo              CHAR(40),
    descripcion       CHAR(100),
    estado            CHAR(30),
    PRIMARY KEY (codTipoFactura)
)ENGINE=MYISAM
;



-- 
-- TABLE: TIPOFORMAPAGO 
--

CREATE TABLE TIPOFORMAPAGO(
    codigo_tipo_forma    INT         AUTO_INCREMENT,
    tipo_forma           CHAR(50)    NOT NULL,
    PRIMARY KEY (codigo_tipo_forma)
)ENGINE=MYISAM
;



-- 
-- TABLE: TIPOMOVIMIENTOINVENTARIO 
--

CREATE TABLE TIPOMOVIMIENTOINVENTARIO(
    codtipomovimiento    CHAR(10)    NOT NULL,
    estado               CHAR(10),
    descripcion          CHAR(70)    NOT NULL,
    movimiento           CHAR(20)    NOT NULL,
    PRIMARY KEY (codtipomovimiento)
)ENGINE=MYISAM
;



-- 
-- TABLE: TIPOPRODUCTO 
--

CREATE TABLE TIPOPRODUCTO(
    codtipoproducto    DECIMAL(10, 0)    NOT NULL,
    estado             CHAR(10),
    descripcion        CHAR(30),
    PRIMARY KEY (codtipoproducto)
)ENGINE=MYISAM
;



-- 
-- TABLE: TIPOVENDEDOR 
--

CREATE TABLE TIPOVENDEDOR(
    codTipoVendedor    INT         AUTO_INCREMENT,
    tipo               CHAR(40),
    descripcion        CHAR(50),
    estado             CHAR(30),
    PRIMARY KEY (codTipoVendedor)
)ENGINE=MYISAM
;



-- 
-- TABLE: USUARIO 
--

CREATE TABLE USUARIO(
    codigo_usuario      CHAR(50)     NOT NULL,
    nombre_usuario      CHAR(100),
    password_usuario    CHAR(100),
    codigo_rol          INT          NOT NULL,
    estado              CHAR(50)     NOT NULL,
    cod_empleado        INT          NOT NULL,
    PRIMARY KEY (codigo_usuario)
)ENGINE=MYISAM
;



-- 
-- TABLE: AGENDAMOVIMIENTOS 
--

ALTER TABLE AGENDAMOVIMIENTOS ADD CONSTRAINT RefMOVIMIENTOSBANCARIOS71 
    FOREIGN KEY (codigo_movimiento)
    REFERENCES MOVIMIENTOSBANCARIOS(codigo_movimiento)
;


-- 
-- TABLE: ALMACEN 
--

ALTER TABLE ALMACEN ADD CONSTRAINT RefEMPRESA114 
    FOREIGN KEY (codigo_empresa)
    REFERENCES EMPRESA(codigo_empresa)
;


-- 
-- TABLE: BASE_DE_DATOS 
--

ALTER TABLE BASE_DE_DATOS ADD CONSTRAINT RefTIPOBD10 
    FOREIGN KEY (codigo_tipo_bd)
    REFERENCES TIPOBD(codigo_tipo_bd)
;

ALTER TABLE BASE_DE_DATOS ADD CONSTRAINT RefEMPRESA11 
    FOREIGN KEY (codigo_empresa)
    REFERENCES EMPRESA(codigo_empresa)
;


-- 
-- TABLE: BITACORA 
--

ALTER TABLE BITACORA ADD CONSTRAINT RefUSUARIO5 
    FOREIGN KEY (codigo_usuario)
    REFERENCES USUARIO(codigo_usuario)
;


-- 
-- TABLE: BOLETA 
--

ALTER TABLE BOLETA ADD CONSTRAINT RefTIPOBOLETA46 
    FOREIGN KEY (codTipoBoleta)
    REFERENCES TIPOBOLETA(codTipoBoleta)
;

ALTER TABLE BOLETA ADD CONSTRAINT RefPAGOPROVEEDOR47 
    FOREIGN KEY (codPagoProveedor)
    REFERENCES PAGOPROVEEDOR(codPagoProveedor)
;

ALTER TABLE BOLETA ADD CONSTRAINT RefPRESTAMO48 
    FOREIGN KEY (codPrestamo)
    REFERENCES PRESTAMO(codPrestamo)
;

ALTER TABLE BOLETA ADD CONSTRAINT RefTALONARIO49 
    FOREIGN KEY (codTalonario)
    REFERENCES TALONARIO(codTalonario)
;

ALTER TABLE BOLETA ADD CONSTRAINT RefPAGOFACTURA50 
    FOREIGN KEY (codPagoFactura)
    REFERENCES PAGOFACTURA(codPagoFactura)
;

ALTER TABLE BOLETA ADD CONSTRAINT RefCUENTASINTERNAS84 
    FOREIGN KEY (codigo_cuenta_interna)
    REFERENCES CUENTASINTERNAS(codigo_cuenta_interna)
;

ALTER TABLE BOLETA ADD CONSTRAINT RefCUENTASEXTERNAS116 
    FOREIGN KEY (codigo_cuenta_externa)
    REFERENCES CUENTASEXTERNAS(codigo_cuenta_externa)
;


-- 
-- TABLE: CHEQUES 
--

ALTER TABLE CHEQUES ADD CONSTRAINT RefCONCEPTOSBANCARIOS73 
    FOREIGN KEY (codigo_concepto)
    REFERENCES CONCEPTOSBANCARIOS(codigo_concepto)
;


-- 
-- TABLE: CLIENTE 
--

ALTER TABLE CLIENTE ADD CONSTRAINT RefMaTipoCliente35 
    FOREIGN KEY (icod)
    REFERENCES MaTipoCliente(icod)
;

ALTER TABLE CLIENTE ADD CONSTRAINT RefEMPLEADO103 
    FOREIGN KEY (cod_empleado)
    REFERENCES EMPLEADO(cod_empleado)
;

ALTER TABLE CLIENTE ADD CONSTRAINT RefPERSONAS108 
    FOREIGN KEY (codigo_persona)
    REFERENCES PERSONAS(codigo_persona)
;


-- 
-- TABLE: COMISION 
--

ALTER TABLE COMISION ADD CONSTRAINT RefTIPOCOMISION95 
    FOREIGN KEY (icodComision)
    REFERENCES TIPOCOMISION(icodComision)
;

ALTER TABLE COMISION ADD CONSTRAINT RefEMPLEADO102 
    FOREIGN KEY (cod_empleado)
    REFERENCES EMPLEADO(cod_empleado)
;


-- 
-- TABLE: CONCEPTOSBANCARIOS 
--

ALTER TABLE CONCEPTOSBANCARIOS ADD CONSTRAINT RefOPERACIONCONTABLE74 
    FOREIGN KEY (codigo_operacion)
    REFERENCES OPERACIONCONTABLE(codigo_operacion)
;

ALTER TABLE CONCEPTOSBANCARIOS ADD CONSTRAINT RefCLASIFICACIONCONCEPTOSBANCARIOS75 
    FOREIGN KEY (codigo_clasificacion)
    REFERENCES CLASIFICACIONCONCEPTOSBANCARIOS(codigo_clasificacion)
;


-- 
-- TABLE: COTIZACIÓN 
--

ALTER TABLE COTIZACIÓN ADD CONSTRAINT RefCLIENTE27 
    FOREIGN KEY (ncodcliente)
    REFERENCES CLIENTE(ncodcliente)
;

ALTER TABLE COTIZACIÓN ADD CONSTRAINT RefEMPLEADO100 
    FOREIGN KEY (cod_empleado)
    REFERENCES EMPLEADO(cod_empleado)
;


-- 
-- TABLE: CUENTASEXTERNAS 
--

ALTER TABLE CUENTASEXTERNAS ADD CONSTRAINT RefBANCOS104 
    FOREIGN KEY (codigo_banco)
    REFERENCES BANCOS(codigo_banco)
;

ALTER TABLE CUENTASEXTERNAS ADD CONSTRAINT RefPERSONAS106 
    FOREIGN KEY (codigo_persona)
    REFERENCES PERSONAS(codigo_persona)
;


-- 
-- TABLE: CUENTASINTERNAS 
--

ALTER TABLE CUENTASINTERNAS ADD CONSTRAINT RefBANCOS68 
    FOREIGN KEY (codigo_banco)
    REFERENCES BANCOS(codigo_banco)
;

ALTER TABLE CUENTASINTERNAS ADD CONSTRAINT RefMONEDAS79 
    FOREIGN KEY (codigo_moneda)
    REFERENCES MONEDAS(codigo_moneda)
;

ALTER TABLE CUENTASINTERNAS ADD CONSTRAINT RefEMPRESA105 
    FOREIGN KEY (codigo_empresa)
    REFERENCES EMPRESA(codigo_empresa)
;


-- 
-- TABLE: DETALLECOTIZACION 
--

ALTER TABLE DETALLECOTIZACION ADD CONSTRAINT RefCOTIZACIÓN28 
    FOREIGN KEY (ncodcotizacion)
    REFERENCES COTIZACIÓN(ncodcotizacion)
;

ALTER TABLE DETALLECOTIZACION ADD CONSTRAINT RefPRODUCTO29 
    FOREIGN KEY (codproducto)
    REFERENCES PRODUCTO(codproducto)
;


-- 
-- TABLE: DETALLEFACTURA 
--

ALTER TABLE DETALLEFACTURA ADD CONSTRAINT RefFACTURA24 
    FOREIGN KEY (ncodfactura)
    REFERENCES FACTURA(ncodfactura)
;

ALTER TABLE DETALLEFACTURA ADD CONSTRAINT RefPRODUCTO25 
    FOREIGN KEY (codproducto)
    REFERENCES PRODUCTO(codproducto)
;


-- 
-- TABLE: DETALLEPEDIDO 
--

ALTER TABLE DETALLEPEDIDO ADD CONSTRAINT RefPEDIDO30 
    FOREIGN KEY (ncodpedido)
    REFERENCES PEDIDO(ncodpedido)
;

ALTER TABLE DETALLEPEDIDO ADD CONSTRAINT RefPRODUCTO31 
    FOREIGN KEY (codproducto)
    REFERENCES PRODUCTO(codproducto)
;


-- 
-- TABLE: DOCUMENTO_COMPRA 
--

ALTER TABLE DOCUMENTO_COMPRA ADD CONSTRAINT RefPROVEEDOR21 
    FOREIGN KEY (codproveedor)
    REFERENCES PROVEEDOR(codproveedor)
;

ALTER TABLE DOCUMENTO_COMPRA ADD CONSTRAINT RefPRODUCTO43 
    FOREIGN KEY (codproducto)
    REFERENCES PRODUCTO(codproducto)
;

ALTER TABLE DOCUMENTO_COMPRA ADD CONSTRAINT RefTIPODOCUMENTO17 
    FOREIGN KEY (codtipodocumento)
    REFERENCES TIPODOCUMENTO(codtipodocumento)
;

ALTER TABLE DOCUMENTO_COMPRA ADD CONSTRAINT RefIMPUESTOS18 
    FOREIGN KEY (codimpuesto)
    REFERENCES IMPUESTOS(codimpuesto)
;


-- 
-- TABLE: DOMICILIO_FISCAL 
--

ALTER TABLE DOMICILIO_FISCAL ADD CONSTRAINT RefEMPRESA8 
    FOREIGN KEY (codigo_empresa)
    REFERENCES EMPRESA(codigo_empresa)
;


-- 
-- TABLE: EMPLEADO 
--

ALTER TABLE EMPLEADO ADD CONSTRAINT RefTIPOVENDEDOR98 
    FOREIGN KEY (codTipoVendedor)
    REFERENCES TIPOVENDEDOR(codTipoVendedor)
;

ALTER TABLE EMPLEADO ADD CONSTRAINT RefPERSONAS107 
    FOREIGN KEY (codigo_persona)
    REFERENCES PERSONAS(codigo_persona)
;


-- 
-- TABLE: FACTURA 
--

ALTER TABLE FACTURA ADD CONSTRAINT RefCLIENTE23 
    FOREIGN KEY (ncodcliente)
    REFERENCES CLIENTE(ncodcliente)
;

ALTER TABLE FACTURA ADD CONSTRAINT RefTIPOFACTURA96 
    FOREIGN KEY (codTipoFactura)
    REFERENCES TIPOFACTURA(codTipoFactura)
;

ALTER TABLE FACTURA ADD CONSTRAINT RefEMPLEADO101 
    FOREIGN KEY (cod_empleado)
    REFERENCES EMPLEADO(cod_empleado)
;


-- 
-- TABLE: FORMAS_PAGO 
--

ALTER TABLE FORMAS_PAGO ADD CONSTRAINT RefTIPOFORMAPAGO76 
    FOREIGN KEY (codigo_tipo_forma)
    REFERENCES TIPOFORMAPAGO(codigo_tipo_forma)
;


-- 
-- TABLE: MORAFACTURA 
--

ALTER TABLE MORAFACTURA ADD CONSTRAINT RefFACTURA64 
    FOREIGN KEY (ncodfactura)
    REFERENCES FACTURA(ncodfactura)
;


-- 
-- TABLE: MORAPRESTAMO 
--

ALTER TABLE MORAPRESTAMO ADD CONSTRAINT RefPRESTAMO57 
    FOREIGN KEY (codPrestamo)
    REFERENCES PRESTAMO(codPrestamo)
;


-- 
-- TABLE: MOVIMIENTOINVENTARIO 
--

ALTER TABLE MOVIMIENTOINVENTARIO ADD CONSTRAINT RefPRODUCTO42 
    FOREIGN KEY (codproducto)
    REFERENCES PRODUCTO(codproducto)
;

ALTER TABLE MOVIMIENTOINVENTARIO ADD CONSTRAINT RefCLIENTE45 
    FOREIGN KEY (ncodcliente)
    REFERENCES CLIENTE(ncodcliente)
;

ALTER TABLE MOVIMIENTOINVENTARIO ADD CONSTRAINT RefTIPOMOVIMIENTOINVENTARIO19 
    FOREIGN KEY (codtipomovimiento)
    REFERENCES TIPOMOVIMIENTOINVENTARIO(codtipomovimiento)
;

ALTER TABLE MOVIMIENTOINVENTARIO ADD CONSTRAINT RefPROVEEDOR20 
    FOREIGN KEY (codproveedor)
    REFERENCES PROVEEDOR(codproveedor)
;


-- 
-- TABLE: MOVIMIENTOSBANCARIOS 
--

ALTER TABLE MOVIMIENTOSBANCARIOS ADD CONSTRAINT RefCONCEPTOSBANCARIOS69 
    FOREIGN KEY (codigo_concepto)
    REFERENCES CONCEPTOSBANCARIOS(codigo_concepto)
;

ALTER TABLE MOVIMIENTOSBANCARIOS ADD CONSTRAINT RefFORMAS_PAGO70 
    FOREIGN KEY (codigo_forma)
    REFERENCES FORMAS_PAGO(codigo_forma)
;

ALTER TABLE MOVIMIENTOSBANCARIOS ADD CONSTRAINT RefCUENTASINTERNAS81 
    FOREIGN KEY (codigo_cuenta_interna)
    REFERENCES CUENTASINTERNAS(codigo_cuenta_interna)
;


-- 
-- TABLE: MOVIMIENTOSCONCILIADOS 
--

ALTER TABLE MOVIMIENTOSCONCILIADOS ADD CONSTRAINT RefCONCILIACIONBANCARIA78 
    FOREIGN KEY (codigo_conciliacion)
    REFERENCES CONCILIACIONBANCARIA(codigo_conciliacion)
;

ALTER TABLE MOVIMIENTOSCONCILIADOS ADD CONSTRAINT RefMOVIMIENTOSBANCARIOS80 
    FOREIGN KEY (codigo_movimiento)
    REFERENCES MOVIMIENTOSBANCARIOS(codigo_movimiento)
;


-- 
-- TABLE: MOVIMIENTOSREPETITIVOS 
--

ALTER TABLE MOVIMIENTOSREPETITIVOS ADD CONSTRAINT RefAGENDAMOVIMIENTOS72 
    FOREIGN KEY (codigo_movimiento)
    REFERENCES AGENDAMOVIMIENTOS(codigo_movimiento)
;


-- 
-- TABLE: PAGOFACTURA 
--

ALTER TABLE PAGOFACTURA ADD CONSTRAINT RefMORAFACTURA52 
    FOREIGN KEY (codMora)
    REFERENCES MORAFACTURA(codMora)
;

ALTER TABLE PAGOFACTURA ADD CONSTRAINT RefFACTURA65 
    FOREIGN KEY (ncodfactura)
    REFERENCES FACTURA(ncodfactura)
;

ALTER TABLE PAGOFACTURA ADD CONSTRAINT RefCLIENTE67 
    FOREIGN KEY (ncodcliente)
    REFERENCES CLIENTE(ncodcliente)
;

ALTER TABLE PAGOFACTURA ADD CONSTRAINT RefFORMAS_PAGO82 
    FOREIGN KEY (codigo_forma)
    REFERENCES FORMAS_PAGO(codigo_forma)
;


-- 
-- TABLE: PAGOPROVEEDOR 
--

ALTER TABLE PAGOPROVEEDOR ADD CONSTRAINT RefPROVEEDOR66 
    FOREIGN KEY (codproveedor)
    REFERENCES PROVEEDOR(codproveedor)
;

ALTER TABLE PAGOPROVEEDOR ADD CONSTRAINT RefFORMAS_PAGO83 
    FOREIGN KEY (codigo_forma)
    REFERENCES FORMAS_PAGO(codigo_forma)
;

ALTER TABLE PAGOPROVEEDOR ADD CONSTRAINT RefFACTURA97 
    FOREIGN KEY (ncodfactura)
    REFERENCES FACTURA(ncodfactura)
;


-- 
-- TABLE: PARAMETROS 
--

ALTER TABLE PARAMETROS ADD CONSTRAINT RefSISTEMA9 
    FOREIGN KEY (codigo_sistema)
    REFERENCES SISTEMA(codigo_sistema)
;

ALTER TABLE PARAMETROS ADD CONSTRAINT RefEMPRESA12 
    FOREIGN KEY (codigo_empresa)
    REFERENCES EMPRESA(codigo_empresa)
;


-- 
-- TABLE: PEDIDO 
--

ALTER TABLE PEDIDO ADD CONSTRAINT RefCLIENTE26 
    FOREIGN KEY (ncodcliente)
    REFERENCES CLIENTE(ncodcliente)
;

ALTER TABLE PEDIDO ADD CONSTRAINT RefEMPLEADO99 
    FOREIGN KEY (cod_empleado)
    REFERENCES EMPLEADO(cod_empleado)
;


-- 
-- TABLE: PERSONAS 
--

ALTER TABLE PERSONAS ADD CONSTRAINT RefEMPRESA113 
    FOREIGN KEY (codigo_empresa)
    REFERENCES EMPRESA(codigo_empresa)
;


-- 
-- TABLE: PRESTAMO 
--

ALTER TABLE PRESTAMO ADD CONSTRAINT RefEMPLEADO55 
    FOREIGN KEY (cod_empleado)
    REFERENCES EMPLEADO(cod_empleado)
;


-- 
-- TABLE: PRIVILEGIOS 
--

ALTER TABLE PRIVILEGIOS ADD CONSTRAINT RefFORMULARIO86 
    FOREIGN KEY (codFormulario)
    REFERENCES FORMULARIO(codFormulario)
;

ALTER TABLE PRIVILEGIOS ADD CONSTRAINT RefROL2 
    FOREIGN KEY (codigo_rol)
    REFERENCES ROL(codigo_rol)
;


-- 
-- TABLE: PRODUCTO 
--

ALTER TABLE PRODUCTO ADD CONSTRAINT RefTIPOPRODUCTO22 
    FOREIGN KEY (codtipoproducto)
    REFERENCES TIPOPRODUCTO(codtipoproducto)
;

ALTER TABLE PRODUCTO ADD CONSTRAINT RefMaTipoCliente37 
    FOREIGN KEY (icod)
    REFERENCES MaTipoCliente(icod)
;

ALTER TABLE PRODUCTO ADD CONSTRAINT RefALMACEN40 
    FOREIGN KEY (codalmacen)
    REFERENCES ALMACEN(codalmacen)
;

ALTER TABLE PRODUCTO ADD CONSTRAINT RefMARCA41 
    FOREIGN KEY (codmarca)
    REFERENCES MARCA(codmarca)
;


-- 
-- TABLE: PROVEEDOR 
--

ALTER TABLE PROVEEDOR ADD CONSTRAINT RefPERSONAS109 
    FOREIGN KEY (codigo_persona)
    REFERENCES PERSONAS(codigo_persona)
;


-- 
-- TABLE: REPORTE 
--

ALTER TABLE REPORTE ADD CONSTRAINT RefSISTEMA85 
    FOREIGN KEY (codigo_sistema)
    REFERENCES SISTEMA(codigo_sistema)
;


-- 
-- TABLE: TALONARIO 
--

ALTER TABLE TALONARIO ADD CONSTRAINT RefPRESTAMO56 
    FOREIGN KEY (codPrestamo)
    REFERENCES PRESTAMO(codPrestamo)
;

ALTER TABLE TALONARIO ADD CONSTRAINT RefMORAPRESTAMO58 
    FOREIGN KEY (codMora)
    REFERENCES MORAPRESTAMO(codMora)
;


-- 
-- TABLE: TIPOCAMBIOMONEDA 
--

ALTER TABLE TIPOCAMBIOMONEDA ADD CONSTRAINT RefMONEDAS77 
    FOREIGN KEY (codigo_moneda)
    REFERENCES MONEDAS(codigo_moneda)
;


-- 
-- TABLE: USUARIO 
--

ALTER TABLE USUARIO ADD CONSTRAINT RefEMPLEADO92 
    FOREIGN KEY (cod_empleado)
    REFERENCES EMPLEADO(cod_empleado)
;

ALTER TABLE USUARIO ADD CONSTRAINT RefROL1 
    FOREIGN KEY (codigo_rol)
    REFERENCES ROL(codigo_rol)
;


