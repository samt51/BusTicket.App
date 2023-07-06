using BusTicket.Core.Dto.DeviceSession.Request;
using Newtonsoft.Json;

namespace BusTicket.Core.Dto.GetBusLocations.Request
{
    public class GetBusLocationsRequest
    {
        public object data { get; set; }
        [JsonProperty("device-session")]
        public DeviceSessionRequest devicesession { get; set; }
        public DateTime date { get; set; }
        public string language { get; set; }
    }
}
