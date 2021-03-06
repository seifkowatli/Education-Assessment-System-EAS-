USE [EAS_Database]
GO
/****** Object:  Table [dbo].[Exam_Questions]    Script Date: 5/28/2018 1:41:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam_Questions](
	[Exam_Id] [int] NOT NULL,
	[Question_Id] [int] NOT NULL,
 CONSTRAINT [Exam_Questions_PK] PRIMARY KEY CLUSTERED 
(
	[Exam_Id] ASC,
	[Question_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Exam_Questions]  WITH CHECK ADD  CONSTRAINT [Exam_Questions_Exam] FOREIGN KEY([Exam_Id])
REFERENCES [dbo].[Exam] ([Exam_ID])
GO
ALTER TABLE [dbo].[Exam_Questions] CHECK CONSTRAINT [Exam_Questions_Exam]
GO
ALTER TABLE [dbo].[Exam_Questions]  WITH CHECK ADD  CONSTRAINT [Exam_Questions_Question] FOREIGN KEY([Question_Id])
REFERENCES [dbo].[Questions_Bank] ([Question_ID])
GO
ALTER TABLE [dbo].[Exam_Questions] CHECK CONSTRAINT [Exam_Questions_Question]
GO
