CREATE TABLE [dbo].[ApplicationVersion]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[ApplicationId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Application](Id), 
	--[ModuleId
    [VersionNumber] VARCHAR(50) NULL, 
    [FirstEncountered] DATETIME NOT NULL, 
    [LastEncountered] DATETIME NOT NULL
)
