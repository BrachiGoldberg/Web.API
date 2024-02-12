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

        public async Task<Costumer> PostAsync(Costumer value)
        {
            return await _costumerRepository.PostAsync(value);
        }

        public async Task<Costumer> PutAsync(int id, Costumer value)
        {
            return await _costumerRepository.PutAsync(id, value);
        }
    }
}
