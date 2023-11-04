using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBank.Data.Models.Enums;

namespace WebBank.Data.Models
{
    public class Transfer
    {
        public Transfer()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public string Currency { get; set; }

        public TransferType Type { get; set; }

        public decimal Income { get; set; }

        public decimal Outgoing { get; set; }

        public decimal Amount { get; set; }

        public string Reason { get; set; }
    }
}
