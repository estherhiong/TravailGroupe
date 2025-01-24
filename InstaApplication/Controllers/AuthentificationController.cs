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
                Id="1",
                Name = "Chadai",
                Email = "chadaimabiala@gmail.com",
                Password = "**********",
                ConfirmPassword = "**********",


            };
            return View();
        }
        public IActionResult Connexion()
        {
            var Connexions = new Connexion
            {
               
                Email = "chadaimabiala@gmail.com",
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
