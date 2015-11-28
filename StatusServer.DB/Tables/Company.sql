﻿CREATE TABLE [dbo].[Company]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [Name] VARCHAR(200) NULL, 
    [Notes] VARCHAR(MAX) NULL, 
    [CreatedDate] DATETIME NOT NULL DEFAULT GETUTCDATE()
)
