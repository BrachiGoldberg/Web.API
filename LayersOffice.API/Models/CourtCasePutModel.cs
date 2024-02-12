using LayersOffice.Core.Entities;

namespace LayersOffice.API.Models
{
    public class CourtCasePutModel
    {
        public int Fees { get; set; }

        public DateTime ClosingDate { get; set; }

        public CourtStatus CourtCaseStatus { get; set; }

        public int AmountToPay { get; set; }
    }
}
