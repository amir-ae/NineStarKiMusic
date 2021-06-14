using System.Collections.Generic;
using System.Linq;

namespace NineStarKi.Models
{
    public interface IRepository
    {
        IEnumerable<Musician> Musicians { get; }

        IEnumerable<Genre> Genres { get; }

        IEnumerable<Occasion> Occasions { get; }

        IEnumerable<Musician> GetMusicians(string number);

        void AddGenres(IEnumerable<Genre> g);

        void AddOccasions(IEnumerable<Occasion> o);

        void AddMusicians(IEnumerable<Musician> m);

        void ClearRepository();
    }
}
