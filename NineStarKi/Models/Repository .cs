using System.Collections.Generic;
using System.Linq;


namespace NineStarKi.Models
{
    public class Repository : IRepository
    {
        private List<Musician> musicians { get; set; } = new List<Musician>();

        private List<Genre> genres { get; set; } = new List<Genre>();

        private List<Occasion> occasions { get; set; } = new List<Occasion>();

        public IEnumerable<Musician> Musicians => musicians;

        public IEnumerable<Genre> Genres => genres;

        public IEnumerable<Occasion> Occasions => occasions;

        public IEnumerable<Musician> GetMusicians(string number) => Musicians
            .Where(m => m.Numbers.Contains(number));

        public IEnumerable<Musician> GetRelated(IEnumerable<Musician> musicians) => musicians;

        public void AddGenres(IEnumerable<Genre> g)
        {
            genres.AddRange(g);
        }

        public void AddOccasions(IEnumerable<Occasion> o)
        {
            occasions.AddRange(o);
        }

        public void AddMusicians(IEnumerable<Musician> m)
        {
            musicians.AddRange(m);
        }

        public void ClearRepository()
        {
            musicians.Clear();
            genres.Clear();
            occasions.Clear();
        }
    }
}
