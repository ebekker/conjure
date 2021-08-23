using Microsoft.AspNetCore.Mvc;

namespace Conjure.Blazor.Sample1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController
    {
        [HttpGet("hello")]
        public string HelloWorld()
        {
            return $"Hello World @ {DateTime.Now}";
        }
    }
}
