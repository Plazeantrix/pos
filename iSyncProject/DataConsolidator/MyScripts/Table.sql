USE [MAIN_08312016_DUMMY]
GO
/****** Object:  Table [dbo].[_ISync_Details]    Script Date: 01/26/2017 15:03:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[_ISync_Details](
	[IndexId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProcessTableName] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DataIdentifier] [varchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IsSuccessfulSync] [numeric](18, 0) NOT NULL CONSTRAINT [DF_Table_1_IsSync]  DEFAULT ((0)),
	[DateProcessSync] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF