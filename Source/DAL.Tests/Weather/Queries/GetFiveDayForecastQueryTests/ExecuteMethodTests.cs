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
using System.Threading.Tasks;

namespace DAL.Tests.Weather.Queries.GetFiveDayForecastQueryTests
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

         contextMock.Setup(c => c.MakeRequest(It.IsAny<string>())).ReturnsAsync(ResponseMocks.GetFiveDayForecastMock);
         appSettingsProviderMock.SetupGet(a => a.ApiKey).Returns(Guid.NewGuid().ToString());

         _contextMock = contextMock.Object;
         _appSettingsProviderMock = appSettingsProviderMock.Object;
      }

      [Test]
      public async Task ShouldReturnDeserializedObject()
      {
         IGetFiveDayForecastQuery getFiveDayForecastQuery = new GetFiveDayForecastQuery(_contextMock, _appSettingsProviderMock);

         ForecastObject actualObject = await getFiveDayForecastQuery.Execute();
         ForecastObject expectedObject = JsonConvert.DeserializeObject<ForecastObject>(ResponseMocks.GetFiveDayForecastMock);

         var actual = JsonConvert.SerializeObject(actualObject);
         var expected = JsonConvert.SerializeObject(expectedObject);

         Assert.AreEqual(actual, expected);
      }
   }
}
