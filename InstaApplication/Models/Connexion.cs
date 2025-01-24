namespace InstaApplication.Models
{
    public class Connexion
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
