using Microsoft.AspNetCore.Mvc;

namespace InstaApplication.Controllers
{
    public class PanierController : Controller
    {
        public IActionResult Ajouter()
        {
            return View();
        }
        public IActionResult Retirer()
        {
            return View();
        }
    }
}
