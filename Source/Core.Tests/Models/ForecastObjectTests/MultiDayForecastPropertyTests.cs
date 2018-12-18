using Core.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace Core.Tests.Models.ForecastObjectTests
{
    [TestFixture]
    public class MultiDayForecastPropertyTests
    {
        [Test]
        public void GetAndSetMultiDayForecast()
        {
            var expected = new List<MultipleDayForecast>()
            {
               new MultipleDayForecast()
               {
                    TimeOfDataCalculation = 2,
                    WeatherDetails = new WeatherDetails()
                    {
                        Temperature = 6.9,
                        Pressure = 89.0,
                        Humidity = 8,
                        TemperatureMin = -12.3,
                        TemperatureMax = 5.6,
                        SeaLevel = 2.3,
                        GroundLevel = 1.0
                    },
                    WeatherForecast = new List<Weather>()
                    {
                        new Weather()
                        {
                            Id = 3,
                            Main = "A",
                            Description = "Sunny",
                            Icon = "Cloud"
                        }
                    },
                    Clouds = new Clouds()
                    {
                        CloudinessPercent = 3
                    },
                    Wind = new Wind()
                    {
                        Speed = 9.6,
                        Degree = 7.8
                    },
                    ForecastCalculationUtc = "ab"
               }
            };

            ForecastObject forecastObject = new ForecastObject();
            forecastObject.MultiDayForecast = expected;

            var actual = forecastObject.MultiDayForecast;

            Assert.AreEqual(actual, expected);
        }
    }
}

