CREATE TABLE [dbo].[ErrorObjectState]
(
	[ErrorId] INT FOREIGN KEY REFERENCES [Error](Id) NOT NULL,
	[ObjectStateId] INT FOREIGN KEY REFERENCES [ObjectState](Id) NOT NULL, 
    CONSTRAINT [PK_ErrorObjectState] PRIMARY KEY ([ErrorId], [ObjectStateId])
)
