using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure.Weather.Queries
{
   public interface IGetWeatherForDaysQuery
   {
      Task<Forecast> Execute(int weatherDays);
   }
}
