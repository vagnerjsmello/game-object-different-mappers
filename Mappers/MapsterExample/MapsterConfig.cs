using GameObjectMapper.Dtos;
using GameObjectMapper.Models;
using Mapster;

namespace GameObjectMapper.Mappers.MapsterExample;

public static class MapsterConfig
{
    public static void Configure()
    {
        TypeAdapterConfig<Character, CharacterDTO>
            .NewConfig()
            .Map(dest => dest.CharacterName, src => src.Name)
            .Map(dest => dest.Class, src => src.Class.ToString())
            .Map(dest => dest.CreatedAt, src => src.CreatedAt.ToString("o"));
    }
}
