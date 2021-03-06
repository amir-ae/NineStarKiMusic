using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NineStarKi.Models
{
    public class Genre
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter genre name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(Musician.Genres))]
        public IEnumerable<Musician> Musicians { get; set; }
    }
}
