using System.Collections.Generic;

namespace NineStarKi.Models
{
    public interface IRepository
    {
        IEnumerable<Musician> Musicians { get; }

        IEnumerable<Genre> Genres { get; }

        IEnumerable<Occasion> Occasions { get; }

        IEnumerable<Musician> GetRelated(IEnumerable<Musician> musicians);

        void AddGenres(IEnumerable<Genre> g);

        void AddOccasions(IEnumerable<Occasion> o);

        void AddMusicians(IEnumerable<Musician> m);

        void ClearRepository();
    }
}
