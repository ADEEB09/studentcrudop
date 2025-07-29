namespace studentcrudop.Model
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string PasswordHash { get; set; } // 🔐 Store hashed passwords only

        public string Role { get; set; } = "User"; // Default role
    }
}
