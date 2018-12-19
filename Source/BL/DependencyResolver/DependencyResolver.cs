using BL.Services;
using DAL.Context;
using DAL.UrlFactory;
using DAL.UrlFactory.ConcreteUrlBuilders;
using DAL.Weather.Queries;
using Infrastructure.Context;
using Infrastructure.Providers;
using Infrastructure.Services;
using Infrastructure.UrlFactory;
using Infrastructure.UrlFactory.UrlBuilder;
using Infrastructure.Weather.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace BL.DependencyResolver
{
   public static class DependencyResolver
   {
      public static ServiceCollection RegisterTypes(this ServiceCollection serviceCollection)
      {
         serviceCollection.AddScoped<IWeatherContext, WeatherContext>();

         serviceCollection.AddScoped<IGetWeatherForDaysService, GetWeatherForDaysService>();

         serviceCollection.AddScoped<IGetWeatherForDaysQuery, GetWeatherForDaysQuery>();

         serviceCollection.AddScoped<IUrlFactory>((serviceProvider) =>
            new UrlFactory(new Dictionary<string, Func<IUrlBuilder>>()
            {
               { nameof(WeatherForDaysUrlBuilder), () => new WeatherForDaysUrlBuilder(serviceProvider.GetService<IAppSettingsProvider>()) }
            }));

         serviceCollection.AddHttpClient();

         return serviceCollection;
      }
   }
}
