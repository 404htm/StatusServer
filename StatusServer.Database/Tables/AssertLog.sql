CREATE TABLE [dbo].[AssertLog]
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
	--      Assert Specific Properties      --
	------------------------------------------

	[Condition] VARCHAR(500),
	[Message] VARCHAR(500),
	CONSTRAINT [FK_AssertLog_ApplicationVersion] FOREIGN KEY ([Version], [ApplicationId], [EnvironmentId], [ModuleId]) REFERENCES [ApplicationVersion]([VersionNumber], [ApplicationId], [EnvironmentId], [ModuleId])


)
