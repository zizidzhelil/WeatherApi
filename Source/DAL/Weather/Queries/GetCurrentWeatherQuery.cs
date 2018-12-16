using Core.Models;
using DAL.Context;
using Infrastructure.Weather.Queries;
using System.Threading.Tasks;
using Infrastructure.Context;

namespace DAL.Weather.Queries
{
   public class GetCurrentWeatherQuery : IGetCurrentWeatherQuery
   {
      private readonly IWeatherContext _context;

      public GetCurrentWeatherQuery(IWeatherContext context)
      {
         _context = context;
      }

      // TODO: Implement missing method.
      public async Task<Coord> Execute()
      {
         string result = await _context.MakeRequest("");
         return null;
      }
   }
}
