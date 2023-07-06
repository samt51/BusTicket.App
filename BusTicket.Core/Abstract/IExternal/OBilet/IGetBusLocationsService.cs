using BusTicket.Core.Dto.GetBusLocations.Request;
using BusTicket.Core.Dto.GetBusLocations.Response;
using BusTicket.Core.Dto.ResponseModel;

namespace BusTicket.Core.Abstract.IExternal.OBilet
{
    public interface IGetBusLocationsService
    {
        Response<List<GetBusLocationsResponse>> GetBusLocations(GetBusLocationsRequest request);

    }
}
