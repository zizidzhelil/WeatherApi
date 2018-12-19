using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.ForecastTests
{
    public class CityPropertyTests
    {
        [Test]
        public void GetAndSetCity()
        {
            var expected = new City()
            {
                Id = 4,
                Name = "Burgas",
                Coordinates = new Coordinates()
                {
                    Latitude = 2.315,
                    Longitude = 4985.67
                },
                Country = "Bulgaria"
            };

            Forecast forecastObject = new Forecast();
            forecastObject.City = expected;

            var actual = forecastObject.City;

            Assert.AreEqual(actual, expected);
        }        
    }
}
