using System;
namespace coreApi.Models
{
	public class ResponseHttpData
	{
		public ResponseHttpData()
		{
		}

		public string statecCode { get; set; }
		public bool isSuccess { get; set; }

        public string[] errorMessage { get; set; }
		public object[] result { get; set; }
	}
}

