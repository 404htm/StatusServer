CREATE TABLE [dbo].[Environments]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[ApplicationId] INT NOT NULL FOREIGN KEY REFERENCES [Applications](Id),
	[Name] Varchar(100),
	[Notes] Varchar(Max),
	[HealthCheckUrl] Varchar(500), 
    [DisplayColor] CHAR(7) NULL
)
