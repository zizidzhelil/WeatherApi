using Core.Models;

namespace DAL.Tests.Mocks.MockData
{
   public class CoordinateMocks
   {
      public static Coordinates GetCurrentCoordinates(double longitude, double latitude) => new Coordinates()
      {
         Latitude = latitude,
         Longitude = longitude
      };
   }
}
