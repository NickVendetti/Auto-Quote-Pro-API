using Microsoft.AspNetCore.Mvc;

namespace AutoQuotePro.API.Controllers;

[ApiController]
[Route("test")]
public class TestController:ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World");
    }
}