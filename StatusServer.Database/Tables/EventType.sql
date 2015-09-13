CREATE TABLE [dbo].[EventType]
(
	[Id] INT NOT NULL, 
    [OrgId] INT NOT NULL,
	[Order] INT NOT NULL,
	[Name] VARCHAR(200),
	[EventTypeGroupId] INT FOREIGN KEY References [dbo].[EventTypeGroup](Id), 
    CONSTRAINT [PK_EventType] PRIMARY KEY NONCLUSTERED ([Id], [OrgId]) 
)

GO

CREATE CLUSTERED INDEX [IX_EventType_Order] ON [dbo].[EventType] ([Order])
