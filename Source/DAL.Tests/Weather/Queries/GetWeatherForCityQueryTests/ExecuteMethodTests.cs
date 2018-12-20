using Core.Models;
using DAL.Factories.ConcreteUrlBuilders;
using DAL.Tests.Mocks.MockData;
using DAL.Weather.Queries;
using Infrastructure.Context;
using Infrastructure.UrlFactory;
using Infrastructure.Weather.Queries;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace DAL.Tests.Weather.Queries.GetWeatherForCityQueryTests
{
   [TestFixture]
   public class ExecuteMethodTests
   {
      private const string City = "Sofia";

      private readonly IWeatherContext _contextMock;
      private readonly IUrlFactory _urlFactoryMock;

      public ExecuteMethodTests()
      {
         Mock<IWeatherContext> contextMock = new Mock<IWeatherContext>();
         Mock<IUrlFactory> urlFactoryMock = new Mock<IUrlFactory>();

         contextMock.Setup(c => c.MakeRequest(It.IsAny<string>())).ReturnsAsync(ResponseMocks.GetForecastMock);
         urlFactoryMock
            .Setup(u => u.Create(nameof(WeatherForCityAndDaysUrlBuilder), City))
            .Returns($"https://samples.openweathermap.org/data/2.5/forecast?q={City},bg&appid={Guid.NewGuid()}");

         _contextMock = contextMock.Object;
         _urlFactoryMock = urlFactoryMock.Object;
      }

      [Test]
      public async Task ShouldReturnDeserializedObject()
      {
         IGetWeatherForCityQuery getWeatherForDaysQuery = new GetWeatherForCityQuery(_contextMock, _urlFactoryMock);

         Forecast actualObject = await getWeatherForDaysQuery.Execute(City);
         Forecast expectedObject = JsonConvert.DeserializeObject<Forecast>(ResponseMocks.GetForecastMock);

         var actual = JsonConvert.SerializeObject(actualObject);
         var expected = JsonConvert.SerializeObject(expectedObject);

         Assert.AreEqual(actual, expected);
      }
   }
}
