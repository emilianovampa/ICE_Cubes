USE GD1C2019
GO

-- Verifico si existe el schema, si no existe lo creo

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'ICE_CUBES')
	BEGIN
		EXEC sys.sp_executesql N'CREATE SCHEMA [ICE_CUBES] AUTHORIZATION [gdCruceros2019]'
		--PRINT 'Schema correctamente creado'
	END
GO

IF(OBJECT_ID('SP_crear_tablas') IS NOT NULL)
	DROP PROCEDURE SP_crear_tablas
GO
IF(OBJECT_ID('SP_CREAR_FUNCIONALIDAD') IS NOT NULL)
	DROP PROCEDURE SP_CREAR_FUNCIONALIDAD
GO


IF(OBJECT_ID('SP_CREAR_ROLES') IS NOT NULL)
	DROP PROCEDURE SP_CREAR_ROLES
GO
 
 IF(OBJECT_ID('SP_MIGRAR_CLIENTES') IS NOT NULL)
	DROP PROCEDURE SP_MIGRAR_CLIENTES
GO

 IF(OBJECT_ID('SP_CREACION') IS NOT NULL)
	DROP PROCEDURE SP_CREACION
GO


CREATE PROCEDURE SP_CREAR_TABLAS
AS
/************************** INI-BORRADO DE TABLAS***************************/
	BEGIN
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.Rol_Funcionalidad'))
		DROP TABLE ICE_CUBES.Rol_Funcionalidad
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.Funcionalidad'))
		DROP TABLE ICE_CUBES.Funcionalidad
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.USUARIO'))
		DROP TABLE ICE_CUBES.USUARIO
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.Rol'))
		DROP TABLE ICE_CUBES.Rol
	--IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.PASAJE'))
	--	DROP TABLE ICE_CUBES.PASAJE
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.OPERACION'))
		DROP TABLE ICE_CUBES.OPERACION
	--IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.RESERVA'))
	--	DROP TABLE ICE_CUBES.RESERVA
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.CLIENTE'))
		DROP TABLE ICE_CUBES.CLIENTE
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.TRAMO'))
		DROP TABLE ICE_CUBES.TRAMO
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.TRAMO_SIMPLE'))
		DROP TABLE ICE_CUBES.TRAMO_SIMPLE
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.TRAMO_COMPUESTO'))
		DROP TABLE ICE_CUBES.TRAMO_COMPUESTO
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.PUERTO'))
		DROP TABLE ICE_CUBES.PUERTO
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.CABINA'))
		DROP TABLE ICE_CUBES.CABINA
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.TIPO_CABINA'))
		DROP TABLE ICE_CUBES.TIPO_CABINA
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.VIAJE'))
		DROP TABLE ICE_CUBES.VIAJE
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.RECORRIDO'))
		DROP TABLE ICE_CUBES.RECORRIDO
	IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'ICE_CUBES.CRUCERO'))
		DROP TABLE ICE_CUBES.CRUCERO

