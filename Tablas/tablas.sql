USE [contabilidad]
GO

/****** Object:  Table [dbo].[cuentas]    Script Date: 8/21/2018 12:39:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF EXISTS (select * from sysobjects where type = 'U' and name like 'cuentas')
begin
	drop table cuentas
end
go
CREATE TABLE [dbo].[cuentas](
	[id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[cuenta] [varchar](20) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[afe] [bit] NOT NULL,
	[cco] [bit]  NULL,
	[ter] [bit]  NULL,
	[doc] [bit]  NULL,
	[aju] [bit]  NULL,
	[bas] [bit]  NULL,
	[tei] [bit]  NULL,
	[partida] [varchar](20) NULL,
	[contrapartida] [varchar](20) NULL,
	[naturaleza] [smallint]  NOT NULL,
 CONSTRAINT [PK_cuentas_1__10] PRIMARY KEY CLUSTERED 
(
	[cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY],
 CONSTRAINT [IX_cuentas_id] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY]
) ON [PRIMARY]
GO

IF EXISTS (select * from sysobjects where type = 'U' and name like 'nivelesCuentas')
begin
	drop table nivelesCuentas
end
go
CREATE TABLE [dbo].[nivelesCuentas](
	[id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[nivel1] [tinyint] NOT NULL,
	[nivel2] [tinyint] NOT NULL,
	[nivel3] [tinyint] NOT NULL,
	[nivel4] [tinyint] NOT NULL,
	[nivel5] [tinyint] NOT NULL,
	[nivel6] [tinyint] NOT NULL,
	[nivel7] [tinyint] NOT NULL,
	[nivel8] [tinyint] NOT NULL,
	[nivel9] [tinyint] NOT NULL,
	[nivel10] [tinyint] NOT NULL,
 CONSTRAINT [IX_nivelesCuentas_id] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY]
) ON [PRIMARY]
GO
IF EXISTS (select * from sysobjects where type = 'U' and name like 'centros')
begin
	drop table centros
end
go
CREATE TABLE [dbo].[centros](
	[id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[centro] [varchar](20) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_centros_1__10] PRIMARY KEY CLUSTERED 
(
	[centro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY],
 CONSTRAINT [IX_centros_id] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY]
) ON [PRIMARY]
GO
IF EXISTS (select * from sysobjects where type = 'U' and name like 'terceros')
begin
	drop table terceros
end
go
CREATE TABLE [dbo].[terceros](
	[id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[tipo_identificacion] [char](1) NOT NULL,
	[nit] [varchar](20) NOT NULL,
	[nombres] [varchar](80) NOT NULL,
	[apellidos] [varchar](80) NULL,
	[email] [varchar](50) NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_terceros_1__10] PRIMARY KEY CLUSTERED 
(
	[tipo_identificacion],[nit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY],
 CONSTRAINT [IX_terceros_id] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY]
) ON [PRIMARY]
GO

--tipo_transacciones
IF EXISTS (select * from sysobjects where type = 'U' and name like 'tipo_transacciones')
begin
	drop table tipo_transacciones
end
go
CREATE TABLE [dbo].[tipo_transacciones](
	[id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[tipo] [varchar](4) NOT NULL,
	[descripcion] [varchar](30) NOT NULL,
	[sw] [smallint] NOT NULL,
	[siguiente] [int] NOT NULL
 CONSTRAINT [PK_tipo_transacciones_1__10] PRIMARY KEY CLUSTERED 
(
	[tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY],
 CONSTRAINT [IX_tipo_transacciones_id] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY]
) ON [PRIMARY]
GO

--movimiento
IF EXISTS (select * from sysobjects where type = 'U' and name like 'movimiento')
begin
	drop table movimiento
end
go
CREATE TABLE [dbo].[movimiento](
	[id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[tipo] [varchar](4) NOT NULL,
	[numero] [int] NOT NULL,
	[seq] [int] NOT NULL,
	[cuenta] [varchar](20) NOT NULL,
	[centro] [int] NULL,
	[nit] [varchar](20)  NULL,
	[fec] [datetime] NOT NULL,
	[valor] [money] NOT NULL,
	[documento] [varchar](20) NULL,
	[explicacion] [varchar](250) NULL,
	[concilio] [smallint] NULL
 CONSTRAINT [PK_movimiento_1__10] PRIMARY KEY CLUSTERED 
(
	[tipo],[numero],[seq] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY],
 CONSTRAINT [IX_movimiento_id] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY]
) ON [PRIMARY]
GO

--documentos
IF EXISTS (select * from sysobjects where type = 'U' and name like 'documentos')
begin
	drop table documentos
end
go
CREATE TABLE [dbo].documentos(
	[id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[sw] [smallint] NOT NULL,
	[tipo] [varchar](4) NOT NULL,
	[numero] [int] NOT NULL,
	[nit] [varchar](20) NOT NULL,
	[fecha][datetime] NOT NULL,
	[valor_total][float] NOT NULL,
	[iva][float] NOT NULL
 CONSTRAINT [PK_documentos_1__10] PRIMARY KEY CLUSTERED 
(
	[sw],[tipo],[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY],
 CONSTRAINT [IX_documentos_id] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 75) ON [PRIMARY]
) ON [PRIMARY]
GO