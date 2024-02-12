using LayersOffice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Core.DTOs
{
    public class PaymentDto
    {
        public int Id { get; set; }

        public int Sum { get; set; }

        public DateTime Date { get; set; }

        public PaymentMethod PaymentBy { get; set; }

        public CourtCaseDto CourtCase { get; set; }

    }
}
