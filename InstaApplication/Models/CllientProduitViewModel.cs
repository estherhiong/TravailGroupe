using InstaApplication.Models;
using Microsoft.AspNetCore.Mvc;
namespace InstaApplication.Models
{
    public class CllientProduitViewModel
    {
        public Produit produits { get; set; }
        public Client clients { get; set; }
    }
}
