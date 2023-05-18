USE [contabilidad]
GO
if exists(select * from sysobjects where type = 'P' and name = 'sp_terceros')
	drop proc sp_terceros
go
CREATE PROCEDURE [dbo].[sp_terceros]   
    @i_operacion    VARCHAR(1),
	@i_id  int = NULL,
	@i_tipo_identificacion   char (1) = NULL,
	@i_nit   varchar (20) = NULL,
	@i_nombres   varchar (80) = NULL,
	@i_apellidos   varchar (80) = NULL,
	@i_email   varchar (50) = NULL,
	@i_estado	bit = NULL,
	@o_out int = NULL out
AS           
BEGIN
	if @i_operacion = 'I'
	begin
		if exists(select *
		from terceros
		where tipo_identificacion = @i_tipo_identificacion
		and   nit = @i_nit )
		begin
			RAISERROR ('El tercero que se requiere ingresar ya existe, revise sus datos',16,1)
		end
		else
		begin
			INSERT INTO terceros (tipo_identificacion,nit,nombres,apellidos,email,estado)
			VALUES (@i_tipo_identificacion, @i_nit, @i_nombres, @i_apellidos, @i_email, @i_estado)
			if @@ERROR > 0
			begin
				RAISERROR ('Error al insertar el tercero',16,1)
			end
			else
			begin
				select @o_out = id
				from terceros
				where tipo_identificacion = @i_tipo_identificacion
				and   nit = @i_nit
				return @o_out
			end
		end
	end
	if @i_operacion = 'U'
	begin
		UPDATE terceros 
		set tipo_identificacion = @i_tipo_identificacion, 
		nit = @i_nit, 
		nombres = @i_nombres,
		apellidos = @i_apellidos,
		email = @i_email,
		estado = @i_estado
		where id =  @i_id
		if @@ERROR > 0
		begin
			RAISERROR ('Error al modificar el tercero',16,1)
		end
	end
	if @i_operacion = 'D'
	begin
		DELETE terceros 
		where id =  @i_id
		if @@ERROR > 0
		begin
			RAISERROR ('Error al modificar el tercero',16,1)
		end
	end
END