using Core.Models;
using System.Linq;

namespace Infrastructure.Models
{
   public class WeatherForCityAndDaysModel
   {
      public WeatherForCityAndDaysModel(Forecast forecast)
      {
         Temperature = forecast.MultiDayForecast.Average(c => c.WeatherDetails.Temperature).ToString();
         CityName = forecast.City.Name;
      }

      public string Temperature { get; set; }

      public string CityName { get; set; }
   }
}
