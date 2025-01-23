namespace InstaApplication.Models
{
    public class Commande
    {
        public int Id_commande { get; set; }

        public DateTime date_commande { get; set; }

        public DateTime date_livraison { get; set; }

        public string adresse_livraison { get; set;}


    }
}
