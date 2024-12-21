using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;
[Route("api/[controller]")]
[ApiController]
public class HelloWorldController : ControllerBase
{
    // GET: api/HelloWorld
    [HttpGet]
    public string Get()
    {
        return "Hello, World!";
    }
}