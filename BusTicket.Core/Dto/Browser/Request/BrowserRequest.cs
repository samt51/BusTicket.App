using Newtonsoft.Json;

namespace BusTicket.Core.Dto.Browser.Request
{
    public class BrowserRequest
    {
        public string name { get; set; } = "Chrome";
        public string version { get; set; } = "47.0.0.12";
        [JsonProperty("equipment-id")]
        public string equipmentid { get; set; } = "distribusion";
    }
}
