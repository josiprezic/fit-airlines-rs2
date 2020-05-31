using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FitAirlines_UI
{
    class ApiHelper
    {
        public struct Enpoints
        {
            public static string GetUsers = "api/Users";
            public static string SomethingElse = "api/something";
        }

        private static string BaseAddress = "https://localhost:44338";

        private static HttpClient Client()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseAddress);
            return client;
        }

        static HttpResponseMessage GetResponse(string enpoint)
        {
            return Client().GetAsync(enpoint).Result;
        }

        static List<T> GetObjectListFromResponse<T>(HttpResponseMessage response)
        {
            return response.Content.ReadAsAsync<List<T>>().Result;
        }

        static string GetErrorMessageFromResponse(HttpResponseMessage response)
        {
            return "Error code: " + response.StatusCode + "\nMessage: " + response.ReasonPhrase;
        }

        public static List<T> GetData<T>(string endpoint)
        {
            HttpResponseMessage response = GetResponse(ApiHelper.Enpoints.GetUsers);
            if (!response.IsSuccessStatusCode)
            {
                string message = GetErrorMessageFromResponse(response);
                throw new ApiException(message);
            }
            else 
            {
                return ApiHelper.GetObjectListFromResponse<T>(response);
            }
        }
    }
}


// TODO: JR move
class ApiException : Exception 
{
    public string message { get; }

    public ApiException(string message)
    {
        this.message = message;
    }
}