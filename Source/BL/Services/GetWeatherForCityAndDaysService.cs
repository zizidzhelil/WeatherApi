using Core.Models;
using Infrastructure.Models;
using Infrastructure.Services;
using Infrastructure.Weather.Queries;
using System.Threading.Tasks;

namespace BL.Services
{
   public class GetWeatherForCityAndDaysService : IGetWeatherForCityAndDaysService
   {
      private readonly IGetWeatherForCityAndDaysQuery _getWeatherForCityAndDaysQuery;

      public GetWeatherForCityAndDaysService(IGetWeatherForCityAndDaysQuery getCurrentWeatherQuery)
      {
         _getWeatherForCityAndDaysQuery = getCurrentWeatherQuery;
      }

      public async Task<WeatherForCityAndDaysModel> GetWeatherForCityAndDays(string city, int weatherForDays)
      {
         Forecast forecast = await _getWeatherForCityAndDaysQuery.Execute(city, weatherForDays);
         WeatherForCityAndDaysModel currentWeather = new WeatherForCityAndDaysModel(forecast);

         return currentWeather;
      }
   }
}
