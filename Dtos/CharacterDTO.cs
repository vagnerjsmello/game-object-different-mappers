namespace GameObjectMapper.Dtos;

public class CharacterDTO
{
    public int Id { get; set; }
    public string CharacterName { get; set; } = string.Empty;
    public string Class { get; set; } = string.Empty; 
    public int Level { get; set; }
    public double Health { get; set; }
    public bool IsNPC { get; set; }
    public string CreatedAt { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Id: {Id}, Name: {CharacterName}, Class: {Class}, Level: {Level}, Health: {Health}, IsNPC: {IsNPC}, CreatedAt: {CreatedAt}";
    }
}