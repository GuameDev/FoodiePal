using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //FKs
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

       
        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();  
    }
}
