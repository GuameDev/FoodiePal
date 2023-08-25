using FoodiePal.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Entities
{
    public class ProductType:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
