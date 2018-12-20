using Core.Models;
using Infrastructure.Models;

namespace Infrastructure.Grouper
{
   public interface IGroupWeatherByDay
   {
      WeatherForCityAndDaysModel GroupWeather(Forecast forecast, int weatherForDaysCount);
   }
}
