using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    interface IRepository
    {
        void CreateMotorcycle(Motorcycle motorcycle);
        IList<Motorcycle> GetMotorcycles();
        Motorcycle GetMotorcycleByID(Guid id);
        void UpdateMotorcycle(Motorcycle motorcycle);
        void DeleteMotorcycle(Motorcycle motorcycle);
    }
}
