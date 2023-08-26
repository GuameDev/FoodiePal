using FoodiePal.Server.Extensions;
using FoodiePal.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace FoodiePal.Server.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MassUnit>MassUnits{ get; set; }
        public DbSet<MassEquivalence> MassEquivalences{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            //Extension method to keep cleen this class
            modelBuilder.Seed();
        }
    }
}