/************************** FIN-BORRADO DE TABLAS***************************/
/************************** INI-CREACION DE TABLAS***************************/
	CREATE TABLE ICE_CUBES.ROL (
		ROL_ID NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
		ROL_DESCRIPCION NVARCHAR(255) NOT NULL,
		ROL_ESTADO BIT NOT NULL DEFAULT 1, 
			PRIMARY KEY (ROL_ID)
	);

	CREATE TABLE ICE_CUBES.FUNCIONALIDAD (
		FUNCION_ID NUMERIC(18,0) IDENTITY(1,1)  NOT NULL,
		FUNCION_NOMBRE NVARCHAR(255) NOT NULL,
			PRIMARY KEY (FUNCION_ID)
	)

	CREATE TABLE ICE_CUBES.ROL_FUNCIONALIDAD (
		--Rol_Funcionalidad_ID NUMERIC(18,0) IDENTITY(1,1),
		ID_rol NUMERIC(18,0) NOT NULL, 
		ID_funcionalidad NUMERIC(18,0) NOT NULL,
		--	PRIMARY KEY(Rol_Funcionalidad_ID)
	)	
	
	CREATE TABLE ICE_CUBES.USUARIO (
		USERID nvarchar(18) PRIMARY KEY NOT NULL,
		USER_TIPO CHAR (2) NOT NULL,
		USER_PASS NVARCHAR(255) NOT NULL,
		USER_ROL NUMERIC (18,0),
		USER_ESTADO TINYINT	NOT NULL DEFAULT 0,
		USER_INTENTOS TINYINT NOT NULL DEFAULT 0,
		)
	
	CREATE TABLE iCE_CUBES.CLIENTE (
		CLIE_ID NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY  NOT NULL,
		CLIE_DNI DECIMAL(18,0) NOT NULL,
		CLIE_NOMBRE NVARCHAR(255) NOT NULL,
		CLIE_APELLIDO NVARCHAR(255) NOT NULL,
		CLI_DIR NVARCHAR(255) NOT NULL,
		CLI_TELEFONO INT,
		CLI_MAIL NVARCHAR(255),
		CLI_FECHA_NAC DATETIME2(3)
		)

	CREATE TABLE ICE_CUBES.OPERACION(
		OPER_ID INTEGER IDENTITY (1,1) PRIMARY KEY,
		OPER_RESERVA_ID DECIMAL(18,0),
		OPER_F_RESERVA DATETIME2(3),
		OPER_PASAJE_ID DECIMAL(18,0),
		OPER_F_COMPRA DATETIME2(3),
		OPER_PRECIO DECIMAL (18,2),
		OPER_CLIENTE NUMERIC(18,0), --FK CLIENTE
		OPER_VIAJE_ID INT, --FK VIAJE
		OPER_CABINA_ID INT, -- FK CABINA
		)


	
	CREATE TABLE ICE_CUBES.PUERTO(
		PUERTO_ID INT IDENTITY(1,1) PRIMARY KEY  NOT NULL,
		PUERTO_NOMBRE NVARCHAR(255),
		PUERTO_ESTADO BIT NOT NULL
		)

	CREATE TABLE ICE_CUBES.RECORRIDO(
		RECO_ID INT PRIMARY KEY  NOT NULL,
		RECO_ESTADO BIT NOT NULL,  
	)

	CREATE TABLE ICE_CUBES.TRAMO(
		TRAMO_RECO_ID INT NOT NULL,
		TRAMO_NIVEL INT NOT NULL, 
		TRAMO_ORIGEN INT,
		TRAMO_DESTINO INT,
		TRAMO_PRECIO DECIMAL (18,2),
		CONSTRAINT PK_TRAMO PRIMARY KEY (TRAMO_RECO_ID,TRAMO_NIVEL)
	)

	--CREATE TABLE ICE_CUBES.TRAMO_SIMPLE (
	--	SIMP_RECO_ID INT PRIMARY KEY  NOT NULL,
	--	SIMP_ORIGEN INT,
	--	SIMP_DESTINO INT,
	--	SIMP_PRECIO DECIMAL (18,2)
	--)

	--CREATE TABLE ICE_CUBES.TRAMO_COMPUESTO (
	--	COMP_RECO_ID INT NOT NULL,
	--	COMP_SIMPLE INT )
	
	CREATE TABLE ICE_CUBES.CRUCERO (
		CRUCERO_ID NVARCHAR(50) PRIMARY KEY  NOT NULL,
		CRUCERO_MODELO NVARCHAR(50),
	--	CRUCERO_IDENTIFICADOR  NVARCHAR(50),
		CRUCERO_MARCA NVARCHAR(255),
		CRUERO_TIPO_SERVICIO NVARCHAR(50),
		CRUCERO_ESTADO BIT ,
		CRUCERO_FALTA DATETIME2(3),
		CRUCERO_FFUERA_SERVICIO DATETIME2(3),
		CRUCERO_FREINICIO DATETIME2(3),
		CRUCERO_BAJA_DEF DATETIME2(3),
	)

	CREATE TABLE ICE_CUBES.CABINA(
		CABINA_ID INT IDENTITY(1,1) PRIMARY KEY  NOT NULL,
		CABINA_CRUCERO_ID NVARCHAR(50), --FK CRUCERO
		CABINA_PISO DECIMAL(18,0),
		CABINA_NUMERO DECIMAL (18,0),
		CABINA_TIPO INT --FK TIPO CABINA
		)

	CREATE TABLE ICE_CUBES.TIPO_CABINA(
		TIPO_CABINA INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
		TIPO_NOMBRE NVARCHAR (50),
		TIPO_RECARGO DECIMAL(18,2)
		)

	CREATE TABLE ICE_CUBES.VIAJE (
		VIAJE_ID INT IDENTITY(1,1) PRIMARY KEY  ,
		VIAJE_CRUCERO_ID NVARCHAR(50),--FK CRUCERO
		VIAJE_RECORRIDO_ID INT, -- FK RECORRIDO
		VIAJE_FINICIO DATETIME,
		VIAJE_FFIN DATETIME
	)

	--CREATE TABLE ICE_CUBES.PASAJE(
	--	PASAJE_VIAJE_ID INT PRIMARY KEY , --PK/FK VIAJE
	--	PASAJE_CABINA_ID INT , -- PK/FK CABINA
	--	PASAJE_PRECIO DECIMAL (18,2),
	--	PASAJE_COMPRA_ID DECIMAL(18,0), --FK COMPRA
	--	PASAJE_RESERVA_ID DECIMAL(18,0) --FK RESERVA
	--	)

		
