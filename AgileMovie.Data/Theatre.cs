using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Data
{
    public class Theatre
    {
        [Key]
        public int TheatreId { get; set; }

        [ForeignKey(nameof(Movie))]
        public int MovieId { get; set; }

        public decimal TicketPrice { get; set; }

        public List<Movie> SelectMovie { get; set; }
    }
}
