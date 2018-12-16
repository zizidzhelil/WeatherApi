using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure.Weather.Queries
{
   public interface IGetCurrentWeatherQuery
   {
      // TODO: Fix this Coord return type once we have all the model types from the service.
      Task<Coord> Execute();
   }
}
