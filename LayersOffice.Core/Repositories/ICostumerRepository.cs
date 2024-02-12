using LayersOffice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersOffice.Core.Repositories
{
    public interface ICostumerRepository
    {
        IEnumerable<Costumer> Get();

        public Costumer Get(int id);

        Costumer Post(Costumer value);

        Costumer Put(int id, Costumer value);
    }
}
