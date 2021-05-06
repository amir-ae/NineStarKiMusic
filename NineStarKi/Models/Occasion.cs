using System;
using System.ComponentModel.DataAnnotations;

namespace NineStarKi.Models
{
    public class Occasion : IEquatable<Occasion>
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter occasion name")]
        [MaxLength(50)]
        public string Name { get; set; }

        public bool Equals(Occasion other)
        {
            if (Name == other.Name)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            int hashName = Name == null ? 0 : Name.GetHashCode();

            return hashName;
        }
    }
}
