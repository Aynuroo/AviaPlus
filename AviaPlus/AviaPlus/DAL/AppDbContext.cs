using AviaPlus.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AviaPlus.DAL
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {

        }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Perfumery> Perfumeries { get; set; }
        public DbSet<Cosmetic> Cosmetics { get; set; }
        public DbSet<Spirit> Spirits { get; set; }
        public DbSet<GourmetFood> GourmetFoods { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<Jewelry> Jewelries { get; set; }
        public DbSet<Clothes> Clothes { get; set; }
    }
}
