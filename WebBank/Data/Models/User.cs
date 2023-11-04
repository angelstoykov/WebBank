namespace WebBank.Data.Models
{
    using Enums;
    using System;
    using System.Collections.Generic;

    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Accounts = new HashSet<Account>();

            this.Credits = new HashSet<Credit>();
        }

        public string Id { get; set; }

        public UserType Type { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Account> Accounts { get; set; }

        public ICollection<Credit> Credits { get; set; }
    }
}
