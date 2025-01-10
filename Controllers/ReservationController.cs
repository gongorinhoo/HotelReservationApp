using HotelReservationApp.Data;
using HotelReservationApp.Data.Models;
using HotelReservationApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
            var reservations = _context.Reservations.Include(x => x.Room)
            .Include(x => x.Customer).Include(x => x.Employee).Select(x => new ReservationViewModel()
            {
                CheckInDate = x.CheckInDate,
                CheckOutDate = x.CheckOutDate,
                ReservationId = x.ReservationId,
                Employee = new EmployeeViewModel()
                {
                    EmployeeId = x.Employee.EmployeeId,
                    FirstName = x.Employee.FirstName,
                    LastName = x.Employee.LastName,
                    Position = x.Employee.Position
                },
                Room = new RoomViewModel()
                {
                    RoomId = x.Room.RoomId,
                    Type = x.Room.Type,
                    IsAvailable = x.Room.IsAvailable,
                    PricePerNight = x.Room.PricePerNight,
                },
                Customer = new CustomerViewModel()
                {
                    FirstName= x.Customer.FirstName,
                    LastName = x.Customer.LastName,
                    CustomerId = x.Customer.CustomerId,
                    PhoneNumber = x.Customer.PhoneNumber,
                }
            }).ToList();

            return View(reservations);
        }

        // GET: ReservationController
        public ActionResult Add()
        {
            var customers = _context.Customers.Select(x => new SelectListItem
            {
                Value = x.CustomerId.ToString(),
                Text = x.FirstName + " " + x.LastName
            }).ToList();
            
            var employees = _context.Employees.Select(x => new SelectListItem
            {
                Value = x.EmployeeId.ToString(),
                Text = x.FirstName + " " + x.LastName
            }).ToList();
            
            var rooms = _context.Rooms.Select(x => new SelectListItem
            {
                Value = x.RoomId.ToString(),
                Text = x.RoomId.ToString() + " - " + x.Type + " - " + x.PricePerNight.ToString()
            }).ToList();
            
            ViewBag.Customers = customers;
            ViewBag.Rooms = rooms;
            ViewBag.Employees = employees;
            
            return View();
        }

        [HttpPost]
        public ActionResult Add(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return Add();
        }
        
        public ActionResult Edit(int id)
        {
            var reservation = _context.Reservations.Find(id);
            
            var customers = _context.Customers.Select(x => new SelectListItem
            {
                Value = x.CustomerId.ToString(),
                Text = x.FirstName + " " + x.LastName
            }).ToList();
            
            var employees = _context.Employees.Select(x => new SelectListItem
            {
                Value = x.EmployeeId.ToString(),
                Text = x.FirstName + " " + x.LastName
            }).ToList();
            
            var rooms = _context.Rooms.Select(x => new SelectListItem
            {
                Value = x.RoomId.ToString(),
                Text = x.RoomId.ToString() + " - " + x.Type + " - " + x.PricePerNight.ToString()
            }).ToList();
            
            ViewBag.Customers = customers;
            ViewBag.Rooms = rooms;
            ViewBag.Employees = employees;
            
            return View(reservation);
        }
        
        [HttpPost]
        public ActionResult Edit(Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                var rezervationUpdate = _context.Reservations.First(x => x.ReservationId == reservation.ReservationId);
            
                rezervationUpdate.CustomerId = reservation.CustomerId;
                rezervationUpdate.RoomId = reservation.RoomId;
                rezervationUpdate.EmployeeId = reservation.EmployeeId;
                rezervationUpdate.CheckInDate = reservation.CheckInDate;
                rezervationUpdate.CheckOutDate = reservation.CheckOutDate;

                _context.Reservations.Update(rezervationUpdate);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return Edit(reservation.ReservationId);
        }
        
        public IActionResult Delete(int id)
        {
            var reservation = _context.Reservations.Find(id);
            
            if (reservation == null)
            {
                return NotFound();
            }
            
            _context.Reservations.Remove(reservation);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}
