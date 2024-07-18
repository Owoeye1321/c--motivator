using System;
using System.Net;

namespace LiftDepression.Interface
{
	public interface IGetMotivationResponse
	{
        string id { get; set; }
        string quote { get; set; }
    }


    public class GetMotivationRespones : IGetMotivationResponse
    {
        public string id { get; set; }
        public string quote { get; set; }
    }
    public interface IGetPicturesResponse
    {

        string id { get; set; }
        string image {get; set;}
        string largeImage { get; set;}
        string mediumImage {get; set;}
        string smallImage {get; set; }
        Source source { get; set; }

    }
    public interface ISource
    {
        string name { get; set; }
        string url { get; set; }
    }
    public class Source : ISource
    {
        public string name { get; set; }
        public string url { get; set; }

    }

    public class GetPicturesResponse : IGetPicturesResponse
    {
        public string id { get; set; }
        public string image { get; set; }
        public string largeImage { get; set; }
        public string mediumImage { get; set; }
        public string smallImage { get; set; }
        public Source source { get; set; }
    }

    public interface IAllQuoteResponseData
    {
        HttpStatusCode Code { get; set; }
        string Message { get; set; }
        IEnumerable<IGetMotivationResponse> Data { get; set; }
    }

    public class AllQuoteResponseData : IAllQuoteResponseData
    {
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }
        public IEnumerable<IGetMotivationResponse> Data { get; set; }
    }

    public interface singleQuoteRequest
    {
        string id { get; set; }
    }


    public interface ISingleQuoteResponse
    {
        HttpStatusCode Code { get; set; }
        string Message { get; set; }
        IGetMotivationResponse Data { get; set; }
    }
    public class SingleQuoteResponse : ISingleQuoteResponse
    {
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }
        public IGetMotivationResponse Data { get; set; }
    }

}

