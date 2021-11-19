USE [MedDB]
GO

/****** Object:  Table [dbo].[report]    Script Date: 10-Jul-20 11:22:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[report](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[report] [image] NULL,
	[rtype] [nvarchar](50) NOT NULL,
	[date] [date] NOT NULL,
	[p_id] [int] NOT NULL,
	[upload] [bit] NOT NULL,
 CONSTRAINT [PK_report] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[report] ADD  CONSTRAINT [DF_report_upload]  DEFAULT ((0)) FOR [upload]
GO

