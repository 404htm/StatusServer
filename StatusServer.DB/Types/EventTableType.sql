CREATE TYPE [dbo].[EventTableType] AS TABLE
(
	[EnvironmentId] INT NOT NULL,
	[ModuleId] INT,
	[Version] VARCHAR(50)
)
