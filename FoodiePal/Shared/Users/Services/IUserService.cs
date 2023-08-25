﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodiePal.Shared.Users.Services
{
    public interface IUserService
    {
        Task<ServiceResponse<List<UserDto>>> GetAllUsers();
    }
}