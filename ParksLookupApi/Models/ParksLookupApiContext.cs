using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Models
{
  public class ParksLookupApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }
    // public DbSet<Review> Review { get; set; }

    public ParksLookupApiContext(DbContextOptions<ParksLookupApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Olympic", State = "Washington"},
          new Park { ParkId = 2, Name = "Denali", State = "Alaska"},
          new Park { ParkId = 3, Name = "Everglades", State = "Florida"},
          new Park { ParkId = 4, Name = "Grand Canyon", State = "Arizona"},
          new Park { ParkId = 5, Name = "Yosemite", State = "California"}
        );
    }
  }
}