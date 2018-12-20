using System;
using System.Collections.Generic;
using Infrastructure.UrlFactory;
using Infrastructure.UrlFactory.UrlBuilder;

namespace DAL.Factories
{
   public class UrlFactory : IUrlFactory
   {
      private readonly Dictionary<string, Func<IUrlBuilder>> _urlBuilders;

      public UrlFactory(Dictionary<string, Func<IUrlBuilder>> urlBuilders)
      {
         this._urlBuilders = urlBuilders;
      }

      public string Create(string builderName, params string[] args)
      {
         if (!_urlBuilders.ContainsKey(builderName))
         {
            throw new KeyNotFoundException($"{nameof(builderName)} is not registered in DI.");
         }

         return _urlBuilders[builderName]().Build(args);
      }
   }
}
