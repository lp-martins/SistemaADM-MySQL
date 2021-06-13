using Microsoft.AspNetCore.Mvc;

namespace SysContabil.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
