using GameObjectMapper.Dtos;
using GameObjectMapper.Models;

namespace GameObjectMapper.Mappers.ExtensionMethodExemple;



public static class CharacterMappingExtensions
{
    public static CharacterDTO ToDTO(this Character character)
    {
        return new CharacterDTO
        {
            Id = character.Id,
            CharacterName = character.Name,
            Class = character.Class.ToString(),
            Level = character.Level,
            Health = character.Health,
            IsNPC = character.IsNPC,
            CreatedAt = character.CreatedAt.ToString("o")
        };
    }
}
