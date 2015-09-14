CREATE TABLE [dbo].[TraceLogAncillaryData]
(
	[TraceLogId] INT FOREIGN KEY REFERENCES [TraceLog](Id) NOT NULL,
	[AncillaryDataId] INT NOT NULL FOREIGN KEY REFERENCES [AncillaryData](Id) ON DELETE CASCADE, 
    CONSTRAINT [PK_TraceAncillaryData] PRIMARY KEY ([TraceLogId], [AncillaryDataId])
)
