using InstaApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InstaApplication.Controllers
{
    public class ProduitController : Controller
    {
        private readonly Myctx _myctx;

        public ProduitController(Myctx myctx)
        {
            _myctx = myctx;
        }

        [HttpPost]
        public IActionResult Create([Bind("Id,Name,Price")] Produit produit)
        {
            if (ModelState.IsValid)
            {
                _myctx.Add(produit);
                _myctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(produit);
        }

        public IActionResult Index ()
        {
            return View();
        }
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
