﻿CREATE TABLE [dbo].[ApplicationVersion]
(
	[VersionNumber] VARCHAR(50) NOT NULL, 
	[EnvironmentId] INT NOT NULL FOREIGN KEY REFERENCES [Environment](Id),
	[ModuleId] INT FOREIGN KEY REFERENCES [Modules](Id),
    [FirstEncountered] DATETIME NOT NULL, 
    [LastEncountered] DATETIME NOT NULL, 
    CONSTRAINT [PK_ApplicationVersion] PRIMARY KEY NONCLUSTERED ([VersionNumber], [EnvironmentId], [ModuleId]) 
)

GO

CREATE CLUSTERED INDEX [IX_ApplicationVersion_Column] ON [dbo].[ApplicationVersion] ([FirstEncountered])
