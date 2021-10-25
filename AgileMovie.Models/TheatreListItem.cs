using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Models
{
    public class TheatreListItem
    {
        public int TheatreId { get; set; }
        public int MovieId { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
