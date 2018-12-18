using Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Models
{
   public class FiveDayForecastModel
   {
      public FiveDayForecastModel(ForecastObject forecastObject)
      {
         this.CityName = forecastObject.City.Name;
         this.MultiDayForecast = forecastObject.MultiDayForecast.Select(c => new ForecastModel()
         {
            ForecastDate = c.ForecastCalculationUtc,
            Temperature = c.WeatherDetails.Temperature.ToString()
         }).ToList();
      }

      public string CityName { get; set; }

      public List<ForecastModel> MultiDayForecast { get; set; }
   }
}
