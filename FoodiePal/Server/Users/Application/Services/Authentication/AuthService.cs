using FoodiePal.Shared;
using FoodiePal.Shared.Users.DTOs;
using FoodiePal.Shared.Users.Services.Authentication;

namespace FoodiePal.Server.Users.Application.Services.Authentication
{
    public class AuthService : IAuthService
    {
        private readonly IUserLogin _userLogin;
        private readonly IUserRegister _userRegister;

        public AuthService(IUserLogin userLogin, IUserRegister userRegister)
        {
            _userLogin = userLogin;
            _userRegister = userRegister;
        }
        public async Task<ServiceResponse<UserLoginResponse>> LoginAsync(UserLoginRequest request)
        {
            return await _userLogin.LoginAsync(request);
        }

        public async Task<ServiceResponse<UserRegisterResponse>> RegisterAsync(UserRegisterRequest request)
        {
            return await _userRegister.RegisterAsync(request);
        }
    }
}
