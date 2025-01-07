using HotelReservationApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservationApp.Controllers
{
    public class ReservationController : Controller
    {
        private DatabaseContext _context;

        public ReservationController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: ReservationController
        public ActionResult Index()
        {
            var reservations = _context.Reservations.ToList();

            return View(reservations);
        }

    }
}
