using FoodiePal.Shared;
using FoodiePal.Shared.Users.DTOs;
using FoodiePal.Shared.Users.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodiePal.Server.Users.Infrastructure.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<UserLoginResponse>>> Login(UserLoginRequest request)
        {
            var result = await _userService.LoginAsync(request);
      
            if(!result.Success || result.Data == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<UserRegisterResponse>>> Register(UserRegisterRequest request)
        {
            var result = await _userService.RegisterAsync(request);

            if (!result.Success || result.Data == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
