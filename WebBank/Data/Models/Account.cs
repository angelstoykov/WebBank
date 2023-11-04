namespace WebBank.Data.Models
{
    using System;
    using System.Collections.Generic;
    using Enums;

    public class Account
    {
        public Account()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Cards = new HashSet<Card>();

            this.Transfers = new HashSet<Transfer>();
        }

        public string Id { get; set; }

        public AccountType AccountType { get; set; }

        public string IBAN { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }

        public DateTime Term { get; set; }

        public ICollection<Card> Cards { get; set; }

        public ICollection<Transfer> Transfers { get; set; }
    }
}
