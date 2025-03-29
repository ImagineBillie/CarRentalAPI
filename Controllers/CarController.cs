using Microsoft.AspNetCore.Mvc;

namespace CarRentalAPI.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
