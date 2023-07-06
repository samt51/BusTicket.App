using BusTicket.Core.Dto.GetSession.Response;
using BusTicket.Core.Dto.ResponseModel;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace BusTicket.Core.Halper.ServiceConnectionHalper
{
    public class GetConnection<T>
    {
        public static Response<T> HttpGet(string client, string jsonBody)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(client);



            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, client);
            request.Content = new StringContent(jsonBody,
                                    Encoding.UTF8,
                                    "application/json");

            HttpResponseMessage httpResponse = httpClient.SendAsync(request).Result;

            var logResponse = httpResponse.Content.ReadAsStringAsync().Result;

            var d = JsonConvert.DeserializeObject<Response<T>>(logResponse);



            return d;


        }
        public static Response<List<T>> HttpListGet(string client, string jsonBody)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(client);



            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, client);
            request.Content = new StringContent(jsonBody,
                                    Encoding.UTF8,
                                    "application/json");

            HttpResponseMessage httpResponse = httpClient.SendAsync(request).Result;

            var logResponse = httpResponse.Content.ReadAsStringAsync().Result;

            var d = JsonConvert.DeserializeObject<Response<List<T>>>(logResponse);



            return d;


        }
    }
}
