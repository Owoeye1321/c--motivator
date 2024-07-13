using System;
using LiftDepression.Helpers;
using System.Net.Http.Headers;
using LiftDepression.Interface;
using System.Text.Json;

namespace LiftDepression.Service
{
    public class MotivatorService : IMotivatorAction

	{
		public MotivatorService()
		{

		}


       public async Task<IEnumerable<IGetMotivationResponse>> GetAllQuotes()
        {
            try
            {


                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://motivational-content.p.rapidapi.com/quotes"),
                    Headers =
                    {
                        { "x-rapidapi-key", "37f4bc3034msha49c34d8cab9a70p1a537fjsnc2dbc343db77" },
                        { "x-rapidapi-host", "motivational-content.p.rapidapi.com" },
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new ErrorHelper($"{response.StatusCode} API Error");
                    }
                    response.EnsureSuccessStatusCode();
                    var  responseString = await response.Content.ReadAsStringAsync();
                    IEnumerable<IGetMotivationResponse> body = JsonSerializer.Deserialize<IEnumerable<IGetMotivationResponse>>(responseString, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                    return body;
                }
            }
            catch (Exception Ex)
            {
                throw new ErrorHelper(Ex.Message);
            }
        }


       public async Task<IGetMotivationResponse> GetSingleQuote(singleQuoteRequest id)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://motivational-content.p.rapidapi.com/quotes/{id}"),
                    Headers =
                    {
                        { "x-rapidapi-key", "37f4bc3034msha49c34d8cab9a70p1a537fjsnc2dbc343db77" },
                        { "x-rapidapi-host", "motivational-content.p.rapidapi.com" },
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    if(!response.IsSuccessStatusCode)
                    {
                        throw new ErrorHelper($"{response.StatusCode} API Error");
                    }
                    response.EnsureSuccessStatusCode();
                    var responseString = await response.Content.ReadAsStringAsync();
                    IGetMotivationResponse body = JsonSerializer.Deserialize<IGetMotivationResponse>(responseString, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true
                    });
                    return body;

                }
            }
            catch (Exception Ex)
            {
                throw new ErrorHelper(Ex.Message);
            }
        }
        //public async Task<IEnumerable<IGetPicturesResponse>> GetAllPictures()
        //{
        //    try
        //    {


        //    }
        //    catch (Exception Ex)
        //    {
        //        throw new ErrorHelper(Ex.Message);
        //    }

        //}


        //Task<IGetPicturesResponse> GetSinglePicture()
        //{
        //    try
        //    {
        //    }
        //    catch (Exception Ex)
        //    {
        //        throw new ErrorHelper(Ex.Message);
        //    }
        //}
    }
}

