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
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentsRepository;
        public PaymentService(IPaymentRepository incomesRepository)
        {
            _paymentsRepository = incomesRepository;
        }

        public IEnumerable<Payment> Get()
        {
            return _paymentsRepository.Get();
        }

        public Payment Get(int id)
        {
            return _paymentsRepository.Get(id);
        }

        public async Task<Payment> PostAsync(Payment value)
        {
            return await _paymentsRepository.PostAsync(value);
        }

        public async Task<Payment> PutAsync(int id, Payment value)
        {
            return await _paymentsRepository.PutAsync(id, value);
        }

        public async Task<Payment> PutAsync(int id, int sum)
        {
            return await _paymentsRepository.PutAsync(id, sum);
        }


        public async Task<Payment> DeleteAsync(int id)
        {
            return await _paymentsRepository.DeleteAsync(id);
        }
    }
}
