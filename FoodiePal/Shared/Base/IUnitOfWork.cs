using FoodiePal.Shared.Recipes.Repository;
using FoodiePal.Shared.Users.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Base
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; set; }
        IRecipeRepository RecipeRepository{ get; set; }
        Task<int> SaveAsync();
    }
}
