using Newtonsoft.Json;

namespace Core.Models
{
   public class City
   {
      [JsonProperty("id")]
      public int Id { get; set; }

      [JsonProperty("name")]
      public string Name { get; set; }

      [JsonProperty("coord")]
      public Coordinates Coordinates { get; set; }

      [JsonProperty("country")]
      public string Country { get; set; }
   }
}
