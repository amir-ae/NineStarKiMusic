using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace NineStarKi.Models
{
    public class EFRepository : IRepository
    {
        private MusicContext context;

        public EFRepository(MusicContext ctx)
        {
            context = ctx;
        }

        public List<Musician> Musicians => context.Musicians
            .Include(m => m.Genres)
            .Include(m => m.Occasions)
            .ToList();

        public List<Musician> GetMusicians(string number) => context.Musicians
            .Where(m => m.Numbers.Contains(number))
            .ToList();

        public List<Genre> Genres => context.Genres
            .Include(g => g.Musicians)
            .Select(g => new Genre { Id = g.Id, Name = g.Name, 
                Musicians = g.Musicians.Select(m => new Musician { Id = m.Id }).ToList() })
            .ToList();

        public List<Occasion> Occasions => context.Occasions
            .Include(o => o.Musicians)
            .Select(o => new Occasion { Id = o.Id, Name = o.Name, 
                Musicians = o.Musicians.Select(m => new Musician { Id = m.Id }).ToList() })
            .ToList();

        public void AddGenres(List<Genre> g)
        {
            context.AddRange(g);
            context.SaveChanges();
        }

        public void AddOccasions(List<Occasion> o)
        {
            context.AddRange(o);
            context.SaveChanges();
        }

        public void AddMusicians(List<Musician> m)
        {
            context.AddRange(m);
            context.SaveChanges();
        }

        public void ClearRepository()
        {
            foreach (Musician m in context.Musicians)
            {
                context.Musicians.Remove(m);
            }
            foreach (Genre g in context.Genres)
            {
                context.Genres.Remove(g);
            }
            foreach (Occasion o in context.Occasions)
            {
                context.Occasions.Remove(o);
            }
            context.SaveChanges();
        }
    }
}
