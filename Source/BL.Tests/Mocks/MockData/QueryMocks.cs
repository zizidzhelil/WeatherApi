using Core.Models;
using System.Collections.Generic;
using Infrastructure.Models;

namespace BL.Tests.Mocks.MockData
{
   public static class QueryMocks
   {
      public static readonly Forecast GetFiveDayForecastQueryResult = new Forecast()
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
               ForecastCalculationUtc = "2017-12-20"
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

      public static readonly WeatherForCityAndDaysModel WeatherForCityAndDays = new WeatherForCityAndDaysModel()
      {
         CityName = "Sofia",
         Weather = new List<WeatherForCityAndDayModel>()
         {
            new WeatherForCityAndDayModel()
            {
               CloudinessPercent = 3,
               Date = "2017-12-20",
               Humidity = 8,
               Temperature = "6.9",
               WindSpeed = 9.6,
               Description = "Sunny",
               Pressure = "89"
            }
         }
      };
   }
}
