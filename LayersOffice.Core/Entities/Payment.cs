using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Core.Entities
{
    public enum PaymentMethod { CASH, BANKTRANSFER, CHECK, }

    public class Payment
    {
        public int Id { get; set; }

        public int Sum { get; set; }

        public DateTime Date { get; set; }

        public PaymentMethod PaymentBy { get; set; }

        public CourtCase CourtCase { get; set; }

        public int CourtCaseId { get; set; }
    }
}
