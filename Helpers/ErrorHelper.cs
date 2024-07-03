using System;
namespace LiftDepression.Helpers
{
	public class ErrorHelper : Exception
	{
		public ErrorHelper(string message) :base(message)
		{
		}
	}
}

