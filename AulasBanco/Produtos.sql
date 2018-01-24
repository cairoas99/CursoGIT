
--ORDEM DE EXECUÇÃO DOS COMANDOS
--FROM
--WHERE
--GROUP BY
--HAVING
--SELECT
--ORDER
--TOP



IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_SelProdutos]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_SelProdutos]
GO

CREATE PROCEDURE [dbo].[SP_SelProdutos]
	
	AS

	/*
		Arquivo fonte: Produto.sql
				Autor: EU
				 Data: 19/01/2018
			 Objetivo: Seleciona produtos cadastrados

			  Exemplo: EXEC [dbo].[SP_SelProdutos]
	*/
	BEGIN
		
		SELECT CODIGO_PRODUTO,
			   NOME,
			   PRECO,
			   ESTOQUE
			FROM [dbo].[PRODUTOS]

	END

GO


---------------------------------------------------------------------------------------------------------


IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_SelDadosProdutos]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_SelDadosProdutos]
GO

CREATE PROCEDURE [dbo].[SP_SelDadosProduto]
	@CodigoProduto INT
	AS

	/*
		Arquivo fonte: Produto.sql
				Autor: EU
				 Data: 19/01/2018
			 Objetivo: Seleciona os dados referentes a um produto

			  Exemplo: EXEC [dbo].[SP_SelDadosProduto]
	*/
	BEGIN
		
		SELECT Nome,
			   Preco,
			   Estoque
			FROM [dbo].[Produtos]
			WHERE CodigoProduto = @CodigoProduto

	END
GO


---------------------------------------------------------------------------------------------------------


IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_InsProduto]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_InsProduto]
GO

CREATE PROCEDURE [dbo].[SP_InsProduto]
	@Nome		varchar(50),
	@Preco		decimal(10,2),
	@Estoque	smallint 
	AS

	/*
		Arquivo fonte: Produto.sql
				Autor: EU
				 Data: 19/01/2018
			 Objetivo: Cadastra produtos na tabela
			 Retornos: 0 - Processamento OK
					   1 - Falha ao inserir Produto 

			  Exemplo: EXEC [dbo].[SP_InsProduto] 'TECLADO', 10.00, 42
	*/
	BEGIN
		
		INSERT INTO [dbo].[Produtos]
			VALUES(@Nome, @Preco, @Estoque)

		IF @@ERROR <> 0 OR @@ROWCOUNT = 0
			RETURN
			 
		RETURN 0

	END
GO



---------------------------------------------------------------------------------------------------------


IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_UptProduto]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_UptProduto]
GO

CREATE PROCEDURE [dbo].[SP_UptProduto]
	@CodigoProduto int,
	@Nome varchar(50),
	@Preco decimal(10,2),
	@Estoque smallint 
	AS

	/*
		Arquivo fonte: Produto.sql
				Autor: EU
				 Data: 19/01/2018
			 Objetivo: Altera produtos na tabela
			 Retornos: 0 - Processamento OK
					   1 - Falha ao Alterar Produto 

			  Exemplo: EXEC [dbo].[SP_UptProduto] 1, 'TECLADO RAZER', 10.50, 38
	*/
	BEGIN
		
		UPDATE [dbo].[Produtos]
			SET
				Nome = @Nome, 
				Preco = @Preco, 
				Estoque = @Estoque
			WHERE(Produtos.CodigoProduto = @CodigoProduto)

		IF @@ERROR <> 0 OR @@ROWCOUNT = 0
			RETURN 1
			 
		RETURN 0

	END
GO



---------------------------------------------------------------------------------------------------------


IF EXISTS (SELECT TOP 1 1 FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[SP_DelProduto]') AND objectproperty(id, N'IsPROCEDURE') = 1)
	DROP PROCEDURE [dbo].[SP_DelProduto]
GO

CREATE PROCEDURE [dbo].[SP_DelProduto]
	@CodigoProduto int 
	AS

	/*
		Arquivo fonte: Produto.sql
				Autor: EU
				 Data: 19/01/2018
			 Objetivo: DELETA
			 Retornos: 0 - Processamento OK
					   1 - Exclusão não permitida, produto vinculado a uma venda
					   2 - Falha ao deletar o produto

			  Exemplo: EXEC [dbo].[SP_UptProduto] 1
	*/
	BEGIN
		
		IF EXISTS (SELECT TOP 1 1 
					FROM [dbo].[VendaItens]
					WHERE CodigoProduto = @CodigoProduto)
			RETURN 1

		DELETE FROM [dbo].[Produtos]
			WHERE CodigoProduto = @CodigoProduto

		IF @@ERROR <> 0 OR @@ROWCOUNT = 0
			RETURN 2
			 
		RETURN 0

	END
GO




