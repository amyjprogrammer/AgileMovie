using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Models
{
    public class CustomerCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter your full First Name.")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter your full Last Name.")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime Birthdate { get; set; }
    }
}
