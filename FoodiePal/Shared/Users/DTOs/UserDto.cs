using FoodiePal.Shared.Base;
using FoodiePal.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Users.DTOs
{
    public class UserDto:BaseEntityDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName1 { get; set; } = string.Empty;
        public string LastName2 { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
        public Role Role { get; set; }
    }
}
