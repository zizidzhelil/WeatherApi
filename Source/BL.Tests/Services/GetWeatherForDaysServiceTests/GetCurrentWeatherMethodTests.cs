using BL.Services;
using BL.Tests.Mocks.MockData;
using Infrastructure.Models;
using Infrastructure.Services;
using Infrastructure.Weather.Queries;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BL.Tests.Services.GetWeatherForDaysServiceTests
{
   [TestFixture]
   public class GetCurrentWeatherMethodTests
   {
      private readonly IGetWeatherForDaysQuery _getCurrentWeatherQueryMock;

      public GetCurrentWeatherMethodTests()
      {
         Mock<IGetWeatherForDaysQuery> getCurrentWeatherQuery = new Mock<IGetWeatherForDaysQuery>();
         getCurrentWeatherQuery.Setup(c => c.Execute(4)).ReturnsAsync(QueryMocks.GetFiveDayForecastQueryResult);

         _getCurrentWeatherQueryMock = getCurrentWeatherQuery.Object;
      }

      [Test]
      public async Task ShouldReturnWeatherModel()
      {
         IGetWeatherForDaysService currentWeatherService = new GetWeatherForDaysService(_getCurrentWeatherQueryMock);

         WeatherForDaysModel actualObject = await currentWeatherService.GetWeatherForDays(4);
         WeatherForDaysModel expectedObject = new WeatherForDaysModel(QueryMocks.GetFiveDayForecastQueryResult);

         var actual = JsonConvert.SerializeObject(actualObject);
         var expected = JsonConvert.SerializeObject(expectedObject);

         Assert.AreEqual(actual, expected);
      }
   }
}
