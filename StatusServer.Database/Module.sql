CREATE TABLE [dbo].[Modules]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[ApplicationId] INT NOT NULL FOREIGN KEY REFERENCES [Application](Id),
	[Name] Varchar(200),
	[Type] Varchar(50), 
    [Notes] VARCHAR(MAX) NULL
)
