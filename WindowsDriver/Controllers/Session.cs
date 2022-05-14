using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Windows.Automation;
using WindowsDriver.AutomationFramework;
using WindowsDriver.Requests;
using WindowsDriver.Requests.Return;

namespace WindowsDriver.Controllers
{
    [ApiController]
    [Route("/wd/hub/session")]
    public class Session : AppiumControllerBase
    {

        [HttpDelete("{sessionId}")]
        [Produces("application/json")]
        public IActionResult DeleteSession(string sessionId)
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
            var app = Utilities.GetApplicationRoot(sessionId);
            return GetTwoHundred(sessionId, SudoHtml.GetPageSource(app));
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

        [HttpGet("{sessionId}/window")]
        [Produces("application/json")]
        public IActionResult GetWindowHandle(string sessionId)
        {
            return GetTwoHundred(sessionId, Utilities.GetHandle(sessionId));
        }

        [HttpGet("{sessionId}/window/handles")]
        [Produces("application/json")]
        public IActionResult GetWindowHandles(string sessionId)
        {
            ValueArrayResponseJson valueResponse = new ValueArrayResponseJson
            {
                sessionId = sessionId,
                value = new string[] { Utilities.GetHandle(sessionId).ToString() }
            };

            return StatusCode(200, valueResponse);
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


        [HttpPost("{sessionId}/window/maximize")]
        [Produces("application/json")]
        public IActionResult MaximizeWindow(string sessionId)
        {
            var app = Utilities.GetApplicationRoot(sessionId);
            Utilities.Resize(app, WindowVisualState.Maximized);
            return GetTwoHundred(sessionId);
        }

        [HttpPost("{sessionId}/window/minimize")]
        [Produces("application/json")]
        public IActionResult MinimizeWindow(string sessionId)
        {
            var app = Utilities.GetApplicationRoot(sessionId);
            Utilities.Resize(app, WindowVisualState.Minimized);
            return GetTwoHundred(sessionId);
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


        [HttpPost]
        [Produces("application/json")]
        public IActionResult NewSession(NewSessionJson newSession)
        {
            string applicationPath = newSession.capabilities.firstMatch[0].app;
            var application = AppController.Launch(applicationPath);

            ReturnSessionJson session = new()
            {
                value = new Requests.Return.Value
                {
                    capabilities = new Requests.Return.Capabilities()
                }
            };

            session.value.capabilities.app = applicationPath;
            session.value.capabilities.platformName = newSession.capabilities.firstMatch[0].platformName;
            session.value.sessionId = $"00000000-0000-0000-0000-{application.Handle.ToInt64().ToString().PadLeft(12, '0')}";

            return StatusCode(200, session);
        }

        [HttpPost("{sessionId}/appium/app/close")]
        [Produces("application/json")]
        public IActionResult CloseApp(string sessionId)
        {
            var app = Utilities.GetApplicationRoot(sessionId);
            var process = Process.GetProcessById(app.Current.ProcessId);

            process.CloseMainWindow();
            Thread.Sleep(1000);

            if (!process.HasExited)
            {
                process.Kill();
            }

            return GetTwoHundred(sessionId);
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










        /////// TODO 
        [HttpGet("{id}/timeouts")]
        [Produces("application/json")]
        public IActionResult GetTimeouts(int id)
        {
            return StatusCode(200, $"{id}");
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
            using MemoryStream memoryStream = new MemoryStream();
            using StreamReader reader = new StreamReader(memoryStream);
            DataContractSerializer serializer = new DataContractSerializer(obj.GetType());
            serializer.WriteObject(memoryStream, obj);
            memoryStream.Position = 0;
            return reader.ReadToEnd();
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