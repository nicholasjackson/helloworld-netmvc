using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [Route("v1/[controller]")]
    public class HealthController : Controller
    {
        public class HealthResponse {
            public string Status { get; set; }
        }

        // GET api/health
        [HttpGet]
        public HealthResponse Get()
        {
            return new HealthResponse { Status = "OK" };
        }
    }
}
