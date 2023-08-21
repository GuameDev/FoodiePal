using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Users.DTOs
{
    public class UserRegisterRequest
    {
        public string FirstName { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }

        public string Email { get; set; }
        public string Password{ get; set; }
        
    }
}
