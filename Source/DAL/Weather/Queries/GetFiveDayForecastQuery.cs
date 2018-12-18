using Core.Models;
using Infrastructure.Context;
using Infrastructure.Providers;
using Infrastructure.Weather.Queries;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace DAL.Weather.Queries
{
   public class GetFiveDayForecastQuery : IGetFiveDayForecastQuery
   {
      private readonly IWeatherContext _context;
      private readonly IAppSettingsProvider _appSettingsProvider;

      public GetFiveDayForecastQuery(IWeatherContext context, IAppSettingsProvider appSettingsProvider)
      {
         _context = context;
         _appSettingsProvider = appSettingsProvider;
      }

      public async Task<ForecastObject> Execute()
      {
         string result = await _context.MakeRequest($"https://samples.openweathermap.org/data/2.5/forecast?lat=35&lon=139&appid={_appSettingsProvider.ApiKey}");
         ForecastObject weatherForFiveDay = JsonConvert.DeserializeObject<ForecastObject>(result);

         return weatherForFiveDay;
      }
   }
}
