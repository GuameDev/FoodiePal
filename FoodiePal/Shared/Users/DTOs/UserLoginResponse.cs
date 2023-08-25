using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Users.DTOs
{
    public class UserLoginResponse
    {
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
