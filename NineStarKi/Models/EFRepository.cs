using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineStarKi.Models
{
    public class EFRepository : IRepository
    {
        private MusicContext context;

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

        public EFRepository(MusicContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Musician> Musicians => GetMusicians();

        public IEnumerable<Musician> GetMusicians()
        {
            IEnumerable<Musician> musicians = context.Musicians
                .Include(m => m.Genres)
                .Include(m => m.Occasions);
            BreakCircularReference(ref musicians);
            return musicians;
        }

        public IEnumerable<Musician> GetMusicians(string number)
        {
            IEnumerable<Musician> musicians = context.Musicians
                .Include(m => m.Genres)
                .Include(m => m.Occasions)
                .Where(m => m.Numbers.Contains(number));
            BreakCircularReference(ref musicians);
            return musicians;
        }

        public IEnumerable<Genre> Genres => context.Genres;

        public IEnumerable<Occasion> Occasions => context.Occasions;

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
