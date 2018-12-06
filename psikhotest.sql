SET ANSI_PADDING ON
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO 

CREATE DATABASE [psihotest]
GO

USE [psihotest]
GO

CREATE TABLE [DBO].[yser]
(
[id_yser] INT NOT NULL IDENTITY (1,1),
[laginus] varchar(max) NOT NULL,
[parol] varchar(max) NOT NULL,
[isadmin] int NOT NULL,
constraint [id_yser] PRIMARY KEY CLUSTERED
	([id_yser] ASC) on [PRIMARY],
)

INSERT into dbo.yser(laginus,parol,isadmin)
Values ('admin','admin','1');
INSERT into dbo.yser(laginus,parol,isadmin)
Values ('test','test','0');
go

CREATE PROCEDURE [DBO ].[yser_add]
(
@laginus varchar(max),
@parol varchar(max),
@isadmin varchar(max)
)
AS
	insert into [dbo].[yser]([laginus],[parol],[isadmin]) values((@laginus),(@parol),(@isadmin));
go

CREATE PROCEDURE [DBO ].[yser_update]
(
@id_yser int,
@laginus varchar(max),
@parol varchar(max),
@isadmin varchar(max)
)
AS
	update [dbo].yser
	set
	laginus=@laginus,
	parol=@parol,
	isadmin=@isadmin
	where id_yser = @id_yser
go
