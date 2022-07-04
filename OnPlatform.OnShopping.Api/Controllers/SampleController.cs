using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnPlatform.OnShopping.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class SampleController
    {
        [HttpGet(Name = "GetHelloWorld")]
        public string Get()
        {
            return "Hello World";
        }
    }
}
