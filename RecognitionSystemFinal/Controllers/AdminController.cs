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

        public IActionResult ReportsPage()
        {
            return View();
        }

        public IActionResult Ranking()
        {
            return View();
        }

        public IActionResult Forecasts()
        {
            return View();
        }

        public IActionResult Diagnostic()
        {
            return View();
        }

        public IActionResult Descriptive()
        {
            return View();
        }
    }
}
