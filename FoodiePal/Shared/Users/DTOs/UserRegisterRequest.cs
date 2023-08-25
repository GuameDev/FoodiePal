using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Users.DTOs
{
    public class UserRegisterRequest
    {
        [Required,EmailAddress, StringLength(50, MinimumLength = 6)]
        public string Email { get; set; } = string.Empty;

        [Required,StringLength(50, MinimumLength =6)]
        public string Password{ get; set; } = string.Empty;

        [Compare("Password", ErrorMessage ="The passwords do not match")]
        public string  ConfirmPassword { get; set; } = string.Empty;

        [StringLength(25)]
        public string? FirstName { get; set; } = string.Empty;

        [StringLength(25)]
        public string? LastName1 { get; set; } = string.Empty;

        [StringLength(25)]
        public string? LastName2 { get; set; } = string.Empty;

    }
}
