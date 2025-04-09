using Microsoft.AspNetCore.Mvc;

namespace ApiInhertTest.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BasicController : ControllerBase
{
    // GET
    public IActionResult Index()
    {
        return Ok("Hello from BasicController");
    }
}