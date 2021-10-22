using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Data
{
    class Ratings
    { 
        [Key]
       public int RatingsId { get; set; } 
    
       [ForeignKey]
        public int MovieId { get; set; }

        [Required]
        public double MovieReviewRating { get; set; } 
        [Required]
        public bool IsFamilyFriendly { get; set; }
        
        public enum MovieRating
        { 
          G = 1, 
          PG,
          PG13,
          R 
        }
    }
}
