using System.Collections.Generic;
using System.Linq;

namespace NineStarKi.Models
{
    public interface IRepository
    {
        List<Musician> Musicians { get; }

        List<Genre> Genres { get; }

        List<Occasion> Occasions { get; }

        List<Musician> GetMusicians(string number);

        void AddGenres(List<Genre> g);

        void AddOccasions(List<Occasion> o);

        void AddMusicians(List<Musician> m);

        void ClearRepository();
    }
}
