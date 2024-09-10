using Microsoft.AspNetCore.Mvc;

namespace CMCSPrototype.Views
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
