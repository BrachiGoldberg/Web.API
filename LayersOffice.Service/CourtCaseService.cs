using LayersOffice.Core.Entities;
using LayersOffice.Core.Repositories;
using LayersOffice.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Service
{
    public class CourtCaseService : ICourtCaseService
    {
        private readonly ICourtCaseRepository _courtCaseRepository;

        public CourtCaseService(ICourtCaseRepository courtCaseRepository)
        {
            _courtCaseRepository = courtCaseRepository;
        }

        public IEnumerable<CourtCase> Get()
        {
            return _courtCaseRepository.Get();
        }
        public CourtCase Get(int id)
        {
            return _courtCaseRepository.Get(id);
        }

        public IEnumerable<CourtCase> Get(DateTime date)
        {
            return _courtCaseRepository.Get(date);
        }


        public async Task<CourtCase> PostAsync(CourtCase value)
        {
           return await _courtCaseRepository.PostAsync(value);
        }

        public async Task<CourtCase> PutAsync(int id, CourtCase value)
        {
            return await _courtCaseRepository.PutAsync(id, value);
        }

        public async Task<CourtCase> PutAsync(int id, CourtStatus status)
        {
            return await _courtCaseRepository.PutAsync(id, status);
        }
    }
}
