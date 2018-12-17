using Newtonsoft.Json;

namespace Core.Models
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int CloudinessPercent { get; set; }
    }
}
