using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Models
{
    class RatingEdit
    {
        public int RatingsId { get; set; }
        public int MovieId { get; set; }
        public double MovieReviewRating { get; set; }
        public enum MovieRating
        {
            G = 1,
            PG,
            PG13,
            R
        }
    }
}
