USE [contabilidad]
GO
if exists(select * from sysobjects where type = 'P' and name = 'sp_movimiento')
	drop proc sp_movimiento
go
/****** Object:  StoredProcedure [dbo].[sp_movimiento]    Script Date: 9/2/2020 7:19:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_movimiento   
    @i_operacion    VARCHAR(1),
	@i_id  int = NULL,
	@i_tipo	varchar(4) = NULL,
	@i_numero	int	= NULL,
	@i_seq	int	= NULL,
	@i_cuenta	 varchar (20) = NULL,
	@i_centro	int	= NULL,
	@i_nit	 varchar (20) = NULL,
	@i_fec	datetime = NULL,
	@i_valor	money	= NULL,
	@i_documento	 varchar (20) = NULL,
	@i_explicacion	 varchar (250) = NULL,
	@i_concilio	smallint = NULL
AS           
BEGIN
declare @o_id int
	if @i_operacion = 'I'
	begin
		INSERT INTO movimiento (tipo, numero, seq, cuenta,
		centro, nit, fec, valor, 
		documento, explicacion, concilio)
		VALUES (@i_tipo, @i_numero, @i_seq, @i_cuenta,
		@i_centro, @i_nit, @i_fec, @i_valor,
		@i_documento, @i_explicacion, @i_concilio)
		if @@ERROR > 0
		begin
			RAISERROR ('Error al insertar el movimiento',16,1)
		end
	end
	if @i_operacion = 'D'
	begin
		DELETE movimiento 
		where id =  @i_id
		if @@ERROR > 0
		begin
			RAISERROR ('Error al eliminar el movimiento',16,1)
		end
	end
END
GO

