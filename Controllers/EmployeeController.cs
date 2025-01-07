using HotelReservationApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservationApp.Controllers
{
    public class EmployeeController : Controller
    {
        private DatabaseContext _context;

        public EmployeeController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

    }
}
