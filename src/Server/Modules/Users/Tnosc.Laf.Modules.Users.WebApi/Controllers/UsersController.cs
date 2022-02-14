using Microsoft.AspNetCore.Mvc;
using Tnosc.Laf.Modules.Users.ApplicationService.Contracts;

namespace Tnosc.Laf.Modules.Users.WebApi.Controllers
{
    [ApiController]
    [Route("api/web/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }
    }
}