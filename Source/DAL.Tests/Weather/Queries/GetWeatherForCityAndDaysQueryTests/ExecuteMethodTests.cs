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
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Tests.Weather.Queries.GetWeatherForCityAndDaysQueryTests
{
   [TestFixture]
   public class ExecuteMethodTests
   {
      private const string _city = "Sofia";
      private const int _weatherForDays = 4;

      private readonly IWeatherContext _contextMock;
      private readonly IUrlFactory _urlFactoryMock;

      public ExecuteMethodTests()
      {
         Mock<IWeatherContext> contextMock = new Mock<IWeatherContext>();
         Mock<IUrlFactory> urlFactoryMock = new Mock<IUrlFactory>();

         contextMock.Setup(c => c.MakeRequest(It.IsAny<string>())).ReturnsAsync(ResponseMocks.GetForecastMock);
         urlFactoryMock
            .Setup(u => u.Create(nameof(WeatherForCityAndDaysUrlBuilder), _city))
            .Returns($"https://samples.openweathermap.org/data/2.5/forecast?q={_city},bg&appid={Guid.NewGuid()}");

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
         IGetWeatherForCityAndDaysQuery getWeatherForDaysQuery = new GetWeatherForCityAndDaysQuery(_contextMock, _urlFactoryMock);

         Forecast actualObject = await getWeatherForDaysQuery.Execute(
            _city,
            weatherObject);
         Forecast expectedObject = JsonConvert.DeserializeObject<Forecast>(ResponseMocks.GetForecastMock);

         expectedObject.ForecastCount = weatherObject;
         expectedObject.MultiDayForecast = expectedObject.MultiDayForecast.Take(weatherObject).ToList();

         var actual = JsonConvert.SerializeObject(actualObject);
         var expected = JsonConvert.SerializeObject(expectedObject);

         Assert.AreEqual(actual, expected);
      }
   }
}
