CREATE TRIGGER [VersionTrigger]
	ON [dbo].[Error]
	FOR INSERT
	AS
	BEGIN
		SET NOCOUNT ON

		MERGE INTO [dbo].[ApplicationVersion] AS Target
		USING (
			SELECT [Version], [ApplicationId], [EnvironmentId], [ModuleId]
			FROM INSERTED
		) AS Source([VersionNumber], [ApplicationId], [EnvironmentId], [ModuleId])
		ON (
			Target.VersionNumber = Source.VersionNumber AND
			Target.ApplicationId = Source.ApplicationId AND
			Target.EnvironmentId = Source.EnvironmentId AND
			Target.ModuleId = Source.ModuleId
		)
		WHEN MATCHED THEN
				UPDATE SET Target.LastEncountered = GETUTCDATE()
		WHEN NOT MATCHED BY Target THEN
				Insert([VersionNumber], [ApplicationId], [EnvironmentId], [ModuleId], [FirstEncountered])
				Values([VersionNumber], [ApplicationId], [EnvironmentId], [ModuleId], GETUTCDATE());

	END
