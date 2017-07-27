USE MAIN_08312016_DUMMY


--SELECT * FROM dbo.[_ISync_Details] 


	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
SELECT TOP 100 'CLIENTDEPENDENTS', DependentsID, 0, '' FROM dbo.ClientDependents 

--
--SELECT * FROM ClientDependents


	--DEPENDENTSID
	INSERT INTO dbo.[_ISync_Details]
		 ( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
SELECT TOP 100 'CLIENTDEPENDENTS2', fkDependentsID, 0, '' FROM dbo.clientDependents2
	--FKDEPENDENTSID
	

	INSERT INTO dbo.[_ISync_Details]
		 ( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
SELECT TOP 100 'CUSTOMER',CustomerID, 0, '' FROM dbo.Customer
--SELECT TOP 50 * FROM dbo.Customer
	

	
	
INSERT INTO dbo.[_ISync_Details]
SELECT  TOP 100 'GLBALANCE' , 
		CONVERT(VARCHAR(50),FKACCOUNTCODEGLBAL) + '|' +
		CONVERT(varchar,  TransactionDate, 110)
		, 0 , '' 
	FROM dbo.GLBalance
--	SELECT TOP 50 * FROM dbo.GLBalance
	--FKACCOUNTCODEGLBAL, TRANSACTIONDATE


 INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
SELECT TOP 100 'INSURANCEACCOUNT', InsuranceID, 0, '' FROM _INSURANCEACCOUNT 
	-- InsuranceID
	
	
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
SELECT TOP 100 'LOANACCOUNT', AccountNumber, 0, '' FROM dbo.LoanAccount
--	ACCOUNTNUMBER


	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
SELECT TOP 100 'LOANCOMAKERACCOUNT', FKAccountNumberComaker, 0, '' FROM dbo.LoanComakerAccount
	--FKACCOUNTNUMBERCOMAKER
	
	
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
SELECT TOP 100 'LOANINSTALLMENT', 
		CONVERT(VARCHAR(30),FKAccountNumberInst) + '|' + 
		CONVERT(VARCHAR(30),InstallmentNumber), 
		0,
		'' FROM dbo.LoanInstallment
	--FKACCOUNTNUMBERINST, INSTALLMENTNUMBER
--	SELECT TOP 10 * FROM dbo.LoanInstallment
	
INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
SELECT TOP 100  'LOANPROTECTIONACCOUNT', FKAccountNumber, 0, '' FROM dbo.LoanProtectionAccount
	--FKACCOUNTNUMBER
	
	
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
SELECT TOP 100 'LOANTRANMASTER', 
		FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar,  TransactionDate, 110) + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0, ''
		 FROM dbo.LoanTranMaster
	--FKACCOUNTNUMBERTRANSACTION, TRANSACTIONNO, TRANSACTIONDATE, AMOUNT
--	SELECT TOP 10 * FROM LoanTranMaster
	
	
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
SELECT TOP 100 'MORTUARYDETAILS', 
		FKCustomerIDAccount + '|' +
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar,TransactionDate, 110) + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		''
 FROM dbo.MortuaryDetails
	--FKCUSTOMERIDACCOUNT, TRANSACTIONNO, TRANSACTIONDATE, AMOUNT
	
--	
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
SELECT TOP 100 'MORTUARYHEADER', FKCustomerIDAccount, 0 ,'' FROM dbo.MortuaryHEADER
	--FKCUSTOMERIDACCOUNT
	
	
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
SELECT TOP 100 'SATRANSACTION',
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar, TransactionDate, 110) + '|' +
	    FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		''
FROM dbo.SATransaction
	--TRANSACTIONNO, TRANSACTIONDATE, FKACCOUNTNUMBERTRANSACTION, AMOUNT
	
	
	
	
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
SELECT TOP 100 'SAVINGSACCOUNT', AccountNumber, 0, '' FROM dbo.SavingsAccount
	--ACCOUNTNUMBER, 
	
	
	

	
	
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
SELECT TOP 100 'SHARETRANSACTION',
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar, TransactionDate, 110) + '|' +
	    FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		''
 FROM dbo.ShareTransaction
	--TRANSACTIONNO, TRANSACTIONDATE, FKACCOUNTNUMBERTRANSACTION, AMOUNT
	
	
	
	
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
SELECT TOP 100 'SLBALANCE', 
		CONVERT(varchar, TransactionDate, 110) + '|' +
		FKSLCodeSLBal,
		0,
		''
  FROM dbo.SLBalance
	--FKSACODESLBAL, TRANSACTIONDATE
	
	
--	
	
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
SELECT TOP 100 'TDACCOUNT', AccountNumber, 0, '' FROM dbo.TDAccount
	--ACCOUNTNUMBER
	
	
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
SELECT TOP 100 'TDTRANSACTION',
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar, TransactionDate, 110) + '|' +
	    FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		'' FROM dbo.TDTransaction
--		




