using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace InstaApplication.Models
{
    public class Produit
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string Name { get; set; }
        public required string Description { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public double Price { get; set; }
    }
}
