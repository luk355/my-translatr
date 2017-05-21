using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MyTranslatr.Services.TranslationHistory.API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class IdentityController : ControllerBase
    {
            [HttpGet]
            public IActionResult Get()
            {
                return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
            }
    }
}