-- Creacion de FKs
	ALTER TABLE ICE_CUBES.Rol_Funcionalidad WITH CHECK ADD
	CONSTRAINT FK_Rol_Funcionalidad_Funcionalidad FOREIGN KEY (ID_FUNCIONALIDAD) REFERENCES ICE_CUBES.FUNCIONALIDAD(FUNCION_ID)
	ON DELETE NO ACTION ON UPDATE CASCADE,
	CONSTRAINT FK_RID_ROl_Funcionalidad_ROL FOREIGN KEY (ID_ROL) REFERENCES ICE_CUBES.ROL (ROL_ID)
	ON DELETE NO ACTION ON UPDATE CASCADE

	ALTER TABLE ICE_CUBES.USUARIO WITH CHECK ADD
	CONSTRAINT FK_USUARIO_ROL FOREIGN KEY (USER_ROL) REFERENCES ICE_CUBES.ROL (ROL_ID)
	ON DELETE NO ACTION ON UPDATE CASCADE

	ALTER TABLE ICE_CUBES.OPERACION WITH CHECK ADD
	CONSTRAINT FK_OPERACION_VIAJE FOREIGN KEY (OPER_VIAJE_ID) REFERENCES ICE_CUBES.VIAJE (VIAJE_ID)
	ON DELETE NO ACTION ON UPDATE CASCADE,
	CONSTRAINT FK_OPERACION_COMPRA FOREIGN KEY (OPER_CLIENTE) REFERENCES ICE_CUBES.CLIENTE (CLIE_ID)
	ON DELETE NO ACTION ON UPDATE CASCADE,
	CONSTRAINT FK_OPERACION_RESERVA FOREIGN KEY (OPER_CABINA_ID) REFERENCES ICE_CUBES.CABINA (CABINA_ID)

	ALTER TABLE ICE_CUBES.VIAJE WITH CHECK ADD
	CONSTRAINT FK_VIAJE_CRUCERO FOREIGN KEY (VIAJE_CRUCERO_ID) REFERENCES ICE_CUBES.CRUCERO (CRUCERO_ID)
	ON DELETE NO ACTION ON UPDATE CASCADE,
	CONSTRAINT FK_VIAJE_RECORRIDO FOREIGN KEY (VIAJE_RECORRIDO_ID) REFERENCES ICE_CUBES.RECORRIDO (RECO_ID)
	ON DELETE NO ACTION ON UPDATE CASCADE

	ALTER TABLE ICE_CUBES.CABINA WITH CHECK ADD
	CONSTRAINT FK_CABINA_CRUCERO FOREIGN KEY (CABINA_CRUCERO_ID) REFERENCES ICE_CUBES.CRUCERO (CRUCERO_ID)
	ON DELETE NO ACTION ON UPDATE CASCADE,
	CONSTRAINT FK_CABINA_TIPO FOREIGN KEY (CABINA_TIPO) REFERENCES ICE_CUBES.TIPO_CABINA (TIPO_CABINA)
	ON DELETE NO ACTION ON UPDATE CASCADE

	ALTER TABLE ICE_CUBES.TRAMO WITH CHECK ADD
	CONSTRAINT FK_TSIMPLE_RECORRIDO FOREIGN KEY (TRAMO_RECO_ID) REFERENCES ICE_CUBES.RECORRIDO (RECO_ID),
	CONSTRAINT FK_TSIMPLE_ORIGEN FOREIGN KEY (TRAMO_ORIGEN) REFERENCES ICE_CUBES.PUERTO (PUERTO_ID),
	CONSTRAINT FK_TSIMPLE_DESTINO FOREIGN KEY (TRAMO_DESTINO) REFERENCES ICE_CUBES.PUERTO (PUERTO_ID)
	
