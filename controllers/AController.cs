using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api2/d/[controller]")]
[ApiController]
public class AController : ControllerBase
{
    [HttpGet("")]
    [HttpGet("a")]
    public ActionResult<string> Index()
    {
        return "ok, a index";
    }

    [HttpGet("bc")]
    [HttpGet("abc")]
    public ActionResult<string> Bc()
    {
        return "ok, a bc";
    }
}