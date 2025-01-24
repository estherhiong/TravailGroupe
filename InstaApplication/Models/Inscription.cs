namespace InstaApplication.Models
{
    public class Inscription
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

        public required  string Password { get; set; }
        public required string ConfirmPassword { get; set; }
    }
}
