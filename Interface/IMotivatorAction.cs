using System;
namespace LiftDepression.Interface
{
	public interface IMotivatorAction
	{
		Task<IGetMotivationResponse> GetSingleQuote();
		Task<IEnumerable<IGetMotivationResponse>> GetAllQuotes();
		//Task<IGetPicturesResponse> GetSinglePicture();
		//Task<IEnumerable<IGetPicturesResponse>> GetAllPictures();
	}
}

