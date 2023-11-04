namespace WebBank.Data.Models
{
    using Enums;
    using System;

    public class Credit
    {
        public Credit()
        {
            this.Id = Guid.NewGuid().ToString();


        }
        public string Id { get; set; }

        public CreditType CreditType { get; set; }

        public decimal Amount { get; set; }

        public decimal InterestAsPercent { get; set; }

        public DateTime Term { get; set; }

        public decimal InstallmentAmountPrincipal { get; set; }

        public decimal InstallmentAmountInterest { get; set; }

        public decimal InstallmentAmountTotal { get; set; } //Вноска.

        public RepaymentSchedule RepaymentSchedule { get; set; }
    }
}
