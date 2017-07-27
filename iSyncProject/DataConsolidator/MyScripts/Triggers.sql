USE [MAIN_08312016_DUMMY]
GO


CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
		
go






CREATE TRIGGER _ISync_ClientDependents ON  ClientDependents
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------





IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  		  INSERT INTO dbo.[_ISync_Details] 
			( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
			SELECT 'CLIENTDEPENDENTS', DependentsID, 0, '' FROM INSERTED
       
	 ELSE
		  INSERT INTO dbo.[_ISync_Details] 
			( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
			SELECT 'CLIENTDEPENDENTS', DependentsID, 0, '' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
		   INSERT INTO dbo.[_ISync_Details] 
			( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
			SELECT 'CLIENTDEPENDENTS', DependentsID, 0, '' FROM DELETED
	END













GO


CREATE TRIGGER _ISync_ClientDependents2 ON  clientDependents2
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------

IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  		 INSERT INTO dbo.[_ISync_Details]
		 ( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
			SELECT 'CLIENTDEPENDENTS2', fkDependentsID, 0, '' FROM INSERTED
       
	 ELSE
		   INSERT INTO dbo.[_ISync_Details]
		 ( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
			SELECT 'CLIENTDEPENDENTS2', fkDependentsID, 0, '' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
		   INSERT INTO dbo.[_ISync_Details]
		 ( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
			SELECT 'CLIENTDEPENDENTS2', fkDependentsID, 0, '' FROM DELETED
	END












GO
CREATE TRIGGER _ISync_Customer ON  Customer
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------

IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  		INSERT INTO dbo.[_ISync_Details]
		 ( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
		SELECT 'CUSTOMER',CustomerID, 0, '' FROM INSERTED
       
	 ELSE
		 INSERT INTO dbo.[_ISync_Details]
		 ( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
		 SELECT 'CUSTOMER',CustomerID, 0, '' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
		  INSERT INTO dbo.[_ISync_Details]
		 ( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
		  SELECT 'CUSTOMER',CustomerID, 0, '' FROM DELETED
	END





GO
CREATE TRIGGER _ISync_GLBalance ON  GLBalance
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------

IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  		INSERT INTO dbo.[_ISync_Details]
		SELECT 'GLBALANCE' , 
		CONVERT(VARCHAR(50),FKACCOUNTCODEGLBAL) + '|' +
		CONVERT(varchar,  TransactionDate, 110)
		, 0 , '' 
		FROM INSERTED
       
	 ELSE
		INSERT INTO dbo.[_ISync_Details]
		SELECT 'GLBALANCE' , 
		CONVERT(VARCHAR(50),FKACCOUNTCODEGLBAL) + '|' +
		CONVERT(varchar,  TransactionDate, 110)
		, 0 , '' 
		FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
		INSERT INTO dbo.[_ISync_Details]
		SELECT 'GLBALANCE' , 
		CONVERT(VARCHAR(50),FKACCOUNTCODEGLBAL) + '|' +
		CONVERT(varchar,  TransactionDate, 110)
		, 0 , '' 
		FROM DELETED
	END





GO
CREATE TRIGGER _ISync_INSURANCEACCOUNT ON  _INSURANCEACCOUNT
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------





IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  	 INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
		SELECT 'INSURANCEACCOUNT', InsuranceID, 0, '' FROM INSERTED
       
	 ELSE
	 
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
		SELECT 'INSURANCEACCOUNT', InsuranceID, 0, '' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
		INSERT INTO dbo.[_ISync_Details] 
		( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
		SELECT 'INSURANCEACCOUNT', InsuranceID, 0, '' FROM DELETED
	END






GO
CREATE TRIGGER _ISync_LoanAccount ON  LoanAccount
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------


DECLARE @Stat AS VARCHAR(10)
	SET @Stat = (SELECT SystemStatus FROM dbo.InstitutionParameter)

IF @Stat = 'ACTIVE'
	BEGIN
	
	IF EXISTS(SELECT * FROM inserted)
		 IF EXISTS(SELECT * FROM deleted)
	  
  		 INSERT INTO dbo.[_ISync_Details] 
		( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
		SELECT 'LOANACCOUNT', AccountNumber, 0, '' FROM INSERTED
	       
		 ELSE
		 
		INSERT INTO dbo.[_ISync_Details] 
		( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
		SELECT 'LOANACCOUNT', AccountNumber, 0, '' FROM INSERTED
	ELSE
		 IF EXISTS(SELECT * FROM deleted)
	    
			INSERT INTO dbo.[_ISync_Details] 
		( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
		SELECT 'LOANACCOUNT', AccountNumber, 0, '' FROM DELETED
		END
END







GO
CREATE TRIGGER _ISync_LoanComakerAccount ON  LoanComakerAccount
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------





IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  	 INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'LOANCOMAKERACCOUNT', FKAccountNumberComaker, 0, '' FROM INSERTED
       
	 ELSE
	 
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'LOANCOMAKERACCOUNT', FKAccountNumberComaker, 0, '' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'LOANCOMAKERACCOUNT', FKAccountNumberComaker, 0, '' FROM DELETED
	END





GO
CREATE TRIGGER _ISync_LoanInstallment ON  LoanInstallment
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------


DECLARE @Stat AS VARCHAR(10)
	SET @Stat = (SELECT SystemStatus FROM dbo.InstitutionParameter)

IF @Stat = 'ACTIVE'
	BEGIN


	IF EXISTS(SELECT * FROM inserted)
		 IF EXISTS(SELECT * FROM deleted)
	  
  		 INSERT INTO dbo.[_ISync_Details] 
		( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
		SELECT 'LOANINSTALLMENT', 
			CONVERT(VARCHAR(30),FKAccountNumberInst) + '|' + 
			CONVERT(VARCHAR(30),InstallmentNumber), 
			0,
			'' FROM INSERTED
	       
		 ELSE
		 
		INSERT INTO dbo.[_ISync_Details] 
		( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
		SELECT 'LOANINSTALLMENT', 
			CONVERT(VARCHAR(30),FKAccountNumberInst) + '|' + 
			CONVERT(VARCHAR(30),InstallmentNumber), 
			0,
			'' FROM INSERTED
	ELSE
		 IF EXISTS(SELECT * FROM deleted)
	    
		INSERT INTO dbo.[_ISync_Details] 
		( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
		SELECT 'LOANINSTALLMENT', 
			CONVERT(VARCHAR(30),FKAccountNumberInst) + '|' + 
			CONVERT(VARCHAR(30),InstallmentNumber), 
			0,
			'' FROM DELETED
		END
END




GO
CREATE TRIGGER _ISync_LoanProtectionAccount ON  LoanProtectionAccount
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------





IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'LOANPROTECTIONACCOUNT', FKAccountNumber, 0, '' FROM INSERTED
       
	 ELSE
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'LOANPROTECTIONACCOUNT', FKAccountNumber, 0, '' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'LOANPROTECTIONACCOUNT', FKAccountNumber, 0, '' FROM DELETED
	END






GO
CREATE TRIGGER _ISync_LoanTranMaster ON  LoanTranMaster
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------





IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'LOANTRANMASTER', 
		FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar,  TransactionDate, 110) + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0, ''
		 FROM INSERTED
       
	 ELSE
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'LOANTRANMASTER', 
		FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar,  TransactionDate, 110) + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0, ''
		 FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'LOANTRANMASTER', 
		FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar,  TransactionDate, 110) + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0, ''
		 FROM DELETED
	END





GO
CREATE TRIGGER _ISync_MortuaryDetails ON  MortuaryDetails
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------





IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'MORTUARYDETAILS', 
		FKCustomerIDAccount + '|' +
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar,TransactionDate, 110) + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		''
	FROM INSERTED
       
	 ELSE
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'MORTUARYDETAILS', 
		FKCustomerIDAccount + '|' +
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar,TransactionDate, 110) + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		''
	FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'MORTUARYDETAILS', 
		FKCustomerIDAccount + '|' +
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar,TransactionDate, 110) + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		''
	 FROM DELETED
	END









GO
CREATE TRIGGER _ISync_MortuaryHEADER ON  MortuaryHEADER
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------





IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'MORTUARYHEADER', FKCustomerIDAccount, 0 ,'' FROM INSERTED
       
	 ELSE
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'MORTUARYHEADER', FKCustomerIDAccount, 0 ,'' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'MORTUARYHEADER', FKCustomerIDAccount, 0 ,'' FROM DELETED
	END




GO
CREATE TRIGGER _ISync_SATransaction ON  SATransaction
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------





IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'SATRANSACTION',
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar, TransactionDate, 110) + '|' +
	    FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		''
	FROM INSERTED
       
	 ELSE
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'SATRANSACTION',
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar, TransactionDate, 110) + '|' +
	    FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		''
	FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
	SELECT 'SATRANSACTION',
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar, TransactionDate, 110) + '|' +
	    FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		''
	FROM DELETED
	END









GO
CREATE TRIGGER _ISync_SavingsAccount ON  SavingsAccount
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------


DECLARE @Stat AS VARCHAR(10)
	SET @Stat = (SELECT SystemStatus FROM dbo.InstitutionParameter)

IF @Stat = 'ACTIVE'
	BEGIN


IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  		  INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
		SELECT 'SAVINGSACCOUNT', AccountNumber, 0, '' FROM INSERTED
       
	 ELSE
		  INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
		SELECT 'SAVINGSACCOUNT', AccountNumber, 0, '' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
		   INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
		SELECT 'SAVINGSACCOUNT', AccountNumber, 0, '' FROM DELETED
	END
END




GO
CREATE TRIGGER _ISync_ShareTransaction ON  ShareTransaction
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------





IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'SHARETRANSACTION',
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar, TransactionDate, 110) + '|' +
	    FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		''
	FROM INSERTED
       
	 ELSE
		INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'SHARETRANSACTION',
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar, TransactionDate, 110) + '|' +
	    FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		''
	from INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'SHARETRANSACTION',
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar, TransactionDate, 110) + '|' +
	    FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		'' 
	FROM DELETED
	END








GO
CREATE TRIGGER _ISync_SLBalance ON  SLBalance
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------

IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'SLBALANCE', 
		CONVERT(varchar, TransactionDate, 110) + '|' +
		FKSLCodeSLBal,
		0,
		''
	 FROM INSERTED
       
	 ELSE
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'SLBALANCE', 
		CONVERT(varchar, TransactionDate, 110) + '|' +
		FKSLCodeSLBal,
		0,
		''
	 FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'SLBALANCE', 
		CONVERT(varchar, TransactionDate, 110) + '|' +
		FKSLCodeSLBal,
		0,
		''
	FROM DELETED
	END

GO



CREATE TRIGGER _ISync_TDAccount ON  TDAccount
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------



DECLARE @Stat AS VARCHAR(10)
	SET @Stat = (SELECT SystemStatus FROM dbo.InstitutionParameter)

IF @Stat = 'ACTIVE'
	BEGIN



IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'TDACCOUNT', AccountNumber, 0, '' FROM INSERTED
       
	 ELSE
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'TDACCOUNT', AccountNumber, 0, '' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'TDACCOUNT', AccountNumber, 0, '' FROM DELETED
	END
END



GO
CREATE TRIGGER _ISync_TDTransaction ON  TDTransaction
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------

IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'TDTRANSACTION',
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar, TransactionDate, 110) + '|' +
	    FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		'' FROM INSERTED
       
	 ELSE
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'TDTRANSACTION',
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar, TransactionDate, 110) + '|' +
	    FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		'' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'TDTRANSACTION',
		CONVERT(VARCHAR(MAX),TransactionNo ) + '|' +
		CONVERT(varchar, TransactionDate, 110) + '|' +
	    FKAccountNumberTransaction + '|' +
		CONVERT(VARCHAR(MAX),Amount ),
		0,
		'' FROM DELETED
	END

GO



CREATE TRIGGER _ISync_ShareAccount ON  dbo.ShareAccount
			AFTER INSERT ,UPDATE
			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------



DECLARE @Stat AS VARCHAR(10)
	SET @Stat = (SELECT SystemStatus FROM dbo.InstitutionParameter)

IF @Stat = 'ACTIVE'
	BEGIN



IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'SHAREACCOUNT', AccountNumber, 0, '' FROM INSERTED
       
	 ELSE
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'SHAREACCOUNT', AccountNumber, 0, '' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
	INSERT INTO dbo.[_ISync_Details] 
	( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)	
	SELECT 'SHAREACCOUNT', AccountNumber, 0, '' FROM DELETED

END
END

go






CREATE TRIGGER _ISync_EMPLOYMENTHISTORY ON  EmploymentHistory
			AFTER INSERT ,UPDATE			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------

IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  		  INSERT INTO dbo.[_ISync_Details] 
			( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
			SELECT 'EMPLOYMENTHISTORY', FKCustomerIDEmp, 0, '' FROM INSERTED
       
	 ELSE
		  INSERT INTO dbo.[_ISync_Details] 
			( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
			SELECT 'EMPLOYMENTHISTORY', FKCustomerIDEmp, 0, '' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
		   INSERT INTO dbo.[_ISync_Details] 
			( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
			SELECT 'EMPLOYMENTHISTORY', FKCustomerIDEmp, 0, '' FROM DELETED
	END


GO






CREATE TRIGGER _ISync_CustomerAddress ON  CustomerAddress
			AFTER INSERT ,UPDATE			
AS 
BEGIN
SET NOCOUNT ON;
			
			
---------------------- [ CHECK IF TABLE EXIST ] -------------			
	IF OBJECT_ID('_ISync_Details') IS NULL 
	BEGIN
		CREATE TABLE [dbo].[_ISync_Details](
		[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
		[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
		[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
		[DateProcessSync] [datetime] NULL
		) ON [PRIMARY]
	END
-------------------------------------------------------------

IF EXISTS(SELECT * FROM inserted)
	 IF EXISTS(SELECT * FROM deleted)
  
  		  INSERT INTO dbo.[_ISync_Details] 
			( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
			SELECT 'CUSTOMERADDRESS', 
				    CONVERT(VARCHAR(MAX),AddressID )+ '|' +
					FKCustomerIDAdd,
					0, '' FROM INSERTED
       
	 ELSE
		  INSERT INTO dbo.[_ISync_Details] 
			( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
			SELECT 'CUSTOMERADDRESS', 
				    CONVERT(VARCHAR(MAX),AddressID )+ '|' +
					FKCustomerIDAdd,
					0, '' FROM INSERTED
ELSE
	 IF EXISTS(SELECT * FROM deleted)
    
		   INSERT INTO dbo.[_ISync_Details] 
			( ProcessTableName ,DataIdentifier ,IsSuccessfulSync ,DateProcessSync)
			SELECT 'CUSTOMERADDRESS', 
				    CONVERT(VARCHAR(MAX),AddressID )+ '|' +
					FKCustomerIDAdd,
					0, '' FROM DELETED
	END


GO


