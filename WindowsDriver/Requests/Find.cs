using System.Runtime.Serialization;

namespace WindowsDriver.Requests
{
    [DataContract]
    public class Find
    {
        [DataMember(Name ="using")]
        public string _using { get; set; }

        [DataMember]
        public string value { get; set; }
    }

}
