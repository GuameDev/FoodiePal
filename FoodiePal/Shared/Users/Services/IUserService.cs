using FoodiePal.Shared.Users.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Users.Services
{
    public interface IUserService
    {
        Task<ServiceResponse<UserLoginResponse>>LoginAsync(UserLoginRequest request);
        Task<ServiceResponse<UserRegisterResponse>> RegisterAsync(UserRegisterRequest request);
    }
}
