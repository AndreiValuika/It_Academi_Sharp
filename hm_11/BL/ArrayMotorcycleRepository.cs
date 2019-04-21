using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DAO.Entiti;

namespace DAL
{
    public class ArrayMotorcycleRepository : IRepository
    {
        public ArrayMoto Moto { get; set; }

        public ArrayMotorcycleRepository(int length)
        {
            Moto = new ArrayMoto(length);
        }

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            if (FindFirstEmptyIndex() < 0)
                throw new Exception("Array is Full!!!");
            Moto.Motorcycles.SetValue(motorcycle, FindFirstEmptyIndex());
        }

        public void DeleteMotorcycle(Motorcycle motorcycle)
        {
            Moto.Motorcycles.SetValue(null, GetMotorcycleIndex(motorcycle));
        }

        public Motorcycle GetMotorcycleByID(Guid id)
        {
            foreach (var moto in Moto.Motorcycles)
            {
                if (moto.Id.Equals(id)) return moto;
            }
            return null;
        }

        public List<Motorcycle> GetMotorcycles()
        {
            List<Motorcycle> result = new List<Motorcycle>();
            foreach (var moto in Moto.Motorcycles)
            {
                result.Add(moto);
            }
            return result;
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            throw new NotImplementedException();
        }

        private int GetMotorcycleIndex(Motorcycle motorcycle)
        {
            int i = 0;
            while ((i != Moto.Motorcycles.Length))
            {
                if (Moto.Motorcycles.GetValue(i) != null)
                    if (Moto.Motorcycles.GetValue(i).Equals(motorcycle))
                        break;
                i++;
            }
            return i!=Moto.Motorcycles.Length?i:-1;
        }

        private int FindFirstEmptyIndex()
        {
            int i = 0;
            while ((Moto.Motorcycles.GetValue(i) != null) && (i != Moto.Motorcycles.Length)) { i++; }
            return i != Moto.Motorcycles.Length ? i : -1;
        }
    }
}
