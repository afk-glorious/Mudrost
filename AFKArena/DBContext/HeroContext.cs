using Microsoft.EntityFrameworkCore;
using AFKArena.Models;

namespace AFKArena.DBContext
{
    public class HeroContext : DbContext
    {
        public HeroContext(DbContextOptions<HeroContext> options)
            : base(options)
        {
        }

        public DbSet<Hero> Heroes { get; set; }
    }
}