namespace WebBank.Data.Models
{
    using Enums;
    using System;

    public class Card
    {
        public Card()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public CardType CardType { get; set; }

        public string CardNumber { get; set; }

        public string Brand { get; set; }

        public decimal WithdrowDayLimit { get; set; }

        public DateTime Expiration { get; set; }

        public int CvcCode { get; set; }
    }
}
