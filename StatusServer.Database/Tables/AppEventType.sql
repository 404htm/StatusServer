CREATE TABLE [dbo].[AppEventType]
(
	[Id] INT NOT NULL, 
    [ApplicationId] INT NOT NULL FOREIGN KEY REFERENCES [Application](Id),
	[Order] INT NOT NULL,
	[Name] VARCHAR(200),
	[EventTypeGroupId] INT FOREIGN KEY References [dbo].[AppEventTypeGroup](Id), 
    CONSTRAINT [PK_EventType] PRIMARY KEY NONCLUSTERED ([Id], [ApplicationId]) 
)

GO

CREATE CLUSTERED INDEX [IX_EventType_Order] ON [dbo].[AppEventType] ([Order])
