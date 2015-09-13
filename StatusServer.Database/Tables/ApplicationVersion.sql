CREATE TABLE [dbo].[ApplicationVersion]
(
	[VersionNumber] VARCHAR(50) NULL, 
	[ApplicationId] INT NOT NULL FOREIGN KEY REFERENCES [Application](Id),
	[EnvironmentId] INT NOT NULL FOREIGN KEY REFERENCES [Environment](Id),
	[ModuleId] INT FOREIGN KEY REFERENCES [Modules](Id),
    [FirstEncountered] DATETIME NOT NULL, 
    [LastEncountered] DATETIME NOT NULL
)
