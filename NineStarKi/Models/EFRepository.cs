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

        private void BreakCircularReference(ref IEnumerable<Musician> musicians)
        {
            foreach (Musician musician in musicians)
            {
                foreach (Genre genre in musician.Genres)
                {
                    genre.Musicians = null;
                }
                foreach (Occasion occasion in musician.Occasions)
                {
                    occasion.Musicians = null;
                }
            }
        }

        public IEnumerable<Musician> Musicians => context.Musicians;

        public IEnumerable<Genre> Genres => context.Genres;

        public IEnumerable<Occasion> Occasions => context.Occasions;

        public IEnumerable<Musician> GetMusicians(string number)
        {
            IEnumerable<Musician> musicians = context.Musicians
                .Include(m => m.Genres)
                .Include(m => m.Occasions)
                .Where(m => m.Numbers.Contains(number));
            BreakCircularReference(ref musicians);
            return musicians;
        }

        public IEnumerable<Musician> GetRelated(IEnumerable<Musician> musicians)
        {
            IEnumerable<Musician> data = context.Musicians
                .Include(m => m.Genres)
                .Include(m => m.Occasions)
                .Where(m => musicians.Select(s => s.Id)
                    .Any(id => id == m.Id));
            BreakCircularReference(ref data);
            return data;
        }

        public void AddGenres(IEnumerable<Genre> g)
        {
            context.AddRange(g);
            context.SaveChanges();
        }

        public void AddOccasions(IEnumerable<Occasion> o)
        {
            context.AddRange(o);
            context.SaveChanges();
        }

        public void AddMusicians(IEnumerable<Musician> m)
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
