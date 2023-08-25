using FoodiePal.Server.Base;
using FoodiePal.Server.Database;
using FoodiePal.Server.Recipes.Repositories;
using FoodiePal.Server.Users.Infrastructure.Repositories;
using FoodiePal.Shared.Base;
using System.Diagnostics.CodeAnalysis;

namespace FoodiePal.Server.Extensions
{
    public static class UnitOfWorkExtensions
    {
        public static IServiceCollection SetupUnitOfWork([NotNullAttribute] this IServiceCollection serviceCollection)
        {
            //TODO: Find a way to inject the repositories and share the same context without creating a instance.
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>(f =>
            {
                var scopeFactory = f.GetRequiredService<IServiceScopeFactory>();
                var context = f.GetService<ApplicationDbContext>();
                return new UnitOfWork(
                    context,
                    new UserRepository(context.Users),
                    new RecipeRepository(context.Recipes)
                );
            });
            return serviceCollection;
        }
    }
}
