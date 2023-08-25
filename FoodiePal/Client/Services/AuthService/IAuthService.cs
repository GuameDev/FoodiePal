using FoodiePal.Shared;
using FoodiePal.Shared.Users.DTOs;

namespace FoodiePal.Client.Services
{
    public interface IAuthService
    {
        Task<ServiceResponse<UserLoginResponse>> LoginAsync(UserLoginRequest request);
        Task<ServiceResponse<UserRegisterResponse>> RegisterAsync(UserRegisterRequest request);

        Task LogoutAsync();
    }
}
