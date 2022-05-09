using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsDriver.Requests.Return
{


    public class ReturnSession
    {
        public Value value { get; set; }
    }

    public class Value
    {
        public Capabilities capabilities { get; set; }
        public string sessionId { get; set; }
    }

    public class Capabilities
    {
        public string platformName { get; set; }
        public string app { get; set; }
    }
}
