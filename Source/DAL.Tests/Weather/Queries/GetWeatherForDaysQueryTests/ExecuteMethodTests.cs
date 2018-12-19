using Core.Models;
using DAL.Tests.Mocks.MockData;
using DAL.Weather.Queries;
using Infrastructure.Context;
using Infrastructure.Providers;
using Infrastructure.Weather.Queries;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Tests.Weather.Queries.GetWeatherForDaysQueryTests
{
   [TestFixture]
   public class ExecuteMethodTests
   {
      private readonly IWeatherContext _contextMock;
      private readonly IAppSettingsProvider _appSettingsProviderMock;

      public ExecuteMethodTests()
      {
         Mock<IWeatherContext> contextMock = new Mock<IWeatherContext>();
         Mock<IAppSettingsProvider> appSettingsProviderMock = new Mock<IAppSettingsProvider>();

         contextMock.Setup(c => c.MakeRequest(It.IsAny<string>())).ReturnsAsync(ResponseMocks.GetForecastMock);
         appSettingsProviderMock.SetupGet(a => a.ApiKey).Returns(Guid.NewGuid().ToString());

         _contextMock = contextMock.Object;
         _appSettingsProviderMock = appSettingsProviderMock.Object;
      }

      [Test]
      [TestCase(1)]
      [TestCase(2)]
      [TestCase(3)]
      [TestCase(4)]
      [TestCase(5)]
      public async Task ShouldReturnDeserializedObject(int weatherObject)
      {
         IGetWeatherForDaysQuery getWeatherForDaysQuery = new GetWeatherForDaysQuery(_contextMock, _appSettingsProviderMock);

         Forecast actualObject = await getWeatherForDaysQuery.Execute(weatherObject);
         Forecast expectedObject = JsonConvert.DeserializeObject<Forecast>(ResponseMocks.GetForecastMock);

         expectedObject.ForecastCount = weatherObject;
         expectedObject.MultiDayForecast = expectedObject.MultiDayForecast.Take(weatherObject).ToList();

         var actual = JsonConvert.SerializeObject(actualObject);
         var expected = JsonConvert.SerializeObject(expectedObject);

         Assert.AreEqual(actual, expected);
      }
   }
}
