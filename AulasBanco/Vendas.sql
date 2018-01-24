IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_SelVendas]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_SelVendas]
GO

CREATE PROCEDURE [dbo].[SP_SelVendas]
	
	AS

	/*
		Arquivo fonte: Vendas.sql
				Autor: EU
				 Data: 19/01/2018
			 Objetivo: Seleciona vendas cadastrados

			  Exemplo: EXEC [dbo].[SP_SelVenndas]
	*/
	BEGIN
		
		SELECT CodigoVenda,
			   DataVenda,
			   SubTotal,
			   Desconto,
			   Total
			FROM [dbo].[Vendas]

	END

GO


---------------------------------------------------------------------------------------------------------


IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_SelItensVendas]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_SelItensVendas]
GO

CREATE PROCEDURE [dbo].[SP_SelItensVendas]
	@CodigoVenda int
	AS

	/*
		Arquivo fonte: Vendas.sql
				Autor: EU
				 Data: 19/01/2018
			 Objetivo: Seleciona vendas cadastrados

			  Exemplo: EXEC [dbo].[SP_SelVenndas] 1 
	*/
	BEGIN
		
		SELECT v.CodigoVenda,
			   v.CodigoProduto,
			   p.Nome,
			   p.Preco ,
			   v.QuantidadeVendida,
			   (v.QuantidadeVendida * p.Preco) as Total
			FROM [dbo].[VendaItens] v
				INNER JOIN [dbo].[Produtos] p 
					ON p.CodigoProduto = v.CodigoProduto
			WHERE v.CodigoVenda = @CodigoVenda

	END

GO


---------------------------------------------------------------------------------------------------------


IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_InsVendas]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_InsVendas]
GO

CREATE PROCEDURE [dbo].[SP_InsVendas]
	@CodigoCliente int = null,
	@SubTotal	   decimal(10,2),
	@Total		   decimal(10,2),
	@Desconto	   decimal(10,2) = null,
	@Entrega	   char(1),
	@CEP		   int = null,
	@Logradouro	   varchar(50) = null,
	@Bairro        varchar(30) = null,
	@Cidade		   varchar(30) = null,
	@UF			   char(2) = null,
	@Numero		   smallint = null,
	@Complemento   varchar(30)
	AS

	/*
		Arquivo fonte: Vendas.sql
				Autor: EU
				 Data: 22/01/2018
			 Objetivo: Seleciona vendas cadastrados
		   Parametros:@Entrega
						S - Sera entregue em um endereço
						N - Sera retirado junto a compra
						C - Sera entregue no endereço do cliente

			  Exemplo: EXEC [dbo].[SP_SelVenndas]
	*/
	BEGIN
		
		DECLARE @CodigoVenda int,
				@CodigoEndereco int

		INSERT INTO [dbo].[Vendas]
			VALUES(@CodigoCliente, GETDATE(), @SubTotal, @Desconto, @Total, @Entrega)

			IF @@ERROR <> 0 OR @@ROWCOUNT = 0
				RETURN -1
		SET @CodigoVenda = SCOPE_IDENTITY()
		
		IF @Entrega = 'N'
			RETURN @CodigoVenda

		IF @Entrega = 'S'
			BEGIN
				IF NOT EXISTS (SELECT TOP 1 1
								FROM [dbo].[Enderecos]
								WHERE Cep = @CEP)
					BEGIN
						INSERT INTO [dbo].[Enderecos]
							VALUES(@CEP, @Logradouro, @Bairro, @Cidade, @UF)
						
						IF @@ERROR <> 0 OR @@ROWCOUNT = 0
							RETURN -2
						
						SET @CodigoEndereco = SCOPE_IDENTITY()
					END

			END
		ELSE
			SET @CodigoEndereco = (SELECT CodigoEndereco
										FROM [dbo].[Enderecos]
										WHERE Cep = @CEP



	END

GO


---