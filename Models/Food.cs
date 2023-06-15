using System.ComponentModel.DataAnnotations;

namespace nutrition.Models
{
    public class Food
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string? name { get; set; }
        
        [Required(ErrorMessage = "Please enter calories")]
        public int? calories { get; set; }

        public bool? isExpensive { get; set; }

        // [EmailAddress]
    }
}