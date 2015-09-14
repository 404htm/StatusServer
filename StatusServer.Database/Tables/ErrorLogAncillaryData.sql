CREATE TABLE [dbo].[ErrorLogAncillaryData]
(
	[ErrorLogId] INT FOREIGN KEY REFERENCES [ErrorLog](Id) NOT NULL,
	[AncillaryDataId] INT NOT NULL FOREIGN KEY REFERENCES [AncillaryData](Id) ON DELETE CASCADE, 
    CONSTRAINT [PK_ErrorAncillaryData] PRIMARY KEY ([ErrorLogId], [AncillaryDataId])
)
