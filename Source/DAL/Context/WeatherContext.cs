using Infrastructure.Context;
using System.Net.Http;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class WeatherContext : IWeatherContext
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherContext(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> MakeRequest(string url)
        {
            var client = _httpClientFactory.CreateClient();
            var result = await client.GetStringAsync(url);

            return result;
        }
    }
}