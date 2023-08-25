﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Base
{
    public class BaseEntityDto
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }


        //Flags
        public bool Visible { get; set; } = true;
        public bool Deleted { get; set; } = false;
        public bool Editing { get; set; } = false;
        public bool IsNew { get; set; } = false;
    }
}