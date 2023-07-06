using Newtonsoft.Json;

namespace BusTicket.Core.Dto.DeviceSession.Request
{
    public class DeviceSessionRequest
    {
        [JsonProperty("session-id")]
        public string sessionid { get; set; }

        [JsonProperty("device-id")]
        public string deviceid { get; set; }
    }
}
