

using DAL;
using DAO.Entiti;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_11
{
    class Program
    {
        static void Main(string[] args)
        {

            IRepository testArray = new ArrayMotorcycleRepository(11);

            for (int i = 0; i < 10; i++)
            {
                testArray.CreateMotorcycle(new Motorcycle(Guid.NewGuid(), "Name" + i, "Model" + i, i * 100, i * 10));
            }

            List<Motorcycle> motorcycles = testArray.GetMotorcycles();
            
            foreach (var moto in motorcycles)
            {
                Console.WriteLine(moto);
            }
            Console.ReadKey();
        }
    }
}
