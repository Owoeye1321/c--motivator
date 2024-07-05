using System;
namespace LiftDepression.Interface
{
	public interface IMotivatorAction
	{
		Task<IGetMotivationResponse> GetSingleQuote();
		Task<IEnumerable<IGetMotivationResponse>> GetAllQuotes();
		Task<IGetAllPicturesResponse> GetSinglePicture();
		Task<IEnumerable<IGetAllPicturesResponse>> GetAllPictures();
	}
}

