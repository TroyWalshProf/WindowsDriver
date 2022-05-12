using Microsoft.AspNetCore.Mvc;

namespace WindowsDriver.Controllers
{
    [ApiController]
    [Route("/wd/hub/session")]
    public class NotImplemented : ControllerBase
    {
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

        ////// TODO : do we need this one?
        ////////[HttpGet("{sessionId}/title")]
        ////////[Produces("application/json")]
        ////////public IActionResult GetTitle(string sessionId)
        ////////{
        ////////    throw new NotImplementedException();
        ////////}

        ////////[HttpDelete("{sessionId}/window")]
        ////////[Produces("application/json")]
        ////////public IActionResult CloseWindow(string sessionId)
        ////////{
        ////////    throw new NotImplementedException();
        ////////}

        ////////[HttpPost("{sessionId}/window")]
        ////////[Produces("application/json")]
        ////////public IActionResult SwitchToWindow(string sessionId)
        ////////{
        ////////    throw new NotImplementedException();
        ////////}

        ////////[HttpPost("{sessionId}/window/fullscreen")]
        ////////[Produces("application/json")]
        ////////public IActionResult FullscreenWindow(string sessionId)
        ////////{
        ////////    throw new NotImplementedException();
        ////////}

        ////////[HttpGet("{sessionId}/window/handles")]
        ////////[Produces("application/json")]
        ////////public IActionResult GetWindowHandles(string sessionId)
        ////////{
        ////////    return StatusCode(200, "123");
        ////////}

        ////////[HttpPost("{sessionId}/window/maximize")]
        ////////[Produces("application/json")]
        ////////public IActionResult MaximizeWindow(string sessionId)
        ////////{
        ////////    throw new NotImplementedException();
        ////////}

        ////////[HttpPost("{sessionId}/window/minimize")]
        ////////[Produces("application/json")]
        ////////public IActionResult MinimizeWindow(string sessionId)
        ////////{
        ////////    throw new NotImplementedException();
        ////////}
    }
}