using Microsoft.EntityFrameworkCore;

using Models;

public class JusticeAvengersDBContext : DbContext
{
    public JusticeAvengersDBContext(DbContextOptions<JusticeAvengersDBContext> options)
        : base(options)
    {
    }

    // DbSets for the entities
    public DbSet<Hero> Heroes { get; set; }
    public DbSet<Quest> Quests { get; set; }
    public DbSet<Equipment> Equipment { get; set; }
    public DbSet<HeroClass> HeroClasses { get; set; }
    public DbSet<EquipmentType> EquipmentTypes { get; set; }

protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Hero>().HasData(
    new Hero { Id = 1, Name = "Aragorn", Description = "A skilled ranger and warrior", ClassId = 1, Level = 20 },
    new Hero { Id = 2, Name = "Legolas", Description = "An elven archer with unmatched precision", ClassId = 2, Level = 18 },
    new Hero { Id = 3, Name = "Gandalf", Description = "A wise and powerful wizard", ClassId = 3, Level = 25 },
    new Hero { Id = 4, Name = "Frodo", Description = "A brave halfling on a dangerous journey", ClassId = 4, Level = 10 },
    new Hero { Id = 5, Name = "Eowyn", Description = "A fierce shieldmaiden of Rohan", ClassId = 5, Level = 15 },
    new Hero { Id = 6, Name = "Boromir", Description = "A noble warrior with a strong sense of duty", ClassId = 1, Level = 17 },
    new Hero { Id = 7, Name = "Gimli", Description = "A stout and fearless dwarf warrior", ClassId = 6, Level = 16 },
    new Hero { Id = 8, Name = "Thranduil", Description = "A king of the woodland elves", ClassId = 2, Level = 22 },
    new Hero { Id = 9, Name = "Arwen", Description = "A graceful elf skilled in healing and magic", ClassId = 3, Level = 14 },
    new Hero { Id = 10, Name = "Samwise", Description = "A loyal companion with unwavering courage", ClassId = 4, Level = 12 }
);


    }

}
