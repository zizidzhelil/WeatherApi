using Core.Models;
using Infrastructure.Context;
using Infrastructure.Providers;
using Infrastructure.Weather.Queries;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using DAL.UrlFactory.ConcreteUrlBuilders;
using Infrastructure.UrlFactory;
using Infrastructure.UrlFactory.UrlBuilder;

namespace DAL.Weather.Queries
{
   public class GetWeatherForDaysQuery : IGetWeatherForDaysQuery
   {
      private readonly IWeatherContext _context;
      private readonly IUrlFactory _urlFactory;

      public GetWeatherForDaysQuery(IWeatherContext context, IUrlFactory urlFactory)
      {
         _context = context;
         _urlFactory = urlFactory;
      }

      public async Task<Forecast> Execute(int weatherDays, Coordinates coordinates)
      {
         string result = await _context.MakeRequest(_urlFactory.Create(
            nameof(WeatherForDaysUrlBuilder),
            coordinates.Latitude.ToString(),
            coordinates.Longitude.ToString()));

         Forecast forecast = JsonConvert.DeserializeObject<Forecast>(result);
         forecast.ForecastCount = weatherDays;
         forecast.MultiDayForecast = forecast.MultiDayForecast.Take(weatherDays).ToList();

         return forecast;
      }
   }
}
