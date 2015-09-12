CREATE TABLE [dbo].[Environment]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[ApplicationId] INT NOT NULL FOREIGN KEY REFERENCES [Application](Id),
	[Name] Varchar(100),
	[Notes] Varchar(Max),
	[HealthCheckUrl] Varchar(500), 
    [DisplayColor] CHAR(7) NULL
)
