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
    public class CostumerRepository : ICostumerRepository
    {
        private readonly DataContext _data;

        public CostumerRepository(DataContext data)
        {
            _data = data;
        }

        public IEnumerable<Costumer> Get()
        {
            return _data.Costumers.Include(c => c.CourtCases);
        }

        public Costumer Get(int id)
        {
            return _data.Costumers.Include(c=>c.CourtCases).First(c=>c.Id == id);
        }

        public Costumer Post(Costumer value)
        {
            var newC = new Costumer()
            {
                FirstName = value.FirstName,
                LastName = value.LastName,
                Address = value.Address,
                PhoneNumber = value.PhoneNumber,
                Email = value.Email,
            };
            _data.Costumers.Add(newC);
            _data.SaveChanges();
            return newC;
        }



        public Costumer Put(int id, Costumer value)
        {
            Costumer temp = _data.Costumers.Find(id);
            if (temp != null)
            {
                temp.FirstName = value.FirstName;
                temp.LastName = value.LastName;
                temp.Address = value.Address;
                temp.PhoneNumber = value.PhoneNumber;
                temp.Email = value.Email;

                _data.SaveChanges();
                return temp;
            }
            
            return null;
        }
    }
}
