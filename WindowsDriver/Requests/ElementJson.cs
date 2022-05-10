using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace WindowsDriver.Requests
{
    public class ElementJson
    {
        public ElementValueJson value { get; set; }
    }

    public class ElementValueJson
    {
        [JsonProperty(PropertyName = "element-6066-11e4-a52e-4f735466cecf")]
        public string element { get; set; }
    }
}
