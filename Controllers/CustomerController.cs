using HotelReservationApp.Data;
using HotelReservationApp.Data.Models;
using HotelReservationApp.Models;
using Microsoft.AspNetCore.Mvc;

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
            var customers = _context.Customers.Select(x => new CustomerViewModel()
            {
                LastName = x.LastName,
                FirstName = x.FirstName,
                PhoneNumber = x.PhoneNumber,
                CustomerId = x.CustomerId,
            }).ToList();

            return View(customers);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return Add();
        }
    }
}
