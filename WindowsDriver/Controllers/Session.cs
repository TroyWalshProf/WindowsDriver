using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Resolvers;
using WindowsDriver.Requests;
using WindowsDriver.Requests.Return;

namespace WindowsDriver.Controllers
{
    [ApiController]
    [Route("/wd/hub/session")]
    public class Session : ControllerBase
    {

        [HttpDelete("{sessionId}")]
        [Produces("application/json")]
        public IActionResult DeleteSession(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/actions")]
        [Produces("application/json")]
        public IActionResult PerformActions(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{sessionId}/actions")]
        [Produces("application/json")]
        public IActionResult ReleaseActions(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/alert/accept")]
        [Produces("application/json")]
        public IActionResult AcceptAlert(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/alert/dismiss")]
        [Produces("application/json")]
        public IActionResult DismissAlert(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/alert/text")]
        [Produces("application/json")]
        public IActionResult GetAlertText(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/alert/text")]
        [Produces("application/json")]
        public IActionResult SendAlertText(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/back")]
        [Produces("application/json")]
        public IActionResult Back(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{sessionId}/cookie")]
        [Produces("application/json")]
        public IActionResult DeleteAllCookies(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/cookie")]
        [Produces("application/json")]
        public IActionResult GetAllCookies(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/cookie")]
        [Produces("application/json")]
        public IActionResult AddCookie(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/cookie/{name}")]
        [Produces("application/json")]
        public IActionResult GetNamedCookie(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{sessionId}/cookie/{name}")]
        [Produces("application/json")]
        public IActionResult DeleteCookie(string sessionId)
        {
            string xml = "";

            XDocument xDoc = XDocument.Parse(xml);

            Console.WriteLine(xDoc.XPathSelectElement("//h3").Value);






            throw new NotImplementedException();
        }

        [HttpPost("{SessionId}/element")]
        [Produces("application/json")]
        public IActionResult FindElement(Find find, string SessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/element/{element_id}/attribute/{name}")]
        [Produces("application/json")]
        public IActionResult GetElementAttribute(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/element/{element_id}/clear")]
        [Produces("application/json")]
        public IActionResult ElementClear(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/element/{element_id}/click")]
        [Produces("application/json")]
        public IActionResult ElementClick(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/element/{element_id}/css/{property_name}")]
        [Produces("application/json")]
        public IActionResult GetElementCSSValue(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/element/{element_id}/element")]
        [Produces("application/json")]
        public IActionResult FindElementFromElement(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/element/{element_id}/elements")]
        [Produces("application/json")]
        public IActionResult FindElementsFromElement(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/element/{element_id}/enabled")]
        [Produces("application/json")]
        public IActionResult IsElementEnabled(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/element/{element_id}/name")]
        [Produces("application/json")]
        public IActionResult GetElementTagName(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/element/{element_id}/property/{name}")]
        [Produces("application/json")]
        public IActionResult GetElementProperty(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/element/{element_id}/rect")]
        [Produces("application/json")]
        public IActionResult GetElementRect(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/element/{element_id}/screenshot")]
        [Produces("application/json")]
        public IActionResult TakeElementScreenshot(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/element/{element_id}/selected")]
        [Produces("application/json")]
        public IActionResult IsElementSelected(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/element/{element_id}/text")]
        [Produces("application/json")]
        public IActionResult GetElementText(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/element/{element_id}/value")]
        [Produces("application/json")]
        public IActionResult ElementSendKeys(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/element/active")]
        [Produces("application/json")]
        public IActionResult GetActiveElement(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/elements")]
        [Produces("application/json")]
        public IActionResult FindElements(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/execute/async")]
        [Produces("application/json")]
        public IActionResult ExecuteAsyncScript(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/execute/sync")]
        [Produces("application/json")]
        public IActionResult ExecuteScript(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/forward")]
        [Produces("application/json")]
        public IActionResult Forward(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/frame")]
        [Produces("application/json")]
        public IActionResult SwitchToFrame(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/frame/parent")]
        [Produces("application/json")]
        public IActionResult SwitchToParentFrame(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/print")]
        [Produces("application/json")]
        public IActionResult PrintPage(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/refresh")]
        [Produces("application/json")]
        public IActionResult Refresh(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/screenshot")]
        [Produces("application/json")]
        public IActionResult TakeScreenshot(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/source")]
        [Produces("application/json")]
        public IActionResult GetPageSource(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/timeouts")]
        [Produces("application/json")]
        public IActionResult GetTimeouts(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/timeouts")]
        [Produces("application/json")]
        public IActionResult SetTimeouts(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/title")]
        [Produces("application/json")]
        public IActionResult GetTitle(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/url")]
        [Produces("application/json")]
        public IActionResult Go(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/url")]
        [Produces("application/json")]
        public IActionResult GetCurrentURL(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/window")]
        [Produces("application/json")]
        public IActionResult GetWindowHandle(string sessionId)
        {
            return StatusCode(200, "123");
            ///throw new NotImplementedException();
        }

        [HttpDelete("{sessionId}/window")]
        [Produces("application/json")]
        public IActionResult CloseWindow(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/window")]
        [Produces("application/json")]
        public IActionResult SwitchToWindow(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/window/fullscreen")]
        [Produces("application/json")]
        public IActionResult FullscreenWindow(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/window/handles")]
        [Produces("application/json")]
        public IActionResult GetWindowHandles(string sessionId)
        {
            return StatusCode(200, "123");
        }

        [HttpPost("{sessionId}/window/maximize")]
        [Produces("application/json")]
        public IActionResult MaximizeWindow(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/window/minimize")]
        [Produces("application/json")]
        public IActionResult MinimizeWindow(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{sessionId}/window/rect")]
        [Produces("application/json")]
        public IActionResult GetWindowRect(string sessionId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{sessionId}/window/rect")]
        [Produces("application/json")]
        public IActionResult SetWindowRect(string sessionId)
        {
            throw new NotImplementedException();
        }






        //// GET: Session
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: Session/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Session/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Session/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Session/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Session/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        [HttpPost]
        [Produces("application/json")]
        public IActionResult NewSession(NewSession newSession)
        {
            Console.WriteLine($"[WindowsDriver] {this.RouteData}");

            ReturnSession session = new()
            {
                value = new Value
                {
                    capabilities = new Requests.Return.Capabilities()
                }
            };

            session.value.capabilities.app = newSession.capabilities.firstMatch[0].app;
            session.value.capabilities.platformName = newSession.capabilities.firstMatch[0].platformName;
            var application = AppController.Launch(session.value.capabilities.app);
  
            
            string tempGUID = $"00000000-0000-0000-0000-{application.Handle.ToInt64().ToString().PadLeft(12, '0')}";
            var lsls = Guid.Parse(tempGUID);
            session.value.sessionId = tempGUID;
           // session.value.sessionId = application.Handle.ToInt64().ToString();



            ////// var kdflks = test.Handle.ToString();
            ////// var kdflkss = test.Handle.ToInt64().ToString();
            ////// var kdflkssss = kdflkss.ToString();


            ////// IntPtr handle = new IntPtr(Convert.ToInt64(kdflkssss, 16));
            ////// IntPtr handle2 = new IntPtr(Convert.ToInt64(kdflkssss));
            ////// IntPtr handle3 = new IntPtr(Convert.ToInt64(session.value.sessionId));



            ////// Console.WriteLine($"[WindowsDriver] {session}");

            ////// Process process = Process.GetProcessById(test.Id);
            ////// Thread.Sleep(1000);
            //////GetElement(test.Handle);

            ////// //elementz.Add((element as AutomationElement).Current);

            ////// //var value = (element as AutomationElement).Current.NativeWindowHandle;
            ////// //var sksks = AutomationElement.FromHandle(new IntPtr(value));

            ////// process.CloseMainWindow();
            //////// process.Close();
            ////// Thread.Sleep(1000);

            ////// if (!process.HasExited)
            ////// {
            //////     process.Kill();
            ////// }
            return StatusCode(200, session);
        }

        [HttpPost("{sessionId}/appium/app/close")]
        [Produces("application/json")]
        public IActionResult CloseApp(string sessionId)
        {
            var id = sessionId.Split('-').Last().TrimStart('0');

            var app = AutomationElement.FromHandle(new IntPtr(Convert.ToInt64(id)));
            var process = Process.GetProcessById(app.Current.ProcessId);

            process.CloseMainWindow();
            Thread.Sleep(1000);

            if (!process.HasExited)
            {
                process.Kill();
            }

            var response = new ValueResponse
            {
                sessionId = sessionId
            };

            return StatusCode(200, response);
        }

        [HttpDelete("{id}")]
        [Produces("application/json")]
        public IActionResult Delete(string id)
        {
            var app = AutomationElement.FromHandle(new IntPtr(Convert.ToInt64(id)));
            var process = Process.GetProcessById(app.Current.ProcessId);

            process.CloseMainWindow();
            Thread.Sleep(1000);

            if (!process.HasExited)
            {
                process.Kill();
            }

            return StatusCode(200, new NewValue()); 
        }

        [HttpGet("{id}/timeouts")]
        [Produces("application/json")]
        public IActionResult GetTimeouts(int id)
        {
            return StatusCode(200, $"{id}");
        }




        public static void GetElement(IntPtr app)
        {
           // PropertyCondition con = new PropertyCondition(AutomationElement.ClassNameProperty, "Notepad");
            PropertyCondition con = new PropertyCondition(AutomationElement.AutomationIdProperty, "TitleBar");
            //TitleBar

            var result2 = AutomationElement.FromHandle(app);
            var kdkddd = result2.Current.ControlType;

           // System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(Type.GetType(AutomationElementInformation.));


            //string xml = "";
            //using (var sww = new StringWriter())
            //{
            //    using (XmlWriter writer = XmlWriter.Create(sww))
            //    {
            //        x.Serialize(writer, result2.Current);
            //        xml = sww.ToString(); // Your XML
            //    }
            //}
            //Console.WriteLine(xml);


            con = new PropertyCondition(AutomationElement.ClassNameProperty, "RichEditD2DPT");
            result2 = result2.FindFirst(TreeScope.Descendants, con);

            result2.SetFocus();
            SendKeys.SendWait("^{END}");
            SendKeys.SendWait("12345zz");


           // Point p = result2.GetClickablePoint();
           // var inputSimulator = new InputSimulator();
           // inputSimulator.Mouse.MoveMouseTo(p.X, p.Y);
           // inputSimulator.Mouse.MoveMouseTo(3000, 3000);
          //  result2.SetFocus();
            LeftClick(result2);
          //  inputSimulator.Mouse.RightButtonClick();

            Thread.Sleep(10000);
          //  Mouse.Click(MouseButton.Left);


            var kdkd  = ((ValuePattern)result2.GetCurrentPattern(ValuePattern.Pattern)).Current.Value;
            //result2 = result2.FindFirst(TreeScope.Descendants, con);

             var sksks = AutomationElement.FromHandle(app);
            sksks = AutomationElement.FromHandle(new IntPtr(result2.Current.NativeWindowHandle));


            var xml = SerializeObjectz(sksks.Current);
            //
        }









        public static IntPtr ElementPointer(string value)
        {
            return new IntPtr(int.Parse(value));
        }




        public static string SerializeObjectz<T>(T toSerialize)
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(toSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        public static string Serialize(object obj)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            using (StreamReader reader = new StreamReader(memoryStream))
            {
                DataContractSerializer serializer = new DataContractSerializer(obj.GetType());
                serializer.WriteObject(memoryStream, obj);
                memoryStream.Position = 0;
                return reader.ReadToEnd();
            }
        }

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

        public static void LeftClick(AutomationElement element)
        {
            element.SetFocus();
            System.Windows.Point p = element.GetClickablePoint();
            Cursor.Position = new System.Drawing.Point((int)p.X, (int)p.Y);
            mouse_event((int)(MouseEventFlags.RIGHTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.RIGHTUP), 0, 0, 0, 0);
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