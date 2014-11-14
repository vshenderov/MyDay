--MYDAY database
USE [master]
GO
IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'MyDay')
BEGIN 
ALTER DATABASE [MyDay] 
SET OFFLINE 
WITH ROLLBACK IMMEDIATE;

ALTER DATABASE [MyDay]
SET ONLINE;

DROP DATABASE [MyDay]; 
END 

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
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
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
	[Name] [varchar](255) NOT NULL,
	[Icon] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Tool] PRIMARY KEY CLUSTERED 
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
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NOT NULL,
	[ToolId] [int] NOT NULL,
	[Account] [varchar](255) NOT NULL,
 CONSTRAINT [PK_PersonTool] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
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

---ACTIVITY table
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activity](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NOT NULL,
	[ToolId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Title] [varchar](MAX) NOT NULL,
	[Content] [varchar](MAX) NOT NULL,
 CONSTRAINT [PK_Activity] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_Activity_Person]
GO

ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_Tool] FOREIGN KEY([ToolId])
REFERENCES [dbo].[Tool] ([Id])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_Activity_Tool]
GO

CREATE USER [myday] FOR LOGIN [myday] WITH DEFAULT_SCHEMA=[dbo]
Go
EXEC sp_addrolemember N'db_owner', N'myday'
Go



---SAMPLE data
insert into Person(Name,Email)
values('Valentin Shenderov','v.shenderov@colours.nl')

insert into Person(Name,Email)
values('Igor Sivakov','i.sivakov@colours.nl')

insert into Person(Name,Email)
values('Yuliya Kaborda','y.kaborda@colours.nl')

insert into Person(Name,Email)
values('Nicolle Severens','n.severens@colours.nl')

insert into Tool(Name,Icon)
values('TargetProcess','tp.png')

insert into Tool(Name,Icon)
values('GitHub','gh.png')

insert into Tool(Name,Icon)
values('Instagram','ig.png')

insert into PersonTool(PersonId,ToolId,Account)
values(3,1,'3')

insert into PersonTool(PersonId,ToolId,Account)
values(1,1,'5')

insert into PersonTool(PersonId,ToolId,Account)
values(2,1,'11')

insert into PersonTool(PersonId,ToolId,Account)
values(1,2,'valikvs')