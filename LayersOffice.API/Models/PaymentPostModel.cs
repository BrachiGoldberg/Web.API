using LayersOffice.Core.Entities;

namespace LayersOffice.API.Models
{
    public class PaymentPostModel
    {
        public int Sum { get; set; }

        public DateTime Date { get; set; }

        public PaymentMethod PaymentBy { get; set; }

        public int CourtCaseId { get; set; }
    }
}
