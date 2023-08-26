using FoodiePal.Shared.Base;
using FoodiePal.Shared.Entities;
using FoodiePal.Shared.Users.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Users.Repository
{
    public interface IUserRepository :IRepository<User>
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByEmailAsync(string email);
        Task<bool> UserExistAsync(string email);
        

    }
}
