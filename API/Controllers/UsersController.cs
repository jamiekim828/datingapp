using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //meaning GET method localhost:5001/api/users 
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
            // instead of this go to the C# extension setting
            // private member prefix -> _
            // Use this for ctor assignment uncheck
            // automatically create _context for private
        }

        // API endpoint
        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            return _context.Users.Find(id);


        }

    }


}