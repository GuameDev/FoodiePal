using FoodiePal.Server.Database;
using FoodiePal.Shared;
using FoodiePal.Shared.Base;
using FoodiePal.Shared.Entities;
using FoodiePal.Shared.Users.DTOs;
using FoodiePal.Shared.Users.Repository;
using FoodiePal.Shared.Users.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace FoodiePal.Server.Users.Application.Services
{
    public class UserLoginJWT : IUserLogin
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        public UserLoginJWT(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        public async Task<ServiceResponse<UserLoginResponse>> LoginAsync(UserLoginRequest request)
        {
            var response = new ServiceResponse<UserLoginResponse>();

            var user = await _unitOfWork.UserRepository.GetUserByEmailAsync(request.Email);

            if (user is null ) 
            {
                response.Success = false;
                response.Message = "User not found";
                return response;
            }

            if(!EnsurePasswordHashIsValid(request.Password,user.PasswordHash,user.PasswordSalt))
            {
                response.Success = false;
                response.Message = "Wrong password";
                return response;
            }

            response.Data = CreateToken(user);
            response.Message = $"Welcome {user.FirstName}, you are in!";
            return response;

        }

        private UserLoginResponse CreateToken(User user)
        {
            var response = new UserLoginResponse();

            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.FirstName),
                new Claim(ClaimTypes.Role,user.Role.Name),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("Jwt:key").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var expirationDate = DateTime.Now.AddDays(1);
            var token = new JwtSecurityToken(
                claims:claims,
                expires:expirationDate,
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return new UserLoginResponse()
            {
                Token = jwt,
                ExpirationDate = expirationDate,
            };
        }

        //TODO: Auth Service? 
        private bool EnsurePasswordHashIsValid(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using(var hmac =new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }
}
