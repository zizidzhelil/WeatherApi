using Core.Models;
using Infrastructure.Weather.Queries;
using System.Threading.Tasks;

namespace DAL.Weather.Queries
{
   public class GetCurrentWeatherQuery : IGetCurrentWeatherQuery
   {

      public Task<Coord> GetCurrentWeather()
      {
         throw new System.NotImplementedException();
      }
   }
}
