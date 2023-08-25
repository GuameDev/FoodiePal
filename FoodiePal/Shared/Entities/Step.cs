using FoodiePal.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Entities
{
    public class Step:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //FKs
        public int RecipeId { get; set; }
        public Recipe Recipe{ get; set; }
    }
}
