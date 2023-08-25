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
                        UserId = 1
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
                         UserId = 1
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


            #region Categories
            modelBuilder.Entity<Category>().HasData(

                    new Category()
                    {
                        Id = 1,
                        Name = "Breakfast",
                        Url = "breakfast"
                    },
                     new Category()
                     {
                         Id = 2,
                         Name = "Meals",
                         Url = "meals"
                     },
                      new Category()
                      {
                          Id = 3,
                          Name = "Dinner",
                          Url = "dinner"
                      }
                );
            #endregion Categories

            #region Authors
            modelBuilder.Entity<Author>().HasData(
                 new Author()
                 {
                     Id = 1,
                     Email = "Author1@fakeEmail.com",
                     Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation",
                     Name = "Áutor número 1"
                 },
                new Author()
                {
                    Id = 2,
                    Email = "Author2@fakeEmail.com",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation",
                    Name = "Áutor número 2"
                }
                );
            #endregion Authors

            #region Products
            modelBuilder.Entity<Product>().HasData(

                    new Product()
                    {
                        Id = 1,
                        Name = "Avena",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        ProductTypeId = 4
                        
                    },
                    new Product()
                    {
                        Id = 2,
                        Name = "Yogur griego",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        ProductTypeId = 3
                    }
                );
            #endregion Products

            #region ProductTypes
            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType()
                    {
                        Id= 1,
                        Description= "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Name="Verduras"
                    },
                    new ProductType()
                    {
                        Id = 2,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Name = "Frutas"
                    },
                    new ProductType()
                    {
                        Id = 3,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Name = "Yogur"
                    }
                    ,
                    new ProductType()
                    {
                        Id = 4,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Name = "Cereales"
                    }
                );
            #endregion ProductTypes

            #region Ingredients
            modelBuilder.Entity<Ingredient>().HasData(
                 new Ingredient()
                 {
                     Id = 1,
                     Name = "Avena",
                     ProductId = 1,
                     Quantity = 50,
                     UnitOfMeasurement = Shared.Enums.UnitType.Grams,
                     RecipeId = 1
                 },
                new Ingredient()
                {
                    Id = 2,
                    Name = "Yogur griego",
                    ProductId = 2,
                    Quantity = 0.15,
                    UnitOfMeasurement = Shared.Enums.UnitType.Kilograms,
                    RecipeId = 1
                });
            #endregion Ingredients

            #region Steps
            modelBuilder.Entity<Step>().HasData(
                 new Step()
                 {
                     Id = 1,
                     Name = "Destapa el yogur griego",
                     Description = "Coge un bol y echa 150 gramos de yogur griego",
                     RecipeId = 1
                 },
                new Step()
                {
                    Id = 2,
                    Name = "Echa la avena",
                    Description = "Echa 50 gramos de avena en el bol",
                    RecipeId = 1
                },
                new Step()
                {
                    Id = 3,
                    Name = "¡A comer!",
                    Description = "¡Remuevelo todo y prepárate para un desayuno lleno de energía!",
                    RecipeId = 1
                    

                }
                );
            #endregion Steps


            #region Recipes
            modelBuilder.Entity<Recipe>()
                .HasData(
                     new Recipe()
                     {
                         Id = 1,
                         Name = "Receta de prueba",
                         Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                         CategoryId = 1,
                        
                     }
                 );


            #endregion Recipes
        }
    }
}
