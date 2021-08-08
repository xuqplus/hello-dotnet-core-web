using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]")]
[ApiController]
public class IndexController : ControllerBase
{
    [HttpGet("/")]
    public ActionResult<string> Index()
    {
        return "ok, 世界..";
    }

    [HttpGet("/aa")]
    public ActionResult<string> AA()
    {
        return "ok, AA..";
    }
}