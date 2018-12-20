using Common.Constants;
using DAL.Factories;
using DAL.Factories.ConcreteUrlBuilders;
using Infrastructure.Providers;
using Infrastructure.UrlFactory.UrlBuilder;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DAL.Tests.Factories.UrlFactoryTests
{
   [TestFixture]
   public class CreateMethodTests
   {
      private readonly Dictionary<string, Func<IUrlBuilder>> _urlBuildersMock;
      private readonly string _apiKeyMock = Guid.NewGuid().ToString();
      private readonly string _cityMock = "Sofia";

      public CreateMethodTests()
      {
         Mock<IAppSettingsProvider> appSettingsProviderMock = new Mock<IAppSettingsProvider>();
         appSettingsProviderMock.SetupGet(s => s.ApiKey).Returns(_apiKeyMock);

         _urlBuildersMock = new Dictionary<string, Func<IUrlBuilder>>()
         {
               { nameof(WeatherForCityAndDaysUrlBuilder), () => new WeatherForCityAndDaysUrlBuilder(appSettingsProviderMock.Object) }
         };
      }

      [Test]
      [TestCase("Mock Test Name")]
      [TestCase("Class Name")]
      [TestCase("Class Mock")]
      public void CreateMethodShouldThrowException(string builderName)
      {
         UrlFactory urlFactory = new UrlFactory(_urlBuildersMock);

         Assert.Throws<KeyNotFoundException>(() => urlFactory.Create(builderName));
      }

      [TestCase(nameof(WeatherForCityAndDaysUrlBuilder))]
      public void CreateMethodShouldReturnUrlBuilder(string builderName)
      {
         UrlFactory urlFactory = new UrlFactory(_urlBuildersMock);

         string actual = urlFactory.Create(builderName, _cityMock);
         string expected = $"{CommonConstants.BaseWeatherUrl}?q={_cityMock},bg&units=metric&appId={_apiKeyMock}";

         Assert.AreEqual(expected, actual);
      }
   }
}
