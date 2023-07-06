using BusTicket.Core.Abstract.IExternal.OBilet;
using BusTicket.Core.Dto.DeviceSession.Request;
using BusTicket.Core.Dto.GetBusLocations.Request;
using BusTicket.Core.Dto.GetBusLocations.Response;
using BusTicket.Core.Dto.ResponseModel;
using BusTicket.Core.Halper.ServiceConnectionHalper;
using Newtonsoft.Json;

namespace BusTicket.Core.Concrete.External.OBilet
{
    public class GetBusLocationsManager : IGetBusLocationsService
    {
        private readonly IGetSessionService _sessionService;
        public GetBusLocationsManager(IGetSessionService sessionService)
        {
            _sessionService = sessionService;
        }
        public Response<List<GetBusLocationsResponse>> GetBusLocations(GetBusLocationsRequest request)
        {
            
            var session = _sessionService.GetSession(new Dto.GetSession.Request.GetSessionRequest());
            var deviceSession = new DeviceSessionRequest
            {
                deviceid= session.data.deviceid,
                sessionid= session.data.sessionid
            };
            request.data = null;
            request.devicesession= deviceSession;
            request.date = Convert.ToDateTime("2016-03-11T11:33:00");
            request.language = "tr-TR";

            var json=JsonConvert.SerializeObject(request);

            var response = GetConnection<GetBusLocationsResponse>.HttpListGet("https://v2-api.obilet.com/api/location/getbuslocations", json);
        
            return response;

        }
    }
}
