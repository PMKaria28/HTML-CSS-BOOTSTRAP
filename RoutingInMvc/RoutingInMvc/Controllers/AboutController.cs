using Microsoft.AspNetCore.Mvc;

namespace RoutingInMvc.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }
    }
}
