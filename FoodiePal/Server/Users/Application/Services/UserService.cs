using FoodiePal.Shared;
using FoodiePal.Shared.Users.DTOs;
using FoodiePal.Shared.Users.Services;

namespace FoodiePal.Server.Users.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IGetAllUsers _getAllUsers;

        public UserService(IGetAllUsers getAllUsers)
        {
            _getAllUsers = getAllUsers;
        }
        public async Task<ServiceResponse<List<UserDto>>> GetAllUsersAsync()
        {
            return await _getAllUsers.GetAllUsersAsync();
        }
    }
}
