using DAL.Context;
using DAL.Tests.Mocks;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace DAL.Tests.Context.WeatherContextTests
{
   [TestFixture]
   public class MakeRequestMethodTests
   {
        private const string Url = "https://samples.openweathermap.org/data/2.5/weather?lat=35&lon=139";
        private readonly HttpClientFactoryMock _mockHttpClientFactory;

      public MakeRequestMethodTests()
      {
         Mock<HttpClientFactoryMock> httpClientFactoryMock = new Mock<HttpClientFactoryMock>();
         Mock<HttpClientMock> httpClientMock = new Mock<HttpClientMock>();

         httpClientMock.Setup(s => s.GetStringAsync(It.IsAny<string>())).Returns(Task.FromResult("asdfasdf"));
         httpClientFactoryMock.Setup(s => s.CreateClient()).Returns(httpClientMock.Object);

         _mockHttpClientFactory = httpClientFactoryMock.Object;
      }

      [Test]
      public async Task ShouldReturnString()
      {
         WeatherContext context = new WeatherContext(_mockHttpClientFactory);
         string result = await context.MakeRequest(Url);

         Assert.IsNotEmpty(result);
      }
   }
}
