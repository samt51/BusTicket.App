using Newtonsoft.Json;

namespace BusTicket.Core.Dto.ResponseModel
{
    public class Response<T>
    {
        public string status { get; set; }
        public T data { get; set; }
        public object message { get; set; }

        [JsonProperty("user-message")]
        public object usermessage { get; set; }

        [JsonProperty("api-request-id")]
        public object apirequestid { get; set; }
        public string controller { get; set; }

        [JsonProperty("client-request-id")]
        public object clientrequestid { get; set; }

        [JsonProperty("web-correlation-id")]
        public object webcorrelationid { get; set; }

        [JsonProperty("correlation-id")]
        public string correlationid { get; set; }
    }
}
