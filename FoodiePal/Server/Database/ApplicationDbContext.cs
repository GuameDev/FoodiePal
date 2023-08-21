using FoodiePal.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace FoodiePal.Server.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<User>Users { get; set; }
        public DbSet<Role> Roles{ get; set; }
        public DbSet<Address>Addresses{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Roles
            modelBuilder.Entity<Role>().HasData
                (
                    new Role()
                    {
                        Id = 1,
                        Name = "Admin",
                    },
                    new Role()
                    {
                        Id = 2,
                        Name = "Free",
                    },
                    new Role()
                    {
                        Id = 3,
                        Name = "Premium",
                    }
                );
            #endregion Roles
            #region Addresses
            modelBuilder.Entity<Address>().HasData
                (
                    new Address()
                    {
                        Id = 1,
                        FirstName = "Jorge",
                        LastName = "Díaz",
                        Street = "Calle Valeriano Alcalá",
                        City = "Madrid",
                        Country = "España",
                        Zip = "40521",
                        UserId= 1
                    },
                     new Address()
                    {
                        Id = 2,
                        FirstName = "María",
                        LastName = "Martínez",
                        Street = "Calle Valeriano Alcalá",
                        City = "Madrid",
                        Country = "España",
                        Zip = "40521",
                        UserId= 1
                    },
                     new Address()
                     {
                         Id = 3,
                         FirstName = "Natalia",
                         LastName = "Murillo",
                         Street = "Calle Paco Palazón",
                         City = "Murcia",
                         Country = "España",
                         Zip = "30256",
                         UserId = 2
                     },
                     new Address()
                     {
                         Id = 4,
                         FirstName = "César",
                         LastName = "Sánchez",
                         Street = "Calle Paco Palazón",
                         City = "Murcia",
                         Country = "España",
                         Zip = "30256",
                         UserId = 2
                     }

                );
            #endregion Addresses
            #region Users
            modelBuilder.Entity<User>().HasData
                (
                    new User()
                    {
                        Id = 1,
                        FirstName = "Jorge",
                        LastName1 = "Díaz",
                        LastName2 = "González",
                        Email = "jorge.diaz@fakeMail.com",
                        PasswordHash = Encoding.UTF8.GetBytes("123456789/a"),
                        PasswordSalt = Encoding.UTF8.GetBytes("Salt"),
                        RoleId = 1
                    },
                    new User()
                    {
                        Id = 2,
                        FirstName = "Natalia",
                        LastName1 = "Murillo",
                        LastName2 = "Palazón",
                        Email = "natalia.murillo@fakeMail.com",
                        PasswordHash = Encoding.UTF8.GetBytes("789456123"),
                        PasswordSalt = Encoding.UTF8.GetBytes("Salty"),
                        RoleId = 3
                    },
                    new User()
                    {
                        Id = 3,
                        FirstName = "Mar",
                        LastName1 = "Casal",
                        LastName2 = "Vilches",
                        Email = "mar.casal@fakeMail.com",
                        PasswordHash = Encoding.UTF8.GetBytes("123456789/a"),
                        PasswordSalt = Encoding.UTF8.GetBytes("FoodiePal"),
                        RoleId = 2
                    }
                ); 
            #endregion AdUsersdresses
        }
    }
}
