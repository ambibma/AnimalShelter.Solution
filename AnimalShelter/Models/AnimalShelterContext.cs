using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {

    public DbSet<Item> Animal { get; set; }


    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}