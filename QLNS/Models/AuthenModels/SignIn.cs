namespace QLNS.Models.AuthenModels
{
    public class SignIn
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public int Role { get; set; }
    }
}
