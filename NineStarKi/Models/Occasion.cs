using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NineStarKi.Models
{
    public class Occasion : IEquatable<Occasion>
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter occasion name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(Musician.Occasions))]
        public IEnumerable<Musician> Musicians { get; set; }

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
