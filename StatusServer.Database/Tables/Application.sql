CREATE TABLE [dbo].[Application]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[Name] Varchar(100),
	[Notes] Varchar(Max), 
    [CreatedDate] DATETIME NULL DEFAULT GETUTCDATE() ,
	[CompanyId] INT NOT NULL FOREIGN KEY REFERENCES [Company](Id)
)
