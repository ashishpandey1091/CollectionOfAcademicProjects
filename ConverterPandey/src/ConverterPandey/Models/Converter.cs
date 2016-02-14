using System.ComponentModel.DataAnnotations;

namespace ConverterPandey.Models
{
    public class Converter
    {
        public int ConverterID { get; set; }

        [Display(Name = "ZIP Code")]
        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$", ErrorMessage = "Please enter a valid US ZIP code")]
        public int Zipcode { get; set; } = 64468;

        [Required]
        [Range(-12, 120)]
        [Display(Name = "Temperature (F)")]
        public int Temperature_F { get; set; } = 72;
    }
}