using AutoMapper;
using FoodiePal.Shared.Entities;
using FoodiePal.Shared.Users.DTOs;

namespace FoodiePal.Server.Utils.AutoMapper.Profiles
{
    public class AddressProfile:Profile
    {
        public AddressProfile()
        {
            DtoToEntity();
            EntityToDto();
        }

        private void EntityToDto()
        {
            CreateMap<Address, AddressDto>()
                .ForMember(
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => $"{src.FirstName}")
                )
                .ForMember(
                    dest => dest.Street,
                    opt => opt.MapFrom(src => $"{src.Street}")
                ).ForMember(
                    dest => dest.City,
                    opt => opt.MapFrom(src => $"{src.City}")
                )
                .ForMember(
                    dest => dest.Country,
                    opt => opt.MapFrom(src => $"{src.Country}")
                )
                .ForMember(
                    dest => dest.CreationDate,
                    opt => opt.MapFrom(src => src.CreationDate)
                ).ForMember(
                    dest => dest.UpdateDate,
                    opt => opt.MapFrom(src => src.UpdateDate)
                ).ForMember(
                    dest => dest.Deleted,
                    opt => opt.MapFrom(src => src.Deleted)
                ).ForMember(
                    dest => dest.Visible,
                    opt => opt.MapFrom(src => src.Visible)
                )
                .ForMember(
                    dest => dest.LastName,
                    opt => opt.MapFrom(src => src.LastName)
                )

                ;
        }

        private void DtoToEntity()
        {
            CreateMap<AddressDto, Address>()
                .ForMember(
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => $"{src.FirstName}")
                )
                .ForMember(
                    dest => dest.Street,
                    opt => opt.MapFrom(src => $"{src.Street}")
                ).ForMember(
                    dest => dest.City,
                    opt => opt.MapFrom(src => $"{src.City}")
                )
                .ForMember(
                    dest => dest.Country,
                    opt => opt.MapFrom(src => $"{src.Country}")
                )
                .ForMember(
                    dest => dest.CreationDate,
                    opt => opt.MapFrom(src => src.CreationDate)
                ).ForMember(
                    dest => dest.UpdateDate,
                    opt => opt.MapFrom(src => src.UpdateDate)
                ).ForMember(
                    dest => dest.Deleted,
                    opt => opt.MapFrom(src => src.Deleted)
                ).ForMember(
                    dest => dest.Visible,
                    opt => opt.MapFrom(src => src.Visible)
                )
                .ForMember(
                    dest => dest.LastName,
                    opt => opt.MapFrom(src => src.LastName)
                )

                ;
        }
    }
}
