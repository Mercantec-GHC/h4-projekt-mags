namespace API.Models
{
    public class User : Common
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public string PasswordBackdoor { get; set; } // For testing purposes
    }
}
