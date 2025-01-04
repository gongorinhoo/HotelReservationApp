using Microsoft.AspNetCore.Mvc;

namespace HotelReservationApp.Controllers
{
    public class ReservationController : Controller
    {
        // GET: ReservationController
        public ActionResult Index()
        {
            return View();
        }

    }
}
