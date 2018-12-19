﻿using BL.DependencyResolver;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeatherApi.DependencyResolver;

namespace WeatherApi
{
   public class Program
   {
      public static void Main(string[] args)
      {
         IConfigurationRoot configguration = new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .Build();

         ServiceProvider serviceProvider = new ServiceCollection()
            .RegisterConcreteTypes(configguration)
            .RegisterTypes()
            .BuildServiceProvider();

         var weatherForDaysService = serviceProvider.GetService<IGetWeatherForDaysService>();
         var result = weatherForDaysService.GetWeatherForDays(4).GetAwaiter().GetResult();
      }
   }
}
