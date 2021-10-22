using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Data
{
    public class Ratings
    { 
        [Key]
       public int RatingsId { get; set; } 
    
       [ForeignKey(nameof (Movie))]
        public int MovieId { get; set; }

        [Required]
        public double MovieReviewRating { get; set; } 
        
        public bool IsFamilyFriendly
        { 
            get
            {
                switch(RatingMovie)
                {
                    case MovieRating.G:
                    case MovieRating.PG:
                        return true;

                    case MovieRating.PG13:
                    case MovieRating.R:
                    default:
                        return false;
                }
            }
        }

        public MovieRating RatingMovie { get; set; }
        public enum MovieRating 
        { 
          G = 1, 
          PG,
          PG13,
          R 
        }
    }
}
