using FoodiePal.Shared.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Entities
{
    public class Recipe:BaseEntity
    {
        //Properties
        public string Name { get; set; }
        public string Description { get; set; }

        //FKs
        public ICollection<Author> Authors { get; set; } = new List<Author>();

        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public ICollection<Step> Steps{ get; set; } = new List<Step>();

        public int CategoryId { get; set; }
        public Category Category { get; set; }


        //Constructors
        public Recipe() { }
  
        
    }
}
