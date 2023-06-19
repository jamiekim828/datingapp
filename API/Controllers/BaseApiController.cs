using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //meaning GET method localhost:5001/api/[controllername] 
    public class BaseApiController : ControllerBase
    {

    }
}