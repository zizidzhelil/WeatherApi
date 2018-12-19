using Core.Models;
using Infrastructure.Models;
using Infrastructure.Services;
using Infrastructure.Weather.Queries;
using System.Threading.Tasks;

namespace BL.Services
{
   public class GetWeatherForDaysService : IGetWeatherForDaysService
   {
      private readonly IGetWeatherForDaysQuery _getWeatherForDaysQuery;

      public GetWeatherForDaysService(IGetWeatherForDaysQuery getCurrentWeatherQuery)
      {
         _getWeatherForDaysQuery = getCurrentWeatherQuery;
      }

      public async Task<WeatherForDaysModel> GetWeatherForDays(int weatherForDays)
      {
         // TODO: Implement actual geolocation search
         Forecast forecast = await _getWeatherForDaysQuery.Execute(weatherForDays, new Coordinates() { Longitude = 39.0, Latitude = 40.0 });
         WeatherForDaysModel currentWeather = new WeatherForDaysModel(forecast);

         return currentWeather;
      }
   }
}
