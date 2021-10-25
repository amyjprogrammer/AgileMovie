using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Data
{
   public class Movie
   {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public string MovieDescription { get; set; }
        [Required]
        public MovieGenre Genre { get; set; }
 /*        public bool NewRelease { get; set; }
        public DateTime ReleaseDate { get; set; }
            Backlog*/

   }
    public enum MovieGenre
    {
        Horror = 1,
        SciFi,
        Fantasy,
        Romcom,
        Action,
        Kids,
        Animation
    }
}
