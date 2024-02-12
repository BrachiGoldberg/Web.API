using LayersOffice.Core.Entities;

namespace LayersOffice.API.Models
{
    public class CourtCasePostModel
    {
        public CourtCaseType CourtType { get; set; }

        public int Fees { get; set; }

        public DateTime OpeningDate { get; set; }

        public CourtStatus CourtCaseStatus { get; set; }

        public CostumerStatus CostumerStatusOnCourt { get; set; }

        public int CostumerId { get; set; }

    }
}