END

GO

--crear funcionalidades
CREATE PROCEDURE SP_CREAR_FUNCIONALIDAD
AS
BEGIN
	INSERT INTO ICE_CUBES.Funcionalidad (FUNCION_NOMBRE) VALUES ('Compra/Reserva de Viaje');
	INSERT INTO ICE_CUBES.Funcionalidad (FUNCION_NOMBRE) VALUES ('Pago Reserva');
	INSERT INTO ICE_CUBES.Funcionalidad (FUNCION_NOMBRE) VALUES ('ABM Puertos');
	INSERT INTO ICE_CUBES.Funcionalidad (FUNCION_NOMBRE) VALUES ('ABM Rol');
	INSERT INTO ICE_CUBES.Funcionalidad (FUNCION_NOMBRE) VALUES ('ABM Usuarios');
	INSERT INTO ICE_CUBES.Funcionalidad (FUNCION_NOMBRE) VALUES ('ABM Recorridos');
	INSERT INTO ICE_CUBES.Funcionalidad (FUNCION_NOMBRE) VALUES ('ABM Cruceros');
	INSERT INTO ICE_CUBES.Funcionalidad (FUNCION_NOMBRE) VALUES ('Generar Viaje');
	INSERT INTO ICE_CUBES.Funcionalidad (FUNCION_NOMBRE) VALUES ('ListadosTOP');
END
GO

