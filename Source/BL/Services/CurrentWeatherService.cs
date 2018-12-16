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
         // TODO: fix this coord return type once we have all the models.
         Coord coord = await _getCurrentWeatherQuery.Execute();
         CurrentWeatherModel weatherModel = new CurrentWeatherModel(coord);

         return weatherModel;
      }
   }
}
