using FoodiePal.Server.Users.Application.Services;
using FoodiePal.Shared;
using FoodiePal.Shared.Users.DTOs;
using FoodiePal.Shared.Users.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

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

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<UserDto>>>> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();

            if(users == null)
            {
                return BadRequest(users);
            }
            return Ok(users);
        }
    }
}
