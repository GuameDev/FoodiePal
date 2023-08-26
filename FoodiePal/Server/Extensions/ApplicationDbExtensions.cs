using FoodiePal.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Text;

namespace FoodiePal.Server.Extensions
{
    public static class ApplicationDbExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
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
                        Id = 1,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                        Name = "Verduras"
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

            #region MassUnits
           

            modelBuilder.Entity<MassUnit>()
                .HasData(
                    new MassUnit()
                    {
                        Id = 1,
                        Name = "Miligramos",
                        PostFix = "mg",
                    },
                    new MassUnit()
                    {
                        Id = 2,
                        Name = "Centigramos",
                        PostFix = "cg",
                    },
                    new MassUnit()
                    {
                        Id = 3,
                        Name = "Gramos",
                        PostFix = "g",
                    },
                    new MassUnit()
                    {
                        Id = 4,
                        Name = "Kilogramos",
                        PostFix = "kg",
                    },
                    new MassUnit()
                    {
                        Id = 5,
                        Name = "Quintal",
                        PostFix = "q",
  
                    },
                    new MassUnit()
                    {
                        Id = 6,
                        Name = "Tonelada",
                        PostFix = "t",
                        
                    },
                    new MassUnit()
                    {
                        Id = 7,
                        Name = "Onza",
                        PostFix = "oz",
                            
                    },
                    new MassUnit()
                    {
                        Id = 8,
                        Name = "Libra",
                        PostFix = "lb",
                    },
                    new MassUnit()
                    {
                        Id = 9,
                        Name = "TableSpoon",
                        PostFix = "tbsp",
                    },
                    new MassUnit()
                    {
                        Id = 10,
                        Name = "TeaSpoon",
                        PostFix = "tsp",
                    }
        );
            #endregion MasUnits

            #region MassEquivalences

