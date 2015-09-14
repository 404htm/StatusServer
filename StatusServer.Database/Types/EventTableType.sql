CREATE TYPE [dbo].[EventTableType] AS TABLE
(
	[ApplicationId] INT NOT NULL,
	[EnvironmentId] INT NOT NULL,
	[ModuleId] INT,
	[Version] VARCHAR(50)
)
