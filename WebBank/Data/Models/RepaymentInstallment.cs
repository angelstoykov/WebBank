using System;

namespace WebBank.Data.Models
{
    public class RepaymentInstallment
    {
        public RepaymentInstallment()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public DateTime DateOfPayment { get; set; }

        public decimal PrincipalAmount { get; set; }

        public decimal InterestAmount { get; set; }

        public decimal PrincipalLeft { get; set; }
    }
}
