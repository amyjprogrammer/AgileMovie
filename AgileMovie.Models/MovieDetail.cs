using AgileMovie.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Models
{
   public class MovieDetail
   {
        public int MovieId { get; set; }
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string MovieDescription { get; set; }
        [Required]
        public MovieGenre Genre { get; set; }
    }
}
