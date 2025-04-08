using GameObjectMapper.Dtos;
using GameObjectMapper.Enum;

namespace GameObjectMapper.Mappers.ImplicitOperatorExemple;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public CharacterClass Class { get; set; }
    public int Level { get; set; }
    public double Health { get; set; }
    public bool IsNPC { get; set; }
    public DateTime CreatedAt { get; set; }

    // implicit operator
    public static implicit operator CharacterDTO(Character character)
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
