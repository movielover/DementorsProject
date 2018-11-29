using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Dementors.Model
{
    public class Feedback
    {        
        
        [Display(Name = "Brugernavn ")]
        [Required]
        [DataType(DataType.Text)]
        public int UserId { get; set; }
        public int Id { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(20, ErrorMessage = "Din feedback skal minimum være 20 tegn")]
        public string Text { get; set; }
        public DateTime TimeDate { get; set; }
    }
}
