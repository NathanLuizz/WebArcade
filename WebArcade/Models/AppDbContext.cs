using Microsoft.EntityFrameworkCore;

namespace WebArcade.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Games> Games { get; set; }


    }
}
