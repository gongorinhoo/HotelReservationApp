using HotelReservationApp.Data;
using HotelReservationApp.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservationApp.Controllers
{
    public class RoomController : Controller
    {
        private DatabaseContext _context;

        public RoomController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: RoomController
        public ActionResult Index()
        {
            var rooms = _context.Rooms.ToList();
            
            return View(rooms);
        }

    }
}
