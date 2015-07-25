﻿CREATE TABLE [dbo].[Errors]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[Time] DATETIME NOT NULL,
	[Handled] Bit NOT NULL,

	[ApplicationId] INT NOT NULL FOREIGN KEY REFERENCES [Applications](Id),
	[EnvironmentId] INT NOT NULL,
	[ModuleId] INT FOREIGN KEY REFERENCES [Modules](Id),
	[UserName] VARCHAR(500) NULL,

	[LineNumber] INT NULL,
	[MemberName] VARCHAR(500),
	
	[DisplayMessage] VARCHAR(MAX) NULL,
    [Message] VARCHAR(MAX) NULL,
	[ExceptionType] VARCHAR(MAX) NULL,
	[ExceptionDetail] XML NULL, 
    
)
