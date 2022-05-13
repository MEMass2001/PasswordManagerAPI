namespace PasswordManagerAPI.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AccountLogin { get; set; }
        public string AccountPassword { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public string UserEmail { get; set; }
        public User User { get; set; }
    }
}