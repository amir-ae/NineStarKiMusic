using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NineStarKi.Models
{
    public class Musician
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select a genre")]
        public List<Genre> Genres { get; set; }

        [Required(ErrorMessage = "Please select an occasion")]
        public List<Occasion> Occasions { get; set; }

        [Required(ErrorMessage = "Please enter a recording")]
        public string Recording { get; set; }

        [Required(ErrorMessage = "Please enter nine star ki number(s)")]
        public string Numbers { get; set; }
    }
}
