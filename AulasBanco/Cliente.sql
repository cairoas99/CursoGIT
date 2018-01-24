IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_SelClientes]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_SelClientes]
GO

CREATE PROCEDURE [dbo].[SP_SelClientes]
	
	AS

	/*
		Arquivo fonte: Clientes.sql
				Autor: EU
				 Data: 22/01/2018
			 Objetivo: Seleciona Clientes cadastrados

			  Exemplo: EXEC [dbo].[SP_SelClientes]
	*/
	BEGIN
		
		SELECT CodigoCliente,
			   CodigoEndereco,
			   CPF,
			   Nome,
			   Telefone,
			   Email
			FROM [dbo].[Clientes]

	END

GO

--*#*#**##**#*#*#*####*#**#*#*#*#*#*#*#**#*##*#*#**##**#******************###############***************######


IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_SelDadosCliente]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_SelDadosCliente]
GO

CREATE PROCEDURE [dbo].[SP_SelDadosCliente]
	@CodigoCliente int
	AS

	/*
		Arquivo fonte: Clientes.sql
				Autor: EU
				 Data: 22/01/2018
			 Objetivo: Seleciona de um cliente especifico cadastrados
			 Retornos: 0 - Processamento OK
					   1 - Falha ao inserir Produto 

			  Exemplo: EXEC [dbo].[SP_SelDadosClientes] 1
	*/
	BEGIN
		
		SELECT c.CodigoCliente,
			   c.CPF,
			   c.Nome,
			   c.Telefone,
			   c.Email,
			   c.Numero,
			   c.Complemento,
			   e.CodigoEndereco,
			   e.Cep,
			   e.Logradouro,
			   e.Cidade,
			   e.UF
			FROM [dbo].[Clientes] c
				LEFT OUTER JOIN [dbo].[Enderecos] e 
					ON  c.CodigoEndereco = e.CodigoEndereco
			WHERE c.CodigoCliente = @CodigoCliente

	END

GO

--*#*#**##**#*#*#*####*#**#*#*#*#*#*#*#**#*##*#*#**##**#******************###############***************######


IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_InsCliente]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_InsCliente]
GO

CREATE PROCEDURE [dbo].[SP_InsCliente]
	@CPF			varchar(14),
	@Nome			varchar(50),
	@Telefone		varchar(15) = null,
	@Email			varchar(50) = null,
	@Numero			smallint,
	@Complemento	varchar(30),
	@CEP			int,
	@Logradouro		varchar(50),
	@Bairro			varchar(30),
	@Cidade			varchar(30),
	@UF				char(2)
	AS

	/*
		Arquivo fonte: Clientes.sql
				Autor: EU
				 Data: Insere um cliente novo
			 Retornos: 0 - Processamento OK
					   1 - Falha ao inserir Endereço
					   2 - Falha ao inserir Cliente 

			  Exemplo: EXEC [dbo].[SP_InsCliente]
				'42914126816', 'Cairo', Null, NULL, 1234, NULL, 14403130, 'Av. Paulo VI', 'PQ. Progresso', 'Franca', 'SP'



	*/
	BEGIN
		BEGIN TRANSACTION

		DECLARE @CodigoEndereco int
		
			INSERT INTO [dbo].[Enderecos]
				VALUES(@CEP, @Logradouro, @Bairro, @Cidade, @UF)

			
			IF @@ERROR <> 0 OR @@ROWCOUNT = 0
				BEGIN
					RETURN 1
					ROLLBACK TRANSACTION
				END

			SET @CodigoEndereco = SCOPE_IDENTITY()

			INSERT INTO [dbo].[Clientes]
				VALUES(@CodigoEndereco, @CPF, @Nome, @Telefone, @Email, @Numero, @Complemento)
				
			IF @@ERROR <> 0 OR @@ROWCOUNT = 0
				BEGIN
					RETURN 2
					ROLLBACK TRANSACTION
				END


					RETURN 0

	END

GO


--*#*#**##**#*#*#*####*#**#*#*#*#*#*#*#**#*##*#*#**##**#******************###############***************######


IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_UpdCliente]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_UpdCliente]
GO

CREATE PROCEDURE [dbo].[SP_UpdCliente]
	@CodigoCliente	int,
	@CodigoEndereco int,
	@CPF			varchar(14),
	@Nome			varchar(50),
	@Telefone		varchar(15) = null,
	@Email			varchar(50) = null,
	@Numero			smallint,
	@Complemento	varchar(30),
	@CEP			int,
	@Logradouro		varchar(50),
	@Bairro			varchar(30),
	@Cidade			varchar(30),
	@UF				char(2)
	AS

	/*
		Arquivo fonte: Clientes.sql
				Autor: EU
				 Data: Insere um cliente novo
			 Retornos: 0 - Processamento OK
					   1 - Falha ao atualizar Endereço
					   2 - Falha ao atualizar Cliente 

			  Exemplo: EXEC [dbo].[SP_InsCliente]
				'42914126816', 'Cairo', Null, NULL, 1234, NULL, 14403130, 'Av. Paulo VI', 'PQ. Progresso', 'Franca', 'SP'



	*/
	BEGIN
		BEGIN TRANSACTION
		
			UPDATE [dbo].[Enderecos]
				SET CEP = @CEP, 
					Logradouro = @Logradouro, 
					Bairro = @Bairro, 
					Cidade = @Cidade, 
					UF = @UF
			WHERE CodigoEndereco = @codigoEndereco

			
			IF @@ERROR <> 0 OR @@ROWCOUNT = 0
				BEGIN
					RETURN 1
					ROLLBACK TRANSACTION
				END

			SET @CodigoEndereco = SCOPE_IDENTITY()

			UPDATE [dbo].[Clientes]
				SET CPF = @CPF, 
				Nome = @Nome, 
				Telefone = @Telefone, 
				Email = @Email, 
				Numero = @Numero, 
				Complemento = @Complemento
			WHERE CodigoCliente = @CodigoCliente
				
			IF @@ERROR <> 0 OR @@ROWCOUNT = 0
				BEGIN
					RETURN 2
					ROLLBACK TRANSACTION
				END


					RETURN 0

	END

GO


---------------------------------------------------------------------------------------------------------


IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_DelCliente]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_DelCliente]
GO

CREATE PROCEDURE [dbo].[SP_DelCliente]
	@CodigoCliente int ,
	@CodigoEndereco int
	AS

	/*
		Arquivo fonte: Clientes.sql
				Autor: EU
				 Data: 19/01/2018
			 Objetivo: DELETA
			 Retornos: 0 - Processamento OK
					   1 - Exclusão não permitida, endereco vinculado a cliente
					   2 - Falha ao deletar endereco

			  Exemplo: EXEC [dbo].[SP_UptProduto] 1
	*/
	BEGIN
		BEGIN TRANSACTION
			DELETE FROM [dbo].[Clientes]
				WHERE CodigoCliente = @CodigoCliente
			

				IF @@ERROR <> 0 OR @@ROWCOUNT = 0
				BEGIN
					RETURN 1
					ROLLBACK TRANSACTION
				END
			DELETE FROM [dbo].[Enderecos]
					WHERE CodigoEndereco = @CodigoEndereco
			

			IF @@ERROR <> 0 OR @@ROWCOUNT = 0
				BEGIN
					RETURN 2
					ROLLBACK TRANSACTION
				END


			RETURN 0

	END
GO
