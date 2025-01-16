using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace InstaApplication.Models
{
    public class Client
    {
        // clé primaire dans la table
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Prenom { get; set; }

        public int age { get; set; }

        public string adresse { get; set; }

    }
}
