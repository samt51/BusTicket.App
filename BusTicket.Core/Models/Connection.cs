using Newtonsoft.Json;

namespace BusTicket.Core.Models
{
    public class Connection
    {
        [JsonProperty("ip-address")]
        public string ipaddress { get; set; }
        public string port { get; set; }
    }
}
