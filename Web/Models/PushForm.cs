namespace Web.Models
{
    public class PushForm
    {

        public string Token { get; set; }

        public string Platform { get; set; }
        public string OsVersion { get; set; }

        public string UdId { get; set; }
    }
}