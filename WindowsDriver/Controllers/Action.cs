using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace WindowsDriver.Controllers
{
    [ApiController]
    [Route("/wd/hub/session")]
    public class Action : ControllerBase
    {
        [HttpPost("{sessionId}/actions")]
        [Produces("application/json")]
        public IActionResult PerformActions(string sessionId)
        {
            using StreamReader reader = new(Request.Body);
            var value = reader.ReadToEndAsync().Result;



            WindowsDriver.Requests.Actions deptObj = JsonSerializer.Deserialize<WindowsDriver.Requests.Actions>(value.ToString());
            throw new NotImplementedException();
        }

        //[HttpPost("{sessionId}/actions")]
        //[Produces("application/json")]
        //public IActionResult PerformActions(WindowsDriver.Requests.Actions deptObj, string sessionId)
        //{
        //    throw new NotImplementedException();
        //}

        [HttpDelete("{sessionId}/actions")]
        [Produces("application/json")]
        public IActionResult ReleaseActions(string sessionId)
        {
            throw new NotImplementedException();
        }
    }
}