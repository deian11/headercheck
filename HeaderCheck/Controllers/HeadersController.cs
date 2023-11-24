using Microsoft.AspNetCore.Mvc;

namespace HeaderCheck.Controllers;


[ApiController]
[Route("[controller]")]
public class HeadersController : ControllerBase
{
    [HttpGet(Name = "GetHeadersName")]
    public Array Get()
    {
        return HttpContext.Request.Headers.ToArray();
    }
    
}