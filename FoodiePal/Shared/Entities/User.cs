using FoodiePal.Shared.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Entities
{
    public class User:BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName1 { get; set; } = string.Empty;
        public string LastName2 { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
        public int RoleId { get; set; } = 2;
        public Role Role { get; set; }

        //Constructor
        public User(){}

        public User(string firstName, string lastName1, string lastName2, string email, byte[] passwordHash, byte[] passwordSalt, ICollection<Address> addresses, int roleId, Role role)
        {
            FirstName = firstName;
            LastName1 = lastName1;
            LastName2 = lastName2;
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            Addresses = addresses;
            RoleId = roleId;
            Role = role;
        }
    }
}
