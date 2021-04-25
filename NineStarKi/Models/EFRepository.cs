using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace NineStarKi.Models
{
    public class EFRepository : IRepository
    {
        private PDbContext context;

        public EFRepository(PDbContext ctx)
        {
            context = ctx;
        }

        public List<Musician> Musicians => context.Musicians
            .Include("Genres")
            .Include("Occasions")
            .ToList();

        public List<Genre> Genres => context.Genres.ToList();

        public List<Occasion> Occasions => context.Occasions.ToList();

        public List<Personality> Personalities => context.Personalities.ToList();

        public void CreatePersonality(Personality p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void AddGenres(List<Genre> g)
        {
            context.Add(g);
            context.SaveChanges();
        }

        public void AddOccasions(List<Occasion> o)
        {
            context.Add(o);
            context.SaveChanges();
        }

        public void AddMusicians(List<Musician> m)
        {
            context.Add(m);
            context.SaveChanges();
        }

        public void ClearRepository()
        {
            foreach (var m in context.Musicians)
            {
                context.Musicians.Remove(m);
            }
            foreach (var p in context.Personalities)
            {
                context.Personalities.Remove(p);
            }
            context.SaveChanges();
        }
    }
}
