using Microsoft.EntityFrameworkCore;

namespace NineStarKi.Models
{
    public class PDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public PDbContext(DbContextOptions<PDbContext> options) : base(options) { }
        public DbSet<Personality> Personalities { get; set; }

        public DbSet<Musician> Musicians { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Occasion> Occasions { get; set; }
    }
}
