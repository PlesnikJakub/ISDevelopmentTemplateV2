using Core;
using Microsoft.AspNetCore.Mvc;

namespace TempalteProject2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public void Get(int id)
        {
            var service = new UserService();
            var user = service.GetById(id);
        }
    }
}