using BL.Services;
using BL.Tests.Mocks.MockData;
using Infrastructure.Models;
using Infrastructure.Services;
using Infrastructure.Weather.Queries;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Threading.Tasks;
using Core.Models;

namespace BL.Tests.Services.GetWeatherForDaysServiceTests
{
   [TestFixture]
   public class GetWeatherForDaysMethodTests
   {
      private const int _weatherForDays = 4;
      private const double _longitude = 39.0;
      private const double _latitude = 40.0;

      private readonly IGetWeatherForDaysQuery _getCurrentWeatherQueryMock;

      public GetWeatherForDaysMethodTests()
      {
         Mock<IGetWeatherForDaysQuery> getCurrentWeatherQuery = new Mock<IGetWeatherForDaysQuery>();

         getCurrentWeatherQuery
            .Setup(c => c.Execute(_weatherForDays, It.IsAny<Coordinates>()))
            .ReturnsAsync(QueryMocks.GetFiveDayForecastQueryResult);

         _getCurrentWeatherQueryMock = getCurrentWeatherQuery.Object;
      }

      [Test]
      public async Task ShouldReturnWeatherModel()
      {
         IGetWeatherForDaysService currentWeatherService = new GetWeatherForDaysService(_getCurrentWeatherQueryMock);

         WeatherForDaysModel actualObject = await currentWeatherService.GetWeatherForDays(_weatherForDays);
         WeatherForDaysModel expectedObject = new WeatherForDaysModel(QueryMocks.GetFiveDayForecastQueryResult);

         var actual = JsonConvert.SerializeObject(actualObject);
         var expected = JsonConvert.SerializeObject(expectedObject);

         Assert.AreEqual(actual, expected);
      }
   }
}
