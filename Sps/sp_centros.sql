USE [contabilidad]
GO
if exists(select * from sysobjects where type = 'P' and name = 'sp_centros')
	drop proc sp_centros
go
CREATE PROCEDURE [dbo].[sp_centros]   
    @i_operacion    VARCHAR(1),
	@i_id  int = NULL,
	@i_centro   varchar (20) = NULL,
	@i_descripcion   varchar (50) = NULL
AS           
BEGIN
declare @o_id int
	if @i_operacion = 'I'
	begin
		if exists(select *
		from centros
		where centro = @i_centro)
		begin
			RAISERROR ('El centro que se requiere ingresar ya existe, revise sus datos',16,1)
		end
		else
		begin
			INSERT INTO centros (centro, descripcion)
			VALUES (@i_centro,@i_descripcion)
			if @@ERROR > 0
			begin
				RAISERROR ('Error al insertar el centro',16,1)
			end
			else
			begin
				select @o_id = id
				from centros
				where centro = @i_centro
				return @o_id
			end
		end
	end
	if @i_operacion = 'U'
	begin
		UPDATE centros 
		set centro = @i_centro, 
		descripcion = @i_descripcion
		where id =  @i_id
		if @@ERROR > 0
		begin
			RAISERROR ('Error al modificar el centro',16,1)
		end
	end
	if @i_operacion = 'D'
	begin
		DELETE centros 
		where id =  @i_id
		if @@ERROR > 0
		begin
			RAISERROR ('Error al modificar el centro',16,1)
		end
	end
END