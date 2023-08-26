using AutoMapper;
using FoodiePal.Shared.Entities;
using FoodiePal.Shared.Users.DTOs;

namespace FoodiePal.Server.Utils.AutoMapper.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            DtoToEntity();
            EntityToDto();
        }

        private void EntityToDto()
        {
            CreateMap<User, UserDto>()
               .ForMember(
                   dest => dest.FirstName,
                   opt => opt.MapFrom(src => $"{src.FirstName}")
               )
               .ForMember(
                   dest => dest.LastName1,
                   opt => opt.MapFrom(src => $"{src.LastName1}")
               ).ForMember(
                   dest => dest.LastName2,
                   opt => opt.MapFrom(src => $"{src.LastName2}")
               )
               .ForMember(
                   dest => dest.Email,
                   opt => opt.MapFrom(src => $"{src.Email}")
               )
               .ForMember(
                   dest => dest.CreationDate,
                   opt => opt.MapFrom(src => src.CreationDate)
               ).ForMember(
                   dest => dest.UpdateDate,
                   opt => opt.MapFrom(src => src.LastUpdateDate)
               ).ForMember(
                   dest => dest.Deleted,
                   opt => opt.MapFrom(src => src.Deleted)
               ).ForMember(
                   dest => dest.Visible,
                   opt => opt.MapFrom(src => src.Visible)
               )
               .ForMember(
                   dest => dest.Role,
                   opt => opt.MapFrom(src => src.Role)
               )
               .ForMember(
                   dest => dest.Addresses,
                   opt => opt.MapFrom(src => src.Addresses)
               )
               ;
        }

        private void DtoToEntity()
        {
            CreateMap<UserDto, User>()
                .ForMember(
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => $"{src.FirstName}")
                )
                .ForMember(
                    dest => dest.LastName1,
                    opt => opt.MapFrom(src => $"{src.LastName1}")
                ).ForMember(
                    dest => dest.LastName2,
                    opt => opt.MapFrom(src => $"{src.LastName2}")
                )
                .ForMember(
                    dest => dest.Email,
                    opt => opt.MapFrom(src => $"{src.Email}")
                )
                .ForMember(
                    dest => dest.CreationDate,
                    opt => opt.MapFrom(src => src.CreationDate)
                ).ForMember(
                    dest => dest.LastUpdateDate,
                    opt => opt.MapFrom(src => src.UpdateDate)
                ).ForMember(
                    dest => dest.Deleted,
                    opt => opt.MapFrom(src => src.Deleted)
                ).ForMember(
                    dest => dest.Visible,
                    opt => opt.MapFrom(src => src.Visible)
                )
                .ForMember(
                    dest => dest.Role,
                    opt => opt.MapFrom(src => src.Role)
                )
                .ForMember(
                    dest => dest.Addresses,
                    opt => opt.MapFrom(src => src.Addresses)
                )
                ;
        }
    }
}
