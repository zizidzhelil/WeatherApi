using System;
using Core.Models;
using Infrastructure.Converters;
using Infrastructure.Grouper;
using Infrastructure.Models;
using System.Linq;

namespace BL.Grouper
{
   public class GroupWeatherByDay : IGroupWeatherByDay
   {
      private readonly IUnixDateTimeConverter _unixDateTimeConverter;

      public GroupWeatherByDay(IUnixDateTimeConverter unixDateTimeConverter)
      {
         _unixDateTimeConverter = unixDateTimeConverter;
      }

      public WeatherForCityAndDaysModel GroupWeather(Forecast forecast, int weatherForDaysCount)
      {
         WeatherForCityAndDaysModel weatherForDays = new WeatherForCityAndDaysModel
         {
            Weather = forecast.MultiDayForecast
               .GroupBy(
                  w => DateTime.Parse(w.ForecastCalculationUtc).ToString("yyyy-MM-dd"),
                  w => w,
                  (day, weather) =>
                     new
                     {
                        Day = day,
                        Weather = weather
                     })
               .Select(w => new WeatherForCityAndDayModel()
               {
                  Date = w.Day,
                  CloudinessPercent = w.Weather.Average(c => c.Clouds.CloudinessPercent),
                  Humidity = w.Weather.Average(h => h.WeatherDetails.Humidity),
                  Temperature = w.Weather.Average(t => t.WeatherDetails.Temperature).ToString(),
                  WindSpeed = w.Weather.Average(ws => ws.Wind.Speed),
                  Pressure = w.Weather.Average(p => p.WeatherDetails.Pressure).ToString(),
                  Description = w.Weather.LastOrDefault()?.WeatherForecast.Select(wf => wf.Description).LastOrDefault()
               })
               .Take(weatherForDaysCount)
               .ToList(),
            CityName = forecast.City.Name
         };

         return weatherForDays;
      }
   }
}
