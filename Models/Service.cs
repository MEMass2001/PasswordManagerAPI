using System.Collections.Generic;

namespace PasswordManagerAPI.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Questionable practice
        public string Image { get; set; }
        public ICollection<Account> Accounts { get; set; }
        public Service()
        {
            Accounts = new HashSet<Account>();
        }
    }
}