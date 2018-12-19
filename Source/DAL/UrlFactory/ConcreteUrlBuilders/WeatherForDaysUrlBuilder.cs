using Common.Constants;
using Infrastructure.Providers;
using Infrastructure.UrlFactory.UrlBuilder;

namespace DAL.UrlFactory.ConcreteUrlBuilders
{
   public class WeatherForDaysUrlBuilder : IUrlBuilder
   {
      private readonly IAppSettingsProvider _appSettingsProvider;

      public WeatherForDaysUrlBuilder(IAppSettingsProvider appSettingsProvider)
      {
         _appSettingsProvider = appSettingsProvider;
      }

      public string Build(params string[] args)
      {
         return $"{CommonConstants.BaseWeatherUrl}?lat={args[0]}&lon={args[1]}&appId={_appSettingsProvider.ApiKey}";
      }
   }
}
