using FoodiePal.Shared;
using FoodiePal.Shared.Base;
using FoodiePal.Shared.Users.DTOs;
using FoodiePal.Shared.Users.Services;

namespace FoodiePal.Server.Users.Application.Services
{
    public class GetAllUsers : IGetAllUsers
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllUsers(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<ServiceResponse<List<UserDto>>> GetAllUsersAsync()
        {
            return _unitOfWork.UserRepository.GetAllAsync();
        }
    }
}
