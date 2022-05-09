using Newtonsoft.Json;

namespace WindowsDriver.Requests
{
    public class NewSession
    {
        public Capabilities capabilities { get; set; }
    }
   
    public class Capabilities
    {
        public Firstmatch[] firstMatch { get; set; }
    }

    public class Firstmatch
    {
        public string platformName { get; set; }

        [JsonProperty("appium:app")]
        public string app { get; set; }
    }

    public class NewValue
    {
        public string Value { get; set; }
    }

}
