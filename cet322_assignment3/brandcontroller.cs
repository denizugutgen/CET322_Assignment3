using System;
namespace cet322_assignment3
{
	public class brandcontroller
	{
		private readonly IDataAccess dataAccess;

		public brandcontroller(IDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}
	}
}

