USE [contabilidad]
GO
if exists(select * from sysobjects where type = 'P' and name = 'sp_cuentas')
	drop proc sp_cuentas
go
CREATE PROCEDURE [dbo].[sp_cuentas]   
    @i_operacion    VARCHAR(1),
	@i_id  int = NULL,
	@i_cuenta   varchar (20) = NULL,
	@i_descripcion   varchar (50) = NULL,
	@i_afe   bit  = NULL,
	@i_cco   bit  = NULL,
	@i_ter   bit  = NULL,
	@i_doc   bit  = NULL,
	@i_aju   bit  = NULL,
	@i_bas   bit  = NULL,
	@i_tei   bit  = NULL,
	@i_partida varchar (20) = NULL,
	@i_contrapartida varchar (20) =  NULL,
	@i_naturaleza  smallint = NULL
AS           
BEGIN
declare @o_id int
	if @i_operacion = 'I'
	begin
		INSERT INTO cuentas (cuenta, descripcion, afe,cco,
		ter,doc,aju,bas,
		tei,partida,contrapartida,naturaleza)
		VALUES (@i_cuenta,@i_descripcion, @i_afe, @i_cco,
		@i_ter ,@i_doc , @i_aju, @i_bas, 
		@i_tei , @i_partida,@i_contrapartida,@i_naturaleza)
		if @@ERROR > 0
		begin
			RAISERROR ('Error al insertar la cuenta',16,1)
		end
		else
		begin
			select @o_id = id
			from cuentas
			where cuenta = @i_cuenta
			return @o_id
		end
	end
	if @i_operacion = 'U'
	begin
		UPDATE cuentas 
		set cuenta = @i_cuenta, 
		descripcion = @i_descripcion,
		afe = @i_afe,
		naturaleza = @i_naturaleza
		where id =  @i_id
		if @@ERROR > 0
		begin
			RAISERROR ('Error al modificar la cuenta',16,1)
		end
	end
	if @i_operacion = 'D'
	begin
		DELETE cuentas 
		where id =  @i_id
		if @@ERROR > 0
		begin
			RAISERROR ('Error al modificar la cuenta',16,1)
		end
	end
END