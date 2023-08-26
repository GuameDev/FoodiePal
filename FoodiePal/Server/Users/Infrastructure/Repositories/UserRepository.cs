using FoodiePal.Server.Base;
using FoodiePal.Server.Database;
using FoodiePal.Shared.Entities;
using FoodiePal.Shared.Users.Repository;
using Microsoft.EntityFrameworkCore;

namespace FoodiePal.Server.Users.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly DbSet<User> _entities;

        public UserRepository(DbSet<User> entities) : base(entities)
        {
            _entities = entities;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return _entities
                .Include(x=>x.Addresses)
                .Include(x => x.Role)
                .ToList();
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var entity = await _entities.Include(user => user.Role)
               .FirstOrDefaultAsync(x => x.Email.ToLower().Equals(email.ToLower()));

            return entity;
        }

        public async Task<bool> UserExistAsync(string email)
        {
            return await _entities.AnyAsync(user => user.Email.ToLower().Equals(email.ToLower()));
        }
    }
}
