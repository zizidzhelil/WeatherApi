using BL.Services;
using BL.Tests.Mocks.MockData;
using Infrastructure.Models;
using Infrastructure.Services;
using Infrastructure.Weather.Queries;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BL.Tests.Services.CurrentWeatherServiceTests
{
   [TestFixture]
   public class GetCurrentWeatherMethodTests
   {
      private readonly IGetCurrentWeatherQuery _getCurrentWeatherQueryMock;

      public GetCurrentWeatherMethodTests()
      {
         Mock<IGetCurrentWeatherQuery> getCurrentWeatherQuery = new Mock<IGetCurrentWeatherQuery>();
            getCurrentWeatherQuery.Setup(c => c.Execute()).ReturnsAsync(QueryMocks.GetCurrentWeatherQueryResult);

            _getCurrentWeatherQueryMock = getCurrentWeatherQuery.Object;
      }

      [Test]
      public async Task ShouldReturnWeatherModel()
      {
         ICurrentWeatherService currentWeatherService = new CurrentWeatherService(_getCurrentWeatherQueryMock);

         CurrentWeatherModel actualObject = await currentWeatherService.GetCurrentWeather();
         CurrentWeatherModel expectedObject = new CurrentWeatherModel(QueryMocks.GetCurrentWeatherQueryResult);

         var actual = JsonConvert.SerializeObject(actualObject);
         var expected = JsonConvert.SerializeObject(expectedObject);

         Assert.AreEqual(actual, expected);
      }
   }
}
