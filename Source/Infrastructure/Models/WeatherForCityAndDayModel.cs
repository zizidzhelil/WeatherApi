namespace Infrastructure.Models
{
   public class WeatherForCityAndDayModel
   {
      public string Temperature { get; set; }

      public double WindSpeed { get; set; }

      public double Humidity { get; set; }

      public double CloudinessPercent { get; set; }

      public string Description { get; set; }

      public string Pressure { get; set; }

      public string Date { get; set; }
   }
}
