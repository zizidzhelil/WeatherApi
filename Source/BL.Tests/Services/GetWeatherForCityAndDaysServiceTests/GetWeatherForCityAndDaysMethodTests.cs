using BL.Services;
using BL.Tests.Mocks.MockData;
using Infrastructure.Grouper;
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

      private readonly IGetWeatherForCityQuery _getWeatherForCityAndDaysQueryMock;
      private readonly IGroupWeatherByDay _groupWeatherByDayMock;

      public GetWeatherForCityAndDaysMethodTests()
      {
         Mock<IGetWeatherForCityQuery> getCurrentWeatherQuery = new Mock<IGetWeatherForCityQuery>();
         Mock<IGroupWeatherByDay> groupWeatherByDayMock = new Mock<IGroupWeatherByDay>();

         getCurrentWeatherQuery
            .Setup(c => c.Execute(It.IsAny<string>()))
            .ReturnsAsync(QueryMocks.GetFiveDayForecastQueryResult);

         groupWeatherByDayMock
            .Setup(c => c.GroupWeather(QueryMocks.GetFiveDayForecastQueryResult, _weatherForDays))
            .Returns(QueryMocks.WeatherForCityAndDays);

         _getWeatherForCityAndDaysQueryMock = getCurrentWeatherQuery.Object;
         _groupWeatherByDayMock = groupWeatherByDayMock.Object;
      }

      [Test]
      public async Task ShouldReturnWeatherModel()
      {
         IGetWeatherForCityAndDaysService currentWeatherService = new GetWeatherForCityAndDaysService(
            _getWeatherForCityAndDaysQueryMock,
            _groupWeatherByDayMock);

         WeatherForCityAndDaysModel actualObject = await currentWeatherService.GetWeatherForCityAndDays(_city, _weatherForDays);
         WeatherForCityAndDaysModel expectedObject = QueryMocks.WeatherForCityAndDays;

         var actual = JsonConvert.SerializeObject(actualObject);
         var expected = JsonConvert.SerializeObject(expectedObject);

         Assert.AreEqual(actual, expected);
      }
   }
}
