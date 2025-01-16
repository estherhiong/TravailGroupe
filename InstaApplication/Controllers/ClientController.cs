using InstaApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstaApplication.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult VueClient()
        {
            var Client = new Client
            {
                Id = 1,
                Name = "Hiong",
                Prenom = "Esther",
                age = 22,
                adresse = "17 RUE LINNE 75005"
            };

            ViewData["Client"] = Client;
            return View();
        }

        public IActionResult Ajouter()
        {
            return View();
        }

        public IActionResult supprimer()
        {
            return View();
        }
    }
}