            modelBuilder.Entity<MassEquivalence>().HasData(

            #region Miligramos
                    new MassEquivalence()
                    {
                        Id = 1,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Miligramos",
                        MassUnitEquivalentFactorName = "Miligramos",
                        Value = 1
                    },
                    new MassEquivalence()
                    {
                        Id = 2,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Miligramos",
                        MassUnitEquivalentFactorName = "Centigramos",
                        Value = 0.1
                    }, new MassEquivalence()
                    {
                        Id = 3,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Miligramos",
                        MassUnitEquivalentFactorName = "Gramos",
                        Value = 0.001
                    },
                    new MassEquivalence()
                    {
                        Id = 4,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Miligramos",
                        MassUnitEquivalentFactorName = "Kilogramos",
                        Value = 1e-6
                    }, new MassEquivalence()
                    {
                        Id = 5,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Miligramos",
                        MassUnitEquivalentFactorName = "Quintal",
                        Value = 1e-8
                    }, new MassEquivalence()
                    {
                        Id = 6,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Miligramos",
                        MassUnitEquivalentFactorName = "Tonelada",
                        Value = 1e-9
                    },
                    new MassEquivalence()
                    {
                        Id = 7,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Miligramos",
                        MassUnitEquivalentFactorName = "Onza",
                        Value = 3.5274e-5
                    }, new MassEquivalence()
                    {
                        Id = 8,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Miligramos",
                        MassUnitEquivalentFactorName = "Libras",
                        Value = 2.20462e-6
                    },
                    new MassEquivalence()
                    {
                        Id = 9,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Miligramos",
                        MassUnitEquivalentFactorName = "Tablespoon",
                        Value = 0.067628
                    }, new MassEquivalence()
                    {
                        Id = 10,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Miligramos",
                        MassUnitEquivalentFactorName = "Teaspoon",
                        Value = 0.202884
                    }
            #endregion Miligramos
            #region Centigramos
                    new MassEquivalence()
                    {
                        Id = 1,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Centigramos",
                        MassUnitEquivalentFactorName = "Miligramos",
                        Value = 10
                    },
                    new MassEquivalence()
                    {
                        Id = 2,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Centigramos",
                        MassUnitEquivalentFactorName = "Centigramos",
                        Value = 1
                    }, new MassEquivalence()
                    {
                        Id = 3,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Centigramos",
                        MassUnitEquivalentFactorName = "Gramos",
                        Value = 0.01
                    },
                    new MassEquivalence()
                    {
                        Id = 4,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Centigramos",
                        MassUnitEquivalentFactorName = "Kilogramos",
                        Value = 1e-5
                    }, new MassEquivalence()
                    {
                        Id = 5,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Centigramos",
                        MassUnitEquivalentFactorName = "Quintal",
                        Value = 1e-7
                    }, new MassEquivalence()
                    {
                        Id = 6,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Centigramos",
                        MassUnitEquivalentFactorName = "Tonelada",
                        Value = 1e-8
                    },
                    new MassEquivalence()
                    {
                        Id = 7,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Centigramos",
                        MassUnitEquivalentFactorName = "Onza",
                        Value = 0.00035274
                    }, new MassEquivalence()
                    {
                        Id = 8,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Centigramos",
                        MassUnitEquivalentFactorName = "Libras",
                        Value = 2.20462e-5
                    },
                    new MassEquivalence()
                    {
                        Id = 9,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Centigramos",
                        MassUnitEquivalentFactorName = "Tablespoon",
                        Value = 0.0067628
                    }, new MassEquivalence()
                    {
                        Id = 10,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Centigramos",
                        MassUnitEquivalentFactorName = "Teaspoon",
                        Value = 0.0202884
                    }
                    #endregion Centigramos
            #region Gramos
                    new MassEquivalence()
                    {
                        Id = 1,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Gramos",
                        MassUnitEquivalentFactorName = "Miligramos",
                        Value = 1000
                    },
                    new MassEquivalence()
                    {
                        Id = 2,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Gramos",
                        MassUnitEquivalentFactorName = "Centigramos",
                        Value = 100
                    }, new MassEquivalence()
                    {
                        Id = 3,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Gramos",
                        MassUnitEquivalentFactorName = "Gramos",
                        Value = 1
                    },
                    new MassEquivalence()
                    {
                        Id = 4,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Gramos",
                        MassUnitEquivalentFactorName = "Kilogramos",
                        Value = 0.001
                    }, new MassEquivalence()
                    {
                        Id = 5,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Gramos",
                        MassUnitEquivalentFactorName = "Quintal",
                        Value = 0.00001
                    }, new MassEquivalence()
                    {
                        Id = 6,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Gramos",
                        MassUnitEquivalentFactorName = "Tonelada",
                        Value = 1e-7
                    },
                    new MassEquivalence()
                    {
                        Id = 7,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Gramos",
                        MassUnitEquivalentFactorName = "Onza",
                        Value = 0.03527396
                    }, new MassEquivalence()
                    {
                        Id = 8,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Gramos",
                        MassUnitEquivalentFactorName = "Libras",
                        Value = 0.00220462
                    },
                    new MassEquivalence()
                    {
                        Id = 9,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Gramos",
                        MassUnitEquivalentFactorName = "Tablespoon",
                        Value = 0.067628
                    }, new MassEquivalence()
                    {
                        Id = 10,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Gramos",
                        MassUnitEquivalentFactorName = "Teaspoon",
                        Value = 0.202884
                    }
                    #endregion Gramos
            #region Kilogramos
                    new MassEquivalence()
                    {
                        Id = 1,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Kilogramos",
                        MassUnitEquivalentFactorName = "Miligramos",
                        Value = 1000000
                    },
                    new MassEquivalence()
                    {
                        Id = 2,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Kilogramos",
                        MassUnitEquivalentFactorName = "Centigramos",
                        Value = 100000
                    }, new MassEquivalence()
                    {
                        Id = 3,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Kilogramos",
                        MassUnitEquivalentFactorName = "Gramos",
                        Value = 1000
                    },
                    new MassEquivalence()
                    {
                        Id = 4,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Kilogramos",
                        MassUnitEquivalentFactorName = "Kilogramos",
                        Value = 1
                    }, new MassEquivalence()
                    {
                        Id = 5,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Kilogramos",
                        MassUnitEquivalentFactorName = "Quintal",
                        Value = 0.01
                    }, new MassEquivalence()
                    {
                        Id = 6,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Kilogramos",
                        MassUnitEquivalentFactorName = "Tonelada",
                        Value = 0.00001
                    },
                    new MassEquivalence()
                    {
                        Id = 7,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Kilogramos",
                        MassUnitEquivalentFactorName = "Onza",
                        Value = 35.27396
                    }, new MassEquivalence()
                    {
                        Id = 8,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Kilogramos",
                        MassUnitEquivalentFactorName = "Libras",
                        Value = 2.20462
                    },
                    new MassEquivalence()
                    {
                        Id = 9,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Kilogramos",
                        MassUnitEquivalentFactorName = "Tablespoon",
                        Value = 67628
                    }, new MassEquivalence()
                    {
                        Id = 10,
                        CreationDate = DateTime.Now,
                        MassUnitParentName = "Kilogramos",
                        MassUnitEquivalentFactorName = "Teaspoon",
                        Value = 202884
                    }
                    #endregion Kilogramos
            #region Quintal
            new MassEquivalence()
            {
                Id = 1,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Quintal",
                MassUnitEquivalentFactorName = "Miligramos",
                Value = 1e8
            },
            new MassEquivalence()
            {
                Id = 2,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Quintal",
                MassUnitEquivalentFactorName = "Centigramos",
                Value = 1e7
            }, new MassEquivalence()
            {
                Id = 3,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Quintal",
                MassUnitEquivalentFactorName = "Gramos",
                Value = 1e6
            },
            new MassEquivalence()
            {
                Id = 4,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Quintal",
                MassUnitEquivalentFactorName = "Kilogramos",
                Value = 1000
            }, new MassEquivalence()
            {
                Id = 5,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Quintal",
                MassUnitEquivalentFactorName = "Quintal",
                Value = 1
            }, new MassEquivalence()
            {
                Id = 6,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Quintal",
                MassUnitEquivalentFactorName = "Tonelada",
                Value = 0.001
            },
            new MassEquivalence()
            {
                Id = 7,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Quintal",
                MassUnitEquivalentFactorName = "Onza",
                Value = 35273.96
            }, new MassEquivalence()
            {
                Id = 8,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Quintal",
                MassUnitEquivalentFactorName = "Libras",
                Value = 2204.62
            },
            new MassEquivalence()
            {
                Id = 9,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Quintal",
                MassUnitEquivalentFactorName = "Tablespoon",
                Value = 676280
            }, new MassEquivalence()
            {
                Id = 10,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Quintal",
                MassUnitEquivalentFactorName = "Teaspoon",
                Value = 2028840
            }
            #endregion Quintal
            #region Tonelada
            new MassEquivalence()
            {
                Id = 1,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tonelada",
                MassUnitEquivalentFactorName = "Miligramos",
                Value = 1e9
            },
            new MassEquivalence()
            {
                Id = 2,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tonelada",
                MassUnitEquivalentFactorName = "Centigramos",
                Value = 1e8
            }, new MassEquivalence()
            {
                Id = 3,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tonelada",
                MassUnitEquivalentFactorName = "Gramos",
                Value = 1e7
            },
            new MassEquivalence()
            {
                Id = 4,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tonelada",
                MassUnitEquivalentFactorName = "Kilogramos",
                Value = 1000000
            }, new MassEquivalence()
            {
                Id = 5,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tonelada",
                MassUnitEquivalentFactorName = "Quintal",
                Value = 1000
            }, new MassEquivalence()
            {
                Id = 6,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tonelada",
                MassUnitEquivalentFactorName = "Tonelada",
                Value = 1
            },
            new MassEquivalence()
            {
                Id = 7,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tonelada",
                MassUnitEquivalentFactorName = "Onza",
                Value = 3527396.2
            }, new MassEquivalence()
            {
                Id = 8,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tonelada",
                MassUnitEquivalentFactorName = "Libras",
                Value = 220462.262
            },
            new MassEquivalence()
            {
                Id = 9,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tonelada",
                MassUnitEquivalentFactorName = "Tablespoon",
                Value = 67628000
            }, new MassEquivalence()
            {
                Id = 10,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tonelada",
                MassUnitEquivalentFactorName = "Teaspoon",
                Value = 202884000
            }
            #endregion Quintal
            #region Onza
            new MassEquivalence()
            {
                Id = 1,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Onza",
                MassUnitEquivalentFactorName = "Miligramos",
                Value = 28349.5231
            },
            new MassEquivalence()
            {
                Id = 2,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Onza",
                MassUnitEquivalentFactorName = "Centigramos",
                Value = 2834.95231
            }, new MassEquivalence()
            {
                Id = 3,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Onza",
                MassUnitEquivalentFactorName = "Gramos",
                Value = 28.3495231
            },
            new MassEquivalence()
            {
                Id = 4,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Onza",
                MassUnitEquivalentFactorName = "Kilogramos",
                Value = 0.0283495231
            }, new MassEquivalence()
            {
                Id = 5,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Onza",
                MassUnitEquivalentFactorName = "Quintal",
                Value = 0.0002834952
            }, new MassEquivalence()
            {
                Id = 6,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Onza",
                MassUnitEquivalentFactorName = "Tonelada",
                Value = 2.834952e-6
            },
            new MassEquivalence()
            {
                Id = 7,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Onza",
                MassUnitEquivalentFactorName = "Onza",
                Value = 1
            }, new MassEquivalence()
            {
                Id = 8,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Onza",
                MassUnitEquivalentFactorName = "Libras",
                Value = 0.0625
            },
            new MassEquivalence()
            {
                Id = 9,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Onza",
                MassUnitEquivalentFactorName = "Tablespoon",
                Value = 2
            }, new MassEquivalence()
            {
                Id = 10,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Onza",
                MassUnitEquivalentFactorName = "Teaspoon",
                Value = 6
            }
            #endregion Onza
            #region Libras
            new MassEquivalence()
            {
                Id = 1,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Libras",
                MassUnitEquivalentFactorName = "Miligramos",
                Value = 453592.37
            },
            new MassEquivalence()
            {
                Id = 2,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Libras",
                MassUnitEquivalentFactorName = "Centigramos",
                Value = 45359.237
            }, new MassEquivalence()
            {
                Id = 3,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Libras",
                MassUnitEquivalentFactorName = "Gramos",
                Value = 453.59237
            },
            new MassEquivalence()
            {
                Id = 4,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Libras",
                MassUnitEquivalentFactorName = "Kilogramos",
                Value = 0.45359237
            }, new MassEquivalence()
            {
                Id = 5,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Libras",
                MassUnitEquivalentFactorName = "Quintal",
                Value = 0.0045359237
            }, new MassEquivalence()
            {
                Id = 6,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Libras",
                MassUnitEquivalentFactorName = "Tonelada",
                Value = 4.5359237e-5
            },
            new MassEquivalence()
            {
                Id = 7,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Libras",
                MassUnitEquivalentFactorName = "Onza",
                Value = 16
            }, new MassEquivalence()
            {
                Id = 8,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Libras",
                MassUnitEquivalentFactorName = "Libras",
                Value = 1
            },
            new MassEquivalence()
            {
                Id = 9,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Libras",
                MassUnitEquivalentFactorName = "Tablespoon",
                Value = 32
            }, new MassEquivalence()
            {
                Id = 10,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Libras",
                MassUnitEquivalentFactorName = "Teaspoon",
                Value = 96
            }
            #endregion Libras
            #region Tablespoon
            new MassEquivalence()
            {
                Id = 1,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tablespoon",
                MassUnitEquivalentFactorName = "Miligramos",
                Value = 15000
            },
            new MassEquivalence()
            {
                Id = 2,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tablespoon",
                MassUnitEquivalentFactorName = "Centigramos",
                Value = 1500
            }, new MassEquivalence()
            {
                Id = 3,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tablespoon",
                MassUnitEquivalentFactorName = "Gramos",
                Value = 15
            },
            new MassEquivalence()
            {
                Id = 4,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tablespoon",
                MassUnitEquivalentFactorName = "Kilogramos",
                Value = 0.015
            }, new MassEquivalence()
            {
                Id = 5,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tablespoon",
                MassUnitEquivalentFactorName = "Quintal",
                Value = 0.00015
            }, new MassEquivalence()
            {
                Id = 6,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tablespoon",
                MassUnitEquivalentFactorName = "Tonelada",
                Value = 1.5e-6
            },
            new MassEquivalence()
            {
                Id = 7,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tablespoon",
                MassUnitEquivalentFactorName = "Onza",
                Value = 0.52743
            }, new MassEquivalence()
            {
                Id = 8,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tablespoon",
                MassUnitEquivalentFactorName = "Libras",
                Value = 0.0321507
            },
            new MassEquivalence()
            {
                Id = 9,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tablespoon",
                MassUnitEquivalentFactorName = "Tablespoon",
                Value = 1
            }, new MassEquivalence()
            {
                Id = 10,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Tablespoon",
                MassUnitEquivalentFactorName = "Teaspoon",
                Value = 3
            }
            #endregion Tablespoon
            #region Teaspoon
            new MassEquivalence()
            {
                Id = 1,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Teaspoon",
                MassUnitEquivalentFactorName = "Miligramos",
                Value = 5000
            },
            new MassEquivalence()
            {
                Id = 2,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Teaspoon",
                MassUnitEquivalentFactorName = "Centigramos",
                Value = 500
            }, new MassEquivalence()
            {
                Id = 3,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Teaspoon",
                MassUnitEquivalentFactorName = "Gramos",
                Value = 5
            },
            new MassEquivalence()
            {
                Id = 4,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Teaspoon",
                MassUnitEquivalentFactorName = "Kilogramos",
                Value = 0.005
            }, new MassEquivalence()
            {
                Id = 5,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Teaspoon",
                MassUnitEquivalentFactorName = "Quintal",
                Value = 0.00005
            }, new MassEquivalence()
            {
                Id = 6,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Teaspoon",
                MassUnitEquivalentFactorName = "Tonelada",
                Value = 5e-7
            },
            new MassEquivalence()
            {
                Id = 7,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Teaspoon",
                MassUnitEquivalentFactorName = "Onza",
                Value = 0.175146
            }, new MassEquivalence()
            {
                Id = 8,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Teaspoon",
                MassUnitEquivalentFactorName = "Libras",
                Value = 0.0100584
            },
            new MassEquivalence()
            {
                Id = 9,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Teaspoon",
                MassUnitEquivalentFactorName = "Tablespoon",
                Value = 0.333333
            }, new MassEquivalence()
            {
                Id = 10,
                CreationDate = DateTime.Now,
                MassUnitParentName = "Teaspoon",
                MassUnitEquivalentFactorName = "Teaspoon",
                Value = 1
            }
            #endregion Teaspoon
                );

            #endregion MassEquivalences

            #region Ingredients
            modelBuilder.Entity<Ingredient>().HasData(
                 new Ingredient()
                 {
                     Id = 1,
                     Name = "Avena",
                     ProductId = 1,
                     Quantity = 50,
                     RecipeId = 1,
                     MassUnitId = 1,

                 },
                new Ingredient()
                {
                    Id = 2,
                    Name = "Yogur griego",
                    ProductId = 2,
                    Quantity = 0.15,
                    RecipeId = 1,
                    MassUnitId = 1,
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
