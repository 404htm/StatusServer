CREATE TABLE [dbo].[Error]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
	[Token] UNIQUEIDENTIFIER DEFAULT newID() NOT NULL,
	[Time] DATETIME NOT NULL,
	[UserName] VARCHAR(500) NULL,

	[ApplicationId] INT NOT NULL FOREIGN KEY REFERENCES [Application](Id),
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
	[ExceptionDetail] XML NULL
)

GO

CREATE UNIQUE INDEX [IX_Error_Token] ON [dbo].[Error] ([Token])
