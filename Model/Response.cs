namespace IHubWebApplication.Model
{
    public class Response
    {
        public int StatusCode { get; set; }

        public string StatusMessage { get; set; }

        public List<object> ObjectsList { get; set; }
        public int UpdatedID { get; internal set; }
        //public int UpdatedId { get; internal set; }
    }
}
