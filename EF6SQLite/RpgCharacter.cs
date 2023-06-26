namespace EF6SQLite;

public class RpgCharacter
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Class { get; set; }

    public int HitPoints { get; set; } = 100;
}
