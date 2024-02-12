using LayersOffice.Core.Entities;
using LayersOffice.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Data.Reposirories
{
    public class CourtCaseRepository : ICourtCaseRepository
    {
        private readonly DataContext _data;
        public CourtCaseRepository(DataContext data)
        {
            _data = data;
        }
        public IEnumerable<CourtCase> Get()
        {
            return _data.CourtCases.Include(c => c.Costumer);
        }

        public CourtCase Get(int id)
        {
            return _data.CourtCases.Include(c=> c.Costumer).First(c => c.Id == id);
        }

        public IEnumerable<CourtCase> Get(DateTime date)
        {
            return _data.CourtCases.Where(c => c.OpeningDate.CompareTo(date) >= 0);
        }

        public async Task<CourtCase> PostAsync(CourtCase value)
        {
            var court = new CourtCase()
            {
                CourtType = value.CourtType,
                Fees = value.Fees,
                OpeningDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                CourtCaseStatus = value.CourtCaseStatus,
                CostumerStatusOnCourt = value.CostumerStatusOnCourt,
                AmountToPay = value.Fees
            };
            _data.CourtCases.Add(court);
            await _data.SaveChangesAsync();
            return court;
        }


        public async Task<CourtCase> PutAsync(int id, CourtCase value)
        {
            var court = _data.CourtCases.Find(id);
            if (court != null)
            {
                court.CourtType = value.CourtType;
                court.Fees = value.Fees;
                court.CourtCaseStatus = value.CourtCaseStatus;
                court.CostumerStatusOnCourt = value.CostumerStatusOnCourt;
                court.AmountToPay = value.AmountToPay;

                await _data.SaveChangesAsync();
                return court;
            }
            return null;
        }

        public async Task<CourtCase> PutAsync(int id, CourtStatus status)
        {
            var found = _data.CourtCases.Find(id);
            if (found != null)
            {
                found.CourtCaseStatus = status;

                await _data.SaveChangesAsync();
                return found;
            }
            return null;
        }
    }
}
