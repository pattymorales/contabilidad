USE [contabilidad]
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

