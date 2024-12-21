using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.PublicStuff;
[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    // GET: api/HelloWorld
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }
}