CREATE TABLE [dbo].[ErrorObjectStates]
(
	[ErrorId] INT FOREIGN KEY REFERENCES [Errors](Id) NOT NULL,
	[ObjectStatesId] INT FOREIGN KEY REFERENCES [ObjectStates](Id) NOT NULL, 
    CONSTRAINT [PK_ErrorObjectStates] PRIMARY KEY ([ErrorId], [ObjectStatesId])
)
