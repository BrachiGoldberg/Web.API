using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Core.Entities
{
    public enum CourtCaseType { FAMILY = 1, TAXES, ADMINISTRATIVELAW, REALESTATE, WORKING }
    /*
     FAMILY : משפחה
     TAXES: מיסים
     ADMINISTRATIVELAW: משפט מנהלי
     REALESTATE: נדלן
     WORKING: עבודה
     */

    public enum CourtStatus { ACTIVE = 1, PASIVE }

    public enum CostumerStatus { PROSECUTOR = 1, DEFENDANT }
    /*
     PROSECUTOR: תובע
     DEFENDANT: נתבע
     */
    public class CourtCase
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

        public Costumer Costumer { get; set; }

        public List<Payment> Payments { get; set; }
    }
}
