using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName1 { get; set; } = string.Empty;
        public string LastName2 { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
        public int RoleId { get; set; } = 2;
        public Role Role { get; set; }



        //Flags
        public bool Visible { get; set; } = true;
        public bool Deleted { get; set; } = false;

        [NotMapped]
        public bool Editing { get; set; } = false;

        [NotMapped]
        public bool IsNew { get; set; } = false;


        //Constructor
        public User(){}
        public User
            (
            int id,
            string name,
            string lastName1,
            string lastName2,
            string email,
            byte[] passwordHash,
            byte[] passwordSalt,
            DateTime dateCreated,
            ICollection<Address> addresses,
            int roleId,
            Role role
,
            bool visible,
            bool deleted,
            bool editing,
            bool isNew)
        {
            Id = id;
            FirstName = name;
            LastName1 = lastName1;
            LastName2 = lastName2;
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            DateCreated = dateCreated;
            Addresses = addresses;
            RoleId = roleId;
            Role = role;
            Visible = visible;
            Deleted = deleted;
            Editing = editing;
            IsNew = isNew;
        }
    }
}
