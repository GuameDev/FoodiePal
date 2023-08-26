using AutoMapper;
using FoodiePal.Shared;
using FoodiePal.Shared.Base;
using FoodiePal.Shared.Users.DTOs;
using FoodiePal.Shared.Users.Services;

namespace FoodiePal.Server.Users.Application.Services
{
    public class GetAllUsers : IGetAllUsers
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllUsers(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<UserDto>>> GetAllUsersAsync()
        {

            //var users = await _unitOfWork.UserRepository.GetAllAsync();
            
            var users = await _unitOfWork.UserRepository.GetAllUsersAsync();
            var mappedUsers = _mapper.Map<List<UserDto>>(users);

            if(mappedUsers == null)
            {
                return null;
            }
            return new ServiceResponse<List<UserDto>>()
            {
                Data = mappedUsers,
                Message = $"Users count is up to: {mappedUsers.Count()}",
                Success = true
            };
        }
    }
}
