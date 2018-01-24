use CursoFerias

INSERT INTO [dbo].[ENDERECOS]
	VALUES(14403-130, 'CAETANO LOMBARDI', 'PQ. PROGRESSO', 'FRANCA', 'SP')

SELECT NOME,
	   SUM(PRECO) AS 'SOMA'
	FROM [dbo].[PRODUTOS] 
	GROUP BY NOME
	HAVING SUM(PRECO) > 50.00
	

INSERT INTO [dbo].[PRODUTOS]
VALUES('TECLADO', 28, 20)


INSERT INTO [dbo].[CLIENTES](COD_ENDERECO, CPF, NOME, NUMERO)
	VALUES(1, '429.141.268-16', 'CAIRO', 2131)

SELECT * FROM [dbo].[CLIENTES]
	WHERE COMPLEMENTO IS NOT NULL



UPDATE [dbo].[CLIENTES]
		SET COMPLEMENTO = 'CASA'
		WHERE COD_CLIENTE = 1


DELETE FROM [dbo].[PRODUTOS]
		WHERE COD_PRODUTO = 1