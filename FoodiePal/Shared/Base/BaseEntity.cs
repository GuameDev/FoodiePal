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
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; } = DateTime.Now;


        //Flags
        public bool Visible { get; set; } = true;
        public bool Deleted { get; set; } = false;

        //Las flags que no se mapean quizá tenga sentido dejarlas en los DTO y
        //sacarlas de las entidades de dominio, ya que realmente no van a ser persisitdas
        [NotMapped]
        public bool Editing { get; set; } = false;

        [NotMapped]
        public bool IsNew { get; set; } = false;
    }
}
