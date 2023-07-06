using BusTicket.Core.Dto.GetSession.Request;
using BusTicket.Core.Dto.GetSession.Response;
using BusTicket.Core.Dto.ResponseModel;

namespace BusTicket.Core.Abstract.IExternal.OBilet
{

    public interface IGetSessionService
    {
        Response<GetSessionResponse> GetSession(GetSessionRequest request);
    }
}
