USE [MedDB]
GO

/****** Object:  Table [dbo].[UInf]    Script Date: 10-Jul-20 11:23:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UInf](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[utype] [nvarchar](50) NOT NULL,
	[uname] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[father] [nvarchar](50) NOT NULL,
	[dob] [date] NOT NULL,
	[gender] [nvarchar](50) NOT NULL,
	[contact] [nvarchar](25) NOT NULL,
	[gmail] [nvarchar](50) NOT NULL,
	[blood] [nvarchar](50) NOT NULL,
	[qo] [nvarchar](100) NOT NULL,
	[address] [nvarchar](100) NOT NULL,
	[remark] [nvarchar](100) NULL,
	[image] [image] NOT NULL,
	[department] [nvarchar](50) NULL,
	[authorization] [bit] NULL,
 CONSTRAINT [PK_UInf] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[UInf] ADD  CONSTRAINT [DF_UInf_authorization]  DEFAULT ((0)) FOR [authorization]
GO

