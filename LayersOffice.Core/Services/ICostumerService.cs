using LayersOffice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Core.Services
{
    public interface ICostumerService
    {
        IEnumerable<Costumer> Get();

        Costumer Get(int id);

        Task<Costumer> PostAsync(Costumer value);

        Task<Costumer> PutAsync(int id, Costumer value);
    }
}
