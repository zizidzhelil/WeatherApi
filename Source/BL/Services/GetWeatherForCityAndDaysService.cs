using Core.Models;
using Infrastructure.Grouper;
using Infrastructure.Models;
using Infrastructure.Services;
using Infrastructure.Weather.Queries;
using System.Threading.Tasks;

namespace BL.Services
{
   public class GetWeatherForCityAndDaysService : IGetWeatherForCityAndDaysService
   {
      private readonly IGetWeatherForCityQuery _getWeatherForCityQuery;
      private readonly IGroupWeatherByDay _groupWeatherByDay;

      public GetWeatherForCityAndDaysService(
         IGetWeatherForCityQuery getCurrentWeatherQuery,
         IGroupWeatherByDay groupWeatherByDay)
      {
         _getWeatherForCityQuery = getCurrentWeatherQuery;
         _groupWeatherByDay = groupWeatherByDay;
      }

      public async Task<WeatherForCityAndDaysModel> GetWeatherForCityAndDays(string city, int weatherForDays)
      {
         Forecast forecast = await _getWeatherForCityQuery.Execute(city);
         WeatherForCityAndDaysModel currentWeather = _groupWeatherByDay.GroupWeather(forecast, weatherForDays);

         return currentWeather;
      }
   }
}
