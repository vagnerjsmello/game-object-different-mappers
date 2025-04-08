using GameObjectMapper.Enum;

namespace GameObjectMapper.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public CharacterClass Class { get; set; }
        public int Level { get; set; }
        public double Health { get; set; }
        public bool IsNPC { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
