using DAL.Tests.Mocks.MockData;
using System.Net.Http;
using System.Threading.Tasks;

namespace DAL.Tests.Mocks
{
   public class HttpClientMock : HttpClient
   {
      public new virtual async Task<string> GetStringAsync(string url)
      {
         await Task.Delay(1);
         return ResponseMocks.GetCurrentWeatherMock;
      }
   }
}
