using Newtonsoft.Json;
using System.Collections.Generic;

namespace Core.Models
{
   public class MultipleDayForecast
   {
      [JsonProperty("dt")]
      public int TimeOfDataCalculation { get; set; }

      [JsonProperty("main")]
      public WeatherDetails WeatherDetails { get; set; }

      [JsonProperty("weather")]
      public List<Weather> WeatherForecast { get; set; }

      [JsonProperty("clouds")]
      public Clouds Clouds { get; set; }

      [JsonProperty("wind")]
      public Wind Wind { get; set; }

      [JsonProperty("dt_txt")]
      public string ForecastCalculationUtc { get; set; }
   }
}
