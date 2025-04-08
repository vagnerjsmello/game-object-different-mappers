using AutoMapper;
using GameObjectMapper.Dtos;
using GameObjectMapper.Models;

namespace GameObjectMapper.Mappers.AutoMapperExemple;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Character, CharacterDTO>()
            .ForMember(dest => dest.CharacterName, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Class, opt => opt.MapFrom(src => src.Class.ToString()))
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt.ToString("o")));
    }
}
