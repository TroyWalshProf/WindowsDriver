using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WindowsDriver.Requests;

namespace WindowsDriver.Controllers
{
    [ApiController]
    [Route("/wd/hub/session")]
    public class Action : AppiumControllerBase
    {
        [HttpPost("{sessionId}/actions")]
        [Produces("application/json")]
        public IActionResult PerformActions(string sessionId)
        {
            using StreamReader reader = new(Request.Body);
            var value = reader.ReadToEndAsync().Result;



            ActionsJson? deptObj = JsonSerializer.Deserialize<ActionsJson>(value.ToString());
            return StatusCode(200, null);
            /// TODO
          /////  throw new NotImplementedException();
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