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
    public class PaymentRepsitory : IPaymentRepository
    {
        private readonly DataContext _data;
        public PaymentRepsitory(DataContext data)
        {
            _data = data;
        }
      
        public IEnumerable<Payment> Get()
        {
            return _data.Payments.Include(p=>p.CourtCase);
        }

        public Payment Get(int id)
        {
            return _data.Payments.Include(p=>p.CourtCase).First();
        }

        public async Task<Payment> PostAsync(Payment value)
        {
            var p = new Payment()
            {
                Date = new DateTime(),
                PaymentBy = value.PaymentBy,
                Sum = value.Sum,
                CourtCaseId = value.CourtCaseId
            };
            _data.Payments.Add(p);
            await _data.SaveChangesAsync();
            return p;
        }

        public async Task<Payment> PutAsync(int id, Payment value)
        {
            var p = _data.Payments.Find(id);
            if (p != null)
            {
                p.Sum = value.Sum;
                p.Date = value.Date;
                p.PaymentBy = value.PaymentBy;

                await _data.SaveChangesAsync();
                return p;
            }
            return null;
        }

        public async Task<Payment> PutAsync(int id, int sum)
        {
            var p = _data.Payments.Find(id);
            if (p != null)
            {
                p.Sum = sum;

                await _data.SaveChangesAsync();
                return p;
            }
            return null;
        }

        public async Task<Payment> DeleteAsync(int id)
        {
            var income = _data.Payments.Find(id);
            if (income != null)
            {
                _data.Payments.Remove(income);

                await _data.SaveChangesAsync();
                return income;
            }
            return null;
        }

    }
}