--Este procedure se encarga de crear ROL del tp
CREATE PROCEDURE SP_CREAR_ROLES
AS
BEGIN
	INSERT INTO ICE_CUBES.ROL(ROL_DESCRIPCION, ROL_ESTADO) VALUES ( 'Administrador', 0)
	INSERT INTO ICE_CUBES.ROL_Funcionalidad (ID_ROL, ID_FUNCIONALIDAD) VALUES (1, 1)
	INSERT INTO ICE_CUBES.ROL_Funcionalidad (ID_ROL, ID_FUNCIONALIDAD) VALUES (1, 2)
	INSERT INTO ICE_CUBES.ROL_Funcionalidad (ID_ROL, ID_FUNCIONALIDAD) VALUES (1, 3)
	INSERT INTO ICE_CUBES.ROL_Funcionalidad (ID_ROL, ID_FUNCIONALIDAD) VALUES (1, 4)
	INSERT INTO ICE_CUBES.ROL_Funcionalidad (ID_ROL, ID_FUNCIONALIDAD) VALUES (1, 5)
	INSERT INTO ICE_CUBES.ROL_Funcionalidad (ID_ROL, ID_FUNCIONALIDAD) VALUES (1, 6)
	INSERT INTO ICE_CUBES.ROL_Funcionalidad (ID_ROL, ID_FUNCIONALIDAD) VALUES (1, 7)
	INSERT INTO ICE_CUBES.ROL_Funcionalidad (ID_ROL, ID_FUNCIONALIDAD) VALUES (1, 8)
	INSERT INTO ICE_CUBES.ROL_Funcionalidad (ID_ROL, ID_FUNCIONALIDAD) VALUES (1, 9)
	INSERT INTO ICE_CUBES.ROL (ROL_DESCRIPCION, ROL_ESTADO) VALUES ('Cliente', 0)
	INSERT INTO ICE_CUBES.ROL_Funcionalidad (ID_ROL, ID_FUNCIONALIDAD) VALUES (2, 1)
	INSERT INTO ICE_CUBES.ROL_Funcionalidad (ID_ROL, ID_FUNCIONALIDAD) VALUES (2, 2)


	INSERT INTO ICE_CUBES.Usuario(USERID, USER_TIPO,USER_PASS)
	VALUES ('admin','A',HASHBYTES('SHA2_256','w23e'))
END
GO

CREATE PROCEDURE SP_MIGRAR_CLIENTES
AS
BEGIN

	INSERT INTO ICE_CUBES.CLIENTE
	SELECT DISTINCT M.CLI_DNI, M.CLI_NOMBRE, M.CLI_APELLIDO, M.CLI_DIRECCION, M.CLI_TELEFONO,
	M.CLI_MAIL,M.CLI_FECHA_NAC
	FROM GD1C2019.gd_esquema.Maestra M
	WHERE M.CLI_DNI IS NOT NULL 
	order by 1;

	INSERT INTO ICE_CUBES.CRUCERO (CRUCERO_ID,CRUCERO_MODELO,CRUCERO_MARCA,CRUCERO_ESTADO)
	SELECT DISTINCT M.CRUCERO_IDENTIFICADOR,M.CRUCERO_MODELO,M.CRU_FABRICANTE,1
	FROM GD1C2019.gd_esquema.Maestra M;

	INSERT INTO ICE_CUBES.TIPO_CABINA (TIPO_NOMBRE,TIPO_RECARGO)
	SELECT DISTINCT M.CABINA_TIPO,M.CABINA_TIPO_PORC_RECARGO
	FROM GD1C2019.gd_esquema.Maestra M;

	INSERT INTO ICE_CUBES.CABINA (CABINA_CRUCERO_ID,CABINA_NUMERO,CABINA_PISO,CABINA_TIPO)
	SELECT distinct m.CRUCERO_IDENTIFICADOR,M.CABINA_NRO,M.CABINA_PISO,TC.TIPO_CABINA
	FROM GD1C2019.gd_esquema.Maestra M
	JOIN ICE_CUBES.TIPO_CABINA TC ON TC.TIPO_NOMBRE = M.CABINA_TIPO  
	order by 1, 3 asc,2 asc;

	INSERT INTO ICE_CUBES.PUERTO(PUERTO_NOMBRE,PUERTO_ESTADO)
		SELECT distinct m.PUERTO_DESDE,1
		FROM GD1C2019.gd_esquema.Maestra M
		

	INSERT INTO ICE_CUBES.RECORRIDO(RECO_ID,RECO_ESTADO)
	SELECT distinct m.RECORRIDO_CODIGO,1
	FROM GD1C2019.gd_esquema.Maestra M

	INSERT INTO ICE_CUBES.TRAMO(TRAMO_RECO_ID,TRAMO_NIVEL,TRAMO_ORIGEN,TRAMO_DESTINO,TRAMO_PRECIO)
	SELECT distinct m.RECORRIDO_CODIGO,1,P.PUERTO_ID,P2.PUERTO_ID, m.RECORRIDO_PRECIO_BASE
		FROM GD1C2019.gd_esquema.Maestra M
		JOIN ICE_CUBES.PUERTO P ON P.PUERTO_NOMBRE = M.PUERTO_DESDE
		JOIN ICE_CUBES.PUERTO P2 ON P2.PUERTO_NOMBRE = M.PUERTO_HASTA
		where 
		M.PUERTO_HASTA = ANY ( SELECT distinct m1.PUERTO_DESDE
								FROM GD1C2019.gd_esquema.Maestra M1
								where m1.RECORRIDO_CODIGO = M.RECORRIDO_CODIGO
								)
		order by 1


	INSERT INTO ICE_CUBES.TRAMO(TRAMO_RECO_ID,TRAMO_NIVEL,TRAMO_ORIGEN,TRAMO_DESTINO,TRAMO_PRECIO)
	SELECT DISTINCT m.RECORRIDO_CODIGO,2,P.PUERTO_ID,P2.PUERTO_ID, m.RECORRIDO_PRECIO_BASE
		FROM GD1C2019.gd_esquema.Maestra M
		JOIN ICE_CUBES.PUERTO P ON P.PUERTO_NOMBRE = M.PUERTO_DESDE
		JOIN ICE_CUBES.PUERTO P2 ON P2.PUERTO_NOMBRE = M.PUERTO_HASTA
		JOIN ICE_CUBES.TRAMO T ON T.TRAMO_RECO_ID = M.RECORRIDO_CODIGO
		WHERE T.TRAMO_ORIGEN <> P.PUERTO_ID


	INSERT INTO ICE_CUBES.VIAJE ( VIAJE_CRUCERO_ID,VIAJE_RECORRIDO_ID,VIAJE_FINICIO,VIAJE_FFIN)
		SELECT DISTINCT  M.CRUCERO_IDENTIFICADOR,M.RECORRIDO_CODIGO,M.FECHA_SALIDA,M.FECHA_LLEGADA
		FROM GD1C2019.gd_esquema.Maestra M
		ORDER BY 3


