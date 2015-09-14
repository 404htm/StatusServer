CREATE TABLE [dbo].[TraceLogObjectData]
(
	[TraceLogId] INT FOREIGN KEY REFERENCES [TraceLog](Id) NOT NULL,
	[ObjectDataId] INT NOT NULL FOREIGN KEY REFERENCES [ObjectData](Id) ON DELETE CASCADE, 
    CONSTRAINT [PK_TraceLogObjectState] PRIMARY KEY ([TraceLogId], [ObjectDataId])
)
