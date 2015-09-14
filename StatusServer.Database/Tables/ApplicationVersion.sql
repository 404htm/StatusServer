CREATE TABLE [dbo].[ApplicationVersion]
(
	[VersionNumber] VARCHAR(50) NOT NULL, 
	[ApplicationId] INT NOT NULL FOREIGN KEY REFERENCES [Application](Id),
	[EnvironmentId] INT NOT NULL FOREIGN KEY REFERENCES [Environment](Id),
	[ModuleId] INT FOREIGN KEY REFERENCES [Modules](Id),
    [FirstEncountered] DATETIME NOT NULL, 
    [LastEncountered] DATETIME NOT NULL, 
    CONSTRAINT [PK_ApplicationVersion] PRIMARY KEY NONCLUSTERED ([VersionNumber], [ApplicationId], [EnvironmentId], [ModuleId]) 
)

GO

CREATE CLUSTERED INDEX [IX_ApplicationVersion_Column] ON [dbo].[ApplicationVersion] ([FirstEncountered])
