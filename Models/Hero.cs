namespace Models;

public class Hero
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int ClassId { get; set; }
    public int Level { get; set; }
    public int? QuestId { get; set; }

    public HeroClass Class { get; set; }
    public Quest? Quest { get; set; }
    public ICollection<Equipment> Equipment { get; set; }
}
