using Common.Constants;
using DAL.Factories.ConcreteUrlBuilders;
using Infrastructure.Providers;
using Moq;
using NUnit.Framework;
using System;

namespace DAL.Tests.Factories.ConcreteUrlBuilders.WeatherForCityAndDaysUrlBuilderTests
{
   [TestFixture]
   public class BuildMethodTests
   {
      private readonly string _cityMock = "Sofia";
      private readonly string _apiKeyMock = Guid.NewGuid().ToString();

      private readonly IAppSettingsProvider _appSettingsProviderMock;

      public BuildMethodTests()
      {
         Mock<IAppSettingsProvider> appSettingsProviderMock = new Mock<IAppSettingsProvider>();

         appSettingsProviderMock.SetupGet(c => c.ApiKey).Returns(_apiKeyMock);

         _appSettingsProviderMock = appSettingsProviderMock.Object;
      }

      [Test]
      public void ShouldReturnUrlString()
      {
         WeatherForCityAndDaysUrlBuilder urlBuilder = new WeatherForCityAndDaysUrlBuilder(_appSettingsProviderMock);

         string actual = urlBuilder.Build(_cityMock);
         string expected = $"{CommonConstants.BaseWeatherUrl}?q={_cityMock},bg&units=metric&appId={_apiKeyMock}";

         Assert.AreEqual(expected, actual);
      }
   }
}
