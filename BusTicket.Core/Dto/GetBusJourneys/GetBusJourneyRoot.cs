using BusTicket.Core.Dto.DeviceSession.Request;
using BusTicket.Core.Dto.GetBusJourneys.Request;
using Newtonsoft.Json;

namespace BusTicket.Core.Dto.GetBusJourneys
{
    public class GetBusJourneyRoot
    {
        [JsonProperty("device-session")]
        public DeviceSessionRequest devicesession { get; set; }
        public string date { get; set; }
        public string language { get; set; }
        public GetBusJourneysRequest data { get; set; }
    }
}
