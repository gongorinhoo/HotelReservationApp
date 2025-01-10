using HotelReservationApp.Data;
using HotelReservationApp.Data.Models;
using HotelReservationApp.Models;
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
            var rooms = _context.Rooms.Select(x => new RoomViewModel()
            {
                IsAvailable = x.IsAvailable,
                PricePerNight = x.PricePerNight,
                Type = x.Type,
                RoomId = x.RoomId
            }).ToList();
            
            return View(rooms);
        }

        public ActionResult Edit(int id)
        {
            var room = _context.Rooms.Find(id);
            
            return View(room);
        }
        
        [HttpPost]
        public ActionResult Edit(Room room)
        {
            if (ModelState.IsValid)
            {
                var roomUpdate = _context.Rooms.First(x => x.RoomId == room.RoomId);
            
                roomUpdate.IsAvailable = room.IsAvailable;
                roomUpdate.PricePerNight = room.PricePerNight;
                roomUpdate.Type = room.Type;

                _context.Rooms.Update(roomUpdate);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return Edit(room.RoomId);
        }
    }
}
