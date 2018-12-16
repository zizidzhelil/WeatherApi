using BL.DependencyResolver;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace WeatherApi
{
   public class Program
   {
      public static void Main(string[] args)
      {
         ServiceProvider serviceProvider = new ServiceCollection()
            .RegisterTypes()
            .BuildServiceProvider();

         var currentWeatherService = serviceProvider.GetService<ICurrentWeatherService>();
         currentWeatherService.GetCurrentWeather().GetAwaiter().GetResult();
      }
   }
}
