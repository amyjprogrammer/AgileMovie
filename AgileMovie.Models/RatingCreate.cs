using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Models
{
    class RatingCreate
    {
        [Required]
        public int RatingsId { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        [Range(0,10, ErrorMessage = "Please enter a number between 1 and 10 I.e 9.8 or 7.0")]
        public double MovieReviewRating { get; set; }


    }
}
