namespace IHubWebApplication.Models
{
    public class Response
    {
        public int StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public List<object> ObjectsList { get; set; }
    }
}
