USE [model]
GO

/****** Object:  Table [dbo].[testDetails]    Script Date: 15/08/2021 21:56:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[testDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](20) NULL,
	[Sobrenome] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[DataNascimento] [datetime2](7) NOT NULL,
	[Escolaridade] [nvarchar](20) NULL,
 CONSTRAINT [PK_testDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


