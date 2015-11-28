CREATE TABLE [dbo].[ErrorLogObjectData]
(
	[ErrorLogId] INT NOT NULL FOREIGN KEY REFERENCES [ErrorLog](Id) ,
	[ObjectDataId] INT  NOT NULL FOREIGN KEY REFERENCES [ObjectData](Id) ON DELETE CASCADE, 
    CONSTRAINT [PK_ErrorObjectState] PRIMARY KEY ([ErrorLogId], [ObjectDataId])
)
