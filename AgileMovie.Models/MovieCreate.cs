using AgileMovie.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Models
{
   public class MovieCreate
   {
        public int MovieId { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Please enter less characters.")]
        public string MovieName { get; set; }
        [Required]
        [MaxLength(300, ErrorMessage = "Please enter less characters.")]
        public string MovieDescription { get; set; }
        [Required]
        public MovieGenre Genre { get; set; }

   }
}
