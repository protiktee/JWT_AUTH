using JWT_AUTH_OST_4.Model;
using Microsoft.AspNetCore.Mvc;

namespace JWT_AUTH_OST_4.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult GetServiceToken()
        {
            return Ok(ServiceToken.GenerateServiceToken());
        }
    }
}
