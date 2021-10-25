using AgileMovie.Data;
using AgileMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileMovie.Services
{
    public class TheatreService
    {
        private readonly Guid _userId;

        public TheatreService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateTheatre(TheatreCreate model)
        {
            var entity = new Theatre()
            {
                OwnerId = _userId,
                MovieId = model.MovieId,
                TicketPrice = model.TicketPrice
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Theatres.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<TheatreListItem> GetTheatre()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Theatres
                        .Select(
                            e =>
                            new TheatreListItem
                            {
                                MovieId = e.MovieId,
                                TicketPrice = e.TicketPrice,
                                TheatreId = e.TheatreId
                            }
                        );
                return query.ToArray();
            }
        }

        public TheatreDetail GetTheatreById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Theatres
                        .Single(e => e.TheatreId == id && e.OwnerId == _userId);
                    return
                        new TheatreDetail
                        {
                            TheatreId = entity.TheatreId,
                            MovieId = entity.MovieId,
                            TicketPrice = entity.TicketPrice
                        };
            }
        }

        public bool UpdateTheatre(TheatreEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Theatres
                        .Single(e => e.TheatreId == model.TheatreId && e.OwnerId == _userId);
                entity.TicketPrice = model.TicketPrice;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteTheatre(int theatreId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Theatres
                        .Single(e => e.TheatreId == theatreId && e.OwnerId == _userId);

                ctx.Theatres.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
