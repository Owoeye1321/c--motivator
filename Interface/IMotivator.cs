using System;
namespace LiftDepression.Interface
{
	public interface IGetPicturesResponse
	{
        string id { get; set; }
        string quote { get; set; }
    }
    public interface IGetAllPicturesResponse
    {

        string id { get; set; }
        string image {get; set;}
        string largeImage { get; set;}
        string mediumImage {get; set;}
        string smallImage {get; set; }
        ISource source { get; set; }

    }
    public interface ISource
    {
        string name { get; set; }
        string url { get; set; }
    }
   
}

