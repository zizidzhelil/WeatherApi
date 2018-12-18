using System.Net.Http;

namespace DAL.Tests.Mocks
{
   public class HttpClientFactoryMock : IHttpClientFactory
   {
      public virtual HttpClient CreateClient()
      {
         return new HttpClientMock();
      }

      public HttpClient CreateClient(string name)
      {
         return new HttpClientMock();
      }
   }
}
