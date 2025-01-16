using InstaApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstaApplication.Controllers
{
    public class ProduitController : Controller
    {
        public IActionResult Details()
        {
            var product = new Produit
            {
                Id = 1,
                Name = "Laptop",
                Price = 5000,
                Description = "",

            };
            //var client = new Client
            //{
            //    Name = "moi",
            //    adresse = "email@example.com"
            //};

            //var ViewModel = new CllientProduitViewModel
            //{
            //    produits = product,
            //    clients = client,
            //};

           

            //ViewData["Product"] = product;
            return View();
        }

        public IActionResult Ajouter()
        {
            return View();
        }

        public IActionResult Modifier()
        {
            return View();
        }

        public IActionResult Supprimer()
        {
            return View();
        }
    }
}
