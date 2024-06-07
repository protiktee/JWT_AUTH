using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT_AUTH_OST_4.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet(Name = "Index"), Authorize]
        public ActionResult Index()
        { 
            return Ok(new { ff = "this is private access" });
        }
        [HttpGet("QryFromUnauthArea")]
        public ActionResult QryFromUnauthArea()
        {

            return Ok(new { token = "this is public access" });
        }

    }
}
