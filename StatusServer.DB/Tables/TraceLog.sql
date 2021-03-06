﻿CREATE TABLE [dbo].[TraceLog]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
	[Token] UNIQUEIDENTIFIER DEFAULT newID() NOT NULL,
	[Time] DATETIME NOT NULL,
	[UserName] VARCHAR(500) NULL,

	[EnvironmentId] INT NOT NULL FOREIGN KEY REFERENCES [Environment](Id),
	[ModuleId] INT FOREIGN KEY REFERENCES [Modules](Id),
	[Version] VARCHAR(50),

	[LineNumber] INT NULL,
	[MemberName] VARCHAR(500),
	[FileName] VARCHAR(1000),

	------------------------------------------
	--     TraceLog Specific Properties     --
	------------------------------------------
	[Message] VARCHAR(1000), 
    CONSTRAINT [FK_TraceLog_ApplicationVersion] FOREIGN KEY ([Version], [EnvironmentId], [ModuleId]) REFERENCES [ApplicationVersion]([VersionNumber], [EnvironmentId], [ModuleId])
)
