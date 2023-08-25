using FoodiePal.Shared;
using FoodiePal.Shared.Base;
using FoodiePal.Shared.Entities;
using FoodiePal.Shared.Users.DTOs;
using FoodiePal.Shared.Users.Repository;
using FoodiePal.Shared.Users.Services;
using System.Security.Cryptography;
using System.Text;

namespace FoodiePal.Server.Users.Application.Services
{
    public class UserRegister : IUserRegister
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserRegister(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ServiceResponse<UserRegisterResponse>> RegisterAsync(UserRegisterRequest request)
        {
            if(await _unitOfWork.UserRepository.UserExistAsync(request.Email))
            {
                return new ServiceResponse<UserRegisterResponse>()
                {
                    Data = null,
                    Message = $"The email {request.Email} is already in use",
                    Success = false
                };
            }

            GeneratePasswordHash(request.Password, out byte[] passwordHash, out byte[] salt);

            //TODO: Configure AutoMapper
            var user = new User()
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName1 = request.LastName1,
                LastName2 = request.LastName2,
                PasswordHash = passwordHash,
                PasswordSalt = salt
            };
            await _unitOfWork.UserRepository.AddAsync(user);
            await _unitOfWork.SaveAsync();


            return new ServiceResponse<UserRegisterResponse>()
            {
                Data = new UserRegisterResponse()
                {
                    Email = user.Email
                },
                Message = $"The user {user.Email} was succesfully registered!"
            };

        }

        private void GeneratePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash=hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
