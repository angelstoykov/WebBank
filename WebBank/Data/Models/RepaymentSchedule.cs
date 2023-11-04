namespace WebBank.Data.Models
{
    using System;

    public class RepaymentSchedule
    {
        public RepaymentSchedule()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string RepaymentInstallmentId { get; set; }
        public RepaymentInstallment RepaymentInstallment { get; set; }

    }
}
