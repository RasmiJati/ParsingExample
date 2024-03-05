using Microsoft.AspNetCore.Mvc;

namespace ParseAndNavigation.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.a = 10;
            ViewData["b"] = 20;
            TempData["c"] = 30;
            //return View();
            return RedirectToAction("Index", "Cross");
        }
    }
}
