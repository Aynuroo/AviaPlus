using Microsoft.EntityFrameworkCore;

namespace AviaPlus.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {

        }
    }
}
