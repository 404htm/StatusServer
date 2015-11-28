/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
GO
SET IDENTITY_INSERT dbo.[Company] ON;

MERGE INTO dbo.[Company] AS Target
USING (VALUES
        (1 , '404htm', 'Default company used for testing and self-reporting')
) AS Source( Id, Name, Notes)
ON Target .Id = Source.Id
WHEN MATCHED THEN
        UPDATE SET Name = Source.Name , Notes = Source.Notes
WHEN NOT MATCHED BY Target THEN
        Insert(Id, Name, Notes)
        Values(Id, Name, Notes)
OUTPUT $action , Inserted .*, Deleted .*;
SET IDENTITY_INSERT dbo.[Company]  OFF;
GO

SET IDENTITY_INSERT dbo.[Application] ON;
MERGE INTO dbo.[Application] AS Target
USING (VALUES
        (1 , 1, 'Test', 'Used for unit testing, content may be cleaned up automatically'),
        (2 , 1, 'StatusServer', 'Self reporting')

) AS Source( Id, CompanyId, Name, Notes)
ON Target .Id = Source.Id
WHEN MATCHED THEN
        UPDATE SET Name = Source.Name , Notes = Source.Notes, CompanyId = Source.CompanyId
WHEN NOT MATCHED BY Target THEN
        Insert(Id, CompanyId, Name, Notes)
        Values(Id, CompanyId, Name, Notes)
OUTPUT $action , Inserted .*, Deleted .*;
SET IDENTITY_INSERT dbo.[Application]  OFF;
GO

