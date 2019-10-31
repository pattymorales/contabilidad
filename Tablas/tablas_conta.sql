USE [Pruebas_Paty]
GO

/****** Object:  Table [dbo].[cuentas]    Script Date: 8/21/2018 12:39:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cuentas](
	[id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[cuenta] [varchar](20) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[afe] [bit] NOT NULL,
	[cco] [bit] NOT NULL,
	[ter] [bit] NOT NULL,
	[doc] [bit] NOT NULL,
	[aju] [bit] NOT NULL,
	[bas] [bit] NOT NULL,
	[tei] [bit] NOT NULL,
	[partida] [varchar](20) NULL,
	[contrapartida] [varchar](20) NULL,
	[naturaleza] [smallint] NULL,
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


CREATE TABLE [dbo].[tablag](
	[nombre_empresa] [varchar](60) NOT NULL,
	[ano] [smallint] NOT NULL,
	[periodo] [smallint] NOT NULL,
	[fecha_actual] [datetime] NOT NULL,
	[gran_contribuyente] [bit] NOT NULL,
	[autoretenedor] [bit] NOT NULL,
	[nit] [varchar](20) NULL,
	[direccion] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[niv1] [tinyint] NOT NULL,
	[niv2] [tinyint] NOT NULL,
	[niv3] [tinyint] NOT NULL,
	[niv4] [tinyint] NOT NULL,
	[niv5] [tinyint] NOT NULL,
	[niv6] [tinyint] NOT NULL,
	[niv7] [tinyint] NOT NULL,
	[niv8] [tinyint] NOT NULL,
	[niv9] [tinyint] NOT NULL,
	[niv10] [tinyint] NOT NULL,
 CONSTRAINT [PK_tablag_1__10] PRIMARY KEY CLUSTERED 
(
	[nombre_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
GO


