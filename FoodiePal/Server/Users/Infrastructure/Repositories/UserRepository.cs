using FoodiePal.Server.Database;
using FoodiePal.Shared.Entities;
using FoodiePal.Shared.Users.Repository;
using Microsoft.EntityFrameworkCore;

namespace FoodiePal.Server.Users.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
   
        public async Task<IEnumerable<User>> GetAll(int skip, int limit)
        {
            return await _context.Users
                .Skip(skip)
                .Take(limit)
                .Include(user => user.Role)
                .Include(user => user.Addresses)
                .ToListAsync();
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var entity = await _context.Users.Include(user => user.Role)
                .FirstOrDefaultAsync(x => x.Email.ToLower().Equals(email.ToLower()));

            return entity;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var entity = await _context.Users
                .Include(user => user.Role)
                .Include(user=>user.Addresses)
                .FirstOrDefaultAsync(user => user.Id.Equals(id));

            return entity;

        }

        public async Task InsertUserAsync(User user)
        {
         await _context.AddAsync(user);
        }
        public async Task UpdateUserAsync(User user)
        {
            await Task.Run(() => { _context.Update(user); });
        }

        public void DeleteUser(User user)
        {
            _context.Users.Remove(user);
        }

        public async Task<bool> UserExistAsync(string email)
        {
            return await _context.Users.AnyAsync(user => user.Email.ToLower().Equals(email.ToLower()));
        }

        public async Task SaveAsync()
        {
             await _context.SaveChangesAsync();
        }



    }
}
