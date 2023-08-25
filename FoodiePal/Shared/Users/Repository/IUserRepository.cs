using FoodiePal.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Users.Repository
{
    public interface IUserRepository 
    {
        Task<IEnumerable<User>> GetAll(int skip, int limit);
        Task<User>GetUserByIdAsync(int id);
        Task<User> GetUserByEmailAsync(string email);
        Task<bool> UserExistAsync(string email);
        Task InsertUserAsync(User user);
        Task UpdateUserAsync(User user);
        void DeleteUser(User user);
        Task SaveAsync();

    }
}
