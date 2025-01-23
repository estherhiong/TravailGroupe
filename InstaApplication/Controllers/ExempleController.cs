using Microsoft.AspNetCore.Mvc;

namespace InstaApplication.Controllers
{
    public class ExempleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
