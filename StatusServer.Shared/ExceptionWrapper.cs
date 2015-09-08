using System;
using System.Runtime.Serialization;

namespace StatusServer.Shared
{
	[DataContract(IsReference = true)]
	public class ExceptionWrapper
	{
		public ExceptionWrapper(Exception ex)
		{
			Message = ex.Message;
			Source = ex.Source;
			StackTrace = ex.StackTrace;
			TargetSite = ex.TargetSite.ToString();
			if (ex.InnerException != null) InnerException = new ExceptionWrapper(ex.InnerException);
		}

		[DataMember]
		public string Message { get; set; }

		[DataMember]
		public string Source { get; set; }

		[DataMember]
		public string StackTrace { get; set; }

		[DataMember]
		public string TargetSite { get; set; }

		[DataMember]
		public ExceptionWrapper InnerException { get; set; }
	}
}
