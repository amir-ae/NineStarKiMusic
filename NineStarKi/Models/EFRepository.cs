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
            .Include("Genres")
            .Include("Occasions")
            .ToList();

        public List<Genre> Genres => context.Genres.ToList();

        public List<Occasion> Occasions => context.Occasions.ToList();

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
