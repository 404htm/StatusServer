CREATE TABLE [dbo].[AppEventTypeGroup]
(
	[Id] INT NOT NULL PRIMARY KEY NONCLUSTERED IDENTITY,
	[ApplicationId] INT NOT NULL FOREIGN KEY REFERENCES [Application](Id),
	[Name] VARCHAR(200),
	[Order] INT NOT NULL
)

GO

CREATE CLUSTERED INDEX [IX_EventTypeGroup_Column] ON [dbo].[AppEventTypeGroup] ([Order])
