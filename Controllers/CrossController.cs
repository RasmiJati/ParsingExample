using Microsoft.AspNetCore.Mvc;

namespace ParseAndNavigation.Controllers
{
    public class CrossController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
