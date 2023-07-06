using BusTicket.Core.Abstract.IExternal.OBilet;
using BusTicket.Core.Dto.DeviceSession.Request;
using BusTicket.Core.Dto.GetBusJourneys;
using BusTicket.Core.Dto.GetBusJourneys.Request;
using BusTicket.Core.Dto.GetBusJourneys.Response;
using BusTicket.Core.Dto.ResponseModel;
using BusTicket.Core.Halper.ServiceConnectionHalper;
using Newtonsoft.Json;

namespace BusTicket.Core.Concrete.External.OBilet
{
    public class GetBusJourneysManager : IGetBusJourneysService
    {
        private readonly IGetSessionService _sessionService;
        public GetBusJourneysManager(IGetSessionService sessionService)
        {
            _sessionService = sessionService;
        }
        public Response<List<GetBusJourneysResponse>> GetBusLocations(GetBusJourneysRequest request)
        {
            var model = new GetBusJourneyRoot();
            var session = _sessionService.GetSession(new Dto.GetSession.Request.GetSessionRequest());
            var deviceSession = new DeviceSessionRequest
            {
                deviceid = session.data.deviceid,
                sessionid = session.data.sessionid
            };
            model.devicesession = deviceSession;
            model.language = "tr-TR";
            model.date = request.departuredate;
            model.data = request;

            var json = JsonConvert.SerializeObject(model);

            var response = GetConnection<GetBusJourneysResponse>.HttpListGet("https://v2-api.obilet.com/api/journey/getbusjourneys", json);

            return response;


        }
    }
}
