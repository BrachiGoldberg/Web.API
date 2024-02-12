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

        public Payment Post(Payment value)
        {
            var p = new Payment()
            {
                Date = new DateTime(),
                PaymentBy = value.PaymentBy,
                Sum = value.Sum
            };
            _data.Payments.Add(p);
            _data.SaveChanges();
            return p;
        }

        public Payment Put(int id, Payment value)
        {
            var income = _data.Payments.Find(id);
            if (income != null)
            {
                income.Sum = value.Sum;
                income.Date = value.Date;
                income.PaymentBy = value.PaymentBy;

                _data.SaveChanges();
                return income;
            }
            return null;
        }

        public Payment Put(int id, int sum)
        {
            var income = _data.Payments.Find(id);
            if (income != null)
            {
                income.Sum = sum;

                _data.SaveChanges();
                return income;
            }
            return null;
        }

        public Payment Delete(int id)
        {
            var income = _data.Payments.Find(id);
            if (income != null)
            {
                _data.Payments.Remove(income);

                _data.SaveChanges();
                return income;
            }
            return null;
        }

    }
}
