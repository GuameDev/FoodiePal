using AutoMapper;
using FoodiePal.Shared.Entities;
using FoodiePal.Shared.Users.DTOs;

namespace FoodiePal.Server.Utils.AutoMapper.Profiles
{
    public class RoleProfile:Profile
    {
        public RoleProfile()
        {
            DtoToEntity();
            EntityToDto();
        }

   

        private void EntityToDto()
        {
            CreateMap<Role, RoleDto>()
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
                  dest => dest.Name,
                  opt => opt.MapFrom(src => $"{src.Name}")
              );
        }

        private void DtoToEntity()
        {
            CreateMap<RoleDto, Role>()
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
                   dest => dest.Name,
                   opt => opt.MapFrom(src => $"{src.Name}")
               );
        }
    }
}
