using Core.Models;
using Infrastructure.Models;
using Infrastructure.Services;
using Infrastructure.Weather.Queries;
using System.Threading.Tasks;

namespace BL.Services
{
   public class FiveDayForecastService : IFiveDayForecastService
   {
      private readonly IGetFiveDayForecastQuery _getFiveDayForecastQuery;

      public FiveDayForecastService(IGetFiveDayForecastQuery getFiveDayForecastQuery)
      {
         _getFiveDayForecastQuery = getFiveDayForecastQuery;
      }

      public async Task<FiveDayForecastModel> GetFiveDayForecast()
      {
         ForecastObject forecast = await _getFiveDayForecastQuery.Execute();
         FiveDayForecastModel fiveDayForecastModel = new FiveDayForecastModel(forecast);

         return fiveDayForecastModel;
      }
   }
}
