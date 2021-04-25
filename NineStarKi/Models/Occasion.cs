using System.ComponentModel.DataAnnotations;

namespace NineStarKi.Models
{
    public class Occasion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter occasion name")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
