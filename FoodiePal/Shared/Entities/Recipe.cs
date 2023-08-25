using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Entities
{
    public class Recipe
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }

        //FKs

        public ICollection<Author> Authors { get; set; } = new List<Author>();

        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public ICollection<Step> Steps{ get; set; } = new List<Step>();

        public int CategoryId { get; set; }
        public Category Category { get; set; }


        //Flags
        public bool Visible { get; set; } = true;
        public bool Deleted  { get; set; } = false;

        [NotMapped]
        public bool Editing { get; set; } = false;

        [NotMapped]
        public bool IsNew { get; set; } = false;


        //Constructors
        public Recipe() { }
  
        
    }
}
