using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NineStarKi.Models
{
    public class Musician
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select a genre")]
        public IEnumerable<Genre> Genres { get; set; }

        [Required(ErrorMessage = "Please select an occasion")]
        public IEnumerable<Occasion> Occasions { get; set; }

        [Required(ErrorMessage = "Please enter a recording")]
        [MaxLength(150)]
        public string Recording { get; set; }

        [Required(ErrorMessage = "Please enter nine star ki number(s)")]
        [MaxLength(150)]
        public string Numbers { get; set; }
    }
}
