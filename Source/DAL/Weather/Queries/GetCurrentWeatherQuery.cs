using Core.Models;
using DAL.Context;
using Infrastructure.Weather.Queries;
using System.Threading.Tasks;

namespace DAL.Weather.Queries
{
   public class GetCurrentWeatherQuery : IGetCurrentWeatherQuery
   {
      private readonly WeatherContext _context;

      public GetCurrentWeatherQuery(WeatherContext context)
      {
         _context = context;
      }

      public Task<Coord> Execute()
      {
         string result = _context.MakeRequest("");
         throw new System.NotImplementedException();
      }
   }
}
