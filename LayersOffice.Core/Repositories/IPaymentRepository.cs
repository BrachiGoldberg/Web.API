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

        Task<Payment> PostAsync(Payment value);

        Task<Payment> PutAsync(int id, Payment value);

        Task<Payment> PutAsync(int id, int sum);

        Task<Payment> DeleteAsync(int id);
    }
}
