using LayersOffice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Core.Repositories
{
    public interface ICourtCaseRepository
    {
        IEnumerable<CourtCase> Get();

        CourtCase Get(int id);

        IEnumerable<CourtCase> Get(DateTime date);

        CourtCase Post(CourtCase value);

        CourtCase Put(int id, CourtCase value);

        CourtCase Put(int id, CourtStatus status);
    }
}
