CREATE TABLE [dbo].[AssertLogAncillaryData]
(
	[AssertLogId] INT FOREIGN KEY REFERENCES [AssertLog](Id) NOT NULL,
	[AncillaryDataId] INT NOT NULL FOREIGN KEY REFERENCES [AncillaryData](Id) ON DELETE CASCADE, 
    CONSTRAINT [PK_AssertLogAncillaryData] PRIMARY KEY ([AssertLogId], [AncillaryDataId])
)
