using Microsoft.AspNetCore.Mvc;

namespace Wang_Gloria_HW4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
