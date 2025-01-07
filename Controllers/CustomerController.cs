using HotelReservationApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace HotelReservationApp.Controllers
{
    public class CustomerController : Controller
    {
        private DatabaseContext _context;

        public CustomerController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }

    }
}
