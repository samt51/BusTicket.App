using BusTicket.Core.Dto.Browser.Request;
using BusTicket.Core.Dto.Connection.Request;

namespace BusTicket.Core.Dto.GetSession.Request
{
    public class GetSessionRequest
    {
        public int type { get; set; } = 1;
        public ConnectionRequest connection { get; set; }
        public BrowserRequest browser { get; set; }
    }
}
