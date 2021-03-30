using System.ComponentModel.DataAnnotations;

namespace NineStarKi.Models
{
    public class Occasion
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Please enter occasion name")]
        public string Name { get; set; }
    }
}
