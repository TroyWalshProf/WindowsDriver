namespace WindowsDriver.Requests
{
    public class ActionsJson
    {
        public Actions[] actions { get; set; }
    }

    public class Actions
    {
        public string type { get; set; }
        public string id { get; set; }
        public Parameters parameters { get; set; }
        public SubAction[] actions { get; set; }
    }

    public class Parameters
    {
        public string pointerType { get; set; }
    }

    public class SubAction
    {
        public string type { get; set; }
        public int button { get; set; }
        public int duration { get; set; }
        public object origin { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string value { get; set; }
    }
}
