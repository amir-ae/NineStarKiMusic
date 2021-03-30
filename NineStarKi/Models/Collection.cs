using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineStarKi.Models
{
    public class Collection
    {
        public IEnumerable<Musician> Musicians { get; set; }

        public IEnumerable<Occasion> Occasions { get; set; }
    }
}
