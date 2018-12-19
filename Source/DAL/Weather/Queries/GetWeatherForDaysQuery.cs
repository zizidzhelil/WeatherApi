using Core.Models;
using Infrastructure.Context;
using Infrastructure.Providers;
using Infrastructure.Weather.Queries;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Weather.Queries
{
   public class GetWeatherForDaysQuery : IGetWeatherForDaysQuery
   {
      private readonly IWeatherContext _context;
      private readonly IAppSettingsProvider _appSettingsProvider;

      public GetWeatherForDaysQuery(IWeatherContext context, IAppSettingsProvider appSettingsProvider)
      {
         _context = context;
         _appSettingsProvider = appSettingsProvider;
      }

      public async Task<Forecast> Execute(int weatherDays)
      {
         string result = await _context.MakeRequest($"https://api.openweathermap.org/data/2.5/forecast?lat=35&lon=139&appid={_appSettingsProvider.ApiKey}");

         Forecast forecast = JsonConvert.DeserializeObject<Forecast>(result);
         forecast.ForecastCount = weatherDays;
         forecast.MultiDayForecast = forecast.MultiDayForecast.Take(weatherDays).ToList();

         return forecast;
      }
   }
}
