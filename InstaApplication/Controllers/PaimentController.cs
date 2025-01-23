using Microsoft.AspNetCore.Mvc;

namespace InstaApplication.Controllers
{
    public class PaimentController : Controller
    {
        public IActionResult Annuler()
        {
            return View();
        }
        public IActionResult ModePaiment()
        {
            return View();
        }
    }
}
