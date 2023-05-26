using AviaPlus.Models;
using Microsoft.EntityFrameworkCore;

namespace AviaPlus.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {

        }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Perfumery> Perfumeries { get; set; }
    }
}
