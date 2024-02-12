using LayersOffice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Core.DTOs
{
    public class CourtCaseDto
    {
        public int Id { get; set; }

        public CourtCaseType CourtType { get; set; }

        public int Fees { get; set; }

        public DateTime OpeningDate { get; set; }

        public DateTime ClosingDate { get; set; }

        public CourtStatus CourtCaseStatus { get; set; }

        public CostumerStatus CostumerStatusOnCourt { get; set; }

        public int AmountToPay { get; set; }

        public int CostumerId { get; set; }

        public CostumerDto Costumer { get; set; }

        public List<PaymentDto> Payments { get; set; }
    }
}
