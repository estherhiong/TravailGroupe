using InstaApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstaApplication.Controllers
{
    public class AuthentificationController : Controller
    {
        public IActionResult Inscription()
        {
            var Inscriptions = new Inscription
            {
                Name = "Kenne",
                Email = "kennewhonore0@icloud.com",
                Password = "**********",
                ConfirmPassword = "**********",


            };
            return View();
        }
        public IActionResult Connexion()
        {
            var Connexions = new Connexion
            {
               
                Email = "kennewhonore0@icloud.com",
                Password = "**********",
               


            };
            return View();
        }

        public IActionResult Deconnexion()
        {
            return View();
        }
    }
}
