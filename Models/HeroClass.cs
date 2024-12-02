namespace Models;

public class HeroClass
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Hero> Heroes { get; set; }
}
