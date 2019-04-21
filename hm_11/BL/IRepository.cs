using DAO;
using DAO.Entiti;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IRepository
    {
        void CreateMotorcycle(Motorcycle motorcycle);
        List<Motorcycle> GetMotorcycles();
        Motorcycle GetMotorcycleByID(int id);
        void UpdateMotorcycle(Motorcycle motorcycle);
        void DeleteMotorcycle(Motorcycle motorcycle);

    }
}
