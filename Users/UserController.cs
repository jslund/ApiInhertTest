using Microsoft.AspNetCore.Mvc;

namespace Users;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private UsersService _service = new UsersService();
    
    public IActionResult Index()
    {
        return Ok(_service.GetUser());
    }
}