using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Data
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;

        [Key]
        public int CustomerId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value.Length < 1 || value.Any(x => !char.IsLetter(x)))
                    throw new FormatException("First Name must be at least one character in the alphabet with no special characters.");
                else
                    _firstName = value;
            }
        }

        [Required]
        public string LastName
        {
            get => _lastName;
            set
            {
                if (value.Length < 1 || value.Any(x => !char.IsLetter(x)))
                    throw new FormatException("Last Name must be at least one character in the alphabet with no special characters.");
                else
                    _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }

        }

        [Required]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsBirthDate14DaysAway
        {
            get
            {
                var today = DateTime.Today;
                var next = new DateTime(today.Year, BirthDate.Month, BirthDate.Day);

                return ((next - today).Days == 14);
            }
        }

        //public bool IsBoughtRecently { get; set; }
    }
}
