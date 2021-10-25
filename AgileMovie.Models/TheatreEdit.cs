using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Models
{
    public class TheatreEdit
    {
        public int TheatreId { get; set; }
        public decimal TicketPrice { get; set; }
        public int MovieId { get; set; }
    }
}
