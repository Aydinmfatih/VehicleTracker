using Microsoft.AspNetCore.Mvc;
using VehicleTracker.Dal.Context;

namespace VehicleTracker.Controllers
{
    public class VehicleController : Controller
    {
        private readonly VehicleTrackContext _context;

        public VehicleController(VehicleTrackContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
           var values = _context.Vehicles.ToList();
            return View(values);
        }
       
    }
}
