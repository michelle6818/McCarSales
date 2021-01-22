using Microsoft.EntityFrameworkCore;
using McCarSales.Models;

namespace McCarSales.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Lot> Lot { get; set; }
    }
}
