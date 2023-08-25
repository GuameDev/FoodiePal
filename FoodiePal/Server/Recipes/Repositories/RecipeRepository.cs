using FoodiePal.Server.Base;
using FoodiePal.Shared.Entities;
using FoodiePal.Shared.Recipes.Repository;
using Microsoft.EntityFrameworkCore;

namespace FoodiePal.Server.Recipes.Repositories
{
    public class RecipeRepository : Repository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(DbSet<Recipe> recipes) : base(recipes)
        {

        }
    }
}
