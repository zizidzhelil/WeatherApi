using System.Collections.Generic;
using Infrastructure.Models;

namespace WeatherApi.Tests.Mocks
{
   public class ModelMocks
   {
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
