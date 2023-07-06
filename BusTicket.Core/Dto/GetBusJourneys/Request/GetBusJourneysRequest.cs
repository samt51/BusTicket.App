using Newtonsoft.Json;

namespace BusTicket.Core.Dto.GetBusJourneys.Request
{
    public class GetBusJourneysRequest
    {
        [JsonProperty("origin-id")]
        public string originid { get; set; }

        [JsonProperty("destination-id")]
        public string destinationid { get; set; }

        [JsonProperty("departure-date")]
        public string departuredate { get; set; }
    }
}
