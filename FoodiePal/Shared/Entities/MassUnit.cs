using FoodiePal.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Entities
{
    public class MassUnit:BaseEntity
    {
        public string Name{ get; set; }
        public string PostFix { get; set; }
        public string? Description { get; set; }

        public ICollection<MassEquivalence> MassEquivalences { get; set; } = new List<MassEquivalence>();
        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    }
}
