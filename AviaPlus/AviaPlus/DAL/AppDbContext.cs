using AviaPlus.Models;
using Microsoft.EntityFrameworkCore;

namespace AviaPlus.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {

        }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
