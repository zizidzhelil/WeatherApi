using Core.Models;
using DAL.Tests.Mocks.MockData;
using DAL.UrlFactory.ConcreteUrlBuilders;
using DAL.Weather.Queries;
using Infrastructure.Context;
using Infrastructure.UrlFactory;
using Infrastructure.Weather.Queries;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Tests.Weather.Queries.GetWeatherForDaysQueryTests
{
   [TestFixture]
   public class ExecuteMethodTests
   {
      private const int _weatherForDays = 4;
      private const double _longitude = 39.0;
      private const double _latitude = 40.0;

      private readonly IWeatherContext _contextMock;
      private readonly IUrlFactory _urlFactoryMock;

      public ExecuteMethodTests()
      {
         Mock<IWeatherContext> contextMock = new Mock<IWeatherContext>();
         Mock<IUrlFactory> urlFactoryMock = new Mock<IUrlFactory>();

         contextMock.Setup(c => c.MakeRequest(It.IsAny<string>())).ReturnsAsync(ResponseMocks.GetForecastMock);
         urlFactoryMock
            .Setup(u => u.Create(nameof(WeatherForDaysUrlBuilder), _longitude.ToString(), _latitude.ToString()))
            .Returns($"https://samples.openweathermap.org/data/2.5/forecast/daily?lat={_latitude}&lon={_longitude}&cnt=10&appid=461731e6baef28d783d676b7672069a1");

         _contextMock = contextMock.Object;
         _urlFactoryMock = urlFactoryMock.Object;
      }

      [Test]
      [TestCase(1)]
      [TestCase(2)]
      [TestCase(3)]
      [TestCase(4)]
      [TestCase(5)]
      public async Task ShouldReturnDeserializedObject(int weatherObject)
      {
         IGetWeatherForDaysQuery getWeatherForDaysQuery = new GetWeatherForDaysQuery(_contextMock, _urlFactoryMock);

         Forecast actualObject = await getWeatherForDaysQuery.Execute(
            weatherObject,
            CoordinateMocks.GetCurrentCoordinates(_latitude, _longitude));
         Forecast expectedObject = JsonConvert.DeserializeObject<Forecast>(ResponseMocks.GetForecastMock);

         expectedObject.ForecastCount = weatherObject;
         expectedObject.MultiDayForecast = expectedObject.MultiDayForecast.Take(weatherObject).ToList();

         var actual = JsonConvert.SerializeObject(actualObject);
         var expected = JsonConvert.SerializeObject(expectedObject);

         Assert.AreEqual(actual, expected);
      }
   }
}
