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
    public class CostumerService : ICostumerService
    {
        private readonly ICostumerRepository _costumerRepository;

        public CostumerService(ICostumerRepository costumerRepository)
        {
            _costumerRepository = costumerRepository;
        }

        public IEnumerable<Costumer> Get()
        {
            return _costumerRepository.Get();
        }

        public Costumer Get(int id)
        {
            return _costumerRepository.Get(id);
        }

        public Costumer Post(Costumer value)
        {
            return _costumerRepository.Post(value);
        }

        public Costumer Put(int id, Costumer value)
        {
            return _costumerRepository.Put(id, value);
        }
    }
}
