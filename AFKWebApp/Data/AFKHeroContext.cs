using Microsoft.EntityFrameworkCore;

namespace AFKWebApp.Models
{
    public class HeroContext : DbContext
    {
        public HeroContext (DbContextOptions<HeroContext> options)
            : base(options)
        {
        }

        public DbSet<AFKWebApp.Models.Hero> Hero { get; set; }
    }
}