using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace InstaApplication.Models
{
    public class Produits
    {

        public int Id { get; set; }

        [Display(Name = "Designation")]
<<<<<<< HEAD
        [Required(ErrorMessage = "Merci de saisir le nom du produit")]
=======
        [Required(ErrorMessage = "Merci de saisir le nom")]
>>>>>>> 3746a6f8bb944067f9e482348c9443506b6c8131
        [MinLength(2, ErrorMessage = "Au moins deux caractères")]
        public string Name { get; set; }
        //[DataType(DataType.Password)]
        [Display(Name = "Prix")]
<<<<<<< HEAD
        [Required(ErrorMessage = "Merci de saisir le prix du produit")]
=======
        [Required(ErrorMessage = "Merci de saisir le prix")]
>>>>>>> 3746a6f8bb944067f9e482348c9443506b6c8131
        public double Price { get; set; }
    }
}
