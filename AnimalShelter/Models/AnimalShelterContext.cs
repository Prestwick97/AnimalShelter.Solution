using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
    : base(options)
    {
    }
    public DbSet<Animal> Animals { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
  builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 1, Species = "cat", Age = 30, Name = "Nepolian", Gender = "male", Info = "Lovely orange kitty, very nice and lovely."},
        new Animal { AnimalId = 2, Species = "dog", Age = 2, Name = "Charlitan", Gender = "male", Info = "Lovely doggo, very nice and snuggly black lab."},
        new Animal { AnimalId = 3, Species = "cat", Age = 1, Name = "Maxamillion", Gender = "male", Info = "Black cat, loves to snuggle."},
        new Animal { AnimalId = 4, Species = "cat", Age = 4, Name = "Hillary", Gender = "female", Info = "Kind and loving calico, occasionally fiesty."},
        new Animal { AnimalId = 5, Species = "cat", Age = 300, Name = "Heceta", Gender = "female", Info = "Purple kitty, ancient and full of wisdom. Great pal."}
      );
    }
  }
}