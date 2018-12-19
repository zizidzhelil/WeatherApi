using Common.Constants;
using Infrastructure.Providers;
using Infrastructure.UrlFactory.UrlBuilder;

namespace DAL.UrlFactory.ConcreteUrlBuilders
{
   public class WeatherForCityAndDaysUrlBuilder : IUrlBuilder
   {
      private readonly IAppSettingsProvider _appSettingsProvider;

      public WeatherForCityAndDaysUrlBuilder(IAppSettingsProvider appSettingsProvider)
      {
         _appSettingsProvider = appSettingsProvider;
      }

      public string Build(params string[] args)
      {
         return $"{CommonConstants.BaseWeatherUrl}?q={args[0]},bg&appId={_appSettingsProvider.ApiKey}";
      }
   }
}
