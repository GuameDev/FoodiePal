using FoodiePal.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Entities
{
    public class Author:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        
        //FKs
        public ICollection<Recipe> Recipes{ get; set; } = new List<Recipe>();

    }
}
