USE [MedDB]
GO

/****** Object:  Table [dbo].[Appointment]    Script Date: 10-Jul-20 11:22:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Appointment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[p_id] [int] NOT NULL,
	[d_id] [int] NOT NULL,
	[prescription] [text] NULL,
	[prescribed] [bit] NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Appointment] ADD  CONSTRAINT [DF_Appointment_authorization]  DEFAULT ((0)) FOR [prescribed]
GO

