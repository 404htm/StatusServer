﻿CREATE TRIGGER [VersionTrigger_Error]
	ON [dbo].[ErrorLog]
	FOR INSERT
	AS
	BEGIN
		DECLARE @version AS EventTableType;
		Insert INTO @version SELECT [EnvironmentId], [ModuleId], [Version] FROM INSERTED;
		EXEC UpdateVersionTable @version;
	END
