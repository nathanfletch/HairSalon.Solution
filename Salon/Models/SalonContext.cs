using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
  public class SalonContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; } //update this
    public DbSet<Client> Clients { get; set; } //update this

    public SalonContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}