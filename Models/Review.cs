using System;
using System.ComponentModel.DataAnnotations;

namespace restauranter.Models
{
    public class Review
    {
        [Key]
        public int restaurant_id { get; set; }

        [Required(ErrorMessage="Cannot leave name field blank")]
        public string name { get; set; }

        [Required(ErrorMessage="Cannot leave restaurant field blank")]
        public string restaurant { get; set; }

        [Required(ErrorMessage="Must provide rating")]
        public int stars { get; set; }

        [Required(ErrorMessage="Cannot leave review empty")]
        [MinLength(10, ErrorMessage="Must be 10 characters or long to be a valid review")]
        public string review { get; set; }

        [Required(ErrorMessage="Must provide a date")]
        public DateTime date_visit { get; set; }
    }
}