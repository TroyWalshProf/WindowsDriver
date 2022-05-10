using Microsoft.AspNetCore.Mvc;

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
            throw new NotImplementedException();
        }

        [HttpDelete("{sessionId}/actions")]
        [Produces("application/json")]
        public IActionResult ReleaseActions(string sessionId)
        {
            throw new NotImplementedException();
        }
    }
}