--FALTA MIGRAR VIAJE PARA LUEGO ACTUALIZAR OPERACION)
	INSERT INTO ICE_CUBES.OPERACION(OPER_RESERVA_ID,OPER_F_RESERVA,OPER_PASAJE_ID,OPER_F_COMPRA
		,OPER_PRECIO,OPER_CLIENTE,OPER_CABINA_ID, OPER_VIAJE_ID)
	SELECT  M.RESERVA_CODIGO, M.RESERVA_FECHA, M.PASAJE_CODIGO,M.PASAJE_FECHA_COMPRA,M.PASAJE_PRECIO,C.CLIE_ID,CA.CABINA_ID,V.VIAJE_ID
		FROM GD1C2019.gd_esquema.Maestra M
		LEFT JOIN ICE_CUBES.VIAJE V 
			ON VIAJE_CRUCERO_ID = M.CRUCERO_IDENTIFICADOR
			and VIAJE_RECORRIDO_ID =M.RECORRIDO_CODIGO
			and VIAJE_FFIN = m.FECHA_LLEGADA
			and VIAJE_FINICIO = m.FECHA_SALIDA
		LEFT JOIN ICE_CUBES.CLIENTE C 
			ON C.CLIE_DNI = M.CLI_DNI
			AND C.CLIE_NOMBRE =M.CLI_NOMBRE
			AND C.CLIE_APELLIDO = M.CLI_APELLIDO
			AND C.CLI_DIR = M.CLI_DIRECCION
			AND C.CLI_TELEFONO = M.CLI_TELEFONO
			AND C.CLI_MAIL = M.CLI_MAIL
			AND C.CLI_FECHA_NAC = M.CLI_FECHA_NAC
		LEFT JOIN ICE_CUBES.CABINA CA 
			ON CA.CABINA_CRUCERO_ID =M.CRUCERO_IDENTIFICADOR
			AND CA.CABINA_NUMERO = M.CABINA_NRO
			AND CA.CABINA_PISO = M.CABINA_PISO
		WHERE m.RESERVA_CODIGO is not null
		ORDER BY 1;

	SELECT M.RESERVA_CODIGO as OPER_RESERVA_ID, M.RESERVA_FECHA as OPER_F_RESERVA ,
	M.PASAJE_CODIGO as OPER_PASAJE_ID ,M.PASAJE_FECHA_COMPRA as OPER_F_COMPRA,
	M.PASAJE_PRECIO as OPER_PRECIO, C.CLIE_ID as OPER_CLIENTE,CA.CABINA_ID as OPER_CABINA_ID,V.VIAJE_ID as OPER_VIAJE_ID
		INTO #pasajes 
		FROM GD1C2019.gd_esquema.Maestra M
		LEFT JOIN ICE_CUBES.VIAJE V 
			ON VIAJE_CRUCERO_ID = M.CRUCERO_IDENTIFICADOR
			and VIAJE_RECORRIDO_ID =M.RECORRIDO_CODIGO
			and VIAJE_FFIN = m.FECHA_LLEGADA
			and VIAJE_FINICIO = m.FECHA_SALIDA
		LEFT JOIN ICE_CUBES.CLIENTE C 
			ON C.CLIE_DNI = M.CLI_DNI
			AND C.CLIE_NOMBRE =M.CLI_NOMBRE
			AND C.CLIE_APELLIDO = M.CLI_APELLIDO
			AND C.CLI_DIR = M.CLI_DIRECCION
			AND C.CLI_TELEFONO = M.CLI_TELEFONO
			AND C.CLI_MAIL = M.CLI_MAIL
			AND C.CLI_FECHA_NAC = M.CLI_FECHA_NAC
		LEFT JOIN ICE_CUBES.CABINA CA 
			ON CA.CABINA_CRUCERO_ID =M.CRUCERO_IDENTIFICADOR
			AND CA.CABINA_NUMERO = M.CABINA_NRO
			AND CA.CABINA_PISO = M.CABINA_PISO
		WHERE M.PASAJE_CODIGO is not null
		ORDER BY 1;

	UPDATE [GD1C2019].[ICE_CUBES].[OPERACION]
	SET
		OPER_PASAJE_ID = #pasajes.OPER_PASAJE_ID,
		OPER_F_COMPRA = #pasajes.OPER_F_COMPRA,
		OPER_PRECIO = #pasajes.OPER_PRECIO   
	FROM [GD1C2019].[ICE_CUBES].[OPERACION] OP
	INNER JOIN #pasajes 
		ON #pasajes.OPER_CLIENTE = OP.OPER_CLIENTE
		AND #pasajes.OPER_CABINA_ID = OP.OPER_CABINA_ID
		AND #pasajes.OPER_VIAJE_ID = OP.OPER_VIAJE_ID;

