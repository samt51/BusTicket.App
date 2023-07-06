using Newtonsoft.Json;

namespace BusTicket.Core.Dto.Connection.Request
{
    public class ConnectionRequest
    {
        [JsonProperty("ip-address")]
        public string ipaddress { get; set; } = "165.114.41.21";
        public string port { get; set; } = "5117";
    }
}
