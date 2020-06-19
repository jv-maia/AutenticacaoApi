using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer3.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace AutenticacaoApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
            private IUserService _userService;

            public UsersController(IUserService userService)
            {
                _userService = userService;
            }

            [AllowAnonymous]
            [HttpPost("authenticate")]

            [HttpGet]
            public IActionResult GetAll()
            {
                var users = _userService.GetType();
                return Ok(users);
            }
    }
}
