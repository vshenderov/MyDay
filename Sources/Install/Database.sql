--MYDAY database
USE [master]
GO
CREATE DATABASE MyDay
GO
USE [MyDay]
GO

---PERSONS table
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF

--TOOLS table 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tool](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](64) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF

---PERSONTOOL table
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonTool](
	[PersonId] [int] NOT NULL,
	[ToolId] [int] NOT NULL,
	[Login] [varchar](255) NOT NULL,
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[PersonTool]  WITH CHECK ADD  CONSTRAINT [FK_PersonTool_Tool] FOREIGN KEY([ToolId])
REFERENCES [dbo].[Tool] ([Id])
GO
ALTER TABLE [dbo].[PersonTool] CHECK CONSTRAINT [FK_PersonTool_Tool]
GO
ALTER TABLE [dbo].[PersonTool]  WITH CHECK ADD  CONSTRAINT [FK_PersonTool_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[PersonTool] CHECK CONSTRAINT [FK_PersonTool_Person]

---SAMPLE data
insert into Person(Name,Email)
values('Valentin Shenderov','v.shenderov@colours.nl')

insert into Person(Name,Email)
values('Igor Sivakov','i.sivakov@colours.nl')

insert into Person(Name,Email)
values('Yuliya Kaborda','y.kaborda@colours.nl')

insert into Person(Name,Email)
values('Nicolle Severens','n.severens@colours.nl')

insert into Tool(Name)
values('TargetProcess')

insert into Tool(Name)
values('GitHub')

insert into Tool(Name)
values('Instagram')