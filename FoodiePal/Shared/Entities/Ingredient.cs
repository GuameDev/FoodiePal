﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodiePal.Shared.Base;
using FoodiePal.Shared.Enums;

namespace FoodiePal.Shared.Entities
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        
        public double Quantity { get; set; }

        //FKs
        public int MassUnitId { get; set; } = 3;
        public MassUnit MassUnit { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }



    }
}
