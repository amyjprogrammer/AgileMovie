
using AgileMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Services
{
    public class RatingsService
    {
        private readonly int _userId;

        public RatingsService(int userId)
        {
            _userId = userId;
        }

        public bool CreateRating(RatingCreate model)

    };
}