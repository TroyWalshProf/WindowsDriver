using Microsoft.AspNetCore.Mvc;
using WindowsDriver.Requests;

namespace WindowsDriver.Controllers
{
    public abstract class AppiumControllerBase : ControllerBase
    {
        protected ObjectResult GetTwoHundred(string sessionId, object? value = null)
        {
            return StatusCode(200, new ValueResponseJson { 
                sessionId = sessionId,
                value = value
            });
        }
    }
}