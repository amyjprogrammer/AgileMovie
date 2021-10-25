using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Models
{
    public class RatingListItem
    {
        public int RatingsId { get; set; }
        public int MovieId { get; set; }
        public double MovieReviewRating { get; set; }

    }
}
