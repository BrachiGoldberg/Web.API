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

        public Payment Post(Payment value)
        {
            return _paymentsRepository.Post(value);
        }

        public Payment Put(int id, Payment value)
        {
            return _paymentsRepository.Put(id, value);
        }

        public Payment Put(int id, int sum)
        {
            return _paymentsRepository.Put(id, sum);
        }


        public Payment Delete(int id)
        {
            return _paymentsRepository.Delete(id);
        }
    }
}
