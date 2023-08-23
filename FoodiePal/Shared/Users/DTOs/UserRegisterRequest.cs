using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Users.DTOs
{
    public class UserRegisterRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Password{ get; set; } = string.Empty;
        public string  ConfirmPassword { get; set; } = string.Empty;
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName1 { get; set; } = string.Empty;
        public string? LastName2 { get; set; } = string.Empty;

    }
}
