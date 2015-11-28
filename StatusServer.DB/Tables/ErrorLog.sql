CREATE TABLE [dbo].[ErrorLog]
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
	--    Exception Specific Properties     --
	------------------------------------------

	[Handled] Bit NOT NULL,
	[DisplayMessage] VARCHAR(MAX) NULL,
    [Message] VARCHAR(MAX) NULL,
	[ExceptionType] VARCHAR(MAX) NULL,
	[ExceptionDetail] XML NULL,
	CONSTRAINT [FK_ErrorLog_ApplicationVersion] FOREIGN KEY ([Version], [EnvironmentId], [ModuleId]) REFERENCES [ApplicationVersion]([VersionNumber], [EnvironmentId], [ModuleId])
)

GO

CREATE UNIQUE INDEX [IX_Error_Token] ON [dbo].[ErrorLog] ([Token])

