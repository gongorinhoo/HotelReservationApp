using HotelReservationApp.Data;
using HotelReservationApp.Models;
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
            var employees = _context.Employees.Select(x => new EmployeeViewModel()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                EmployeeId = x.EmployeeId,
                Position = x.Position
            }).ToList();
            
            return View(employees);
        }

    }
}
