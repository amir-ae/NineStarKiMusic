using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NineStarKi.Models
{
    public class Personality
    {
        [Required(ErrorMessage = "Please select a personality")]
        /*[Range(1, 9, ErrorMessage = "Please select a personality")]*/
        public char Key { get; set; }         // Main personality

        [Required(ErrorMessage = "Please select a personality")]
        public string Value { get; set; }       // Emotional self and life challenge

        public Personality() {}

        public Personality(string number)
        {
            Key = number[0];
            Value = $"{number[1]}.{number[2]}";
        }
    }
}
