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

namespace DAL.Tests.Weather.Queries.GetCurrentWeatherQueryTests
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

         contextMock.Setup(c => c.MakeRequest(It.IsAny<string>())).ReturnsAsync(ResponseMocks.GetCurrentWeatherMock);
         appSettingsProviderMock.SetupGet(a => a.ApiKey).Returns(Guid.NewGuid().ToString());

         _contextMock = contextMock.Object;
         _appSettingsProviderMock = appSettingsProviderMock.Object;
      }

      [Test]
      public async Task ShouldReturnDeserializedObject()
      {
         IGetCurrentWeatherQuery getCurrentWeatherQuery = new GetCurrentWeatherQuery(_contextMock, _appSettingsProviderMock);

         WeatherObject actualObject = await getCurrentWeatherQuery.Execute();
         WeatherObject expectedObject = JsonConvert.DeserializeObject<WeatherObject>(ResponseMocks.GetCurrentWeatherMock);

         var actual = JsonConvert.SerializeObject(actualObject);
         var expected = JsonConvert.SerializeObject(expectedObject);

         Assert.AreEqual(actual, expected);
      }
   }
}
