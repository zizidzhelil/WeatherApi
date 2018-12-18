using Core.Models;
using System.Collections.Generic;

namespace BL.Tests.Mocks.MockData
{
    public static class QueryMocks
    {
        public static readonly WeatherObject GetCurrentWeatherQueryResult = new WeatherObject()
        {
            Coordinates = new Coordinates()
            {
                Longitude = 2.3,
                Latitude = 9.6
            },
            Weather = new List<Weather>()
            {
                new Weather()
                {
                   Id = 4,
                   Main = "Rain",
                   Description = "Mostly Cloudy",
                   Icon = "cloud"
                }
            },
            WeatherDetails = new WeatherDetails()
            {
                Temperature = 3.6,
                Pressure = 4.5,
                Humidity = 5,
                TemperatureMin = -5.0,
                TemperatureMax = 10.0,
                SeaLevel = 3.0,
                GroundLevel = 1.0
            },
            Wind = new Wind()
            {
                Speed = 5.6,
                Degree = 9
            },
            Clouds = new Clouds()
            {
                CloudinessPercent = 4
            },
            TimeOfDataCalculation = 2,
            CountryDetails = new CountryDetails()
            {
                Message = "Sun",
                Country = "Bulgaria",
                Sunrise = "07:40",
                Sunset = "18:40"
            },
            CityId = 2,
            CityName = "Burgas"
        };

        public static readonly ForecastObject GetFiveDayForecastQueryResult = new ForecastObject()
        {
            Message = 2.0,
            ForecastCount = 8,
            MultiDayForecast = new List<MultipleDayForecast>()
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
            },
            City = new City()
            {
                Id = 7,
                Name = "Sofia",
                Coordinates = new Coordinates()
                {
                    Longitude = 1.645151,
                    Latitude = 154.568
                },
                Country = "Bulgaria"
            }
        };
    }
}
