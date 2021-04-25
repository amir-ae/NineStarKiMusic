using System.ComponentModel.DataAnnotations;

namespace NineStarKi.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter genre name")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
