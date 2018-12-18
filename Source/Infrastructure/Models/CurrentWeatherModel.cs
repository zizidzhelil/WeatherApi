using Core.Models;

namespace Infrastructure.Models
{
    public class CurrentWeatherModel
    {
        public CurrentWeatherModel(WeatherObject weatherObject)
        {
            Temperature = weatherObject.WeatherDetails.Temperature.ToString();
            CityName = weatherObject.CityName;
        }

        public string Temperature { get; set; }

        public string CityName { get; set; }
    }
}
