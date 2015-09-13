CREATE TABLE [dbo].[EventTypeGroup]
(
	[Id] INT NOT NULL PRIMARY KEY NONCLUSTERED IDENTITY,
	[Name] VARCHAR(200),
	[Order] INT NOT NULL
)

GO

CREATE CLUSTERED INDEX [IX_EventTypeGroup_Column] ON [dbo].[EventTypeGroup] ([Order])
