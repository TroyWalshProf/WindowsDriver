using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Windows.Automation;
using WindowsDriver.AutomationFramework;
using WindowsDriver.Requests;

namespace WindowsDriver.Controllers
{
    [ApiController]
    [Route("/wd/hub/session/{sessionId}/element")]
    public class Element : ControllerBase
    {
        [HttpPost]
        [Produces("application/json")]
        public IActionResult FindElement(Find find, string sessionId)
        {
            var response = new ElementJson
            {
                value = new ElementValueJson
                {
                    element = Utilities.FindElementShortcut(find, sessionId)
                }
            };

            return StatusCode(200, response);
        }

        [HttpGet("{elementId}/attribute/{name}")]
        [Produces("application/json")]
        public IActionResult GetElementAttribute(string sessionId, string elementId, string name)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{elementId}/clear")]
        [Produces("application/json")]
        public IActionResult ElementClear(string sessionId, string elementId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{elementId}/click")]
        [Produces("application/json")]
        public IActionResult ElementClick(string sessionId, string elementId)
        {
            var element = Utilities.GetElement(elementId);
            LeftClick(element);
            return StatusCode(200, new ValueResponse { sessionId = sessionId });
        }

        [HttpGet("{elementId}/css/{property_name}")]
        [Produces("application/json")]
        public IActionResult GetElementCSSValue(string sessionId, string elementId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{elementId}/element")]
        [Produces("application/json")]
        public IActionResult FindElementFromElement(Find find, string sessionId, string elementId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{elementId}/elements")]
        [Produces("application/json")]
        public IActionResult FindElementsFromElement(Find find, string sessionId, string elementId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{elementId}/enabled")]
        [Produces("application/json")]
        public IActionResult IsElementEnabled(string sessionId, string elementId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{elementId}/name")]
        [Produces("application/json")]
        public IActionResult GetElementTagName(string sessionId, string elementId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{elementId}/property/{name}")]
        [Produces("application/json")]
        public IActionResult GetElementProperty(string sessionId, string elementId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{elementId}/rect")]
        [Produces("application/json")]
        public IActionResult GetElementRect(string sessionId, string elementId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{elementId}/screenshot")]
        [Produces("application/json")]
        public IActionResult TakeElementScreenshot(string sessionId, string elementId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{elementId}/selected")]
        [Produces("application/json")]
        public IActionResult IsElementSelected(string sessionId, string elementId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{elementId}/text")]
        [Produces("application/json")]
        public IActionResult GetElementText(string sessionId, string elementId)
        {
            AutomationElement element = Utilities.GetElement(elementId);

            if (element.TryGetCurrentPattern(ValuePattern.Pattern, out object value))
            {
                return StatusCode(200, new ValueResponse { sessionId = sessionId, value=(value as ValuePattern).Current.Value });
            }
            else if (element.TryGetCurrentPattern(TextPattern.Pattern, out object text))
            {
                return StatusCode(200, new ValueResponse { sessionId = sessionId, value = (text as TextPattern).DocumentRange.GetText(-1) });
            }
            else
            {
                return StatusCode(200, new ValueResponse { sessionId = sessionId, value = element.Current.Name });
            }
        }

        [HttpPost("{elementId}/value")]
        [Produces("application/json")]
        public IActionResult ElementSendKeys(string sessionId, string elementId, TextJson value)
        {

            AutomationElement element = Utilities.GetElement(elementId);
            
            element.SetFocus();
            SendKeys.SendWait(value.text);


            return StatusCode(200, new ValueResponse { sessionId = sessionId });
        }


        //////// TODO : ADD back
        ////////[HttpGet("{sessionId}/element/active")]
        ////////[Produces("application/json")]
        ////////public IActionResult GetActiveElement(string sessionId, string elementId)
        ////////{
        ////////    throw new NotImplementedException();
        ////////}

        //////////[HttpPost("{sessionId}/elements")]
        //////////[Produces("application/json")]
        //////////public IActionResult FindElements(string sessionId, string elementId)
        //////////{
        //////////    throw new NotImplementedException();
        //////////}

        //////////////public static void GetElement(IntPtr app)
        //////////////{
        //////////////    // PropertyCondition con = new PropertyCondition(AutomationElement.ClassNameProperty, "Notepad");
        //////////////    PropertyCondition con = new PropertyCondition(AutomationElement.AutomationIdProperty, "TitleBar");
        //////////////    //TitleBar

        //////////////    var result2 = AutomationElement.FromHandle(app);
        //////////////    var kdkddd = result2.Current.ControlType;

        //////////////    // System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(Type.GetType(AutomationElementInformation.));


        //////////////    //string xml = "";
        //////////////    //using (var sww = new StringWriter())
        //////////////    //{
        //////////////    //    using (XmlWriter writer = XmlWriter.Create(sww))
        //////////////    //    {
        //////////////    //        x.Serialize(writer, result2.Current);
        //////////////    //        xml = sww.ToString(); // Your XML
        //////////////    //    }
        //////////////    //}
        //////////////    //Console.WriteLine(xml);


        //////////////    con = new PropertyCondition(AutomationElement.ClassNameProperty, "RichEditD2DPT");
        //////////////    result2 = result2.FindFirst(TreeScope.Descendants, con);

        //////////////    result2.SetFocus();
        //////////////    SendKeys.SendWait("^{END}");
        //////////////    SendKeys.SendWait("12345zz");


        //////////////    // Point p = result2.GetClickablePoint();
        //////////////    // var inputSimulator = new InputSimulator();
        //////////////    // inputSimulator.Mouse.MoveMouseTo(p.X, p.Y);
        //////////////    // inputSimulator.Mouse.MoveMouseTo(3000, 3000);
        //////////////    //  result2.SetFocus();
        //////////////    ///  LeftClick(result2);
        //////////////    //  inputSimulator.Mouse.RightButtonClick();

        //////////////    Thread.Sleep(10000);
        //////////////    //  Mouse.Click(MouseButton.Left);


        //////////////    var kdkd = ((ValuePattern)result2.GetCurrentPattern(ValuePattern.Pattern)).Current.Value;
        //////////////    //result2 = result2.FindFirst(TreeScope.Descendants, con);

        //////////////    var sksks = AutomationElement.FromHandle(app);
        //////////////    sksks = AutomationElement.FromHandle(new IntPtr(result2.Current.NativeWindowHandle));


        //////////////    var xml = SerializeObjectz(sksks.Current);
        //////////////    //
        //////////////}



        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy,
              int dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        public static void RightClick(AutomationElement element)
        {
            element.SetFocus();
            System.Windows.Point p = element.GetClickablePoint();
            Cursor.Position = new System.Drawing.Point((int)p.X, (int)p.Y);
            mouse_event((int)(MouseEventFlags.RIGHTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.RIGHTUP), 0, 0, 0, 0);
        }

        public static void LeftClick(AutomationElement element)
        {
            element.SetFocus();
            System.Windows.Point p = element.GetClickablePoint();
            Cursor.Position = new System.Drawing.Point((int)p.X, (int)p.Y);
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
        }


        /*
         * 
         * 
         [HttpPost("	New Session
[HttpDelete("{id}	Delete Session
GET	/status	Status
[HttpGet("{id}/timeouts")] - GetTimeouts
[HttpPost("/{id}/timeouts	Set Timeouts
[HttpPost("/{id}/url	Navigate To
[HttpGet("{id}/url")] - GetCurrent URL
[HttpPost("/{id}/back	Back
[HttpPost("/{id}/forward	Forward
[HttpPost("/{id}/refresh	Refresh
[HttpGet("{id}/title")] - GetTitle
[HttpGet("{id}/window")] - GetWindow Handle
[HttpDelete("{id}/window	Close Window
[HttpPost("/{id}/window	Switch To Window
[HttpGet("{id}/window/handles")] - GetWindow Handles
[HttpPost("/{id}/window/new	New Window
[HttpPost("/{id}/frame	Switch To Frame
[HttpPost("/{id}/frame/parent	Switch To Parent Frame
[HttpGet("{id}/window/rect")] - GetWindow Rect
[HttpPost("/{id}/window/rect	Set Window Rect
[HttpPost("/{id}/window/maximize	Maximize Window
[HttpPost("/{id}/window/minimize	Minimize Window
[HttpPost("/{id}/window/fullscreen	Fullscreen Window
[HttpGet("{id}/element/active")] - GetActive Element
[HttpGet("{id}/element/{element id}/shadow")] - GetElement Shadow Root
[HttpPost("/{id}/element	Find Element
[HttpPost("/{id}/elements	Find Elements
[HttpPost("/{id}/element/{element id}/element	Find Element From Element
[HttpPost("/{id}/element/{element id}/elements	Find Elements From Element
[HttpPost("/{id}/shadow/{shadow id}/element	Find Element From Shadow Root
[HttpPost("/{id}/shadow/{shadow id}/elements	Find Elements From Shadow Root
[HttpGet("{id}/element/{element id}/selected	Is Element Selected
[HttpGet("{id}/element/{element id}/attribute/{name}")] - GetElement Attribute
[HttpGet("{id}/element/{element id}/property/{name}")] - GetElement Property
[HttpGet("{id}/element/{element id}/css/{property name}")] - GetElement CSS Value
[HttpGet("{id}/element/{element id}/text")] - GetElement Text
[HttpGet("{id}/element/{element id}/name")] - GetElement Tag Name
[HttpGet("{id}/element/{element id}/rect")] - GetElement Rect
[HttpGet("{id}/element/{element id}/enabled	Is Element Enabled
[HttpGet("{id}/element/{element id}/computedrole")] - GetComputed Role
[HttpGet("{id}/element/{element id}/computedlabel")] - GetComputed Label
[HttpPost("/{id}/element/{element id}/click	Element Click
[HttpPost("/{id}/element/{element id}/clear	Element Clear
[HttpPost("/{id}/element/{element id}/value	Element Send Keys
[HttpGet("{id}/source")] - GetPage Source
[HttpPost("/{id}/execute/sync	Execute Script
[HttpPost("/{id}/execute/async	Execute Async Script
[HttpPost("/{id}/actions	Perform Actions
[HttpDelete("{id}/actions	Release Actions
[HttpPost("/{id}/alert/dismiss	Dismiss Alert
[HttpPost("/{id}/alert/accept	Accept Alert
[HttpGet("{id}/alert/text")] - GetAlert Text
[HttpPost("/{id}/alert/text	Send Alert Text
[HttpGet("{id}/screenshot	Take Screenshot
[HttpGet("{id}/element/{element id}/screenshot	Take Element Screenshot
[HttpPost("/{id}/print	Print Page
         * 
         * 
         * 
         */


    }
}