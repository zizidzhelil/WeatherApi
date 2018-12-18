using Core.Models;
using Infrastructure.Models;
using Infrastructure.Services;
using Infrastructure.Weather.Queries;
using System.Threading.Tasks;

namespace BL.Services
{
   public class CurrentWeatherService : ICurrentWeatherService
   {
      private readonly IGetCurrentWeatherQuery _getCurrentWeatherQuery;

      public CurrentWeatherService(IGetCurrentWeatherQuery getCurrentWeatherQuery)
      {
         _getCurrentWeatherQuery = getCurrentWeatherQuery;
      }

      public async Task<CurrentWeatherModel> GetCurrentWeather()
      {
         WeatherObject weather = await _getCurrentWeatherQuery.Execute();
         CurrentWeatherModel currentWeather = new CurrentWeatherModel(weather);

         return currentWeather;
      }
   }
}
