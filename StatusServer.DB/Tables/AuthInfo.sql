﻿CREATE TABLE [dbo].[AuthInfo]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [PassHash] VARCHAR(256) NOT NULL,
	[Salt] VARCHAR(256) NOT NULL,
	[HashType] VARCHAR(200)
)
