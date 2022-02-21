using Microsoft.AspNetCore.Mvc;

namespace RecognitionSystemFinal.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminDashboard()
        {
            return View();
        }


        public IActionResult NotificationPage()
        {
            return View();
        }

    }
}
