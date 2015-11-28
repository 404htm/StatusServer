CREATE TABLE [dbo].[AssertLogObjectData]
(
	[AssertLogId] INT FOREIGN KEY REFERENCES [AssertLog](Id) NOT NULL,
	[ObjectDataId] INT NOT NULL  FOREIGN KEY REFERENCES [ObjectData](Id) ON DELETE CASCADE, 
    CONSTRAINT [PK_AssertLogObjectState] PRIMARY KEY ([AssertLogId], [ObjectDataId])
)
