USE [contabilidad]
GO
if exists(select * from sysobjects where type = 'P' and name = 'sp_tipo_transacciones')
	drop proc sp_tipo_transacciones
go
CREATE PROCEDURE [dbo].[sp_tipo_transacciones]   
    @i_operacion    VARCHAR(1),
	@i_id  int = NULL,
	@i_tipo   varchar (20) = NULL,
	@i_descripcion   varchar (50) = NULL,
	@i_sw smallint = NULL,
	@i_siguiente int = NULL
AS           
BEGIN
declare @o_id int
	if @i_operacion = 'I'
	begin
		if exists(select *
		from tipo_transacciones
		where tipo = @i_tipo)
		begin
			RAISERROR ('El centro que se requiere ingresar ya existe, revise sus datos',16,1)
		end
		else
		begin
			INSERT INTO tipo_transacciones (tipo, descripcion, sw, siguiente)
			VALUES (@i_tipo,@i_descripcion, @i_sw, 3)
			if @@ERROR > 0
			begin
				RAISERROR ('Error al insertar el tipo de transaccion',16,1)
			end
			else
			begin
				select @o_id = id
				from tipo_transacciones
				where tipo = @i_tipo
				return @o_id
			end
		end
	end
	if @i_operacion = 'U'
	begin
		UPDATE tipo_transacciones 
		set tipo = @i_tipo, 
		descripcion = @i_descripcion,
		sw = @i_sw
		where id =  @i_id
		if @@ERROR > 0
		begin
			RAISERROR ('Error al modificar el tipo de transaccion',16,1)
		end
	end
	if @i_operacion = 'D'
	begin
		DELETE tipo_transacciones 
		where id =  @i_id
		if @@ERROR > 0
		begin
			RAISERROR ('Error al modificar el tipo de transaccion',16,1)
		end
	end
	if @i_operacion = 'S'
	begin
		UPDATE tipo_transacciones 
		set siguiente = @i_siguiente
		where id =  @i_id
		if @@ERROR > 0
		begin
			RAISERROR ('Error al modificar el tipo de transaccion',16,1)
		end
	end
END