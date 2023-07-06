using Newtonsoft.Json;

namespace BusTicket.Core.Models
{
    public class Browser
    {
        public string name { get; set; }
        public string version { get; set; }

        [JsonProperty("equipment-id")]
        public string equipmentid { get; set; }
    }
}
