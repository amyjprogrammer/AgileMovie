using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Models
{
    public class TheatreCreate
    {
        [Required]
        public decimal TicketPrice { get; set; }
        [Required]
        public int MovieId { get; set; }
    }
}
