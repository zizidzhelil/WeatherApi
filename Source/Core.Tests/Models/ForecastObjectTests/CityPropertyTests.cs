using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.ForecastObjectTests
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

            ForecastObject forecastObject = new ForecastObject();
            forecastObject.City = expected;

            var actual = forecastObject.City;

            Assert.AreEqual(actual, expected);
        }        
    }
}
