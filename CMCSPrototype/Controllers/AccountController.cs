using Microsoft.AspNetCore.Mvc;

namespace CMCSPrototype.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public IActionResult Login(string username, string password, string role)
        {
            // Authentication logic here (e.g., checking username and password against database)
            // For now, assuming the login is always successful

            if (role == "Academic Manager" || role == "Programme Coordinator")
            {
                // Redirect to Admin Dashboard for admin roles
                return RedirectToAction("AdminDashboard", "Home");
            }
            else if (role == "Lecturer")
            {
                // Redirect to Lecturer Dashboard
                return RedirectToAction("LecturerDashboard", "Home");
            }

            // If role is not recognized, redirect back to login with an error message
            ModelState.AddModelError("", "Invalid role selected.");
            return View();
        }
    }
}
