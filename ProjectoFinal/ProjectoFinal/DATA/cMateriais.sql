USE [TICKETS]
GO

/****** Object:  Table [dbo].[Materiais]    Script Date: 04/05/2017 16:10:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Materiais](
	[partnumber] [nvarchar](10) NOT NULL,
	[name] [nvarchar](50) NULL,
	[supplier] [nvarchar](50) NULL,
	[price] [decimal](18, 2) NULL,
	[issoftware] [bit] NOT NULL,
	[expires] [datetime] NULL
) ON [PRIMARY]

GO


