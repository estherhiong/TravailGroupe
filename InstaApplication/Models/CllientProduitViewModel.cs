using InstaApplication.Models;
using Microsoft.AspNetCore.Mvc;
namespace InstaApplication.Models
{
    public class CllientProduitViewModel
    {
        public required Produit produits { get; set; }
        public required Client clients { get; set; }
    }
}
