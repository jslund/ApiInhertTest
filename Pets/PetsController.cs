using Microsoft.AspNetCore.Mvc;

namespace Pets;


[ApiController]
[Route("api/[controller]")]
public class PetsController : ControllerBase
{
    private PetsService _service = new PetsService();
    
    // GET
    public IActionResult Index()
    {
        return Ok(_service.FindPet());
    }
}
