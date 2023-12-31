namespace program;

public class Hero
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int PowerLvl { get; set; }

    public override string ToString()
    {
        return $"Hero(id: {Id}, name: {Name}, power: {PowerLvl})";
    }
}
