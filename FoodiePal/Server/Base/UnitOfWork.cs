using FoodiePal.Server.Database;
using FoodiePal.Shared.Base;
using FoodiePal.Shared.Recipes.Repository;
using FoodiePal.Shared.Users.Repository;

namespace FoodiePal.Server.Base
{
    public class UnitOfWork:IUnitOfWork
    {
 
        private readonly ApplicationDbContext dbContext;

        public IUserRepository UserRepository { get  ;set ; }
        public IRecipeRepository RecipeRepository { get; set ; }

        //Repositories


        public UnitOfWork(ApplicationDbContext dbContext,IUserRepository userRepository,IRecipeRepository recipeRepository)
        {
            this.dbContext = dbContext;
            UserRepository = userRepository;
            RecipeRepository = recipeRepository;
        }

        public async Task<int> SaveAsync() => await dbContext.SaveChangesAsync();

        public void Dispose() => dbContext.Dispose();
    }
}
