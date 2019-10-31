USE [contabilidad]
GO
if exists(select * from sysobjects where type = 'P' and name = 'sp_nivelesCuentas')
	drop proc sp_nivelesCuentas
go
CREATE PROCEDURE [dbo].[sp_nivelesCuentas]   
    @i_operacion    VARCHAR(1),
	@i_id  int = NULL,
	@i_niv1 tinyint = NULL,
	@i_niv2 tinyint = NULL,
	@i_niv3 tinyint = NULL,
	@i_niv4 tinyint = NULL,
	@i_niv5 tinyint = NULL,
	@i_niv6 tinyint = NULL,
	@i_niv7 tinyint = NULL,
	@i_niv8 tinyint = NULL,
	@i_niv9 tinyint = NULL,
	@i_niv10 tinyint = NULL
AS           
BEGIN
declare @o_id int
	if @i_operacion = 'I'
	begin
		INSERT INTO nivelesCuentas (
		niv1, niv2, niv3, niv4, niv5,
		niv6, niv7, niv8, niv9, niv10)
		VALUES (
		@i_niv1, @i_niv2, @i_niv3, @i_niv4, @i_niv5,
		@i_niv6, @i_niv7, @i_niv8, @i_niv9, @i_niv10)
		if @@ERROR > 0
		begin
			RAISERROR ('Error al insertar los niveles',16,1)
		end
		else
		begin
			select top 1 @o_id = id
			from nivelesCuentas
			return @o_id
		end
	end
	if @i_operacion = 'U'
	begin
		UPDATE nivelesCuentas 
		set niv1 = @i_niv1, niv2 = @i_niv2, niv3 = @i_niv3, niv4 = @i_niv4, niv5= @i_niv5,
		niv6 = @i_niv6, niv7 = @i_niv7, niv8 = @i_niv8, niv9 = @i_niv9, niv10 = @i_niv10
		where id =  @i_id
		if @@ERROR > 0
		begin
			RAISERROR ('Error al modificar la cuenta',16,1)
		end
	end
	if @i_operacion = 'D'
	begin
		DELETE nivelesCuentas 
		where id =  @i_id
		if @@ERROR > 0
		begin
			RAISERROR ('Error al modificar la cuenta',16,1)
		end
	end
END