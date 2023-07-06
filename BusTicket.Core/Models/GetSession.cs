namespace BusTicket.Core.Models
{
    public class GetSession
    {
        public int type { get; set; }
        public Connection connection { get; set; }
        public Browser browser { get; set; }
    }
}
