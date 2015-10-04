CREATE PROCEDURE [dbo].[UpdateVersionTable] @Inserted EventTableType READONLY
AS
	MERGE INTO [dbo].[ApplicationVersion] AS Target
		USING (
			SELECT [Version], [EnvironmentId], [ModuleId]
			FROM @Inserted
			WHERE [Version] IS NOT NULL
		) AS Source([VersionNumber], [EnvironmentId], [ModuleId])
		ON (
			Target.VersionNumber = Source.VersionNumber AND
			Target.EnvironmentId = Source.EnvironmentId AND
			Target.ModuleId = Source.ModuleId
		)
		WHEN MATCHED THEN
				UPDATE SET Target.LastEncountered = GETUTCDATE()
		WHEN NOT MATCHED BY Target THEN
				Insert([VersionNumber], [EnvironmentId], [ModuleId], [FirstEncountered])
				Values([VersionNumber],  [EnvironmentId], [ModuleId], GETUTCDATE());
RETURN 0
