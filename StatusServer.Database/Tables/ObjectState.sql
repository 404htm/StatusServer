CREATE TABLE [dbo].[ObjectState]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ClassName] VARCHAR(200) NULL, 
    [InstanceName] VARCHAR(200) NULL, 
    [Data] VARCHAR(MAX) NOT NULL, 
    [Format] VARCHAR(50) NULL
)
