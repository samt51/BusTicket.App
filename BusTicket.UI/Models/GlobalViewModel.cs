using BusTicket.Core.Dto.GetBusJourneys.Response;
using BusTicket.Core.Dto.GetBusLocations.Response;

namespace BusTicket.UI.Models
{
    public class GlobalViewModel
    {
        public List<GetBusLocationsResponse> GetBusLocationsResponses { get; set; }
        public GetBusLocationsResponse GetBusLocationsResponse { get; set; }
        public List<GetBusJourneysResponse> getBusJourneysResponses { get; set; }
    }
}
