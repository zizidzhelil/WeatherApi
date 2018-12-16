using Core.Models;

namespace Infrastructure.Models
{
   public class CurrentWeatherModel
   {
      // TODO: fix this coord return type once we have all the models.
      public CurrentWeatherModel(Coord coord)
      {
         this.Degrees = coord.ToString();
      }

      public string Degrees { get; set; }
   }
}
