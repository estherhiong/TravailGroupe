using Microsoft.AspNetCore.Mvc;

namespace InstaApplication.Controllers
{
    public class CommandeController : Controller
    {
        public IActionResult Ajouter()
        {
            return View();
        }
        public IActionResult Supprimer()
        {
            return View();
        }
        public IActionResult Confirmer()
        {
            return View();
        }
    }
}
