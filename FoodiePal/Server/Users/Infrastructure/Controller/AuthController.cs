using FoodiePal.Shared;
using FoodiePal.Shared.Users.DTOs;
using FoodiePal.Shared.Users.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodiePal.Server.Users.Infrastructure.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<UserLoginResponse>>> Login(UserLoginRequest request)
        {
            var result = await _authService.LoginAsync(request);
      
            if(!result.Success || result.Data == null)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<UserRegisterResponse>>> Register(UserRegisterRequest request)
        {
            var result = await _authService.RegisterAsync(request);

            if (!result.Success || result.Data == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
