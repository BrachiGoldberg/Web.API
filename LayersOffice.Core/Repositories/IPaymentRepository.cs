using LayersOffice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Core.Repositories
{
    public interface IPaymentRepository
    {
        IEnumerable<Payment> Get();

        Payment Get(int id);

        Payment Post(Payment value);

        Payment Put(int id, Payment value);

        Payment Put(int id, int sum);

        Payment Delete(int id);
    }
}
