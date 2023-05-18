USE [contabilidad]
GO
if exists(select * from sysobjects where type = 'P' and name = 'sp_documentos')
	drop proc sp_documentos
go
CREATE PROCEDURE [dbo].[sp_documentos]   
    @i_operacion  VARCHAR(1),
	@i_sw smallint = NULL,
	@i_tipo varchar(4) = NULL,
	@i_numero int = NULL,
	@i_nit varchar(20) = NULL,
	@i_fecha datetime  = NULL,
	@i_valor_total float = NULL,
	@i_iva float = NULL
AS           
BEGIN
declare @o_id int
	if @i_operacion = 'I'
	begin
		INSERT INTO documentos (sw,	tipo, numero, nit, fecha,
		valor_total,	iva)
		VALUES (@i_sw,	@i_tipo, @i_numero, @i_nit, @i_fecha,
		@i_valor_total,	@i_iva)
		if @@ERROR > 0
		begin
			RAISERROR ('Error al insertar el documento',16,1)
		end
		else
		begin
			select @o_id = id
			from documentos
			where sw = @i_sw
			and tipo = @i_tipo
			and numero = @i_numero
			return @o_id
		end
	end
END