using System;
using System.Collections.Generic;

namespace CarSales.Models
{
	public class APIResponse
	{
		public APIResponse ()
		{
			Errors = new List<Error> ();
			Success = true;
		}

		public bool Success { get; set; }
		public string Message { get; set; }
		public List<Error> Errors { get; set; }

		public class Error{
			public string Source { get; set; }
			public string Message { get; set; }
		}
	}
}

