namespace Models;

public class Equipment
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int TypeId { get; set; }
    public decimal Weight { get; set; }
    public int? HeroId { get; set; }

    public EquipmentType Type { get; set; }
    public Hero? Hero { get; set; }
}
