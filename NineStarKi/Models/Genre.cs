using System.ComponentModel.DataAnnotations;

namespace NineStarKi.Models
{
    public class Genre
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Please enter genre name")]
        public string Name { get; set; }
    }
}
