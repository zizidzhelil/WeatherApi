using System.Collections.Generic;
using Newtonsoft.Json;

namespace Core.Models
{
   public class Forecast
   {
      [JsonProperty("message")]
      public double Message { get; set; }

      [JsonProperty("cnt")]
      public int ForecastCount { get; set; }

      [JsonProperty("list")]
      public List<MultipleDayForecast> MultiDayForecast { get; set; }

      [JsonProperty("city")]
      public City City { get; set; }
   }
}
