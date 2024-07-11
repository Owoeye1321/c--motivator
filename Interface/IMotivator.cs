using System;
using System.Net;

namespace LiftDepression.Interface
{
	public interface IGetMotivationResponse
	{
        string id { get; set; }
        string quote { get; set; }
    }
    public interface IGetPicturesResponse
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
    public interface IAllQuoteResponseData
    {
        HttpStatusCode Code { get; set; }
        string Message { get; set; }
        object Data { get; set; }
    }

    public class AllQuoteResponseData : IAllQuoteResponseData
    {
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }

}

