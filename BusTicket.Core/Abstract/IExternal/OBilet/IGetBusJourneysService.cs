using BusTicket.Core.Dto.GetBusJourneys.Request;
using BusTicket.Core.Dto.GetBusJourneys.Response;
using BusTicket.Core.Dto.ResponseModel;

namespace BusTicket.Core.Abstract.IExternal.OBilet
{
    public interface IGetBusJourneysService
    {
        Response<List<GetBusJourneysResponse>> GetBusLocations(GetBusJourneysRequest request);
        
    }
}
