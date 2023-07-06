using BusTicket.Core.Abstract.IExternal.OBilet;
using BusTicket.Core.Dto.Connection.Request;
using BusTicket.Core.Dto.GetSession.Request;
using BusTicket.Core.Dto.GetSession.Response;
using BusTicket.Core.Dto.ResponseModel;
using BusTicket.Core.Halper.ServiceConnectionHalper;
using Newtonsoft.Json;

namespace BusTicket.Core.Concrete.External.OBilet
{
    public class GetSessionManager : IGetSessionService
    {
        public Response<GetSessionResponse> GetSession(GetSessionRequest request)
        {
            request.connection = new ConnectionRequest();
            request.browser = new Dto.Browser.Request.BrowserRequest();
            var json = JsonConvert.SerializeObject(request);
            var response = GetConnection<GetSessionResponse>.HttpGet("https://v2-api.obilet.com/api/client/getsession", json);
            return response;
        }
    }
}
