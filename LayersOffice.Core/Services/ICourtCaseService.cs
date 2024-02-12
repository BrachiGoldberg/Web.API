using LayersOffice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Core.Services
{
    public interface ICourtCaseService
    {
        IEnumerable<CourtCase> Get();

        CourtCase Get(int id);

        IEnumerable<CourtCase> Get(DateTime date);

        Task<CourtCase> PostAsync(CourtCase value);

        Task<CourtCase> PutAsync(int id, CourtCase value);

        Task<CourtCase> PutAsync(int id, CourtStatus status);
    }
}
