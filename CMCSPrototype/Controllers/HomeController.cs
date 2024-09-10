using Microsoft.AspNetCore.Mvc;

namespace CMCSPrototype.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LecturerDashboard()
        {
            return View();
        }

        public IActionResult AdminDashboard()
        {
            return View();
        }

        public IActionResult ClaimTracking()
        {
            return View();
        }
    }
}