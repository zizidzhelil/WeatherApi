using BL.Services;
using BL.Tests.Mocks.MockData;
using Infrastructure.Models;
using Infrastructure.Services;
using Infrastructure.Weather.Queries;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BL.Tests.Services.GetWeatherForCityAndDaysServiceTests
{
   [TestFixture]
   public class GetWeatherForCityAndDaysMethodTests
   {
      private const string _city = "Sofia";
      private const int _weatherForDays = 4;

      private readonly IGetWeatherForCityAndDaysQuery _getWeatherForCityAndDaysQueryMock;

      public GetWeatherForCityAndDaysMethodTests()
      {
         Mock<IGetWeatherForCityAndDaysQuery> getCurrentWeatherQuery = new Mock<IGetWeatherForCityAndDaysQuery>();

         getCurrentWeatherQuery
            .Setup(c => c.Execute(It.IsAny<string>(), _weatherForDays))
            .ReturnsAsync(QueryMocks.GetFiveDayForecastQueryResult);

         _getWeatherForCityAndDaysQueryMock = getCurrentWeatherQuery.Object;
      }

      [Test]
      public async Task ShouldReturnWeatherModel()
      {
         IGetWeatherForCityAndDaysService currentWeatherService = new GetWeatherForCityAndDaysService(_getWeatherForCityAndDaysQueryMock);

         WeatherForCityAndDaysModel actualObject = await currentWeatherService.GetWeatherForCityAndDays(_city, _weatherForDays);
         WeatherForCityAndDaysModel expectedObject = new WeatherForCityAndDaysModel(QueryMocks.GetFiveDayForecastQueryResult);

         var actual = JsonConvert.SerializeObject(actualObject);
         var expected = JsonConvert.SerializeObject(expectedObject);

         Assert.AreEqual(actual, expected);
      }
   }
}
