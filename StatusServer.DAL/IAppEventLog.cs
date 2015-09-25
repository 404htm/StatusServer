using System;

namespace StatusServer.DAL
{
	public interface ILogData
	{
		Application Application { get; set; }
		int ApplicationId { get; set; }
		ApplicationVersion ApplicationVersion { get; set; }
		Environment Environment { get; set; }
		int EnvironmentId { get; set; }
		string FileName { get; set; }
		int Id { get; set; }
		int? LineNumber { get; set; }
		string MemberName { get; set; }
		string Message { get; set; }
		Module Module { get; set; }
		int? ModuleId { get; set; }
		DateTime Time { get; set; }
		Guid Token { get; set; }
		string UserName { get; set; }
		string Version { get; set; }
	}
}