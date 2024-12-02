namespace Models;

public class Quest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public ICollection<Hero> Heroes { get; set; }
}
