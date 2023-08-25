using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodiePal.Shared.Enums;

namespace FoodiePal.Shared.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public UnitType UnitOfMeasurement { get; set; }


        //FKs
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe{ get; set; }

       

    }
}
