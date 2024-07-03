using System;
namespace LiftDepression.Interface
{
	public interface IMotivatorAction
	{
		Task GetSingleQuote();
		Task GetAllQuotes();
		Task GetSinglePicture();
		Task GetAllPictures();
	}
}

