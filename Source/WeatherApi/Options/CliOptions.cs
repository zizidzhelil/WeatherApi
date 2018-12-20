using CommandLine;

namespace WeatherApi.Options
{
   public class CliOptions
   {
      [Option('c', "CityName", Required = true, HelpText = "City name to display the weather")]
      public string City { get; set; }

      [Option('d', "SubsequentDays", Required = true, HelpText = "Subsequent days to display the weather")]
      public int SubsequentDays { get; set; }
   }
}
