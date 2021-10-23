using AgileMovie.Models;
using AgileMovie.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgileMovie.WebAPI.Controllers
{
    [Authorize]
    public class MovieController : ApiController
    {
        private MovieService CreateMovieService()
        {
            var userId = int.Parse(User.Identity.GetUserId());
            var movieService = new MovieService(userId);
            return movieService;
        }
        public IHttpActionResult Get()
        {
            MovieService movieService = CreateMovieService();
            var movies = movieService.GetMovie();
            return Ok(movies);
        }

        public IHttpActionResult Post(MovieCreate movie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateMovieService();

            if (!service.CreateMovie(movie))
                return InternalServerError();

            return Ok();
        }

        //Get Method by Id
        public IHttpActionResult Get(int id)
        {
            MovieService movieService = CreateMovieService();
            var movie = movieService.GetMovieById(id);
            return Ok(movie);
        }

        public IHttpActionResult Put(MovieEdit movie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateMovieService();

            if (!service.UpdateMovie(movie))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateMovieService();

            if (!service.DeleteMovie(id))
                return InternalServerError();

            return Ok();
        }
    }
}
