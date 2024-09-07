using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningDemo.Controllers
{
    [ApiVersion("1.0",Deprecated =true )]
    [Route("api/v{version:apiVersion}/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        List<string> users
            = new List<string> { "A1", "A2", "A3", "A4", "A5","B1", "B2", "B3", "B4", "B5" };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(users);
        }
    }
}