INSERT INTO ICE_CUBES.OPERACION(OPER_RESERVA_ID,OPER_F_RESERVA,OPER_PASAJE_ID,OPER_F_COMPRA
		,OPER_PRECIO,OPER_CLIENTE,OPER_CABINA_ID, OPER_VIAJE_ID)
	SELECT  p.OPER_RESERVA_ID, p.OPER_F_RESERVA, p.OPER_PASAJE_ID, p.OPER_F_COMPRA
		,p.OPER_PRECIO,p.OPER_CLIENTE,p.OPER_CABINA_ID, p.OPER_VIAJE_ID
		FROM #pasajes p
		WHERE NOT EXISTS (Select null 
						from [GD1C2019].[ICE_CUBES].[OPERACION] ope 
						where ope.OPER_CLIENTE = p.OPER_CLIENTE 
						AND ope.OPER_CABINA_ID = p.OPER_CABINA_ID
						AND ope.OPER_VIAJE_ID = p.OPER_VIAJE_ID );

--	SELECT DISTINCT M.RESERVA_CODIGO,M.RESERVA_FECHA,M.PASAJE_CODIGO,M.PASAJE_FECHA_COMPRA,M.PASAJE_PRECIO,C.CLIE_ID
--		,CA.CABINA_ID
----		,V.VIAJE_ID
--		--,		(select VIAJE_ID
--		--				from ICE_CUBES.VIAJE
--		--				where VIAJE_CRUCERO_ID =m.CRUCERO_IDENTIFICADOR
--		--				and VIAJE_FFIN = m.FECHA_LLEGADA
--		--				and VIAJE_FINICIO = m.FECHA_SALIDA
--		--				and VIAJE_RECORRIDO_ID = 
--		FROM GD1C2019.gd_esquema.Maestra M
--		JOIN ICE_CUBES.CLIENTE C ON C.CLIE_DNI = M.CLI_DNI
--		AND C.CLIE_NOMBRE =M.CLI_NOMBRE
--		AND C.CLIE_APELLIDO = M.CLI_APELLIDO
--		AND C.CLI_DIR = M.CLI_DIRECCION
--		AND C.CLI_TELEFONO = M.CLI_TELEFONO
--		AND C.CLI_MAIL = M.CLI_MAIL
--		AND C.CLI_FECHA_NAC = M.CLI_FECHA_NAC
--		JOIN ICE_CUBES.CABINA CA ON CA.CABINA_CRUCERO_ID =M.CRUCERO_IDENTIFICADOR
--		AND CA.CABINA_NUMERO = M.CABINA_NRO
--		AND CA.CABINA_PISO = M.CABINA_PISO
----		LEFT JOIN ICE_CUBES.VIAJE V ON VIAJE_CRUCERO_ID =m.CRUCERO_IDENTIFICADOR
----						and VIAJE_FFIN = m.FECHA_LLEGADA
----						and VIAJE_FINICIO = m.FECHA_SALIDA
----						and VIAJE_RECORRIDO_ID =M.RECORRIDO_CODIGO
--		ORDER BY 1;

----SELECT DISTINCT M.RESERVA_CODIGO,M.RESERVA_FECHA,M.PASAJE_CODIGO,M.PASAJE_FECHA_COMPRA,M.PASAJE_PRECIO
----		 , (select v.VIAJE_ID
----		from ICE_CUBES.VIAJE v
----		where
----		v.VIAJE_CRUCERO_ID =  m.CRUCERO_IDENTIFICADOR and
----		v.VIAJE_RECORRIDO_ID = M.RECORRIDO_CODIGO and
----		v.VIAJE_FINICIO = M.FECHA_SALIDA and v.VIAJE_FFIN = M.FECHA_LLEGADA) as viaje_id
----		into #viaje_op
----		FROM GD1C2019.gd_esquema.Maestra M
----		ORDER BY 1;

----update ICE_CUBES.OPERACION
----set OPER_VIAJE_ID = (
----		select v.viaje_id
----		from #viaje_op v
----		left join ICE_CUBES.OPERACION op on v.RESERVA_CODIGO =op.OPER_RESERVA_ID
----		and v.RESERVA_FECHA = op.OPER_F_RESERVA
----		and v.PASAJE_CODIGO = op.OPER_PASAJE_ID
----		and v.PASAJE_FECHA_COMPRA = op.OPER_F_COMPRA
----		and v.PASAJE_PRECIO = op.OPER_PRECIO
----		)
----drop table #viaje_op
END


/************************** EJEC PROCEDURES***************************/
GO

CREATE PROCEDURE SP_CREACION
AS
BEGIN 

	EXEC DBO.SP_CREAR_TABLAS
	EXEC DBO.SP_CREAR_FUNCIONALIDAD
	EXEC DBO.SP_CREAR_ROLES
	EXEC DBO.SP_MIGRAR_CLIENTES

END