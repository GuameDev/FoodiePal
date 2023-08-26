using FoodiePal.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Entities
{
    public class MassEquivalence:BaseEntity
    {
        public double Value { get; set; }
        public string MassUnitParentName { get; set; }
        public string MassUnitEquivalentFactorName { get; set; }
        public ICollection<MassUnit> MassUnits { get; set; } = new List<MassUnit>();

    }
}
