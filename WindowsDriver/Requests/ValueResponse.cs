namespace WindowsDriver.Requests
{
    public class ValueResponse
    {
        public string sessionId { get; set; }
        public object value { get; set; }

    }


    public class ValueArrayResponse
    {
        public string sessionId { get; set; }
        public object[] value { get; set; }
    }

}
