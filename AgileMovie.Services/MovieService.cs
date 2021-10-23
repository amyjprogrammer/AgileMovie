using AgileMovie.Data;
using AgileMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AgileMovie.Services
{
    public class MovieService
    {
        private readonly int _userId;

        public MovieService(int userId)
        {
            _userId = userId;
        }

        public bool CreateMovie(MovieCreate model)
        {
            var entity = new Movie()
            {
                MovieId = _userId,
                MovieName = model.MovieName,
                MovieDescription = model.MovieDescription,
                Genre = model.Genre
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Movies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<MovieListItem> GetMovie()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Movies
                        .Where(e => e.MovieId == _userId)
                        .Select(
                             e =>
                              new MovieListItem
                              {
                                  MovieId = e.MovieId,
                                  MovieName = e.MovieName,
                                  MovieDescription = e.MovieDescription,
                                  Genre = e.Genre
                              });
                              
                return query.ToArray();
            }
        }

        public MovieDetail GetMovieById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Movies
                    .Single(e => e.MovieId == id && e.MovieId == _userId);
                return
                    new MovieDetail
                    {
                        MovieId = entity.MovieId,
                        MovieName = entity.MovieName,
                        MovieDescription = entity.MovieDescription,
                        Genre = entity.Genre
                    };
            }
        }
        public bool UpdateMovie(MovieEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Movies
                        .Single(e => e.MovieId == model.MovieId);

                entity.MovieName = model.MovieName;
                entity.MovieDescription = model.MovieDescription;
                entity.Genre = model.Genre;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteMovie(int movieId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Movies
                    .Single(e => e.MovieId == movieId);

                ctx.Movies.Remove(entity);

                return ctx.SaveChanges() == 1;

            }
        }
    }
}
