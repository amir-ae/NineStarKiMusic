using Microsoft.EntityFrameworkCore;

namespace NineStarKi.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options) { 
            // ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Musician> Musicians { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Occasion> Occasions { get; set; }
    }
}
