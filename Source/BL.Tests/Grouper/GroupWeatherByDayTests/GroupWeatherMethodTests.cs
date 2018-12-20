using System;
using BL.Grouper;
using BL.Tests.Mocks.MockData;
using Infrastructure.Converters;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;

namespace BL.Tests.Grouper.GroupWeatherByDayTests
{
   [TestFixture]
   public class GroupWeatherMethodTests
   {
      private readonly IUnixDateTimeConverter _unixDateTimeConverterMock;

      public GroupWeatherMethodTests()
      {
         Mock<IUnixDateTimeConverter> unixDateTimeConverterMock = new Mock<IUnixDateTimeConverter>();

         unixDateTimeConverterMock
            .Setup(u => u.ConvertUnixTimestampToDateTime(It.IsAny<int>()))
            .Returns(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(It.IsAny<int>()).ToLocalTime());

         _unixDateTimeConverterMock = unixDateTimeConverterMock.Object;
      }

      [Test]
      public void ShouldReturnValidWeatherForDays()
      {
         GroupWeatherByDay groupWeatherByDay = new GroupWeatherByDay(_unixDateTimeConverterMock);

         var actualObject = groupWeatherByDay.GroupWeather(QueryMocks.GetFiveDayForecastQueryResult, 4);
         var expectedObject = QueryMocks.WeatherForCityAndDays;

         var actual = JsonConvert.SerializeObject(actualObject);
         var expected = JsonConvert.SerializeObject(expectedObject);

         Assert.AreEqual(actual, expected);
      }
   }
}
