using Microsoft.AspNetCore.Mvc;

namespace VehicleTracker.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
