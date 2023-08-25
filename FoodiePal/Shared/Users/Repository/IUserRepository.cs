using FoodiePal.Shared.Base;
using FoodiePal.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Users.Repository
{
    public interface IUserRepository :IRepository<User>
    {

        Task<User> GetUserByEmailAsync(string email);
        Task<bool> UserExistAsync(string email);
        

    }
}
