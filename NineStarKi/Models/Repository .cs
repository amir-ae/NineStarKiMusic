﻿using System.Collections.Generic;
using System.Linq;


namespace NineStarKi.Models
{
    public class Repository : IRepository
    {
        public List<Personality> Personalities { get; set; } = new List<Personality>();

        public List<Musician> Musicians { get; set; } = new List<Musician>();

        public List<Genre> Genres { get; set; } = new List<Genre>();

        public List<Occasion> Occasions { get; set; } = new List<Occasion>();

        public void CreatePersonality(Personality p)
        {
            Personalities.Add(p);
        }

        public void AddGenres(List<Genre> g)
        {
            Genres.AddRange(g);
        }

        public void AddOccasions(List<Occasion> o)
        {
            Occasions.AddRange(o);
        }

        public void AddMusicians(List<Musician> m)
        {
            Musicians.AddRange(m);
        }

        public void ClearRepository()
        {
            Personalities.ToList().Clear();
        }
    }
}
