using System.Collections.Generic;
using System.Linq;

namespace NineStarKi.Models
{
    public interface IRepository
    {
        List<Personality> Personalities { get; }

        List<Musician> Musicians { get; }

        List<Genre> Genres { get; }

        List<Occasion> Occasions { get; }

        void CreatePersonality(Personality p);

        void AddGenres(List<Genre> g);

        void AddOccasions(List<Occasion> o);

        void AddMusicians(List<Musician> m);

        void ClearRepository();
    }
}
