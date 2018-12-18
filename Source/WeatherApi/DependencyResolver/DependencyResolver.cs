using Infrastructure.Providers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeatherApi.Providers;

namespace WeatherApi.DependencyResolver
{
   public static class DependencyResolver
   {
      public static ServiceCollection RegisterConcreteTypes(this ServiceCollection serviceCollection, IConfigurationRoot configuration)
      {
         serviceCollection.AddSingleton<IAppSettingsProvider>(new AppSettingsProvider(configuration));

         return serviceCollection;
      }
   }
}
