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
        new Animal { AnimalId = 1, Species = "cat", Age = 30, Name = "Nepolian", Gender = "male", Info = "Lovely kitty, very nice and lovely."}
      );
    }
  }
}