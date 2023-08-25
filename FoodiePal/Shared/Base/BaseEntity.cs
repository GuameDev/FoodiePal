using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }

        //Flags
        public bool Visible { get; set; } = true;
        public bool Deleted { get; set; } = false;

        [NotMapped]
        public bool Editing { get; set; } = false;

        [NotMapped]
        public bool IsNew { get; set; } = false;
    }
}
